const express = require("express");
const validateUser = require("./../Validators/ValidateUser");
const validateTravel = require("./../Validators/ValidateTravel");
const Travel = require("./../Class/Travel");
const status = require("./../Enum/StatusEnum");
// Importação do Service
const travelService = require("./../Service/TravelService");
TravelApp = express();
//Criar
TravelApp.post("/", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    user => {
      validateTravel.create(
        req.body,
        async () => {
          let travel = await travelService.saveTravel(new Travel(req.body));
          if (travel != null) {
            travel.setStatus(status.open)
            res.status(201).send(travel.get());
          } else res.status(400).send("Erro ao criar Viagem");
        },
        () => {
          res.status(400).send("Erro ao criar Viagem,campos invalidos, ");
        }
      );
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
//Listar
TravelApp.get("/", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      let travels = await travelService.getAll();
      if (travels != null) {
        res.status(200).send(travels);
      } else {
        res.status(400).send("Erro ao listar os Viagems");
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
//Detalhar
TravelApp.get("/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      let travel = await travelService.getById(req.params.id);
      if (travel != null) {
        res.status(200).send(travel.get());
      } else {
        res.status(400).send("Erro ao detalhar o Viagem");
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});

//Atualizar
TravelApp.put("/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      validateTravel.update(
        req.body,
        async () => {
          let newTravel = new Travel(req.body);
          newTravel.setId(req.params.id);
          let travel = await travelService.updateTravel(newTravel);
          if (travel != null) res.status(201).send(travel);
          else res.status(400).send("Erro ao atualizar Viagem");
        },
        () => {
          res.status(400).send("Erro ao atualizar Viagem,campos invalidos, ");
        }
      );
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});

TravelApp.put("/finish/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
          let newTravel = new Travel();
          newTravel.setId(req.params.id);
          newTravel.setStatus(status.finish);
          let travel = (await travelService.updateTravel(newTravel));
          if (travel != null) res.status(201).send(travel);
          else res.status(400).send("Erro ao atualizar Viagem");
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
module.exports = TravelApp;
