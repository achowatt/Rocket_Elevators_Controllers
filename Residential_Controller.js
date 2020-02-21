//TURN ON POWER
var init = prompt("Type 1 to initialize: ")
while (init !== "1") {
    init = prompt("Press 1 now to initialize!")
    if (init ==="1") {
    } else {
        init = prompt("Press 1 to continue!")
    }
}

//Once the user initializes
alert("POWER ON")

// 50% chance of battery of being "low"
var batteryLife = Math.random();
batteryLife = batteryLife * 2;
batteryLife = Math.floor(batteryLife);

if (batteryLife === 1) {
    alert("🚨"+ "Low Battery!" + "🚨")
    prompt("Change battery!")
    alert("POWER ON")
    alert("Battery FULL")
    } else {
    alert("Battery FULL")
}

/*-----------------------------------------------------*/

class Elevator {
    constructor(id, numberOfFloors) {
        this.id = id
        this.status = 'IDLE' //'UP','DOWN','MAINTENANCE'; 
        this.currentFloor = 1 //floor 1-10
        this.requestList = Array(numberOfFloors).fill(false) //todo list[array]
    }

    //methods
    requestFloor(floor) {
        if (floor === undefined || !Number.isInteger(floor)) {
            console.error('Error: floor must be a number')
            return
        } else if (floor > this.requestList.length || floor < 1) {
            console.error(`Error: floor ${floor} does not exist`)
            return
        }

        this.requestList[floor - 1] = true
        this.showButtons()
        this.moveElevator(floor)

    }

    showButtons() {
        this.requestList.forEach((status, index) => {
            console.log(`${index + 1}: ${status ? 'LIGHT ON' : 'OFF'}`)
        })
        console.log('\n')
    }

    openDoor() {
      prompt("The door opens!") 
    }

    closeDoor() {
      prompt("The door closes!")
    }

    moveElevator(floor) {
                if (this.currentFloor < floor){
                    this.status = 'UP'
                    while (this.currentFloor < floor) {
                        this.currentFloor++;
                        this.requestList[floor-1] = false;
                    }
                } else if (this.currentFloor > floor) {
                    this.status ='DOWN'
                    while (this.currentFloor > floor) {
                        this.currentFloor--;
                        this.requestList[floor-1] = false;
                    }
                }
    }
    
    
}

var a;
class Controller {
    constructor(numberOfElevators, numberOfFloors) {
        this.elevators = []
        for (let i = 0; i < numberOfElevators; i++) {
            this.elevators.push(new Elevator(i, numberOfFloors))
        }
    }

    //methods 
    requestElevator(direction, floor) {
        const id = this.selectElevator(direction, floor)
        this.elevators[id].requestFloor(floor)
        this.elevators[id].moveElevator(floor)
        a = id + 1
        console.log(`Elevator `+ a +` is CHOSEN and is moved to floor ${floor}!`)
        console.log(this.elevators[id])
        console.log('\n')
        this.elevators[id].openDoor();
        console.log('\n')
        console.log("You walk in.")
        console.log('\n')
        var pickFloor = parseInt(prompt("Which floor are you going to?"))
        this.elevators[id].requestFloor(pickFloor)
        console.log('\n')
        prompt(`Move your feet, the door's about to to close`)
        console.log('\n')
        this.elevators[id].closeDoor();
        console.log('*********************************************')
        console.log(residentialController.elevators[id])
        console.log('*********************************************')
        console.log('\n')
        prompt(`You've arrived! But before you leave, let me tell you an elevator joke! `)
        console.log('\n')
        console.log(`An elevator walks into a psychiatrist office and says, hey Doc I think I'm out of control. The Doctor replies your an elevator in your line of work your going to have your ups and downs!`)
        console.log('\n')
        console.log(`Have a good day!`)
        console.log('\n')
        this.elevators[id].openDoor();
        console.log('\n')
        this.elevators[id].closeDoor();
    }

