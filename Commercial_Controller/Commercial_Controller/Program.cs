using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Commercial_Controller
{
    class Elevator
    {
        public int ID; //elevator array number
        public string Status { get; set; } //'UP','DOWN','MAINTENANCE'; 
        public int CurrentFloor { get; set; } //depends on column
        public List<int> RequestList = new List<int>(); //array
        public int NumberOfFloors;
        public int Proximity;
        public bool GoodChoice;

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
            Console.WriteLine("The door will close in 3 seconds");
            for (int i = 3; i > 0; i--)

            {
                Thread.Sleep(1000);
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine("Door Closes");
            
        }

        public void RequestFloor(int floor)
        {
            this.SortRequestList();
            this.MoveElevator(floor);
        }


        public void MoveElevator(int floor)
        {
            if (this.RequestList.Count() !=0)
            { 
                if (this.CurrentFloor < this.RequestList[0])
                {
                    while ( (this.CurrentFloor < this.RequestList[0]) && (this.RequestList.Count() != 0) )
                        {   //CONVERTING NUMBERS TO READABLE FLOOR NUMBERS
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
                        this.Status = "UP";
                        this.CurrentFloor++;


                        if (this.CurrentFloor == this.RequestList[0])
                        {
                            this.RequestList.RemoveAt(0); //REMOVE FIRST ITEM IN REQUESTLIST

                            //CONVERTING NUMBERS TO READABLE FLOOR NUMBERS
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
                            OpenDoor();
                            CloseDoor();
                        }
                 
                    }
                }
                else if (this.CurrentFloor > this.RequestList[0])
                {
                        while (this.RequestList.Count > 0)
                        {

                            if (this.CurrentFloor > this.RequestList[0])
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

                                if (this.CurrentFloor == this.RequestList[0])
                                {
                                    this.RequestList.RemoveAt(0); //REMOVE FIRST ITEM IN REQUESTLIST

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
                                    this.OpenDoor();
                                    this.CloseDoor();
                                }
                            }
                        }
                }
            }
            

            if (this.RequestList.Count > 0)
            {
                this.RequestFloor(this.RequestList[0]);
            }
        }

        public void ChangeStatus() //based on the requestList
        {
            if(this.RequestList.Count() != 0)
            {
                if (this.RequestList[0] > this.CurrentFloor)
                {
                    this.Status = "UP";
                }
                else if (this.RequestList[0] < this.CurrentFloor)
                {
                    this.Status = "DOWN";
                }
            }
        }

        public void SortRequestList()
        {

            if (this.RequestList[0] > this.CurrentFloor)
            {
                //sortList
                this.RequestList.Sort();
            }

            if (this.RequestList[0] < this.CurrentFloor)
            {
                //sortList
                this.RequestList.Sort();
                //Reversing the sorted List (descending order)
                this.RequestList.Reverse();
            }
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




        public void RequestElevator(int floor, int requestedFloor)
        {
            //select elevator
            int arrayNumber = this.SelectElevator(floor, requestedFloor);
            int a = arrayNumber + 1;
            this.ElevatorsList[arrayNumber].RequestList.Add(floor);
            this.ElevatorsList[arrayNumber].RequestList.Add(requestedFloor);
            this.ElevatorsList[arrayNumber].SortRequestList();

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
            this.ElevatorsList[arrayNumber].RequestFloor(requestedFloor);
        }


        public int SelectElevator(int floor, int requestedFloor)
        {
            int selectedElevatorId = 0;
            string direction = "direction";

            if (requestedFloor < floor)
            {
                direction = "DOWN";
            }
            else if (requestedFloor > floor)
            {
                direction = "UP";
            }



            // step 1: GET ALL AVAILABLE ELEVATORS
            List<Elevator> availableElevators = this.ElevatorsList.FindAll(e => e.Status != "MAINTENANCE");
            // step 2: GROUP ALL IDLE ELEVATORS
            List<Elevator> idleElevators = availableElevators.FindAll(c => c.Status == "IDLE");
            // step 3: GROUP ALL MOVING ELEVATORS
            List<Elevator> movingElevators = availableElevators.FindAll(c => c.Status != "IDLE");

            foreach (Elevator j in movingElevators) //FINDING IF ITS ON THE WAY
            {
                if(j.CurrentFloor == floor)
                { 
                    j.GoodChoice = true;
                }
                else if (j.RequestList[0] == floor)
                {
                    j.GoodChoice = true;
                }
                else if ((j.Status == "DOWN") && (j.CurrentFloor >= floor) && (direction == "DOWN"))
                {
                    j.GoodChoice = true;
                }
                else if ((j.Status == "UP") && (j.CurrentFloor <= floor))
                {
                    j.GoodChoice = true;
                }
                else
                {
                    j.GoodChoice = false;
                }

            }

            // step 4: GROUP GOOD CHOICE ELEVATORS
            List<Elevator> goodElevators = availableElevators.FindAll(o => o.GoodChoice == true);
            // step 5: GROUP LAST CHOICE ELEVATORS (NOT ON THE WAY
            List<Elevator> badElevators = availableElevators.FindAll(w => w.GoodChoice != true);

            // step 6: CALCULATE PROXIMITY
            foreach (Elevator j in idleElevators)
            {
                int prox = Math.Abs(j.CurrentFloor - floor);
                j.Proximity = prox;
            }


            foreach (Elevator l in goodElevators)
            {
                int prox = Math.Abs(l.CurrentFloor - floor);
                l.Proximity = prox;
            }

            foreach (Elevator r in badElevators)
            {
                if (r.RequestList.Count != 0)
                {
                    int prox = Math.Abs(r.CurrentFloor - r.RequestList[0]) + Math.Abs(floor - r.RequestList[0]);
                    r.Proximity = prox;
                }
            }

            // step 7: FIND THE ELEVATOR (PRIORITIZE MOVING ELEVATOR

            var difference = 999;

            if (goodElevators.Count > 0)
            {
                foreach (Elevator l in goodElevators)
                {
                    if (l.CurrentFloor == floor)
                    {
                        difference = l.Proximity;
                        selectedElevatorId = l.ID;
                        break;
                    }
                    else if (l.RequestList[0] == floor)
                    {
                        difference = l.Proximity;
                        selectedElevatorId = l.ID;
                        break;
                    }

                    else if (l.Proximity < difference)
                    {
                        difference = l.Proximity;
                        selectedElevatorId = l.ID;
                        break;
                    }
                }
            }
            else if (idleElevators.Count > 0)
            {
                foreach (Elevator j in idleElevators)
                {
                    if (j.CurrentFloor == floor)
                    {
                        selectedElevatorId = j.ID;
                        break;
                    }
                    else if (j.Proximity < difference)
                    {
                        difference = j.Proximity;
                        selectedElevatorId = j.ID;
                        break;
                    }
                }
            }
            else
            {
                foreach (Elevator r in badElevators)
                {
                    if (r.Proximity < difference)
                    {
                        difference = r.Proximity;
                        selectedElevatorId = r.ID;
                        break;
                    }
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

            columnsList[0].NumberOfFloors= 7;
            columnsList[1].NumberOfFloors = 21;
            columnsList[2].NumberOfFloors = 21;
            columnsList[3].NumberOfFloors = 21;

            /*****************************************************************/
            /*******************PROGRAM STARTS ******************************/
            /***************************************************************/

            Console.WriteLine("***********************************************************");
            Console.WriteLine("***********************SCENARIO ONE************************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("The second column has " + columnsList[1].NumberOfFloors + " floors, ranging from 1-20");
            Console.WriteLine("Setting " + columnsList[1].ElevatorsList.Count + " elevators in column 2." + "\n");
            
            /*****************************************************************/
            //SETTING CURRENT FLOOR AND REQUESTED FLOOR  COLUMN B / COLUMN 2


            //ELEVATOR 1
            columnsList[1].ElevatorsList[0].CurrentFloor = 20; //<==1-20 only
            columnsList[1].ElevatorsList[0].RequestList.Add(5);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[1].ElevatorsList[0].ChangeStatus();

            Console.WriteLine("***COLUMN 2 INFO***");
            Console.WriteLine("Elevator 1 is on floor :" + columnsList[1].ElevatorsList[0].CurrentFloor);

            Console.WriteLine("Elevator 1 request list");
            if (columnsList[1].ElevatorsList[0].RequestList.Count() != 0)
            {
                columnsList[1].ElevatorsList[0].RequestList.ForEach(Console.WriteLine);
            }
           
            Console.WriteLine("It's status is currently: " + columnsList[1].ElevatorsList[0].Status + "\n");
       



            //ELEVATOR 2
            columnsList[1].ElevatorsList[1].CurrentFloor = 3; //<==1-20 only
            columnsList[1].ElevatorsList[1].RequestList.Add(15);//<==PUT REQUEST FLOOR HERE
            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[1].ElevatorsList[1].ChangeStatus();

            Console.WriteLine("Elevator 2 is on floor :" + columnsList[1].ElevatorsList[1].CurrentFloor);
            Console.WriteLine("Elevator 2 request list");
            if (columnsList[1].ElevatorsList[1].RequestList.Count() != 0)
            {
                columnsList[1].ElevatorsList[1].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[1].ElevatorsList[1].Status + "\n");
 




            //ELEVATOR 3
            columnsList[1].ElevatorsList[2].CurrentFloor = 13; //<==1-20 only
            columnsList[1].ElevatorsList[2].RequestList.Add(1);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[1].ElevatorsList[2].ChangeStatus();

            Console.WriteLine("Elevator 3 is on floor :" + columnsList[1].ElevatorsList[2].CurrentFloor);
            Console.WriteLine("Elevator 3 request list");
            if (columnsList[1].ElevatorsList[2].RequestList.Count() != 0)
            {
                columnsList[1].ElevatorsList[2].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[1].ElevatorsList[2].Status + "\n");




            //ELEVATOR 4
            columnsList[1].ElevatorsList[3].CurrentFloor = 15; //<==1-20 only
            columnsList[1].ElevatorsList[3].RequestList.Add(2);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[1].ElevatorsList[3].ChangeStatus();


            Console.WriteLine("Elevator 4 is on floor :" + columnsList[1].ElevatorsList[3].CurrentFloor);
            Console.WriteLine("Elevator 4 request list");
            if (columnsList[1].ElevatorsList[3].RequestList.Count() != 0)
            {
                columnsList[1].ElevatorsList[3].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[1].ElevatorsList[3].Status + "\n");



            //ELEVATOR 5
            columnsList[1].ElevatorsList[4].CurrentFloor = 6; //<==1-20 only
            columnsList[1].ElevatorsList[4].RequestList.Add(1);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[1].ElevatorsList[4].ChangeStatus();


            Console.WriteLine("Elevator 5 is on floor :" + columnsList[1].ElevatorsList[4].CurrentFloor);
            Console.WriteLine("Elevator 5 request list");
            if (columnsList[1].ElevatorsList[4].RequestList.Count() != 0)
            {
                columnsList[1].ElevatorsList[4].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[1].ElevatorsList[4].Status + "\n");



            /*****************************************************************/


            Console.WriteLine("***********************************************************");
            Console.WriteLine("***********************SCENARIO TWO************************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("The third column has " + columnsList[2].NumberOfFloors + " floors, ranging from 1,21-40");
            Console.WriteLine("Setting " + columnsList[2].ElevatorsList.Count + " elevators in column 3." + "\n");

            /*****************************************************************/
            //SETTING CURRENT FLOOR AND REQUESTED FLOOR  COLUMN C / COLUMN 3

            Console.WriteLine("***INFO ON COLUMN 3***");


            //ELEVATOR 1
            columnsList[2].ElevatorsList[0].CurrentFloor = 1; //1,21-40 only
            columnsList[2].ElevatorsList[0].RequestList.Add(21);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[2].ElevatorsList[0].ChangeStatus();

            Console.WriteLine("Elevator 1 is on floor :" + columnsList[2].ElevatorsList[0].CurrentFloor);
            Console.WriteLine("Elevator 1 request list");
            if (columnsList[2].ElevatorsList[0].RequestList.Count() != 0)
            {
                columnsList[2].ElevatorsList[0].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[2].ElevatorsList[0].Status + "\n");


            //ELEVATOR 2
            columnsList[2].ElevatorsList[1].CurrentFloor = 23; //1,21-40 only
            columnsList[2].ElevatorsList[1].RequestList.Add(28);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[2].ElevatorsList[1].ChangeStatus();

            Console.WriteLine("Elevator 2 is on floor :" + columnsList[2].ElevatorsList[1].CurrentFloor);
            Console.WriteLine("Elevator 2 request list");
            if (columnsList[2].ElevatorsList[1].RequestList.Count() != 0)
            {
                columnsList[2].ElevatorsList[1].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[2].ElevatorsList[1].Status + "\n");




            //ELEVATOR 3
            columnsList[2].ElevatorsList[2].CurrentFloor = 33; //1,21-40 only
            columnsList[2].ElevatorsList[2].RequestList.Add(1);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[2].ElevatorsList[2].ChangeStatus();

            Console.WriteLine("Elevator 3 is on floor :" + columnsList[2].ElevatorsList[2].CurrentFloor);
            Console.WriteLine("Elevator 3 request list");
            if (columnsList[2].ElevatorsList[2].RequestList.Count() != 0)
            {
                columnsList[2].ElevatorsList[2].RequestList.ForEach(Console.WriteLine);
            }


            Console.WriteLine("It's status is currently: " + columnsList[2].ElevatorsList[2].Status + "\n");




            //ELEVATOR 4
            columnsList[2].ElevatorsList[3].CurrentFloor = 40; //1,21-40 only
            columnsList[2].ElevatorsList[3].RequestList.Add(24);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[2].ElevatorsList[3].ChangeStatus();

            Console.WriteLine("Elevator 4 is on floor :" + columnsList[2].ElevatorsList[3].CurrentFloor);
            Console.WriteLine("Elevator 4 request list");
            if (columnsList[2].ElevatorsList[3].RequestList.Count() != 0)
            {
                columnsList[2].ElevatorsList[3].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[2].ElevatorsList[3].Status + "\n");






            //ELEVATOR 5
            columnsList[2].ElevatorsList[4].CurrentFloor = 39; //1,21-40 only
            columnsList[2].ElevatorsList[4].RequestList.Add(1);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[2].ElevatorsList[4].ChangeStatus();

            Console.WriteLine("Elevator 5 is on floor :" + columnsList[2].ElevatorsList[4].CurrentFloor);
            Console.WriteLine("Elevator 5 request list");
            if (columnsList[2].ElevatorsList[4].RequestList.Count() != 0)
            {
                columnsList[2].ElevatorsList[4].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[2].ElevatorsList[4].Status + "\n");




            /*****************************************************************/




            Console.WriteLine("***********************************************************");
            Console.WriteLine("***********************SCENARIO THREE**********************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("The fourth column has " + columnsList[3].NumberOfFloors + " floors, ranging from 1,41-60");
            Console.WriteLine("Setting " + columnsList[3].ElevatorsList.Count + " elevators in column 4.");
    
            /**************************UNCOMMENT HERE****************************/
            //SETTING CURRENT FLOOR AND REQUESTED FLOOR  COLUMN D / COLUMN 4
            //ELEVATOR 1
            columnsList[3].ElevatorsList[0].CurrentFloor = 58; //1, 41-60 only
            columnsList[3].ElevatorsList[0].RequestList.Add(1);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[3].ElevatorsList[0].ChangeStatus();

            Console.WriteLine("***INFO ON COLUMN 4***");
            Console.WriteLine("Elevator 1 is on floor :" + columnsList[2].ElevatorsList[0].CurrentFloor);
            Console.WriteLine("Elevator 1 request list");
            if (columnsList[2].ElevatorsList[0].RequestList.Count() != 0)
            {
                columnsList[2].ElevatorsList[0].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[2].ElevatorsList[0].Status + "\n");



            //ELEVATOR 2
            columnsList[3].ElevatorsList[1].CurrentFloor = 50; //1, 41-60 only
            columnsList[3].ElevatorsList[1].RequestList.Add(60);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[3].ElevatorsList[1].ChangeStatus();

            Console.WriteLine("Elevator 2 is on floor :" + columnsList[2].ElevatorsList[1].CurrentFloor);
            Console.WriteLine("Elevator 2 request list");
            if (columnsList[2].ElevatorsList[1].RequestList.Count() != 0)
            {
                columnsList[2].ElevatorsList[1].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[2].ElevatorsList[1].Status + "\n");




            //ELEVATOR 3
            columnsList[3].ElevatorsList[2].CurrentFloor = 46; // 1, 41 - 60 only
            columnsList[3].ElevatorsList[2].RequestList.Add(58);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[3].ElevatorsList[2].ChangeStatus();

            Console.WriteLine("Elevator 3 is on floor :" + columnsList[2].ElevatorsList[2].CurrentFloor);
            Console.WriteLine("Elevator 3 request list");
            if (columnsList[2].ElevatorsList[2].RequestList.Count() != 0)
            {
                columnsList[2].ElevatorsList[2].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[2].ElevatorsList[2].Status + "\n");




            //ELEVATOR 4
            columnsList[3].ElevatorsList[3].CurrentFloor = 1; //1, 41-60 only
            columnsList[3].ElevatorsList[3].RequestList.Add(54);//<==PUT REQUEST FLOOR HERE


            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[3].ElevatorsList[4].ChangeStatus();

            Console.WriteLine("Elevator 4 is on floor :" + columnsList[2].ElevatorsList[3].CurrentFloor);
            Console.WriteLine("Elevator 4 request list");
            if (columnsList[2].ElevatorsList[3].RequestList.Count() != 0)
            {
                columnsList[2].ElevatorsList[3].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[2].ElevatorsList[3].Status + "\n");




            //ELEVATOR 5
            columnsList[3].ElevatorsList[4].CurrentFloor = 60; //1, 41-60 only
            columnsList[3].ElevatorsList[4].RequestList.Add(1);//<==PUT REQUEST FLOOR HERE

            /**CHANGE STATUS BASED ON REQUEST LIST(UP OR DOWN OR IDLE)**/
            columnsList[3].ElevatorsList[4].ChangeStatus();

            Console.WriteLine("Elevator 5 is on floor :" + columnsList[2].ElevatorsList[4].CurrentFloor);
            Console.WriteLine("Elevator 5 request list");
            if (columnsList[2].ElevatorsList[4].RequestList.Count() != 0)
            {
                columnsList[2].ElevatorsList[4].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[2].ElevatorsList[4].Status + "\n");

   
            /*****************************************************************/



            Console.WriteLine("***********************************************************");
            Console.WriteLine("***********************SCENARIO FOUR***********************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("The first column has " + columnsList[0].NumberOfFloors + " floors, ranging from 1,B1-B6");
            Console.WriteLine("Setting " + columnsList[0].ElevatorsList.Count + " elevators in column 1.");

            /*****************************************************************/
            //SETTING CURRENT FLOOR AND REQUESTED FLOOR  COLUMN A / COLUMN 1

   
            //ELEVATOR 1
            columnsList[0].ElevatorsList[0].CurrentFloor = -3; //1,  0 = B1, -1 = B2, -2 = B3, -3 = B4, -4 =B5, -5 = B6
            //columnsList[0].ElevatorsList[0].RequestList.Add(-);//<==DON't UNCOME IF ITS IDLE
            
            Console.WriteLine("***COLUMN 1 INFO***");
            Console.WriteLine("Elevator 1 is on floor :" + columnsList[0].ElevatorsList[0].CurrentFloor);
            Console.WriteLine("Elevator 1 request list");
            if (columnsList[0].ElevatorsList[0].RequestList.Count() != 0)
            {
                columnsList[0].ElevatorsList[0].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[0].ElevatorsList[0].Status + "\n");


            //ELEVATOR 2
            columnsList[0].ElevatorsList[1].CurrentFloor = 1; //1 (0,-1,-2,-3,-4,-5) 0 = B1, -1 = B2, etc
                                                              //columnsList[0].ElevatorsList[1].RequestList.Add(-);//<==PUT REQUEST FLOOR HERE

            Console.WriteLine("Elevator 2 is on floor :" + columnsList[0].ElevatorsList[1].CurrentFloor);
            Console.WriteLine("Elevator 2 request list");
            if (columnsList[0].ElevatorsList[1].RequestList.Count() != 1)
            {
                columnsList[0].ElevatorsList[1].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[0].ElevatorsList[1].Status + "\n");


            //ELEVATOR 3
            columnsList[0].ElevatorsList[2].CurrentFloor = -2; //1 (0,-1,-2,-3,-4,-5) 0 = B1, -1 = B2, etc
            columnsList[0].ElevatorsList[2].RequestList.Add(-4);//<==PUT REQUEST FLOOR HERE

            Console.WriteLine("Elevator 3 is on floor :" + columnsList[0].ElevatorsList[2].CurrentFloor);
            Console.WriteLine("Elevator 3 request list");
            if (columnsList[0].ElevatorsList[2].RequestList.Count() != 1)
            {
                columnsList[0].ElevatorsList[2].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[0].ElevatorsList[2].Status + "\n");


            //ELEVATOR 4
            columnsList[0].ElevatorsList[3].CurrentFloor = -5; //1 (0,-1,-2,-3,-4,-5) 0 = B1, -1 = B2, etc
            columnsList[0].ElevatorsList[3].RequestList.Add(1);//<==PUT REQUEST FLOOR HERE

            Console.WriteLine("Elevator 4 is on floor :" + columnsList[0].ElevatorsList[3].CurrentFloor);
            Console.WriteLine("Elevator 4 request list");
            if (columnsList[0].ElevatorsList[3].RequestList.Count() != 1)
            {
                columnsList[0].ElevatorsList[3].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[0].ElevatorsList[3].Status + "\n");


            //ELEVATOR 5
            columnsList[0].ElevatorsList[4].CurrentFloor = 0; //1 (0,-1,-2,-3,-4,-5) 0 = B1, -1 = B2, etc
            columnsList[0].ElevatorsList[4].RequestList.Add(-5);//<==PUT REQUEST FLOOR HERE

            Console.WriteLine("Elevator 5 is on floor :" + columnsList[0].ElevatorsList[4].CurrentFloor);
            Console.WriteLine("Elevator 5 request list");
            if (columnsList[0].ElevatorsList[4].RequestList.Count() != 1)
            {
                columnsList[0].ElevatorsList[4].RequestList.ForEach(Console.WriteLine);
            }
            Console.WriteLine("It's status is currently: " + columnsList[0].ElevatorsList[4].Status + "\n");



         
            Console.WriteLine("***********************************************************");

            ShowDate();
            Console.WriteLine("Welcome to Rocket Elevator Commercial Building!");
            Console.WriteLine("Please choose a floor you are on!\n");
            Console.WriteLine("B1 - B6 \n1 - 20 \n21 - 40 \n41 - 60\n");

            //REQUEST FLOOR (SCENERIO 1) (floor you're on,floor you're going to)
            //columnsList[1].RequestElevator(1, 20);

            //REQUEST FLOOR (SCENERIO 2)
            //columnsList[2].RequestElevator(1, 36);

            //REQUEST FLOOR (SCENERIO 3)
            //columnsList[3].RequestElevator(54, 1);

            //REQUEST FLOOR (SCENERIO 4)
            columnsList[0].RequestElevator(-2, 1); //(B1,1)
        }

        private static void ShowDate()
        {
            DateTime myValue = DateTime.Now;

            Console.WriteLine("Date: " + myValue.ToLongDateString());
        }


    }

}