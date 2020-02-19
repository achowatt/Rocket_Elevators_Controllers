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

if (batteryLife === 0) {
    alert("*RED FLASHING LIGHT* Low Battery!")
    var changeBattery = window.confirm("Do you want to change battery?")
    if (changeBattery) {
        alert("Battery CHANGED!")
    } else {
    alert("Battery CHANGED!")
    init = prompt("Type 1 to initialize: ")
    while (init !== "1") {
        init = prompt("Press 1 now to initialize!")
        if (init ==="1") {
        } else {
        init = prompt("Press 1 to continue!")
        }
    }
        alert("POWER ON")
        alert("Battery FULL")
    }

} else {
    alert("Battery FULL")
}

/*-----------------------------------------------------*/
//ELEVATOR CONSTRUCTOR function
    function Elevator (ID,status,available,currentFloor,list,boolean) {
        this.ID = ID;
        this.status = status;
        this.available = available;
        this.currentFloor = currentFloor;
        this.requestList = list;
        this.on_the_way = boolean;
    }

//TWO ELEVATORS in the building
    var elevator1 = new Elevator (1,"idle",true,1,[],true);
    var elevator2 = new Elevator (1,"idle",true,1,[],true);

    
//CALL BUTTONS for floors
    function callButton(direction,floor) {
        direction;
        floor;
        find_elevator();
    }


//SORT FLOOR REQUEST
function sortElevator1RequestUP(x) {
    elevator1.push(x);
    elevator1.sort();
}
 function sortElevator1RequestDOWN(x) {
    elevator1.push(x);
    elevator1.sort();
    elevator1.reverse();
}

function sortElevator2RequestUP(x) {
    elevator2.push(x);
    elevator2.sort();
}
 function sortElevator2RequestDOWN(x) {
    elevator2.push(x);
    elevator2.sort();
    elevator2.reverse();
}

//FLOOR REQUEST button
    function floorRequest(x) {
        elevator1.requestList.push(x);
        elevator1.requestList.sort();
    }


//on_the_way
function on_the_way_up(elevatorFloor,callButtonFloor){
    if (elevatorFloor < callButtonFloor) {
        return true
    }
    else {
        return false
    }
}

function on_the_way_down(elevatorFloor,callButtonFloor){
    if (elevatorFloor > callButtonFloor) {
        return true
    }
    else {
        return false
    }
}
/*********FIND ELEVATOR ***********/
    function find_elevator(){
        let d = callButton.direction;
        let f = callButton.floor;

        if (elevator1.available == true && elevator2.available == true) {
            let elevatorProximity1 = elevator1.currentFloor - f;
            let elevatorProximity2 = elevator2.currentFloor - f;

            if(elevator1.status == idle && elevator2.status == idle) {
                if (elevatorProximity1 <= elevatorProximity2) {
                    if (d.toUpperCase == 'UP') {
                        sortElevator1RequestUP(f);
                    }
                    else {
                        sortElevator1RequestDOWN(f);
                    }
                }
                else if (elevatorProximity1 > elevatorProximity2) {
                    if (d.toUpperCase == 'UP') {
                        sortElevator2RequestUP(f);
                    }
                    else {
                        sortElevator2RequestDOWN(f);
                    }
                }
            }
            else {
               let current_direction_of_elevator1 = elevator1.requestList[0] - elevator1.currentFloor
               let current_direction_of_elevator2 = elevator2.requestList[0] - elevator2.currentFloor
                if(Math.sign(current_direction_of_elevator1) == 1 && callButton.direction == 'UP') {
                    elevator1.on_the_way = on_the_way_up(elevator1.currentFloor,f);
                    
                }
                else if (Math.sign(current_direction_of_elevator1) == -1 && callButton.direction !== 'UP') {
                    elevator1.on_the_way = on_the_way_down(elevator2.currentFloor,f)

                }
                else if (Math.sign(current_direction_of_elevator1) == -1 && callButton.direction == 'UP'){
                    elevator1.on_the_way = false

                }
                else if (Math.sign(current_direction_of_elevator1) == 1 && callButton.direction !== 'UP'){
                    elevator1.on_the_way = false

                }
                else if(Math.sign(current_direction_of_elevator2) == 1 && callButton.direction == 'UP') {
                    elevator2.on_the_way = on_the_way_up(elevator2.currentFloor,f)
                }
                else if (Math.sign(current_direction_of_elevator2) == -1 && callButton.direction !== 'UP') {
                    elevator2.on_the_way = on_the_way_down(elevator2.currentFloor,f)
                }
                else if (Math.sign(current_direction_of_elevator2) == -1 && callButton.direction == 'UP'){
                    elevator2.on_the_way = false

                }
                else if (Math.sign(current_direction_of_elevator2) == 1 && callButton.direction !== 'UP'){
                    elevator2.on_the_way = false

                }
                else if (Math.sign(current_direction_of_elevator1) == 0){
                    elevator1.on_the_way = true

                }
                else if (Math.sign(current_direction_of_elevator2) == 0){
                    elevator2.on_the_way = true

                } 
                //FIND MOST CONVENIENT ELEVATOR, GET ID AND ADD CALL BUTTON TO ITS WAITLIST
                if (elevator1.on_the_way == true && elevator2.on_the_way == true){
                    if (elevatorProximity1 <= elevatorProximity2){
                        ADD to
                    }
                    else {
                        
                    }
                }
            
            }

        }
        else if (elevator1.available == true && elevator2.available !== true) {

        }
        else if (elevator1.available !== true && elevator2.available == true) {

        }


    }


