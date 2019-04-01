const express = require("express");
const validateUser = require("./../utils/ValidateUser");
const validateVehicle = require("./../utils/ValidateVehicle");
const Vehicle = require("./../Class/Vehicle");
// Importação do Service
const vehicleService = require("./../Service/VehicleService");
VehicleApp = express();
//Criar
VehicleApp.post("/", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    user => {
      validateVehicle.create(
        req.body,
        async () => {
          let vehicle = await vehicleService.saveVehicle(new Vehicle(req.body));
          if (vehicle != null) res.status(201).send(vehicle.get());
          else res.status(400).send("Erro ao criar Veículo");
        },
        () => {
          res.status(400).send("Erro ao criar Veículo,campos invalidos, ");
        }
      );
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
//Listar
VehicleApp.get("/", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      let vehicles = await vehicleService.getAll();
      if (vehicles != null) {
        res.status(200).send(vehicles);
      } else {
        res.status(400).send("Erro ao listar os Veículos");
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
//Detalhar
VehicleApp.get("/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      let vehicle = await vehicleService.getById(req.params.id);
      if (vehicle != null) {
        res.status(200).send(vehicle.get());
      } else {
        res.status(400).send("Erro ao detalhar o Veículo");
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});

//Atualizar
VehicleApp.put("/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      validateVehicle.update(
        req.body,
        async () => {
          let newVehicle = new Vehicle(req.body);
          newVehicle.setId(req.params.id);
          let vehicle = await vehicleService.updateVehicle(newVehicle);
          if (vehicle != null) res.status(201).send(vehicle);
          else res.status(400).send("Erro ao atualizar Veículo");
        },
        () => {
          res.status(400).send("Erro ao atualizar Veículo,campos invalidos, ");
        }
      );
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
module.exports = VehicleApp;
