

// Game values
let min = 1,
    max = 10,
    winningNum = getRandomNum(min, max),
    guessesLeft = 3;

// UI elements
const
    UIgame = document.querySelector('#game'),
    UIminNum = document.querySelector('.min-num'),
    UImaxNum = document.querySelector('.max-num'),
    UIguessBtn = document.querySelector('#guess-btn'),
    UIguessInput = document.querySelector('#guess-input'),
    UImessage = document.querySelector('.message');

// Assign UI min and max
UIminNum.textContent = min;
UImaxNum.textContent = max;

// Play again event listener
game.addEventListener('mousedown', function(e){
    if(e.target.className === 'play-again'){
        window.location.reload();
    }
});

// Set focus
UIguessInput.focus();

// Listen for guess
UIguessBtn.addEventListener('click', function(){
    let guess = parseInt(UIguessInput.value);

    // Validate
    if (isNaN(guess) || guess < min || guess > max){
        setMessage(`Please enter a number between ${min} and ${max}`, 'red');
    }

    // Check if won
    if(guess === winningNum){
        //Game over - won

       gameOver(true, `${winningNum} is correct! You win!`)
       // Clear input
       UIguessInput.value = '';

    } else {
        // Wrong number
        guessesLeft -= 1;

        if(guessesLeft == 0){
            // Game over - lost

            gameOver(false, `Game Over. You lost. The correct number was ${winningNum}`);
            // Clear input
            UIguessInput.value = '';

        } else {
            // Game continue - answer wrong

            // Change border color
            UIguessInput.style.borderColor = 'red';
            // Clear input
            UIguessInput.value = '';
            // Wrong message
            setMessage(`Guess is incorrect. ${guessesLeft} guesses left`, 'red');
            // Reset focus
            UIguessInput.focus();
        }
    }
});

// Game over
function gameOver(won, msg){
    let color;
    won === true ? color = 'green' : color = 'red';

    // Disable input
    UIguessInput.disabled = true;
    // Change border color
    UIguessInput.style.borderColor = color;
    UImessage.style.color = color;
    // Set message
    setMessage(msg);

    // Play again
    UIguessBtn.value = 'Play Again';
    UIguessBtn.className += 'play-again';
}

// Get winning num
function getRandomNum(min, max){
    return (Math.floor(Math.random() * (max-min+1) + min));
}

// Set message
function setMessage(msg, color){
    UImessage.style.color=color;
    UImessage.textContent = msg;
}