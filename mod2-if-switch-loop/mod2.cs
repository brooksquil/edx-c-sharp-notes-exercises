// Module 2 Desicion Statements

// /////////////////////////////////

// if statement
// string response = "Yes";
// if (response == "Yes")
// {
//     // statements which execute if condition is true here
// }
// /////////////////////////////////////////////////

// if else statement
// string response;
// if (response == "connection_failed")
// {
//     //code here executes if condition is true
// }
// else
// {
//     //code here executes if condition is false
// }
// //////////////////////////////////////////////////

// else if statement
// string response;
// if (response == "connection_failed")
// {
//     // code here executes if condition in "if" is true
// }
// else if (response == "connection_error")
// {
//     // code here executes if condition in "else if" is true
// }
// else
// {
//     // code here executes if condition in both conditions are false
// }
// ///////////////////////////////////////////////////////////////

// Switch Statement
// string response;
// switch (response)
// {
//     // case is the condition
//     case "connection_failed":
//         // code here executes if above condition is true
//     case "connection_success":
//         // code here executes if above condition is true
//     case "connection_error":
//         // code here executes if above condition is true
//         break;
//     default:
//         // code here executes if none of the above case
//         // conditions is met
//         break;
// }
// ////////////////////////////////////////////////////

// Loops ////

//For Loop
// for ([intializer]; [condition]; [iterator]
// {
//     // code to repeat here
// })
//
// for (int i = 0; i < 10; i++)
// {
//     // code to repeat here
// }
// ///////////////////////////////
// For Each Loop
// string[] names = new string[10];
// // process each name in above array
// foreach (string name in names)
// {
//     // code to execute
// }
// ///////////////////////////////
// While Loop
// In a while loop, if the condition is false from the start, the       body of the loop will never execute
// string response = PromptUser();
// while (response != "Quit")
// {
//     // process data
//     // imperitave to include the following to avoid an infinite loop
//     response = PromptUser();
// }
// ///////////////////////////////
// the do loop
//  a do loop will always execute the body of the loop at least once
// do
// {
//     //process data
//     response = PromptUser();
// } while (response != "Quit");
// ////////////////////////////////
