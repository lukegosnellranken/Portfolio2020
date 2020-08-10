// // Person constructor
// function Person(name, dob) {
//     this.name = name;
//     //this.age = age;
//     this.birthday = new Date(dob);
//     this.calculateAge = function(){
//         const diff = Date.now() - this.birthday.getTime();
//         const ageDate = new Date(diff);
//         return Math.abs(ageDate.getUTCFullYear() - 1970);
//     }

//     // Logs every Person object
//     //console.log(this);
// }

// // Gives window object when used in global scope
// console.log(this);

// // const luke = new Person('Luke', 22);
// // const john = new Person('John', 30);

// //console.log(luke, john);

// const luke = new Person('Luke', '3-24-1998');
// console.log(luke.calculateAge());


//lecture 45

// //String
// const name1 = 'Luke';
// const name2 = new String('Luke');

// //name2.foo = 'bar';

// // Gets value
// console.log(name1);
// // Gets string as an object
// console.log(name2);

// // returns string
// console.log(typeof name1);

// // returns object
// console.log(typeof name2);

// if(name1 === 'Luke'){
//     console.log('Yes');
// } else {
//     console.log('No');
// }

// //Number
// const num1 = 5;
// const num2 = new Number(5);

// // returns object, not number
// console.log(num2);

// //Boolean
// const bool1 = true;
// const bool2 = new Boolean(true);

// //Function
// const getSum1 = function(x, y){
//     return x + y
// }

// const getSum2 = new Function('x','y', 'return 3+5');

// console.log(getSum1(3,5));
// console.log(getSum2());

// //Object

// const john = {name: 'john'};
// const john2 = new Object({name: 'John'});
// console.log(john);

// //Arrays
// const arr1 = [1,2,3,4];
// const arr2 = new Array(1,2,3,4);
// console.log(arr2);

// // Regular expressions
// const re1 = /\w+/;
// const re2 = new RegExp('\\w+');

// console.log(re2);



//Lecture 46

// //Oject.prototype
// //Person.prototype

// // Person constructor
// function Person(name, lastName, dob) {
//     this.name = name;
//     this.lastName = lastName;
//     this.birthday = new Date(dob);
//     // this.calculateAge = function(){
//     //     const diff = Date.now() - this.birthday.getTime();
//     //     const ageDate = new Date(diff);
//     //     return Math.abs(ageDate.getUTCFullYear() - 1970);
//     // }
// }

// // Calculate age
// Person.prototype.calculateAge = function(){
//     const diff = Date.now() - this.birthday.getTime();
//     const ageDate = new Date(diff);
//     return Math.abs(ageDate.getUTCFullYear() - 1970);
// }

// // Get full name
// Person.prototype.fullName = function(){
//     return `${this.name} ${this.lastName}`;
// }

// // Gets Married
// Person.prototype.getsMarried = function(newLastName){
//     this.lastName = newLastName;
// }

// const dan = new Person('Dan', 'Doe', '8-12-2001');
// const mary = new Person('Mary', 'Johnson', 'March 20 1978');

// console.log(mary);

// console.log(dan.calculateAge());

// console.log(mary.fullName());

// mary.getsMarried('Smith');

// console.log(mary.fullName());

// //True
// console.log(mary.hasOwnProperty('lastName'));
// //False (because it's in prototype)
// console.log(mary.hasOwnProperty('fullName'));

// Lecture 47

// // Person constructor
// function Person(firstName, lastName){
//     this.firstName = firstName;
//     this.lastName = lastName;
// }

// //Greeting
// Person.prototype.greeting = function(){
//     return `Hello there, ${this.firstName} ${this.lastName}`;
// }

// const person1 = new Person('John', 'Doe');

// console.log(person1.greeting());

// // Customer
// function Customer(firstName, lastName, phone, membership){
//     Person.call(this, firstName, lastName);
//     this.phone = phone;
//     this.membership = membership;
// }

// // Inherit the Person prototype methods
// Customer.prototype = Object.create(Person.prototype);

// // Make Customer.prototype return Customer()
// Customer.prototype.constructor = Customer;

// // Create customer
// const customer1 = new Customer('Tom', 'Smith', '555-555-5555', 'Standard');

// console.log(customer1);

// // Customer greeting
// Customer.prototype.greeting = function(){
//     return `Hello there, ${this.firstName} ${this.lastName}. Welcome to our company.`;
// }

// console.log(customer1.greeting());



// Lecture 48

// const personPrototypes = {
//     greeting: function() {
//         return `Hello there, ${this.firstName} ${this.lastName}`;
//     },
//     getsMarried: function(newLastName) {
//         this.lastName = newLastName;
//     }
// }

// const mary = Object.create(personPrototypes);
// mary.firstName = 'Mary';
// mary.lastName = 'Williams';
// mary.age = 30;

// mary.getsMarried('Thompson');

// console.log(mary.greeting());

// const brad = Object.create(personPrototypes, {
//     firstName: {value: 'Brad'},
//     lastName: {value: 'Traversy'},
//     age: {value: 36}
// });

// console.log(brad);
// console.log(brad.greeting());

// Lecture 49 (ES6 classes to replace use of constructors and object.create)

// class Person {
//     constructor(firstName, lastName, dob) {
//         this.firstName = firstName;
//         this.lastName = lastName;
//         this.birthday = new Date(dob);
//     }

//     greeting() {
//         return `Hello there, ${this.firstName} ${this.lastName}`;
//     }

//     calculateAge() {
//         const diff = Date.now() - this.birthday.getTime();
//         const ageDate = new Date(diff);
//         return Math.abs(ageDate.getUTCFullYear() - 1970);
//     }

//     getsMarried(newLastName) {
//         this.lastName = newLastName;
//     }

//     static addNumbers(x, y) {
//         return x + y;
//     }
// }

// const mary = new Person('Mary', 'Williams', '11-13-1980');

// mary.getsMarried("Thompson");

// console.log(mary.greeting());
// console.log(mary.calculateAge());

// //Static method
// console.log(Person.addNumbers(1,2));



// Lecture 50

class Person {
    constructor(firstName, lastName) {
        this.firstName = firstName;
        this.lastName  = lastName;
    }

    greeting() {
        return `hello there, ${this.firstName} ${this.lastName}`;
    }
}

// Create subclass of Person
class Customer extends Person {
    constructor(firstName, lastName, phone, membership) {
        super(firstName, lastName);

        this.phone = phone;
        this.membership = membership
    }

    static getMembershipCost() {
        return 500;
    }
}

const john = new Customer('John', 'Doe', '555-555-5555', 'Standard');

console.log(john.greeting());

console.log(Customer.getMembershipCost());