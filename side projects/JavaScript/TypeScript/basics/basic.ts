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

var getSum = function (num1: number, num2: number): number{
  return num1 + num2;
} 

var theSum1: number = getSum(5, 2);

var getDiff = function(num1: number, num2 = 2, num3?: number): number{
  if(typeof num3 !== 'undefined'){
    return num1 - num2 - num3;
  }
  return num1 - num2;
}