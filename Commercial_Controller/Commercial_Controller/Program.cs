using System;
using System.Collections.Generic;

namespace Commercial_Controller
{
    class Elevator
    {
        private int ID; //elevator array number
        private string Status { get; set; } //'UP','DOWN','MAINTENANCE'; 
        private int CurrentFloor { get; set; } //depends on column
        private List<int> RequestList = new List<int>(); //array



        public Elevator(int id, string Status, int CurrentFloor)
        {
            this.ID = id;
            this.Status = Status;
            this.CurrentFloor = CurrentFloor;
        }

        public void AddToRequestList(int requestFloor)
        {
            this.RequestList.Add(requestFloor);
        }

        public void ShowRequestList()
        {
            Console.WriteLine("Request list:" + this.RequestList);
        }

        public void OpenDoor()
        {
            Console.WriteLine("Door Opens");
        }

        public void CloseDoor()
        {
            Console.WriteLine("Door Closes");
        }

        public void FindDirectionOfElevator() //help to find elevator
        {
            if (this.RequestList[0] > this.CurrentFloor)
            {
                this.Status = "UP";
                Console.WriteLine("The elevator is going UP ");
            }
            else if (this.RequestList[0] < this.CurrentFloor)
            {
                this.Status = "DOWN";
                Console.WriteLine("The elevator is going DOWN ");
            }
            else if (this.Status == "IDLE")
            {
                this.Status = "IDLE";
            }
            else if (this.Status == "MAINTENANCE")
            {
                this.Status = "MAINTENANCE";
            }
        }

        public void MoveElevator(int floor)
        {
            if (this.CurrentFloor < floor)
            {
                while (this.CurrentFloor < floor)
                {
                    Console.WriteLine("The Elevator is moving from" + this.CurrentFloor);
                    this.CurrentFloor++;
                    if (this.CurrentFloor == floor)
                    {
                        //remove the first item from the RequestList
                    }
                }
            }
            else if (this.CurrentFloor > floor)
            {
                while (this.CurrentFloor > floor)
                {
                    Console.WriteLine("The elevator is moving from " + this.CurrentFloor);
                    this.CurrentFloor--;
                    if (this.CurrentFloor == floor)
                    {
                        //remove the first item from the RequestList
                    }
                }
            }
        }
    }

    class Column
    {
        //member variables
        public int ID { get; set; }
        List<Elevator> elevatorsList = new List<Elevator>(); //array
        public int MaxFloor;
        public int MinFloor { get; set; }
        public int SelectedElevatorId { get; set; }

        public Column(int id, int numberOfElevators)
        {
            this.ID = id;
            for (int i = 0; i < numberOfElevators; i++)
            {
                elevatorsList.Add(new Elevator(i, "IDLE", 1));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //array of columns
            List<Column> columnsList = new List<Column>();

            for (int i = 0; i < 4; i++)
            {
                columnsList.Add(new Column(i, 5));
            }

            //SETTING FIRST COLUMN
            columnsList[0].MaxFloor = -5;
            columnsList[0].MinFloor = 0;

            //SETTING SECOND COLUMN
            columnsList[1].MaxFloor = 20;
            columnsList[1].MinFloor = 1;

            //SETTING THIRD COLUMN
            columnsList[2].MaxFloor = 40;
            columnsList[2].MinFloor = 21;

            //SETTING FOURTH COLUMN
            columnsList[3].MaxFloor = 60;
            columnsList[3].MinFloor = 41;





            //set elevators


            Console.WriteLine("Which floor are you heading?");
            var floor = Console.ReadLine();
            var floorNumber = floor.ToLower();

            if (floorNumber == "b1" || floorNumber == "b2" || floorNumber == "b3" || floorNumber == "b4" || floorNumber == "b5" || floorNumber == "b6")
            {
                Console.WriteLine("Thank you, please go to column 1");

                //slice number(to get 1?) -> add -1
                //get column 1
            }
            else if (int.Parse(floorNumber) >= 2 && int.Parse(floorNumber) <= 20)
            {
                Console.WriteLine("Thank you, please go to column 2");
                //get column 2
            }
            else if (int.Parse(floorNumber) >= 21 && int.Parse(floorNumber) <= 40)
            {
                Console.WriteLine("Thank you, please go to column 3");
                //get column 3
            }
            else if (int.Parse(floorNumber) >= 41 && int.Parse(floorNumber) <= 60)
            {
                Console.WriteLine("Thank you, please go to column 4");
                //get column 4
            }
            else
            {
                Console.WriteLine("Please enter floors between B1-B6 or 2-60");
            }


            //this.column ->requestElevator
            //Select Elevator
            //Added to requestList
            //elevator moves to ground floor

            //call button from column ->requestElevator
            //Select Elevator
            //Added to requestList
            //elevator moves


            //requestButton 
            //Added to requestList
            //elevator moves
        }

    }
}