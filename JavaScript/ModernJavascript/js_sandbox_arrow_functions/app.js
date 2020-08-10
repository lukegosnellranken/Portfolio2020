// const sayHello = function() {
//     console.log('Hello');
// }

// const sayHello = () => {
//     console.log('Hello');
// }

// One line arrow function (no ned for braces)
//const sayHello = () => console.log('Hello');

//One line return
//const sayHello = () => 'Hello';

//Wrap in parenthesis to return object (otherwise will be returned as undefined)
//const sayHello = () => ({msg: 'Hello'});

//Single param needs no parenthesis
//const sayHello = name => console.log(`Hello ${name}`);

// Multiple params need parenthesis
// const sayHello = (fname, lname) => console.log(`Hello, ${fname} ${lname}`);

// sayHello('Luke', 'Gosnell');

const users = ['Nathan', 'John', 'William'];

// const nameLengths = users.map(function(name) {
//     return name.length;
// });

//Shorter (than above)
// const nameLengths = users.map((name) => {
//     return name.length;
// });

//Shortest
const nameLengths = users.map(name => name.length);

console.log(nameLengths);