var interval = 1000;

var limit = 0;

var canvas, ctx, size, startAngle, wedgeSize, fillClr, elapsed, intervalId, timerElement;

var mm = 0, ss = 0;

var mInput, sInput, overlay;

var hpts = 0, apts = 0;


$(document).ready(function () {

    timeOut = document.getElementById("timeout");

    timerElement = document.getElementById('elapsedTime');

    mInput = document.getElementById('minutes');

    sInput = document.getElementById('seconds');

    overlay = document.getElementById('timesUp');
    initClock();

});

function validate(evt) {

    var theEvent = evt || window.event;

    var key = theEvent.keyCode || theEvent.which;

    key = String.fromCharCode(key);

    var regex = /[0-9]|\./;

    if (!regex.test(key)) {

        theEvent.returnValue = false;

        if (theEvent.preventDefault) theEvent.preventDefault();

    }
}

function initClock() {
    console.log("initClock");
    timerElement.value = "00:00";

    elapsed = 0;
}

function startClock() {
    console.log("startClock()");

    mm = mInput.value;
    ss = sInput.value;
    
    limit *= 1000;

    timerElement.value = (mm + ":" + ss);

    intervalId = setInterval(function () {

        elapsed = elapsed + interval;

        updateTime();

    }, interval);

}

function updateTime() {

    var s, m;

    ss -= 1;

    s = ss < 10 ? '0' + ss : ss;

    if (ss < 0) {

        ss = 59;

        s = '59';

        mm -= 1;

    }

    m = mm < 10 ? '0' + mm : mm;

    timerElement.value = m + ':' + s;

    if (mm == 0 && ss == 0) {

        clearInterval(intervalId);

        finish();

    }
}

function finish() {
    document.getElementById("message").innerHTML = "Game Over";
}

function pauseClock() {

    clearInterval(intervalId);
    mInput.value = mm;
    sInput.value = ss;

}

function resetClock() {

    pauseClock();

    elapsed = mm = ss = 0;

    initClock();

}

function homeup() {
    hpts += 1;
    document.getElementById("homePoints").innerHTML = hpts;
}

function homedown() {
    hpts -= 1;
    document.getElementById("homePoints").innerHTML = hpts;

}

function awayup() {
    apts += 1;
    document.getElementById("awayPoints").innerHTML = apts;

}

function awaydown() {
    apts -= 1;
    document.getElementById("awayPoints").innerHTML = apts;

}
/*
function initTimeout() {
   
    console.log("initClock");
    timeOut.innerHTML = ":59";

    elapsed = 0;
   
}
    timeOut.innerHTML = ":59";
    var t = 59;
    
} */