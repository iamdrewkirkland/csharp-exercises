const placesArray = [
  "Nashville",
  "Hong Kong",
  "The back yard",
  "Earth",
  "London",
  "The mall",
  "Ryman Auditorium",
  "The Great Wall of China",
];
const thePlaces = placesArray.filter((place) => {
  return place.includes("The");
});

function main() {
  // Put your code here

  // Print some output to the terminal (aka. "Console");
  console.log("These are definitely places");

  placesArray.map((place) => console.log(place));

  console.log("These are definitely THE places");

  thePlaces.map((thePlace) => console.log(thePlace));
}
main();
