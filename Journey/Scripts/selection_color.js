let radioButtons = document.querySelectorAll('.js-button');
let selected = radioButtons[0];

var checkButtons = function () {
    for (let j = 0; j < radioButtons.length; j++) {
        if (radioButtons[j].checked == true) {
            label = radioButtons[j].parentElement.parentElement;
            label.style.backgroundColor = "rgb(104, 212, 108)";
        }
        else {
            label = radioButtons[j].parentElement.parentElement;
            label.style.backgroundColor = "white";
        }
    }
}

for(let i = 0; i < radioButtons.length; i++) {
    radioButtons[i].onclick = checkButtons;
}

checkButtons();