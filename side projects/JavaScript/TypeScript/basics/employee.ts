var employees: string [] = ["Bob", "Sally", "Sam"];

document.write(employees.toString() + "<br />");

interface SuperHero{
  realName: String;
  superName: String;
}

var superheroes: SuperHero [] = [];
superheroes.push(
  {
    realName: "Bruce Wayne",
    superName: "Batman"
  }
)

document.write(superheroes[0].realName + " is " + superheroes[0].superName + "<br />");