# Rocket_Elevators_Controllers.  Please scroll to the bottom to see the information about COMMERCIAL CONTROLLER

RESIDENTIAL CONTROLLER 
-----------------------
Contains the algorithm files for the elevator controllers for the New Rocket Elevator Solutions for both Residential and Commercial Offers.

The Residential controller algorithms are written in Javascript and Python.
In order to use the files, for Javascript, it is best to run it either on the web browser or on repl.it since some commands do not work on the terminal.
The goal of the programs are to find out which elevators would arrive first when the call button is pressed. It also involves other elements such as the movement of the elevator,
the opening and the closing of the doors, and other components that an elevator need to run smoothly.

The Residential Building currently contains 2 elevators and 10 floors. 

Javascript
1. At the bottom of the Residential_Controller.js file, you can change the starting position of Elevator1 and Elevator2 below the
comments: "#STEP 1: MODIFY THE INITIAL STATES OF ELEVATORS HERE"
2. If you wish to change the direction and the floor of the call button. Find #STEP 2: REQUEST ELEVATOR and change the values inside the paranthesis.
3. Copy the whole code onto repl.it and run it.
   OR you can use this link to run the code https://repl.it/repls/ForsakenFatalTranslation

Python
1. See step 1 and 2 of Javascript
2. See step 1 and 2 of Javascript
3. Run the file on the terminal


COMMERCIAL CONTROLLER
---------------------
The Commercial controller algorithms are implemented in C# and Go Lang.

To access the C# code, please:
Go to the Commercial_Controller file.
Then Commercial_Controller (again)
Then, Program.cs

I have written all the scenarios (1-4) in the file. But to test each of them, you must go to the bottom of the code (at the very bottom) and you'll see a section that says:

            //REQUEST FLOOR (SCENERIO 1) (floor you're on,floor you're going to)
            //columnsList[1].RequestElevator(1, 20);<--PLEASE UNCOMMENT THESE INDIVIDUALLY

            //REQUEST FLOOR (SCENERIO 2)
            //columnsList[2].RequestElevator(1, 36); <--PLEASE UNCOMMENT THESE INDIVIDUALLY

            //REQUEST FLOOR (SCENERIO 3)
            //columnsList[3].RequestElevator(54, 1);<--PLEASE UNCOMMENT THESE INDIVIDUALLY

            //REQUEST FLOOR (SCENERIO 4)
            //columnsList[0].RequestElevator(-2, 1); //(B1,1) <--PLEASE UNCOMMENT THESE INDIVIDUALLY
            
 Don't forget to put the // back once you are done with a scenerio and testing out the next one.
 

To access the C# code, please click on:
Commercial_Controller.go
