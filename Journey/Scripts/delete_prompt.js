let deletionPrompt = document.querySelector('#deletion-prompt');
let warningMessage = document.querySelector('.warning-message');
let inputId = document.querySelector('#input-id')

function deleteHabit(id) {
    inputId.value = id;
    warningMessage.innerHTML = "Delete habit?";
    deletionPrompt.style.display = "block";
}