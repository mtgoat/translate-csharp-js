// Put your code here

const names =[  "Nashville", "Hong Kong", "The back yard", "Earth",
"London", "The mall", "Ryman Auditorium", "The Great Wall of China"];

console.log("All Place Names", );
// console.log(`${names}`)
for (let name of names) {
    console.log(`${name}`);
  }
  console.log()

  const theNames = names.filter((n) => n.startsWith("The"));
 
  for (let name of theNames) {
    console.log(`${name}`);
  }
 
