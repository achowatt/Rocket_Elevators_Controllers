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
    alert("POWER OFF")
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
} else {
    alert("Battery FULL")
}

/*-----------------------------------------------------*/

//make object models
//callButton (for floors)
//elevator
//floor request button (inside elevator)

