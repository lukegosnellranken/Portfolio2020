/**
* @version 3.0.0
* @author Luke Gosnell
*
**/

class EasyHTTP {
    // Make an HTTP GET Request
    async get(url) {
        // return new Promise((resolve, reject) => {
        //     fetch(url)
        //         .then(res => res.json())
        //         .then(data => resolve(data))
        //         .catch(err => reject(err));
        // });
        const response = await fetch(url);
        const resData = await response.json();
        return resData;
    }

    // Make an HTTP POST Request
    async post(url, data) {
        
        const response = await fetch(url, {
            method: 'POST',
            headers: {
                'Content-type': 'application/json'
            },
            body: JSON.stringify(data)
        });

        const resData = await response.json();
        return resData;
    }
        

    // Make an HTTP PUT request
    async put(url, data) {
        const response = await fetch(url, {
            method: 'PUT',
            headers: {
                'Content-type': 'application/json'
            },
            body: JSON.stringify(data)
        });

        const resData = await response.json();
        return resData;
    }

    // Make an HTTP DELETE request
    async delete(url) {
        const response = await fetch(url, {
            method: 'DELETE',
            headers: {
                'Content-type': 'application/json'
            }
        });
            
        const resData = await 'Resource Deleted';
        return resData;
    }
}
