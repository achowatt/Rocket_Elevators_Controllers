using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commercial_Controller
{
    class Elevator
    {
        public int ID; //elevator array number
        public string Status { get; set; } //'UP','DOWN','MAINTENANCE'; 
        public int CurrentFloor { get; set; } //depends on column
        public List<int> RequestList = new List<int>(); //array
        public int NumberOfFloors;

        public Elevator(int ID, string Status, int CurrentFloor)
        {
            this.ID = ID;
            this.Status = Status;
            this.CurrentFloor = CurrentFloor;
        }

        public void OpenDoor()
        {
            Console.WriteLine("Door Opens");
        }

        public void CloseDoor()
        {
            Console.WriteLine("Door Closes");
        }

        public void RequestFloor(int floor)
        {
            this.MoveElevator(floor);
        }


        public void MoveElevator(int floor)
        {
            if (this.CurrentFloor < floor)
            {
                while (this.CurrentFloor < floor)
                {
                    if (this.CurrentFloor == 1)
                    {
                        Console.WriteLine("The elevator is moving from Lobby");
                    }
                    else if (this.CurrentFloor == 0)
                    {
                        Console.WriteLine("The elevator is moving from B1");
                    }
                    else if (this.CurrentFloor == -1)
                    {
                        Console.WriteLine("The elevator is moving from B2");
                    }
                    else if (this.CurrentFloor == -2)
                    {
                        Console.WriteLine("The elevator is moving from B3");
                    }
                    else if (this.CurrentFloor == -3)
                    {
                        Console.WriteLine("The elevator is moving from B4");
                    }
                    else if (this.CurrentFloor == -4)
                    {
                        Console.WriteLine("The elevator is moving from B5");
                    }
                    else if (this.CurrentFloor == -5)
                    {
                        Console.WriteLine("The elevator is moving from B6");
                    }
                    else
                    {
                        Console.WriteLine("The elevator is moving from " + this.CurrentFloor);
                    }
                    this.CurrentFloor++;
                    this.Status = "UP";

                    if (this.CurrentFloor == floor)
                    {
                        if (this.CurrentFloor == 1)
                        {
                            Console.WriteLine("The elevator is stopped at Lobby");
                        }
                        else if (this.CurrentFloor == 0)
                        {
                            Console.WriteLine("The elevator is stopped at B1");
                        }
                        else if (this.CurrentFloor == -1)
                        {
                            Console.WriteLine("The elevator is stopped at B2");
                        }
                        else if (this.CurrentFloor == -2)
                        {
                            Console.WriteLine("The elevator is stopped at B3");
                        }
                        else if (this.CurrentFloor == -3)
                        {
                            Console.WriteLine("The elevator is stopped at B4");
                        }
                        else if (this.CurrentFloor == -4)
                        {
                            Console.WriteLine("The elevator is stopped at B5");
                        }
                        else if (this.CurrentFloor == -5)
                        {
                            Console.WriteLine("The elevator is stopped at B6");
                        }
                        else
                        {
                            Console.WriteLine("The elevator is stopped at " + this.CurrentFloor);
                        }
                    }

                    if (this.CurrentFloor == 20)
                    {
                        this.Status = "DOWN";
                    }
                    else if (this.CurrentFloor == 40)
                    {
                        this.Status = "DOWN";
                    }
                    else if (this.CurrentFloor == 60)
                    {
                        this.Status = "DOWN";
                    }
                    else if (this.CurrentFloor == 1)
                    {
                        if (this.Status == "UP")
                        {
                            this.Status = "DOWN";
                        }
                        else if (this.Status == "DOWN")
                        {
                            this.Status = "UP";
                        }
                    }
                }

            }
            else if (this.CurrentFloor > floor)
            {
                while (this.CurrentFloor > floor)
                {
                    if (this.CurrentFloor == 1)
                    {
                        Console.WriteLine("The elevator is moving from Lobby");
                    }
                    else if (this.CurrentFloor == 0)
                    {
                        Console.WriteLine("The elevator is moving from B1");
                    }
                    else if (this.CurrentFloor == -1)
                    {
                        Console.WriteLine("The elevator is moving from B2");
                    }
                    else if (this.CurrentFloor == -2)
                    {
                        Console.WriteLine("The elevator is moving from B3");
                    }
                    else if (this.CurrentFloor == -3)
                    {
                        Console.WriteLine("The elevator is moving from B4");
                    }
                    else if (this.CurrentFloor == -4)
                    {
                        Console.WriteLine("The elevator is moving from B5");
                    }
                    else if (this.CurrentFloor == -5)
                    {
                        Console.WriteLine("The elevator is moving from B6");
                    }
                    else
                    {
                        Console.WriteLine("The elevator is moving from " + this.CurrentFloor);
                    }
                    this.CurrentFloor--;
                    this.Status = "DOWN";

                    if (this.CurrentFloor == floor)
                    {
                        if (this.CurrentFloor == 1)
                        {
                            Console.WriteLine("The elevator is stopped at Lobby");
                        }
                        else if (this.CurrentFloor == 0)
                        {
                            Console.WriteLine("The elevator is stopped at B1");
                        }
                        else if (this.CurrentFloor == -1)
                        {
                            Console.WriteLine("The elevator is stopped at B2");
                        }
                        else if (this.CurrentFloor == -2)
                        {
                            Console.WriteLine("The elevator is stopped at B3");
                        }
                        else if (this.CurrentFloor == -3)
                        {
                            Console.WriteLine("The elevator is stopped at B4");
                        }
                        else if (this.CurrentFloor == -4)
                        {
                            Console.WriteLine("The elevator is stopped at B5");
                        }
                        else if (this.CurrentFloor == -5)
                        {
                            Console.WriteLine("The elevator is stopped at B6");
                        }
                        else
                        {
                            Console.WriteLine("The elevator is moving from " + this.CurrentFloor);
                        }

                    }

                    if (this.CurrentFloor == -5)
                    {
                        this.Status = "UP";
                    }
                    if (this.CurrentFloor == 1)
                    {
                        if (this.Status == "UP")
                        {
                            this.Status = "DOWN";
                        }
                        else if (this.Status == "DOWN")
                        {
                            this.Status = "UP";
                        }
                    }
                }
            }
            this.OpenDoor();
            this.CloseDoor();
        }
    }
        class Column
        {
            //member variables
            public List<Elevator> ElevatorsList = new List<Elevator>(); //array
            public int NumberOfFloors { get; set; }

            public Column(int numberOfElevators)
            {
                for (int i = 0; i < numberOfElevators; i++)
                {
                    this.ElevatorsList.Add(new Elevator(i, "IDLE", 1));
                }

            }

            public void ShowElevator() //not showing
            {
                Console.WriteLine(this.ElevatorsList[1]);
            }


            public void RequestElevator(int floor, int requestedFloor)
            {
                //select elevator
                int arrayNumber = this.SelectElevator(floor, requestedFloor);
                int a = arrayNumber + 1;
                Console.WriteLine("Elevator " + a + " is CHOSEN");
                if (this.ElevatorsList[arrayNumber].CurrentFloor == 1)
                {
                    Console.WriteLine("Elevator " + a + " is currently on Lobby");
                }
                else if (this.ElevatorsList[arrayNumber].CurrentFloor == 0)
                {
                    Console.WriteLine("Elevator " + a + " is currently on B1");
                }
                else if (this.ElevatorsList[arrayNumber].CurrentFloor == -1)
                {
                    Console.WriteLine("Elevator " + a + " is currently on B2");
                }
                else if (this.ElevatorsList[arrayNumber].CurrentFloor == -2)
                {
                    Console.WriteLine("Elevator " + a + " is currently on B3");
                }
                else if (this.ElevatorsList[arrayNumber].CurrentFloor == -3)
                {
                    Console.WriteLine("Elevator " + a + " is currently on B4");
                }
                else if (this.ElevatorsList[arrayNumber].CurrentFloor == -4)
                {
                    Console.WriteLine("Elevator " + a + " is currently on B5");
                }
                else if (this.ElevatorsList[arrayNumber].CurrentFloor == -5)
                {
                    Console.WriteLine("Elevator " + a + " is currently on B6");
                }
                else
                {
                    Console.WriteLine("Elevator" + a + "is currently on " + this.ElevatorsList[arrayNumber].CurrentFloor);
                }

            }

            //Do i need diff functions for each columns?
            public int SelectElevator(int floor, int requestedFloor)
            {
                int selectedElevatorId = 0;
                string direction;

                if (requestedFloor < floor)
                {
                    direction = "DOWN";
                }
                else if (requestedFloor > floor)
                {
                    direction = "UP";
                }
                else
                {
                    direction = "IDLE";
                }

                List<Elevator> availableElevators = this.ElevatorsList.FindAll(e => e.Status != "MAINTENANCE");

                int difference = 999;

                //step 1 choose same floor + direction
                foreach (Elevator x in availableElevators)
                {
                    if (x.Status == direction && x.CurrentFloor == floor)
                    {
                        difference = Math.Abs(x.CurrentFloor - floor);
                        selectedElevatorId = x.ID;

                    }
                    else if (x.Status == "IDLE" && x.CurrentFloor == floor)
                    {
                        difference = Math.Abs(x.CurrentFloor - floor);
                        selectedElevatorId = x.ID;

                    }
                    else if (x.Status == direction && x.Status == "UP" && x.CurrentFloor < floor)
                    {
                        difference = Math.Abs(x.CurrentFloor - floor);
                        selectedElevatorId = x.ID;

                    }
                    else if (x.Status == direction && x.Status == "DOWN" && x.CurrentFloor > floor)
                    {
                        difference = Math.Abs(x.CurrentFloor - floor);
                        selectedElevatorId = x.ID;

                    }
                    else if (x.Status == "IDLE")
                    {
                        difference = Math.Abs(x.CurrentFloor - floor);
                        selectedElevatorId = x.ID;

                    }
                    else if (x.Status == "UP" && direction == "DOWN" && x.CurrentFloor < floor)
                    {
                        difference = Math.Abs(x.CurrentFloor - floor);
                        selectedElevatorId = x.ID;

                    }
                    else if (x.Status == "DOWN" && direction == "UP" && x.CurrentFloor > floor)
                    {
                        difference = Math.Abs(x.CurrentFloor - floor);
                        selectedElevatorId = x.ID;

                    }
                    else
                    {
                        difference = Math.Abs(x.CurrentFloor - floor);
                        selectedElevatorId = x.ID;
                    }
                }
                return selectedElevatorId;
            }
        }
            class Program
            {
                //variables
                public object columnsList;

                public static void Main(string[] args)
                {
                    //array of columns
                    List<Column> columnsList = new List<Column>();

                    for (int i = 0; i < 4; i++)
                    {
                        columnsList.Add(new Column(5));
                    }
                    /***************************INITIALIZE**************************/
                    Console.WriteLine("Press any key to initialize!");
                    Console.ReadLine();
                    Console.WriteLine("POWER ON");
                    Console.WriteLine("BATTERIES FULL \n");

                    /*##############################################################*/
                    /*#########SET 1st COLUMN FLOORS + ITS ELEVATOR FLOORS##########*/
                    /*##############################################################*/

                    columnsList[0].NumberOfFloors = 6 + 1; //intializing floors ( 1 = lobby)

                    Console.WriteLine("Setting " + columnsList.Count + " columns in total.");
                    Console.WriteLine("The first column has " + columnsList[0].NumberOfFloors + " floors");
                    Console.WriteLine("Setting " + columnsList[0].ElevatorsList.Count + " elevators in column 1.");

                    //SET ELEVATOR 1 STATUS AND FLOOR HERE (COLUMN1)
                    columnsList[0].ElevatorsList[0].Status = "IDLE";     //"IDLE" "MAINTENANCE" "UP" "DOWN"
                    columnsList[0].ElevatorsList[0].CurrentFloor = 1;   //1,0,-1,-2,-3,-4,-,5

                    //SET ELEVATOR 2 STATUS AND FLOOR HERE
                    columnsList[0].ElevatorsList[1].Status = "IDLE";     //"IDLE" "MAINTENANCE" "UP" "DOWN"
                    columnsList[0].ElevatorsList[1].CurrentFloor = 1;   //1,0,-1,-2,-3,-4,-,5

                    //SET ELEVATOR 3 STATUS AND FLOOR HERE
                    columnsList[0].ElevatorsList[2].Status = "IDLE";     //"IDLE" "MAINTENANCE" "UP" "DOWN"
                    columnsList[0].ElevatorsList[2].CurrentFloor = 1;   //1,0,-1,-2,-3,-4,-,5

                    //SET ELEVATOR 4 STATUS AND FLOOR HERE
                    columnsList[0].ElevatorsList[3].Status = "IDLE";     //"IDLE" "MAINTENANCE" "UP" "DOWN"
                    columnsList[0].ElevatorsList[3].CurrentFloor = 1;   //1,0,-1,-2,-3,-4,-,5


                    Console.WriteLine("Elevator1 in Column 1 is current:" + columnsList[0].ElevatorsList[0].Status + " and located on floor: "
                        + columnsList[0].ElevatorsList[0].CurrentFloor);

                    Console.WriteLine("Elevator2 in Column 1 is current:" + columnsList[0].ElevatorsList[1].Status + " and located on floor: "
                        + columnsList[0].ElevatorsList[1].CurrentFloor);

                    Console.WriteLine("Elevator3 in Column 1 is current:" + columnsList[0].ElevatorsList[2].Status + " and located on floor: "
                        + columnsList[0].ElevatorsList[2].CurrentFloor);


                    Console.WriteLine("Elevator4 in Column 1 is current:" + columnsList[0].ElevatorsList[3].Status + " and located on floor: "
                        + columnsList[0].ElevatorsList[3].CurrentFloor + "\n");

                    /*##############################################################*/
                    /*#########SET 2nd COLUMN FLOORS + ITS ELEVATOR FLOORS########*/
                    /*##############################################################*/
                    columnsList[1].NumberOfFloors = 20;

                    Console.WriteLine("************************************************************");
                    Console.WriteLine("_________________________SCENERIO 1_________________________");
                    Console.WriteLine("************************************************************");

                    Console.WriteLine("The second column has " + columnsList[1].NumberOfFloors + " floors");
                    Console.WriteLine("Setting " + columnsList[1].ElevatorsList.Count + " elevators in column 2.");

                    /***************************************************/
                    //SETTING INITIAL ELEVATOR 1 STATUS AND FLOOR HERE (COLUMN2)
                    /*************************************************/
                    int B1_CurrentFloor = 2; //1-20 only
                    int B1_RequestFloor = 20; //<==PUT REQUEST FLOOR HERE

                    //CALLING CurrentFloor & function RequestFloor
                    columnsList[1].ElevatorsList[0].CurrentFloor = B1_CurrentFloor;
                    Console.WriteLine("Elevator1 in Column 2 is currently:" + "\"" + columnsList[1].ElevatorsList[0].Status + "\"" + "on floor: "
                    + columnsList[1].ElevatorsList[0].CurrentFloor);
                    columnsList[1].ElevatorsList[0].RequestFloor(B1_RequestFloor);
                    Console.WriteLine("Elevator1 in Column 2 is currently:" + "\"" + columnsList[1].ElevatorsList[0].Status + "\"" + "on floor: "
                    + columnsList[1].ElevatorsList[0].CurrentFloor);


                    //adding things to request list to compare proximity later
                    columnsList[1].ElevatorsList[0].RequestList.Add(B1_CurrentFloor);
                    columnsList[1].ElevatorsList[0].RequestList.Add(B1_RequestFloor);

                    Console.WriteLine("----------------------------------------------------");

                    /************************************************/
                    /***SET ELEVATOR 2 STATUS AND FLOOR HERE*******/
                    /*********************************************/


                    int B2_CurrentFloor = 3; //1-20 only
                    int B2_RequestFloor = 15; //<==PUT REQUEST FLOOR HERE

                    columnsList[1].ElevatorsList[1].CurrentFloor = B2_CurrentFloor;
                    Console.WriteLine("Elevator2 in Column 2 is currently:" + "\"" + columnsList[1].ElevatorsList[1].Status + "\"" + " on floor: "
                    + columnsList[1].ElevatorsList[1].CurrentFloor);
                    columnsList[1].ElevatorsList[1].RequestFloor(B2_RequestFloor);
                    Console.WriteLine("Elevator2 in Column 2 is currently:" + "\"" + columnsList[1].ElevatorsList[1].Status + "\"" + " on located on floor: "
                    + columnsList[1].ElevatorsList[1].CurrentFloor);

                    //adding things to request list to compare proximity later
                    columnsList[1].ElevatorsList[1].RequestList.Add(B2_CurrentFloor);
                    columnsList[1].ElevatorsList[1].RequestList.Add(B2_RequestFloor);

                    Console.WriteLine("----------------------------------------------------");

                    /************************************************/
                    /***SET ELEVATOR 3 STATUS AND FLOOR HERE*******/
                    /*********************************************/
                    int B3_CurrentFloor = 13; //1-20 only
                    int B3_RequestFloor = 1; //<==PUT REQUEST FLOOR HERE

                    columnsList[1].ElevatorsList[2].CurrentFloor = B3_CurrentFloor;
                    Console.WriteLine("Elevator3 in Column 2 is currently:" + "\"" + columnsList[1].ElevatorsList[2].Status + "\"" + " on floor: "
                    + columnsList[1].ElevatorsList[2].CurrentFloor);
                    columnsList[1].ElevatorsList[2].RequestFloor(B3_RequestFloor);
                    Console.WriteLine("Elevator3 in Column 2 is currently:" + "\"" + columnsList[1].ElevatorsList[2].Status + "\"" + " on floor: "
                    + columnsList[1].ElevatorsList[2].CurrentFloor);

                    //adding things to request list to compare proximity later
                    columnsList[1].ElevatorsList[2].RequestList.Add(B3_CurrentFloor);
                    columnsList[1].ElevatorsList[2].RequestList.Add(B3_RequestFloor);
                    Console.WriteLine("----------------------------------------------------");

                    /************************************************/
                    /***SET ELEVATOR 4 STATUS AND FLOOR HERE*******/
                    /*********************************************/
                    int B4_CurrentFloor = 15; //1-20 only
                    int B4_RequestFloor = 2; //<==PUT REQUEST FLOOR HERE

                    columnsList[1].ElevatorsList[3].CurrentFloor = B4_CurrentFloor;
                    Console.WriteLine("Elevator4 in Column 2 is currently:" + "\"" + columnsList[1].ElevatorsList[3].Status + "\"" + "on floor: "
                    + columnsList[1].ElevatorsList[3].CurrentFloor);
                    columnsList[1].ElevatorsList[3].RequestFloor(B4_RequestFloor);
                    Console.WriteLine("Elevator4 in Column 2 is currently:" + "\"" + columnsList[1].ElevatorsList[3].Status + "\"" + "on floor: "
                    + columnsList[1].ElevatorsList[3].CurrentFloor);

                    //adding things to request list to compare proximity later
                    columnsList[1].ElevatorsList[3].RequestList.Add(B4_CurrentFloor);
                    columnsList[1].ElevatorsList[3].RequestList.Add(B4_RequestFloor);
                    Console.WriteLine("----------------------------------------------------");
                    /************************************************/
                    /***SET ELEVATOR 5 STATUS AND FLOOR HERE*******/
                    /*********************************************/
                    int B5_CurrentFloor = 6;  //1-20 only
                    int B5_RequestFloor = 1; //<==PUT REQUEST FLOOR HERE

                    columnsList[1].ElevatorsList[4].CurrentFloor = B5_CurrentFloor;
                    Console.WriteLine("Elevator5 in Column 2 is currently:" + "\"" + columnsList[1].ElevatorsList[4].Status + "\"" + " and located on floor: "
                    + columnsList[1].ElevatorsList[4].CurrentFloor);

                    columnsList[1].ElevatorsList[4].RequestFloor(B5_RequestFloor);

                    Console.WriteLine("Elevator5 in Column 2 is currently:" + "\"" + columnsList[1].ElevatorsList[4].Status + "\"" + " and located on floor: "
                    + columnsList[1].ElevatorsList[4].CurrentFloor);

                    //adding things to request list to compare proximity later
                    columnsList[1].ElevatorsList[4].RequestList.Add(B5_CurrentFloor);
                    columnsList[1].ElevatorsList[4].RequestList.Add(B5_RequestFloor);

                    Console.WriteLine("************************************************************");





                    Console.WriteLine("************************************************************");
                    Console.WriteLine("_________________________SCENERIO 2_________________________");
                    Console.WriteLine("************************************************************");

                    /*##############################################################*/
                    /*#########SET 3rd COLUMN FLOORS + ITS ELEVATOR FLOORS########*/
                    /*##############################################################*/

                    columnsList[2].NumberOfFloors = 20 + 1;

                    Console.WriteLine("The third column has " + columnsList[2].NumberOfFloors + " floors");
                    Console.WriteLine("Setting " + columnsList[2].ElevatorsList.Count + " elevators in column 3.");



                    //SET ELEVATOR 1 STATUS AND FLOOR HERE (COLUMN3)
                    int C1_CurrentFloor = 1;  //1,21-40 only
                    int C1_RequestFloor = 21; //<==PUT REQUEST FLOOR HERE

                    columnsList[2].ElevatorsList[0].CurrentFloor = C1_CurrentFloor;
                    Console.WriteLine("Elevator1 in Column 3 is currently" + "\"" + columnsList[2].ElevatorsList[0].Status + "\"" + " and located on floor: "
                    + columnsList[2].ElevatorsList[0].CurrentFloor);
                    columnsList[2].ElevatorsList[0].RequestFloor(C1_RequestFloor);
                    Console.WriteLine("Elevator1 in Column 3 is currently" + "\"" + columnsList[2].ElevatorsList[0].Status + "\"" + " and located on floor: "
                    + columnsList[2].ElevatorsList[0].CurrentFloor);

                    //adding things to request list to compare proximity later
                    columnsList[2].ElevatorsList[0].RequestList.Add(C1_CurrentFloor);
                    columnsList[2].ElevatorsList[0].RequestList.Add(C1_RequestFloor);

                    Console.WriteLine("----------------------------------------------------");


                    //SET ELEVATOR 2 STATUS AND FLOOR HERE
                    int C2_CurrentFloor = 23;  //1,21-40 only
                    int C2_RequestFloor = 28; //<==PUT REQUEST FLOOR HERE

                    columnsList[2].ElevatorsList[1].CurrentFloor = C2_CurrentFloor;
                    Console.WriteLine("Elevator2 in Column 3 is currently" + "\"" + columnsList[2].ElevatorsList[1].Status + "\"" + " and located on floor: "
                    + columnsList[2].ElevatorsList[1].CurrentFloor);
                    columnsList[2].ElevatorsList[1].RequestFloor(C2_RequestFloor);
                    Console.WriteLine("Elevator2 in Column 3 is currently" + "\"" + columnsList[2].ElevatorsList[1].Status + "\"" + " and located on floor: "
                    + columnsList[2].ElevatorsList[1].CurrentFloor);

                    //adding things to request list to compare proximity later
                    columnsList[2].ElevatorsList[1].RequestList.Add(C2_CurrentFloor);
                    columnsList[2].ElevatorsList[1].RequestList.Add(C2_RequestFloor);


                    Console.WriteLine("----------------------------------------------------");


                    //SET ELEVATOR 3 STATUS AND FLOOR HERE
                    int C3_CurrentFloor = 33;  //1,21-40 only
                    int C3_RequestFloor = 1; //<==PUT REQUEST FLOOR HERE

                    columnsList[2].ElevatorsList[2].CurrentFloor = C3_CurrentFloor;
                    Console.WriteLine("Elevator3 in Column 3 is currently:" + "\"" + columnsList[2].ElevatorsList[2].Status + "\"" + " and located on floor: "
                    + columnsList[2].ElevatorsList[2].CurrentFloor);
                    columnsList[2].ElevatorsList[2].RequestFloor(C3_RequestFloor);
                    Console.WriteLine("Elevator3 in Column 3 is currently:" + "\"" + columnsList[2].ElevatorsList[2].Status + "\"" + " and located on floor: "
                    + columnsList[2].ElevatorsList[2].CurrentFloor);

                    //adding things to request list to compare proximity later
                    columnsList[2].ElevatorsList[2].RequestList.Add(C3_CurrentFloor);
                    columnsList[2].ElevatorsList[2].RequestList.Add(C3_RequestFloor);


                    Console.WriteLine("----------------------------------------------------");

                    //SET ELEVATOR 4 STATUS AND FLOOR HERE
                    int C4_CurrentFloor = 24;  //1,21-40 only
                    int C4_RequestFloor = 40; //<==PUT REQUEST FLOOR HERE

                    columnsList[2].ElevatorsList[3].CurrentFloor = C4_CurrentFloor;
                    Console.WriteLine("Elevator4 in Column 3 is currently:" + "\"" + columnsList[2].ElevatorsList[3].Status + "\"" + " and located on floor: "
                    + columnsList[2].ElevatorsList[3].CurrentFloor);
                    columnsList[2].ElevatorsList[3].RequestFloor(C4_RequestFloor);
                    Console.WriteLine("Elevator4 in Column 3 is currently:" + "\"" + columnsList[2].ElevatorsList[3].Status + "\"" + " and located on floor: "
                    + columnsList[2].ElevatorsList[3].CurrentFloor);

                    //adding things to request list to compare proximity later
                    columnsList[2].ElevatorsList[3].RequestList.Add(C4_CurrentFloor);
                    columnsList[2].ElevatorsList[3].RequestList.Add(C4_RequestFloor);

                    Console.WriteLine("----------------------------------------------------");


                    //SET ELEVATOR 5 STATUS AND FLOOR HERE
                    int C5_CurrentFloor = 39;  //1,21-40 only
                    int C5_RequestFloor = 1; //<==PUT REQUEST FLOOR HERE

                    columnsList[2].ElevatorsList[4].CurrentFloor = C5_CurrentFloor;
                    Console.WriteLine("Elevator4 in Column 3 is currently:" + "\"" + columnsList[2].ElevatorsList[4].Status + "\"" + " and located on floor: "
                    + columnsList[2].ElevatorsList[4].CurrentFloor);
                    columnsList[2].ElevatorsList[4].RequestFloor(C5_RequestFloor);
                    Console.WriteLine("Elevator4 in Column 3 is currently:" + "\"" + columnsList[2].ElevatorsList[4].Status + "\"" + " and located on floor: "
                    + columnsList[2].ElevatorsList[4].CurrentFloor);

                    //adding things to request list to compare proximity later
                    columnsList[2].ElevatorsList[4].RequestList.Add(C5_CurrentFloor);
                    columnsList[2].ElevatorsList[4].RequestList.Add(C5_RequestFloor);


                    Console.WriteLine("************************************************************");
                    /*##############################################################*/
                    /*#########SET 4th COLUMN FLOORS + ITS ELEVATOR FLOORS##########*/
                    /*##############################################################*/
                    columnsList[3].NumberOfFloors = 20 + 1;

                    Console.WriteLine("The first column has " + columnsList[3].NumberOfFloors + " floors");
                    Console.WriteLine("Setting " + columnsList[3].ElevatorsList.Count + " elevators in column 4.");

                    //SET ELEVATOR 1 STATUS AND FLOOR HERE (COLUMN4)
                    columnsList[3].ElevatorsList[0].Status = "IDLE";     //"IDLE" "MAINTENANCE" "UP" "DOWN"
                    columnsList[3].ElevatorsList[0].CurrentFloor = 1;   //1,40-60 ONLY

                    //SET ELEVATOR 2 STATUS AND FLOOR HERE
                    columnsList[3].ElevatorsList[1].Status = "IDLE";     //"IDLE" "MAINTENANCE" "UP" "DOWN"
                    columnsList[3].ElevatorsList[1].CurrentFloor = 1;   //1,40-60 ONLY

                    //SET ELEVATOR 3 STATUS AND FLOOR HERE
                    columnsList[3].ElevatorsList[2].Status = "IDLE";     //"IDLE" "MAINTENANCE" "UP" "DOWN"
                    columnsList[3].ElevatorsList[2].CurrentFloor = 1;   //1,40-60 ONLY

                    //SET ELEVATOR 4 STATUS AND FLOOR HERE
                    columnsList[3].ElevatorsList[3].Status = "IDLE";     //"IDLE" "MAINTENANCE" "UP" "DOWN"
                    columnsList[3].ElevatorsList[3].CurrentFloor = 1;   //1,40-60 ONLY


                    Console.WriteLine("Elevator1 in Column 4 is current:" + columnsList[3].ElevatorsList[0].Status + " and located on floor: "
                        + columnsList[3].ElevatorsList[0].CurrentFloor);

                    Console.WriteLine("Elevator2 in Column 3 is current:" + columnsList[3].ElevatorsList[1].Status + " and located on floor: "
                        + columnsList[3].ElevatorsList[1].CurrentFloor);

                    Console.WriteLine("Elevator3 in Column 3 is current:" + columnsList[3].ElevatorsList[2].Status + " and located on floor: "
                        + columnsList[3].ElevatorsList[2].CurrentFloor);


                    Console.WriteLine("Elevator4 in Column 3 is current:" + columnsList[3].ElevatorsList[3].Status + " and located on floor: "
                        + columnsList[3].ElevatorsList[3].CurrentFloor + "\n");



                    Console.WriteLine("*************************************************");
                    /*****************************************************************/
                    /*******************PROGRAM STARTS ******************************/
                    /***************************************************************/

                    ShowDate();
                    ShowLobbyPad();


                    //REQUEST FLOOR FROM LOBBY
                    var floorButton = Console.ReadLine();
                    var requestedFloor = floorButton.ToLower();

                    if (requestedFloor == "b1" || requestedFloor == "b2" || requestedFloor == "b3" || requestedFloor == "b4" || requestedFloor == "b5" || requestedFloor == "b6")
                    {
                        Console.WriteLine("\nThank you, please go to column 1");
                        if (requestedFloor == "b1")
                        {
                            int requestedFloorB1 = 0;
                            columnsList[0].RequestElevator(1, requestedFloorB1);
                        }
                        else if (requestedFloor == "b2")
                        {
                            int requestedFloorB2 = -1;
                            columnsList[0].RequestElevator(1, requestedFloorB2);
                        }
                        else if (requestedFloor == "b3")
                        {
                            int requestedFloorB3 = -2;
                            columnsList[0].RequestElevator(1, requestedFloorB3);
                        }
                        else if (requestedFloor == "b4")
                        {
                            int requestedFloorB4 = -3;
                            columnsList[0].RequestElevator(1, requestedFloorB4);
                        }
                        else if (requestedFloor == "b5")
                        {
                            int requestedFloorB5 = -4;
                            columnsList[0].RequestElevator(1, requestedFloorB5);
                        }
                        else if (requestedFloor == "b6")
                        {
                            int requestedFloorB6 = -5;
                            columnsList[0].RequestElevator(1, requestedFloorB6);
                        }
                    }
                    else if (int.Parse(requestedFloor) >= 2 && int.Parse(requestedFloor) <= 20)
                    {
                        int reqFloor = int.Parse(requestedFloor);
                        Console.WriteLine("\nThank you, please go to column 2");
                        columnsList[1].RequestElevator(1, reqFloor);
                    }
                    else if (int.Parse(requestedFloor) >= 21 && int.Parse(requestedFloor) <= 40)
                    {
                        int reqFloor = int.Parse(requestedFloor);
                        Console.WriteLine("\nThank you, please go to column 3");
                        columnsList[2].RequestElevator(1, reqFloor);
                    }
                    else if (int.Parse(requestedFloor) >= 41 && int.Parse(requestedFloor) <= 60)
                    {
                        int reqFloor = int.Parse(requestedFloor);
                        Console.WriteLine("\nThank you, please go to column 4");
                        columnsList[3].RequestElevator(1, reqFloor);
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter floors between B1-B6 or 2-60");
                    }

                    Console.WriteLine("*************************************************");


                    /*********Requesting Elevator from a different floor !=Lobby********/

                    Console.WriteLine("You are now leaving from a floor and is pressing the request button");
                    Console.WriteLine("Which floor are you currently on?");
                    var requestButton = Console.ReadLine();
                    var requestBtn = requestButton.ToLower();

                    //add while loop

                    if (requestBtn == "b1" || requestBtn == "b2" || requestBtn == "b3" || requestBtn == "b4" || requestBtn == "b5" || requestedFloor == "b6")
                    {
                        if (requestedFloor == "b1")
                        {
                            columnsList[0].RequestElevator(0, 1);
                        }
                        else if (requestedFloor == "b2")
                        {
                            columnsList[0].RequestElevator(-1, 1);
                        }
                        else if (requestedFloor == "b3")
                        {
                            columnsList[0].RequestElevator(-2, 1);
                        }
                        else if (requestedFloor == "b4")
                        {
                            columnsList[0].RequestElevator(-3, 1);
                        }
                        else if (requestedFloor == "b5")
                        {
                            columnsList[0].RequestElevator(-4, 1);
                        }
                        else if (requestedFloor == "b6")
                        {
                            columnsList[0].RequestElevator(-5, 1);
                        }
                    }
                    else if (int.Parse(requestedFloor) >= 2 && int.Parse(requestedFloor) <= 20)
                    {
                        int reqButton = int.Parse(requestBtn);
                        columnsList[1].RequestElevator(reqButton, 1);
                    }
                    else if (int.Parse(requestedFloor) >= 21 && int.Parse(requestedFloor) <= 40)
                    {
                        int reqButton = int.Parse(requestBtn);
                        columnsList[2].RequestElevator(reqButton, 1);
                    }
                    else if (int.Parse(requestedFloor) >= 41 && int.Parse(requestedFloor) <= 60)
                    {
                        int reqButton = int.Parse(requestBtn);
                        columnsList[3].RequestElevator(reqButton, 1);
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter floors between B1-B6 or 2-60");
                    }

                }


                private static void ShowDate()
                {
                    DateTime myValue = DateTime.Now;

                    Console.WriteLine("Date: " + myValue.ToLongDateString());
                }
                private static void ShowLobbyPad()
                {
                    Console.WriteLine("Welcome to Rocket Elevator Commercial Building!");
                    Console.WriteLine("Please choose a floor!\n");
                    Console.WriteLine("B1 - B6 \n2 - 20 \n21 - 40 \n41 - 60\n");
                }

            }

}