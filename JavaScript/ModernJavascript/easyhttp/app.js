const http = new easyHTTP;

// GET posts
http.get('https://jsonplaceholder.typicode.com/posts/',
function(err, posts) {
    if(err) {
        console.log(err);
    } else {
        console.log(posts);
    }
});

// GET single post

http.get('https://jsonplaceholder.typicode.com/posts/1',
function(err, post) {
    if(err) {
        console.log(err);
    } else {
        console.log(post);
    }
});

// Create Data

const data = {
    title: 'Custom Post',
    body: 'This is a custom post'
};

// // Create Post ("id" key is added by the API through the backend)
// http.post('https://jsonplaceholder.typicode.com/posts/', data, function (err, post){
//     if(err) {
//         console.log(err);
//     } else {
//         console.log(post);
//     }
// });

// Update Post (id 1)
http.put('https://jsonplaceholder.typicode.com/posts/1', data, function(err, post) {
    if(err) {
        console.log(err);
    } else {
        console.log(post);
    }
});

// Delete Post
http.delete('https://jsonplaceholder.typicode.com/posts/1',
function(err, response) {
    if(err) {
        console.log(err);
    } else {
        console.log(response);
    }
});