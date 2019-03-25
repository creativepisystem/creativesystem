const firebase = require("firebase");
require("firebase/firestore");
var config = {
    apiKey: "AIzaSyD7jpxR6BkaIxhk18E_9Vy6MZVmNJt2KSA",
    authDomain: "creative-external-supply.firebaseapp.com",
    databaseURL: "https://creative-external-supply.firebaseio.com",
    projectId: "creative-external-supply",
    storageBucket: "creative-external-supply.appspot.com",
    messagingSenderId: "455292196906"
  };
  firebase.initializeApp(config);
var db = firebase.firestore()
module.exports = db;