    selectElevator(direction, floor) {
        let selectedElevatorId = null

        // step 1: find available elevators = this.elevators
        const availableElevators = this.elevators.filter((elevator) => elevator.status !== 'MAINTENANCE')

        // step 2: choose the closest elevator (if it's moving towards the call button)
        //upElevators
        const upElevators = availableElevators.filter(elevator => {
            return elevator.status === 'UP' && elevator.currentFloor <= floor
        })

        //downElevators
        const downElevators = availableElevators.filter(elevator => {
            return elevator.status === 'DOWN' && elevator.currentFloor >= floor
        })

        let difference = 999
        upElevators.forEach(elevator => {
            if (floor - elevator.currentFloor < difference) {
                difference = floor - elevator.currentFloor
                selectedElevatorId = elevator.id 
            }
        })
        
        downElevators.forEach(elevator=>{
            if (elevator.currentFloor - floor < difference) {
                difference = floor - elevator.currentFloor
                selectedElevatorId = elevator.id
            }
        })

        // step 3: choose the closest idle elevator
        //idleElevators
        const idleElevators = availableElevators.filter((elevator) => elevator.status === 'IDLE')
        idleElevators.forEach(elevator=>{
            if (Math.abs(elevator.currentFloor - floor) < difference) {
                difference = floor - elevator.currentFloor
                selectedElevatorId = elevator.id
            }
        })

        // step 4: choose the elevator with last item on requestList that's closest to request floor
        //upElevators_  *not on the way as button*
        const upElevators_ = availableElevators.filter(elevator=>{
            return elevator.status === 'UP' && elevator.currentFloor > floor
        })

        //downElevators_ *not on the way as button*
        const downElevators_ = availableElevators.filter(elevator=>{
            return elevator.status === 'DOWN' && elevator.currentFloor < floor
        })

        var index;
        upElevators_.forEach(elevator=>{
            for (var x = 0; x < elevator.requestList.length; x++)
            {   if (elevator.requestList[x] === true) {
                    index = x;
                }
            
                if (Math.abs((x + 1) - floor) < difference) {
                    difference = floor - elevator.currentFloor
                    selectedElevatorId = elevator.id
                }
            }
            
        })

        downElevators_.forEach(elevator=>{
            for (var x = 0; x < elevator.requestList.length; x++)
            {   if (elevator.requestList[x] === true) {
                    index = x;
                    break;
                }
                if (Math.abs((x + 1) - floor) < difference) {
                    difference = floor - elevator.currentFloor
                    selectedElevatorId = elevator.id
                }
            }
        })

        // return selected elevator
        return selectedElevatorId
    }
}

const residentialController = new Controller(2, 10)

//STEP 1: MODIFY THE INITIAL STATES OF ELEVATORS HEREꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜ
//elevator1
residentialController.elevators[0].currentFloor = 1
residentialController.elevators[0].status = 'IDLE'

//elevator2
residentialController.elevators[1].status = 'IDLE'
residentialController.elevators[1].currentFloor = 1
/***************************************************************************************/

console.log("****************************************************")
console.log(residentialController.elevators[0])
console.log("****************************************************")
console.log(residentialController.elevators[1])
console.log("****************************************************")
console.log("RESIDENTIAL ELEVATORS ACTIVATED")
console.log('\n')
var name = prompt("What is your name?")
console.log('\n')
console.log("Hello "+name+"! So the story goes like this:")
console.log("Today, you came over to your friend's place to pick up a charger for your computer. But before leaving, you can't help it but to think about the building's elevator algorithm. Since everyone's been talking about elevators, you are curious to see how these elevators work. You press the button and wait for the door to open. Based on your request and the current state of the elevator, you'll see your answer below!")
console.log('\n')
prompt("Are you ready?")
console.log('\n')
console.log('---after call---')

//STEP 2: REQUEST ELEVATOR HEREꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜꜜ
residentialController.requestElevator('DOWN', 7) //options are UP or DOWN
/***************************************************************************************/

