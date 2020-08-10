// Log to console

// console.log('hello');

// console.error('error!');
// console.clear();

// var weird = "haha";

// console.log(typeof weird);

// weird = 6;

// console.log(typeof weird);

// weird = Symbol();

// console.log(typeof weird);

// let val;

// //Num to string
// val = String(5);
// val = String(4+4);

// //Bool to string
// val = String(true);

// //Date to string
// val = String(Date());

// //Array to string
// val = String(['one', 'two', 'three']);

// // toString() method
// val = (5).toString();
// val = (true).toString();

// // String to num
// val = Number('5');
// val = Number(true);
// val = Number(null);

// val = parseInt('100.30');
// val = parseFloat('100.30');


// console.log(val);
// console.log(typeof val);
// //console.log(val.length);
// console.log(val.toFixed(2));

// const num1 = 100;
// const num2 = 5;
// let val;

// val = num1 + num2;

// val = Math.PI;
// val = Math.E;
// val = Math.round(2.4);
// val = Math.floor(2.4);
// val = Math.ceil(2.4);
// val = Math.sqrt(64);
// val = Math.abs(-3);
// val = Math.pow(8, 2);
// val = Math.min(2, 33, 4, 1, 55, 6, 3);
// val = Math.max(2, 33, 4, 1, 55, 6, 3);
// val = Math.floor(Math.random() * 20 + 1);

// console.log(val);

// const f = "Luke";
// const l = "Gosnell";
// const str = 'Hello there, my name is Luke';

// let val;

// val = f + l;

// //Conact
// val = f + " " + l;
// //Append
// val = 'Luke ';
// val += 'Gosnell';

// //Escaping
// val = 'That\'s awesome, I can\'t wait!';

// //Length
// val = l.length;

// //Concat as a method
// val = f.concat(' ', l);

// //change case
// val = f.toUpperCase();
// val = l.toLowerCase();

// //Position (String can be treated as a read-only array)
// val = l[0];

// //index
// val = f.indexOf('k');
// val = l.lastIndexOf('o');
// val = l.indexOf('o');

// //charAt()
// val = f.charAt(2);
// //Formula to always get last char
// val = f.charAt(f.length -1);

// //substring()
// val = f.substring(0, 2);

// //slice() mostly used to pull something out from an array
// val = f.slice(0, 3);
// val = f.slice(-3);

// // split()
// val = str.split(' ');

// // replace()
// val = str.replace('Luke', 'Kewl Dewd');

// // includes()
// val = str.includes('Luke');

// console.log(val);

// const name = 'Luke';
// const age = 22;
// const job = 'Web Developer';
// const city = 'St. Louis';
// let html;

// //without template literals
// html = '<ul><li>Name: ' + name + '</li>' + '<li>Age: ' + age + '</li></ul>'

// // with template literals
// html  = `
//     <ul>
//         <li>Name: ${name}</li>
//         <li>Age: ${age}</li>
//     </ul>
// `;

// document.body.innerHTML = html;

// //Create some arrays
// const numbers = [1,2,3,4,5];
// const numbers2 = new Array(1,2,3,4,5);
// const mixed = [22, 'Hello', true, undefined, null, {a:1, b:1}, new Date()];
// let val;

// val = numbers.length;
// val = Array.isArray(numbers);
// val = numbers[3];
// val = numbers[0];
// numbers[0] = 100;
// val = numbers.indexOf(3);

// //Mutating arrays
// numbers.push(250);
// numbers.unshift(120);
// numbers.pop();
// numbers.shift();
// numbers.splice(1,1);
// numbers.reverse();

// //Concat arrays
// val = numbers.concat(numbers2);

// //sort
// val = numbers.sort();

// //use the compare function
// val = numbers.sort(function(x, y){
//     return x-y;
// });

// //reverse sort
// val = numbers.sort(function(x, y){
//     return y-x;
// });

// //find
// function under50(num){
//     return num < 50;
// }
// val = numbers.find(under50);

// console.log(numbers);
// console.log(val);

// const person = {
//     fn: 'Luke',
//     ln: 'Gosnell',
//     hobbies: ['music', 'drawing'],
//     address: {
//         city: "St. Louis",
//         state: 'MO'
//     },
//     getBirthYear: function(){
//         return 2020 - this.age;
//     }
// }

// let val;

