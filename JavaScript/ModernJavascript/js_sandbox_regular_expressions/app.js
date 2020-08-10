// Lecture 83

// let re;
// re = /hello/;
// re = /hello/i; // i = case insensitive
// // re = /hello/g; // Global search for all instances of "hello"

// // console.log(re);
// // console.log(re.source);

// // exec() - Return result in an array (if match) or null (no match)
// // const result = re.exec('hello world');
// // const result2 = re.exec('hi world');

// // console.log(result);
// // console.log(result2);
// // console.log(result[0]);
// // console.log(result.index);
// // console.log(result.input);

// // test() - Returns true or false depending on match
// // const result = re.test('Hello');
// // console.log(result);

// // match() - Return result array or null
// // const str = 'Hello There';
// // const result = str.match(re);
// // console.log(result);

// // search() - Returns index of first match - if not found, returns -1
// // const str = 'Well, Hello There';
// // const result = str.search(re);
// // console.log(result);

// // replace() - Returns a new string with some or all matches of a pattern
// const str = 'Hello There';
// const newStr = str.replace(re, 'Hi');
// console.log(newStr);

// Lecture 84

let re;
// literal characters
re = /hello/i;

// Metacharacter Symbols
re = /^h/i  // Must start with
re = /d$/i; // Must end with
re = /^hello$/i; // Must start and end with
re = /^h.llo$/i; // Matches any ONE character
re = /h*llo/i; // Matches any character 0 or more times
re = /gre?a?y/i; // Optional character
re = /gre?a?y\?/i; // Escape character

// Brackets [] - Character sets
re = /gr[ae]y/i; // Must be an a or an e
re = /[GF]ray/; // Must be G or F
re = /[^GF]ray/; // Match anything except for G or F
re = /[A-Z]ray/; // Match any uppercase letter
re = /[A-Za-z]ray/; // Match any letter of either case
re = /[0-9]ray/; // Match any digit

// Braces {} - Quantifiers
re = /Hel{2}o/i; // Must occur exactly {m} amount of times
re = /Hel{2,4}o/i; // Can have between 2-4 'l's
re = /Hel{2,}o/i; // Must occur at least {m} amount of times

// Parenthesis () - Grouping
re = /([0-9]x){3}/;

// Shorthand character classes
re = /\w/; // Word character - alphanumeric or _
re = /\w+/; // + = one or more
re = /\W/; // any non-word characters
re = /\d/; // matches any digit
re = /\d+/; // matches any digit 0 or more times
re = /\D/; // matches any non-digit
re = /\s/; // matches a whitespace character
re = /\S/; // matches any non-whitespace character
re = /Hell\b/i; // Word boundary

// Assertions
re = /x(?=y)/; // Match x only if followed by y
// Assertions
re = /x(?!y)/; // Match x only if NOT followed by y


//String to match
let str = 'Hello';
str = 'Heello';
str = 'Gray';
str = 'Gray?';
str = 'Gray';
str = 'Xray';
str = '8ray';
str = 'Hello';
str = '3x3x3x';
str = ' ';
str = 'Hello, welcome to Hell';
str = 'xy';

// Log results
const result = re.exec(str);
console.log(result);

function reTest (re, str){
    if(re.test(str)) {
        console.log(`${str} matches ${re.source}`);
    } else {
        console.log(`${str} does NOT match ${re.source}`);
    }
}

reTest(re, str);