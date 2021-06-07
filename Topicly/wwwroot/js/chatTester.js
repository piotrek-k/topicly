"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .configureLogging(signalR.LogLevel.Debug)
    .build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("sendMessage", function (userId, userName, message, chatId, dateOfSending) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = userName + " ("+ userId + ") says " + msg + " to chat " + chatId + " at time " + dateOfSending;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
})
// .catch(err => {
//     console.error(err)
//     var li = document.createElement("li");
//     li.textContent = "error from server: " + err;
//     document.getElementById("messagesList").appendChild(li);
// });

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    // let user = document.getElementById("userInput").value;
    let message = document.getElementById("messageInput").value;
    let chatId = parseInt(document.getElementById("chatIdInput").value);
    connection.invoke("SendMessage", message, chatId).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
