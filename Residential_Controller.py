import random
import math
#TURN ON POWER
init = input("Type 1 to initialize: ")
while init != "1":
    init = input("Press 1 now to initialize: ")

#Once the user initializes
print("POWER ON")

# 50% chance of battery of being "low"
batteryLife = random.random()
batteryLife = batteryLife * 2
batteryLife = math.floor(batteryLife)

if batteryLife == 1:
    print("Low Battery")
    input("Change battery!")
    print("POWER ON")
    print("Battery FULL")
else:
    print("Battery FULL")


#-----------------------------------------------------#
class Elevator:
    def __init__(self, id, numberOfFloor):
        self.id = id
        self.numFloors = numberOfFloor
        self.status = 'IDLE'
        self.currentFloor = 1
        self.requestList = [False for x in range(0, self.numFloors)]

    #methods
    def requestFloor(self, floor):
        self.requestList[floor - 1] = True
        self.moveElevator(floor)

    def openDoor(self):
        print("The door opens!")

    def closeDoor(self):
        input("The door closes!")
        print("\n")

    def moveElevator(self, floor):
        if self.currentFloor < floor:
            self.status = 'UP'
            while self.currentFloor < floor:
                print("The elevator is moving from " + str(self.currentFloor))
                self.currentFloor += 1
                self.requestList[floor - 1] = False
        elif self.currentFloor > floor:
            self.status = 'DOWN'
            while self.currentFloor > floor:
                print("The elevator is moving from " + str(self.currentFloor))
                self.currentFloor -= 1
                self.requestList[floor - 1] = False


class Controller:
    def __init__(self, numberOfElevators, numberOfFloors):
        self.elevators = []
        for i in range(0, numberOfElevators):
            self.elevators.append(Elevator(i, numberOfFloors))


#methods

    def selectElevator(self, direction, floor):
        selectedElevatorId = None

        # step 1: find available elevators = this.elevators
        availableElevators = []
        for i in range(0, len(self.elevators)):
            if self.elevators[i].status != "MAINTENANCE":
                availableElevators.append(self.elevators[i])

    #step 2: choose the closest elevator (if it's moving towards the call button)
    #upElevators
        upElevators = []
        for i in range(0, len(availableElevators)):
            if availableElevators[i].status == "UP" and i.currentFloor <= floor:
                upElevators.append(availableElevators[i])

    #downElevators
        downElevators = []
        for i in range(0, len(availableElevators)):
            if availableElevators[
                    i].status == "DOWN" and i.currentFloor >= floor:
                downElevators.append(availableElevators[i])

        difference = 999
        for i in range(0, len(upElevators)):
            if floor - i.currentFloor < difference:
                difference = floor - i.currentFloor
                selectedElevatorId = i.id

        for i in range(0, len(downElevators)):
            if i.currentFloor - floor < difference:
                difference = floor - i.currentFloor
                selectedElevatorId = i.id

    # step 3: choose the closest idle elevator
    # idleElevators
        idleElevators = []
        for i in range(0, len(availableElevators)):
            if availableElevators[i].status == 'IDLE':
                idleElevators.append(availableElevators[i])

        for i in idleElevators:
            if abs(i.currentFloor - floor) < difference:
                difference = floor - i.currentFloor
                selectedElevatorId = i.id

    # step 4: choose the elevator with last item on requestList that's closest to request floor
    #upElevators_  *not on the way as button*
        upElevators_ = []
        for i in range(0, len(availableElevators)):
            if availableElevators[i].status == 'UP' and i.currentFloor > floor:
                upElevators_.append(availableElevators[i])

    #downElevators_ *not on the way as button*
        downElevators_ = []
        for i in range(0, len(availableElevators)):
            if availableElevators[
                    i].status == 'DOWN' and i.currentFloor < floor:
                downElevators_.append(availableElevators[i])

        for i in range(0, len(upElevators_)):
            for x in range(0, len(i.requestList)):
                if abs((x + 1) - floor) < difference:
                    difference = floor - i.currentFloor
                    selectedElevatorId = i.id

        for i in downElevators_:
            for x in range(0 < len(i.requestList)):
                if abs((x + 1) - floor) < difference:
                    difference = floor - i.currentFloor
                    selectedElevatorId = i.id

        #return selected elevator
        return selectedElevatorId

    def requestElevator(self, direction, floor):
        id = self.selectElevator(direction, floor)
        self.elevators[id].requestFloor(floor)
        self.elevators[id].moveElevator(floor)
        a = id + 1
        print("Elevator", a, "is CHOSEN and is moved to floor", floor, "!")
        print(str(self.elevators[id].__dict__))
        self.elevators[id].openDoor()
        pickFloor = int(input("Which floor are you going to? "))
        # while pickFloor != int:
        # pickFloor = int(input("Please input a number between 1 - 10"))

        while pickFloor > 10:
            pickFloor = int(input("Please input a number between 1 - 10"))

        while pickFloor < 1:
            pickFloor = int(input("Please input a number between 1 - 10"))
        input("Move your feet, the door's about to to close")
        print("\n")
        self.elevators[id].closeDoor()
        self.elevators[id].requestFloor(pickFloor)
        print("Elevator ",a, " is moved to floor",pickFloor,"!")
        print('*********************************************')
        print(str(residentialController.elevators[id].__dict__))
        print('*********************************************')
        print('\n')
        input(
            "You've arrived! But before you leave, let me tell you an elevator joke!"
        )
        print('\n')
        print(
            "An elevator walks into a psychiatrist office and says, hey Doc I think I'm out of control. The Doctor replies your an elevator in your line of work your going to have your ups and downs!"
        )
        print('\n')
        input("Have a good day!")
        print("\n")
        self.elevators[id].openDoor()
        print('\n')
        self.elevators[id].closeDoor()

residentialController = Controller(2, 10)

#STEP 1: MODIFY THE INITIAL STATES OF ELEVATORS HEREꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜ

#elevator1
residentialController.elevators[0].currentFloor = 1
residentialController.elevators[0].status = 'IDLE'

#elevator2
residentialController.elevators[1].status = 'IDLE'
residentialController.elevators[1].currentFloor = 1
#***************************************************************************************

print("****************************************************")
print(residentialController.elevators[0].__dict__)
print("****************************************************")
print(residentialController.elevators[1].__dict__)
print("****************************************************")
print("RESIDENTIAL ELEVATORS ACTIVATED")
print("\n")
name = input("What is your name?")
print('\n')
print("Hello " + name + "! So the story goes like this:")
print(
    "Today, you came over to your friend's place to pick up a charger for your computer. But before leaving, you can't help it but to think about the building's elevator algorithm. Since everyone's been talking about elevators, you are curious to see how these elevators work. You press the button and wait for the door to open. Based on your request and the current state of the elevator, you'll see your answer below!"
)
print('\n')
input("Are you ready?")
print('\n')
print('---after call---')

#STEP 2: REQUEST ELEVATOR HEREꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜ
residentialController.requestElevator('DOWN', 7)  #options are UP or DOWN
#***************************************************************************************
