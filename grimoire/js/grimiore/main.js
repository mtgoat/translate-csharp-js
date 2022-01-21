// Put your code here

const createSpell = (name, isEvil, EnergyReqired) => {
    return {
            name: name,
            isEvil: isEvil,
            energy: EnergyReqired
    }
}

const createSpellBook = (title,spells) => {
    return {
            title:title,
            spells: spells,
            addSpell: (spell) => {
                this.spells.push(hobby);
            }
    }
}

function getAllSpells () {

const turn = createSpell("Turn enemy into a newt", true, 5.1)
const conjure = createSpell("Conjure some gold for a local charity", false, 2.99)
const give = createSpell("Give a deaf person the ability to heal", false, 12.2)
const make = createSpell("Make yourself emperor of the universe", true, 100.0)
const share = createSpell("Share your relatives your political views", false, 2921.5)

let allTheSpells = [turn, conjure, give, make, share]
return (
    allTheSpells
)
}

const alltheSpells = getAllSpells()
// console.log(alltheSpells)

function makeGoodSpellBook (allTheSpells) {
    let alltheSpells = getAllSpells()
    let goodSpells = alltheSpells.filter(spell => !spell.isEvil)
    const goodBook = createSpellBook("Good Book", goodSpells )
    // console.log(goodSpells)
    return (
        goodBook
        // console.log(goodBook.title, goodBook.spells)

    )
}

const goodBook = makeGoodSpellBook()

function makeEvilSpellBook (allTheSpells) {
    let alltheSpells = getAllSpells()
    let evilSpells = alltheSpells.filter(spell => spell.isEvil)
    const evilBook = createSpellBook("Evil Book", evilSpells )
    
    return (
        evilBook
        // console.log(evilBook.title, evilSpells.spells)

    )
}
const evilBook = makeEvilSpellBook()

// console.log (goodBook)
function display (book) {
    console.log(book.title)
 for (let eSpell of book.spells )
    {
        console.log(`${eSpell.name}`);
    }
        
}

display(goodBook)
console.log()
display(evilBook)