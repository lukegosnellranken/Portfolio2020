
for (let i=1; i < 101; i++) {
    
    if (((i / 3) % 0) && ((i / 5) % 0)) {
        document.getElementById('result').innerHTML = "fizzbuzz"
    }
    else if ((i / 3) % 0) {
        document.getElementById('result').innerHTML = "fizz"
    }
    else if ((i / 5) % 0) {
        document.getElementById('result').innerHTML = "buzz"
    }
}