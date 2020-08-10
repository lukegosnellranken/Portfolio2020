// let val;

// val = document;
// val = document.all;
// val = document.all[2];
// val = document.all.length;
// val = document.head;
// val = document.body;
// val = document.doctype;
// val = document.domain;
// val = document.URL;
// val = document.characterSet;
// val = document.contentType;

// val = document.forms;
// val = document.forms[0];
// val = document.forms[0].id;
// val = document.forms[0].method;
// val = document.forms[0].action;

// val = document.links;
// val = document.links[0];
// val = document.links[0].id;
// val = document.links[0].className;
// val = document.links[0].classList[0];

// val = document.images;

// val = document.scripts;
// val = document.scripts[2].getAttribute('src');

// let scripts = document.scripts;

// let scriptsArr = Array.from(scripts);

// scriptsArr.forEach(function(script) {
//   console.log(script.getAttribute('src'));
// });

// console.log(val);

// document.getElementById();

// console.log(document.getElementById('task-title'));

// // Get things from the element
// console.log(document.getElementById('task-title').id);
// console.log(document.getElementById('task-title').className);

// const taskTitle = document.getElementById('task-title');

// // Change styling
// taskTitle.style.background = '#333';
// taskTitle.style.color = '#fff';
// taskTitle.style.padding = '5px';

// // Change content
// taskTitle.textContent = 'Task List';
// taskTitle.textContent = 'My Tasks';
// taskTitle.innerHTML = '<span style="color:red">Task List</span>'

// //document.querySelector()
// console.log(document.querySelector('#task-title'));
// console.log(document.querySelector('.card-title'));
// console.log(document.querySelector('h5'));

// document.querySelector('ul li').style.color = 'red';

// //Using pseudo-classes

// document.querySelector('li:last-child').style.color = 'red';
// document.querySelector('li:nth-child(3)').style.color = 'yellow';
// document.querySelector('li:nth-child(4)').textContent = 'Hello World';

// //document.getElementsByClassName

// const items = document.getElementsByClassName('collection-item');
// console.log(items);
// console.log(items[0]);
// items[0].style.color = 'red';
// items[3].textContent = 'Hello'

// //Selects specific items in block scope, not global scope
// const listItems = document.querySelector('ul').getElementsByClassName('collection-item');

// console.log(listItems);

// //document.getElementByTagName

// let lis = document.getElementsByTagName('li');
// console.log(lis);
// console.log(lis[0]);
// lis[0].style.color = 'red';
// lis[3].textContent = 'Hello'

// //Convert HTML collection into an array
// lis = Array.from(lis);

// lis.reverse();

// lis.forEach(function(li, index){
//   console.log(li.className)
//   li.textContent = `${index}: Hello`;
// });

// console.log(lis);

// //document.querySelectorAll
// let items = document.querySelectorAll('ul.collection li.collection-item');
// //same as
// items = document.querySelectorAll('ul li');

// items.forEach(function(item, index){
//   item.textContent = `${index}: Hello`;
// });

// const liOdd = document.querySelectorAll('li:nth-child(odd)');
// const liEven = document.querySelectorAll('li:nth-child(even)');

// liOdd.forEach(function(li, index){
//   li.style.background = '#ccc';
// });

// liEven.forEach(function(li, index){
//   li.style.background='red';
// });

// console.log(items);

// let val;
// const list = document.querySelector('ul.collection');
// const listItem = document.querySelector('li.collection-item:first-child')

// val = listItem;
// val = list;

// //get child node
// val = list.childNodes;
// val = list.childNodes[0].nodeName;
// val = list.childNodes[1].nodeType;

// //get children element nodes
// val = list.children;
// val = list.children[0].textContent = "Hello";
// //children of children
// list.children[3].children[0].id = 'test-link';

// val = list.firstChild;
// //ignores #text nodes
// val = list.firstElementChild;

// val = list.lastChild;
// val = list.lastElementChild;

// //count child elements
// val = list.childElementCount;

// //get parent node
// val = listItem.parentNode;
// val = listItem.parentElement;
// val = listItem.parentElement.parentElement;

// //get next sibling
// val = listItem.nextSibling;
// val = listItem.nextElementSibling;

// //get previous sibling
// val = listItem.previousSibling;
// val = listItem.previousElementSibling;

// console.log(val);
// //console.log(list.children[3].children[0].id);

// // Create element
// const li = document.createElement('li');

// // Add class
// li.className = 'collection-item';

// // Add attribute
// li.setAttribute('title', 'New Item');

// //Create text node and append
// //puts "Hello World" inside the li
// li.appendChild(document.createTextNode('Hello World'));

// //Create new link element
// const link = document.createElement('a');
// //Add class
// link.className = 'delete-item secondary-content';
// //Add icon html
// link.innerHTML = '<i class="fa fa-remove"></i>';
// //Append link into li
// li.appendChild(link);

// //Append li as child to ul
// document.querySelector('ul.collection').appendChild(li);

// console.log(li);

// //Replace element

// //Create element
// const newHeading = document.createElement('h2');
// //Add id
// newHeading.id = 'task-title';
// //New text node
// newHeading.appendChild(document.createTextNode('Task List'));

// //Get the old heading
// const oldHeading = document.getElementById('task-title');
// //Parent
// const cardAction = document.querySelector('.card-action');
// //Replace
// cardAction.replaceChild(newHeading, oldHeading);

