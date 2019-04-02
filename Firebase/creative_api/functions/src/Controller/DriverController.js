const express = require("express");
const validateUser = require("./../Validators/ValidateUser");
const validateDriver = require("./../Validators/ValidateDriver");
const users = require("./../Enum/UserEnum");
const Driver = require("./../Class/Driver");
// Importação do Service
const driverService = require("./../Service/DriverService");
DriverApp = express();
//Criar
DriverApp.post("/", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    user => {
      if (user.getType == users.DRIVER) {
        res.status(401).send("não autorizado");
      } else {
        validateDriver.create(
          req.body,
          async () => {
            let driver = await driverService.saveDriver(new Driver(req.body));
            if (driver != null) res.status(201).send(driver.get());
            else res.status(400).send("Erro ao criar Motorista");
          },
          () => {
            res.status(400).send("Erro ao criar Motorista,campos invalidos, ");
          }
        );
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
//Listar
DriverApp.get("/", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      if (user.getType == users.DRIVER) {
        res.status(401).send("não autorizado");
      } else {
        let drivers = await driverService.getAll();
        if (drivers != null) {
          res.status(200).send(drivers);
        } else {
          res.status(400).send("Erro ao listar os Motoristas");
        }
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
//Detalhar
DriverApp.get("/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      if (user.getType == users.DRIVER) {
        res.status(401).send("não autorizado");
      } else {
        let driver = await driverService.getById(req.params.id);
        if (driver != null) {
          res.status(200).send(driver.get());
        } else {
          res.status(400).send("Erro ao detalhar o Motorista");
        }
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});

//Atualizar
DriverApp.put("/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      if (user.getType == users.DRIVER && user.getDriver != req.params.id) {
        res.status(401).send("não autorizado");
      } else {
        validateDriver.update(
          req.body,
          async () => {
            let newDriver = new Driver(req.body);
            newDriver.setId(req.params.id);
            let driver = (await driverService.updateDriver(newDriver));
            if (driver != null) res.status(201).send(driver);
            else res.status(400).send("Erro ao atualizar Motorista");
          },
          () => {
            res.status(400).send("Erro ao atualizar Motorista,campos invalidos, ");
          }
        );
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
module.exports = DriverApp;