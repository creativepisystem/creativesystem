/********************************************
 * Trabalho do 2 Semestre de ADS 2019
 * 
 * @CreativeApi
 * 
 * Grupo :
 *  Leonardo Ferreira Lima
 *  Eliel
 *  Felipe Goulart
 * ******************************************/
const functions = require('firebase-functions');
const express = require('express');
//Importações dos Módulos
const UserApp = require('./src/Controller/UserController')
const VehicleApp = require('./src/Controller/VehicleController')
const DriverApp = require('./src/Controller/DriverController')
const RouteApp = require('./src/Controller/RouteController')
const SupplyApp = require('./src/Controller/SupplyController')
const TravelApp = require('./src/Controller/TravelController')
const DeviceApp = require('./src/Controller/DeviceController')
//Criação do server da aplicação
const app  = express();
//Injeção modulos no servidor
app.use("/user",UserApp);
app.use("/vehicle",VehicleApp);
app.use("/driver",DriverApp);
app.use("/route",RouteApp);
app.use("/supply",SupplyApp);
app.use("/travel",TravelApp);
app.use("/device",DeviceApp);

exports.api = functions.https.onRequest(app);