// val = person;
// val = person.fn;
// val = person['fn'];
// val= person.getBirthYear();
// val = person.address.state;

// console.log(val);

// const people = [
//     {name: 'Luke', age: 22},
//     {name: 'Bluke', age: 11}
// ];

// for (let i = 0; i < people.length; i++){
//     console.log(people[i].name);
// }

// let val;

// const today = new Date();
// let birthday = new Date('3/24/1998');
// birthday = new Date('September 10 1981');


// val = today;
// val= birthday;
// val = today.getMonth();
// val = today.getDate();
// val = today.getFullYear();
// val = today.getHours();
// val = today.getTime();

// birthday.setMonth(4);
// //etc.

// console.log(typeof val);

// console.log(val);
// console.log(birthday);

// const color = 'red';

// switch(color){
//     case 'red':
//         console.log('Color is red');
//         break;
//     case 'blue':
//         console.log('Color is blue');
//         break;
// }

//Function declarations

// function greet(fn = "default first", ln = "default last"){
//     //console.log('Hello');
//     return 'Hello ' + fn + " " + ln;
// }

// console.log(greet('Luke', 'Gosnell'));

// //Function Expressions
// //a function as a variable assignment

// const square = function(x){
//     return x*x;
// };

// console.log(square(8));

// //Immediately invokable function expressions (IIFEs)

// (function(){
//     console.log('IIFE ran...');
// })();

// (function(name){
//     console.log('Hello ' + name);
// })('Luke');

// //Property methods

// const todo = {
//     add: function(){
//         console.log('Add todo...');
//     },
//     edit: function(id){
//         console.log(`Edit todo ${id}`);
//     }
// }

// todo.delete = function() {
//     console.log('Delete todo...');
// }

// todo.add();
// todo.edit(22);
// todo.delete();
// console.log(todo);

// for(let i = 0; i < 10; i++){
//     //console.log(i);
//     if(i === 2){
//         console.log('2 is the best number');
//         continue;
//     }

//     if(i === 5) {
//         break;
//     }

//     console.log(i);
// }

// let i = 0;

// while(i < 10){
//     console.log('Number ' + i);
//     i++;
// }

// let i = 100;

// do{
//     console.log('Number ' + i);
//     i++;
// } while(i < 10);

// const cars = ['Ford', 'Chevy', 'Honda', 'Toyota'];

// cars.forEach(function(car, index, array){
//     console.log(`${index} : ${car}`);
//     console.log(array);
// });

// //Map

// const users = [
//     {id: 1, name: 'Luke'},
//     {id: 2, name: 'Bluke'}
// ];

// const ids = users.map(function(user){
//     return user.id;
// });

// console.log(ids);
// console.log(typeof ids);

// // For In loop
// const user = {
//     fn: 'Luke',
//     ln: 'Gosnell',
//     age: 22
// }

// for(let x in user){
//     console.log(`${x} : ${user[x]}`);
// }







// //Window Methods / objects / properties

// alert('Hello World');

// //Prompt
// const input = prompt();
// alert(input);

// //Confirm
// if(confirm('Are you sure?')){
//     console.log('YES');
// } else {
//     console.log('NO');
// }

// let val;

// //Outter height and width
// val = window.outerHeight;
// val = window.outerWidth;

// //Inner height and width
// val = window.innerHeight;
// val = window.innerWidth;

// // Scroll points
// val = window.scrollY;

// //Location object
// val = window.location;
// val = window.location.port

// //Redirect
// //window.location.href='http://google.com';

// //Reload
// //window.location.reload();

// //History Object
// //window.history.go(-1);
// val = window.history.length;

// //Navigator Object
// val = window.navigator;
// val = window.navigator.appName;
// val = window.navigator.appVersion;
// val = window.navigator.platform;

// console.log(val);


// Global Scope
var a = 1;
let b = 2;
const c = 3;

// function test(){
//     var a = 4;
//     let b = 5;
//     const c = 6;
//     console.log('Function Scope: ', a, b, c);
// }

// test();

// if(true) {
//     //Block Scope
//     var a = 4;
//     let b = 5;
//     const c = 6;
//     console.log('If Scope: ', a, b, c);
// }

// for(let a = 0; a < 10; a++){
//     console.log(`Loop: ${a}`);
// }

// console.log('Global Scope: ', a, b, c);


// Section 3

