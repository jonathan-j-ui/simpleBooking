async function loadPeople() {
    const status = document.getElementById("status");
    const list = document.getElementById("people");

    try {
        const response = await fetch("/api/People");

        if(!response.ok) {
            throw new Error("Could not load people.");
        }

        const data = await response.json();

        list.replaceChildren();

        for (const person of data.people) {
            const item = document.createElement("li");

            item.innerHTML = `
                <h1>${person.firstName} ${person.lastName}</h1>
                <p><span class="tag">${person.email}</span></p>
            `;

            list.appendChild(item);
        }

        status.textContent = data.people.length === 0 ? "No people found." : "";
    } catch (error) {
        status.textContent = error.message;
    }
}

loadPeople();