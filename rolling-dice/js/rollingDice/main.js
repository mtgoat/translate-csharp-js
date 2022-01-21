// Put your code here

for (let i = 0; i < 10; i++) {

function createDie (value, char) {
    return {
        value:value,
        char: char,
        }
        }

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

let die1 = createDie (getRandomInt(1,6), "")
let die2 = createDie (getRandomInt(1,6), "")

function char ( taco ) {
            if (taco.value == 1) {
                taco.char = "\u2680";
            }
            else if (taco.value == 2){
                taco.char = "\u2681";
            }
            else if (taco.value == 3){
                taco.char = "\u2682";
            }
            else if (taco.value == 4){
                taco.char = "\u2683";
            }
            else if (taco.value == 5){
                taco.char = "\u2684";
            }
            else if(taco.value == 6){
                taco.char = "\u2685";
            }
            }

char(die1)
char(die2)

// console.log(`${die1.char}`, `${die1.value}`)
// console.log(`${die2.char}`, `${die2.value}`)

function ConsoleMessage () {
let sum = `${die1.value + die2.value}`
let parts = `${die1.char} + ${die2.char} = ` 

let message = parts + sum

if (die1.value == die2.value)
{
    message += " DOUBLES!";
}
return (
console.log(`${message}`)
)
}

ConsoleMessage()
   
    
  }





