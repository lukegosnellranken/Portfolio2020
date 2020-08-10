//Using ES5 prototypes instead of ES6 classes

function easyHTTP() {
    this.http = new XMLHttpRequest();
}

// Make an HTTP GET REQUEST (asynchronously with a callback)
easyHTTP.prototype.get = function(url, callback) {
    this.http.open('GET', url, true);

    let self = this;
    this.http.onload = function() {
        if(self.http.status === 200) {
            callback(null, self.http.responseText);
        } else {
            callback('Error: ' + self.http.status);
        }
    }

    this.http.send();
}

// Make an HTTP POST REQUEST
easyHTTP.prototype.post = function(url, data, callback) {
    this.http.open('POST', url, true);
    //Set content type to JSON
    this.http.setRequestHeader('Content-type', 'application/json');

    let self = this;
    this.http.onload = function() {
        callback(null, self.http.responseText);
    }

    this.http.send(JSON.stringify(data));
}

// Make an HTTP PUT REQUEST
easyHTTP.prototype.put = function(url, data, callback) {
    this.http.open('PUT', url, true);
    //Set content type to JSON
    this.http.setRequestHeader('Content-type', 'application/json');

    let self = this;
    this.http.onload = function() {
        callback(null, self.http.responseText);
    }

    this.http.send(JSON.stringify(data));
}

// Make an HTTP DELETE REQUEST
easyHTTP.prototype.delete = function(url, callback) {
    this.http.open('DELETE', url, true);

    let self = this;
    this.http.onload = function() {
        if(self.http.status === 200) {
            callback(null, 'Post deleted');
        } else {
            callback('Error: ' + self.http.status);
        }
    }

    this.http.send();
}