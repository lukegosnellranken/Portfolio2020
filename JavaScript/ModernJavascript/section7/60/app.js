document.getElementById('button1').addEventListener('click', loadCustomer);

document.getElementById('button2').addEventListener('click', loadCustomers);

//Load customer
function loadCustomer(e) {
    const xhr = new XMLHttpRequest();

    xhr.open('GET', 'customers.json', true);

    xhr.onload = function() {
        if(this.status === 200) {
            console.log(this.responseText);

            const customer = JSON.parse(this.responseText);

            const output = `
                <ul>
                    <li>ID: ${customer.id}</l1>
                    <li>Name: ${customer.name}</l1>
                    <li>Comapny: ${customer.company}</l1>
                    <li>Phone: ${customer.phone}</l1>
                </ul>
            `;

            document.getElementById('customer').innerHTML = output;
        }
    }
    xhr.send();
}

// Load customers
function loadCustomers(e) {
    //Instantiate xhr object
    const xhr = new XMLHttpRequest();

    //GET request
    xhr.open('GET', 'customers.json', true);

    xhr.onload = function() {
        if(this.status === 200) {
            console.log(this.responseText);

            const customers = JSON.parse(this.responseText);

            let output = '';

            customers.forEach(function(customer){
                output += `
                <ul>
                    <li>ID: ${customer.id}</li>
                    <li>Name: ${customer.name}</li>
                    <li>Comapny: ${customer.company}</li>
                    <li>Phone: ${customer.phone}</li>
                </ul>
            `;
            });

            document.getElementById('customers').innerHTML = output;
        }
    }
    xhr.send();
}