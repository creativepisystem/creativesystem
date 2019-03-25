const express = require('express');
const validateUser = require("./../utils/ValidateUser");
const validateVehicle = require('./../utils/ValidateVehicle');
const vehicleService = require('./../Service/VehicleService');

VehicleApp = express();

VehicleApp.get('/', (req, res) => {
    validateUser.auth({
        user: req.header('user'),
        auth: req.header('auth')
    },
        async function (vehicle) {

        },

        () => {
            res.status(401).send("");
        }
    );
});

VehicleApp.get('/:id', (req, res) => {
    validateUser.auth({
        user: req.header('user'),
        auth: req.header('auth')
    },
        async function (user) {

        },

        () => {
            res.status(401).send("");
        }
    );
});

VehicleApp.post('/', (req, res) => {
    validateUser.auth({
        user: req.header('user'),
        auth: req.header('auth')
    },
        async function (user) {
            validateVehicle.create(req.body,
                async () => {
                    validateVehicle.create(req.body,
                        async () => {
                            let vehicle = await vehicleService.saveVehicle(req.body);
                            if (vehicle == null)
                                res.status(400).send("Erro ao criar veículo");
                            else
                                res.status(201).send(vehicle.get());
                        },
                        () => {
                            res.status(400).send("Dados inválidos");
                        })

                },
                () => {
                    res.status(400).send("Parâmetros Inválidos");
                })
        },

        () => {
            res.status(401).send("");
        }
    );
});

VehicleApp.put('/:id', (req, res) => {
    validateUser.auth({
        user: req.header('user'),
        auth: req.header('auth')
    },
        async function (user) {

        },

        () => {
            res.status(401).send("");
        }
    );
});

module.exports = VehicleApp