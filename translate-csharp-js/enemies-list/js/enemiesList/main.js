const enemyList = [
  {
    id: 1,
    FirstName: "Joshua",
    LastName: "Flowers",
    Offenses: [
      "Being a jerk to me in elementary school",
      "Not being nice to me in elementary school",
    ],
    IsReallyHated: true,
  },
  {
    id: 2,
    FirstName: "Darth",
    LastName: "Vader",
    Offenses: [
      "Cut off Luke's hand",
      "Murdered all those kids",
      "Unkind management practices",
    ],
    IsReallyHated: false,
  },
  {
    id: 3,
    FirstName: "Betty",
    LastName: "Rudelady",
    Offenses: [
      "Phone calls in the theater",
      "Phone calls on the bus",
      "Phone calls in line at the grocery store",
      "Poor conversationalist",
    ],
    IsReallyHated: true,
  },
  {
    id: 4,
    FirstName: "Leon",
    LastName: "Peck",
    Offenses: ["Keeps giving me a hotplate"],
    IsReallyHated: false,
  },
];

function main() {
  // Put your code here
  console.log("My Enemies");
  console.log("----------");
  enemyList.map((enemy) => {
    if (enemy.IsReallyHated) {
      return console.log(`I really hate ${enemy.FirstName} ${enemy.LastName}`);
    } else {
      return console.log(`${enemy.FirstName} ${enemy.LastName}`);
    }
  });
}

main();
