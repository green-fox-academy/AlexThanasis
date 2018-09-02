var myName: string = "Alex";
var myAge: number = 32;
var canVote: boolean = true;
var anything: any = "dog";
anything = 2;

document.getElementById("tsStuff").innerHTML = "My name is " + myName;

document.write("canVote is a " + typeof(canVote) + "<br />");
document.write("myName is a " + typeof(myName) + "<br />");
document.write("anything is a " + typeof(anything) + "<br />");

var strToNumber: number = parseInt("5");
var numToString: number = 5;
document.write("numToString is a " + typeof(numToString.toString()) + "<br />");
