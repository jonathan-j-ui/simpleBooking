async function loadPeople() {
    const status = document.getElementById("status");
    const list = document.getElementById("people");

    try {
        const response = await fetch("/api/People");

        if(!response.ok) {
            throw new Error("Could not load people.");
        }

        const data = await response.json();

        data.people.sort((a, b) =>
            (a.lastName ?? "").localeCompare(b.lastName ?? "")
        );

        list.replaceChildren();

        for (const person of data.people) {
            const item = document.createElement("tr");

            item.innerHTML = `
                <td><span class="tag flag country-${person.country}" role="img"></span></td>

                <td>${person.firstName} ${person.lastName}</td>
                
                <td>${person.email}</td>

                <td><span class="icon-phone" aria-hidden="true"></span> ${person.phoneNumber}</td>

                <td>${person.address.street} ${person.address.streetNo}, ${person.address.postalCode} ${person.address.city}</td>
            `;

            list.appendChild(item);
        }

        status.textContent = data.people.length === 0 ? "No people found." : "";
    } catch (error) {
        status.textContent = error.message;
    }
}

loadPeople();