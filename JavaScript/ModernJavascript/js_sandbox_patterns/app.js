// Basic structure
// (function() {
//     // Declare private vars and functions

//     return {
//         // Declare public var and functions

//     }
// })();

// STANDARD MODULE PATTERN
// const UIctrl = (function() {
//     let _text = 'Hello World';

//     const changeText = function() {
//         const element = document.querySelector('h1');
//         element.textContent = text;
//     }

//     return {
//         callChangeText: function() {
//             changeText();
//             console.log(text);
//         }
//     }
// })();

// UIctrl.callChangeText();

// REVEALING MODULE PATTERN
// const ItemCtrl = (function() {
//     let data = [];

//     function add(item) {
//         data.push(item);
//         console.log('Item Added');
//     }

//     function get(id) {
//         return data.find(item => {
//             return item.id === id;
//         });
//     }

//     return {
//         // Makes methods public
//         add: add,
//         get: get
//     }
// })();

// ItemCtrl.add({id: 1, name: 'John'});
// ItemCtrl.add({id: 2, name: 'Mark'});
// console.log(ItemCtrl.get(1));

//SINGLETON

// const Singleton = (function() {
//     let instance;

//     function createInstance() {
//         const object = new Object({name: 'Luke'});
//         return object;
//     }

//     return {
//         getInstance: function() {
//             if(!instance) {
//                 instance = createInstance();
//             }
//             return instance;
//         }
//     }
// })();

// const instanceA = Singleton.getInstance();
// const instanceB = Singleton.getInstance();

// //console.log(instanceA);

// console.log(instanceA === instanceB);


// FACTORY

// function MemberFactory() {
//     this.createMember = function(name, type) {
//         let member;

//         if(type === 'simple') {
//             member = new SimpleMembership(name);
//         } else if (type === 'standard') {
//             member = new StandardMembership(name);
//         } else if (type === 'super') {
//             member = new SuperMembership(name);
//         }

//         member.type = type;

//         member.define = function() {
//             console.log(`${this.name} (${this.type}): ${this.cost}`);
//         }

//         return member;
//     }
// }

// const SimpleMembership = function(name) {
//     this.name = name;
//     this.cost = '$5';
// }

// const StandardMembership = function(name) {
//     this.name = name;
//     this.cost = '$15';
// }

// const SuperMembership = function(name) {
//     this.name = name;
//     this.cost = '$25';
// }

// const members = [];
// const factory = new MemberFactory();

// members.push(factory.createMember('John Doe', 'simple'));
// members.push(factory.createMember('Joe Mama', 'standard'));
// members.push(factory.createMember('Tom Smith', 'super'));

// //console.log(members);

// members.forEach((member) => {
//     member.define();
// })



// OBSERVER

// function EventObserver() {
//     this.observers = [];
// }

// EventObserver.prototype = {
//     subscribe: function(fn) {
//         this.observers.push(fn);
//         console.log(`You are now subscribed to ${fn.name}`)
//     },
//     unsubscribe: function(fn) {
//         // Filters out from list whatever matches callback function.
//         // If no match, callback stays on the list.
//         // Filter returns a new list and reassigns the list of observers.
//         this.observers = this.observers.filter(function(item) {
//             if(item !== fn) {
//                 return item;
//             }
//         });
//         console.log(`You are now unsubscribed from ${fn.name}`);
//     },
//     fire: function() {
//         this.observers.forEach(function(item) {
//             item.call();
//         });
//     }
// }

// const click = new EventObserver();

// // Event listeners
// document.querySelector('.sub-ms').addEventListener('click', () => {
//     click.subscribe(getCurMilliseconds);
// });

// document.querySelector('.unsub-ms').addEventListener('click', () => {
//     click.unsubscribe(getCurMilliseconds);
// });

// document.querySelector('.sub-s').addEventListener('click', () => {
//     click.subscribe(getCurSeconds);
// });

// document.querySelector('.unsub-s').addEventListener('click', () => {
//     click.unsubscribe(getCurSeconds);
// });

// document.querySelector('.fire').addEventListener('click', () => {
//     click.fire();
// });

// // Click handler
// const getCurMilliseconds = () => {
//     console.log(`Current Milliseconds: ${new Date().getMilliseconds()}`);
// }

// const getCurSeconds = () => {
//     console.log(`Current Seconds: ${new Date().getSeconds()}`);
// }



// MEDIATOR

const User = function(name) {
    this.name = name;
    this.chatroom = null;
}

User.prototype = {
    send: function(message, to) {
        this.chatroom.send(message, this, to);
    },
    recieve: function(message, from) {
        console.log(`${from.name} to ${this.name}: ${message}`);
    }
}

const Chatroom = function() {
    let users = {}; // list of users

    return {
        register: function(user) {
            users[user.name] = user;
            user.chatroom = this;
        },
        send: function(message, from, to) {
            if(to) {
                // Single user message
                to.recieve(message, from);
            } else {
                // Mass message
                for(key in users) {
                    if(users[key] !== from) {
                        users[key].recieve(message, from);
                    }
                }
            }
        }
    }
}

const luke = new User('Luke');
const david = new User('David');
const nick = new User('Nick');

const chatroom = new Chatroom();

chatroom.register(luke);
chatroom.register(david);
chatroom.register(nick);

luke.send('Hello David', david);
nick.send('Hello Luke, you are the greatest dev alive', luke);
david.send('Hello all!');