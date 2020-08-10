// OBSERVER (ES6 standard)

class EventObserver {
    constructor() {
        this.observers = [];
    }

    subscribe(fn) {
        this.observers.push(fn);
        console.log(`You are now subscribed to ${fn.name}`)
    }

    unsubscribe(fn) {
        // Filters out from list whatever matches callback function.
        // If no match, callback stays on the list.
        // Filter returns a new list and reassigns the list of observers.
        this.observers = this.observers.filter(function(item) {
            if(item !== fn) {
                return item;
            }
        });
        console.log(`You are now unsubscribed from ${fn.name}`);
    }

    fire() {
        this.observers.forEach(function(item) {
            item.call();
        });
    }
}

const click = new EventObserver();

// Event listeners
document.querySelector('.sub-ms').addEventListener('click', () => {
    click.subscribe(getCurMilliseconds);
});

document.querySelector('.unsub-ms').addEventListener('click', () => {
    click.unsubscribe(getCurMilliseconds);
});

document.querySelector('.sub-s').addEventListener('click', () => {
    click.subscribe(getCurSeconds);
});

document.querySelector('.unsub-s').addEventListener('click', () => {
    click.unsubscribe(getCurSeconds);
});

document.querySelector('.fire').addEventListener('click', () => {
    click.fire();
});

// Click handler
const getCurMilliseconds = () => {
    console.log(`Current Milliseconds: ${new Date().getMilliseconds()}`);
}

const getCurSeconds = () => {
    console.log(`Current Seconds: ${new Date().getSeconds()}`);
}