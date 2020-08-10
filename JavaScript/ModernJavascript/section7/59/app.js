document.getElementById('button').addEventListener('click', loadData);

function loadData() {
    // Create an XHR Object
    const xhr = new XMLHttpRequest();

    // OPEN
    xhr.open('GET', 'data.txt', true);

    //console.log('READYSTATE', xhr.readyState);

    // Optional - used for spinners/loaders
    xhr.onprogress = function() {
        console.log('READYSTATE', xhr.readyState);
    }

    xhr.onload = function() {
        if(this.status === 200) {
            console.log(this.responseText);
            document.getElementById('output').innerHTML = `<h5>${this.responseText}</h5.`
        }
    }

    //SAME AS (above is easier and newer)
    xhr.onreadystatechange = function() {
        //console.log('READYSTATE', xhr.readyState);

        if(this.status === 200 && this.readyState === 4){
            console.log(this.responseText);
        }
    }

    xhr.onerror = function() {
        console.log('Request error...');
    }

    xhr.send();
}