// //Remove element
// const lis = document.querySelectorAll('li');
// const list = document.querySelector('ul');

// //Remove list item
// lis[0].remove();

// //Remove child element
// list.removeChild(lis[3]);

// //Classes and attributes
// const firstLi = document.querySelector('li:first-child');
// const link = firstLi.children[0];

// let val;

// //Classes
// val = link.className;
// val = link.classList;
// val = link.classList[0];
// link.classList.add('test');
// val = link.classList[2];
// link.classList.remove('test');

// //Attributes
// val = link.getAttribute('href');
// val = link.setAttribute('href', 'http://google.com');
// val = link.hasAttribute('href');
// link.setAttribute('title', 'Google');
// link.removeAttribute('title');

// console.log(link);

//EVENT LISTENERS

// document.querySelector('.clear-tasks').addEventListener('click', 
// function(e){
//   console.log('Hello World');

//   //e.preventDefault();
// });

// document.querySelector('.clear-tasks').addEventListener('click', onClick);

// function onClick(e){
//   //console.log('clicked');

//   let val;
//   val = e;

//   //event target element
//   val = e.target;
//   val = e.target.className;
//   //get as a collection
//   val = e.target.classList;

//   e.target.innerText = 'Hello';

//   // Event type
//   val = e.type;

//   //Time stamp
//   val = e.timeStamp;

//   //coords event relative to window
//   val = e.clientY;
//   val = e.clientX;

//   //coords event relative to the element
//   val = e.offsetY;
//   val = e.offsetX;

//   console.log(val);
// }

// const clearBtn = document.querySelector('.clear-tasks');
// const card = document.querySelector('.card');
// const heading = document.querySelector('h5');

// //Click
// clearBtn.addEventListener('click', runEvent);
// //Double Click
// clearBtn.addEventListener('dblclick', runEvent);
// //Mousedown
// clearBtn.addEventListener('mousedown', runEvent);
// //Mouseup
// clearBtn.addEventListener('mouseup', runEvent);
// //mouseenter (ONLY FIRES WHEN ENTERING MAIN ELEMENT)
// card.addEventListener('mouseenter', runEvent);
// //mouseleave
// card.addEventListener('mouseleave', runEvent);
// //Mouseover (FIRES WHEN ENTERING NESTED ELEMENTS)
// card.addEventListener('mouseover', runEvent);
// //mouseout
// card.addEventListener('mouseout', runEvent);
// //mousemove
// card.addEventListener('mousemove', runEvent);


// //Event handler
// function runEvent(e){
//     console.log(`Event type: ${e.type}`);

//     heading.textContent = `MouseX: ${e.offsetX} MouseY: ${e.offsetY}`;

//     document.body.style.backgroundColor = `rgb(${e.offsetX}, ${e.offsetY}, 40)`;
// }

// const form = document.querySelector('form');
// const taskInput = document.getElementById('task');
// const heading = document.querySelector('h5');

// taskInput.value = '';

// //form.addEventListener('submit', runEvent);

// taskInput.addEventListener('keydown', runEvent);
// //also keyup, keypress, focus, blur, cut, paste, input (any input event), change (for options lists)

// function runEvent(e){
//   console.log(`event type: ${e.type}`);

//   console.log(e.target.value);

//   //heading.innerText = e.target.value;

//   //Get input value
//   // console.log(taskInput.value);

//   // e.preventDefault();
// }


// //EVENT BUBBLING
// document.querySelector('.card-title').addEventListener('click', 
// function(){
//   console.log('card title');
// });

// document.querySelector('.card-content').addEventListener('click', 
// function(){
//   console.log('card content');
// });

// document.querySelector('.card').addEventListener('click', 
// function(){
//   console.log('card');
// });

// document.querySelector('.col').addEventListener('click', 
// function(){
//   console.log('col');
// });


//EVENT DELEGATION

// const delItem = document.querySelector('.delete-item');

// delItem.addEventListener('click', deleteItem);

// document.body.addEventListener('click', deleteItem);

// function deleteItem(e){
//   // if(e.target.parentElement.className === 'delete-item secondary-content'){
//   //   console.log('delete item');
//   // }

//   if(e.target.parentElement.classList.contains('delete-item')){
//     console.log('delete item');
//     e.target.parentElement.parentElement.remove();
//   }
// }

//SET LOCAL STORAGE ITEM
// localStorage.setItem('name', 'John');
// localStorage.setItem('age', '30');
//set session storage item (deleted when browser sessio is closed)
//sessionStorage.setItem('name', 'Beth');

//remove from storage
//localStorage.removeItem('name');

//get from storage
// const name = localStorage.getItem('name');
// const age = localStorage.getItem('age');

//clear local storage
// localStorage.clear();

// console.log(name, age);

document.querySelector('form').addEventListener('submit',
function(e){
  const task = document.getElementById('task').value;

  let tasks;

  if(localStorage.getItem('tasks') === null){
    tasks = [];
  } else {
    tasks = JSON.parse(localStorage.getItem('tasks'));
  }

  tasks.push(task);

  localStorage.setItem('tasks', JSON.stringify(tasks));
  alert('Task saved');

  e.preventDefault();
});

const tasks = JSON.parse(localStorage.getItem('tasks'));

tasks.forEach(function(task){
  console.log(task);
});