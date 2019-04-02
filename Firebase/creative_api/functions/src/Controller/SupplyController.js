const express = require("express");
const validateUser = require("./../Validators/ValidateUser");
const validateSupply = require("./../Validators/ValidateSupply");
const Supply = require("./../Class/Supply");
// Importação do Service
const supplyService = require("./../Service/SupplyService");
SupplyApp = express();
//Criar
SupplyApp.post("/", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    user => {
      validateSupply.create(
        req.body,
        async () => {
          let supply = await supplyService.saveSupply(new Supply(req.body));
          if (supply != null) res.status(201).send(supply.get());
          else res.status(400).send("Erro ao criar Abastecimento");
        },
        () => {
          res.status(400).send("Erro ao criar Abastecimento,campos invalidos, ");
        }
      );
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
//Listar
SupplyApp.get("/", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      let supplys = await supplyService.getAll();
      if (supplys != null) {
        res.status(200).send(supplys);
      } else {
        res.status(400).send("Erro ao listar os Abastecimentos");
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
//Detalhar
SupplyApp.get("/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      let supply = await supplyService.getById(req.params.id);
      if (supply != null) {
        res.status(200).send(supply.get());
      } else {
        res.status(400).send("Erro ao detalhar o Abastecimento");
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});

//Atualizar
SupplyApp.put("/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      validateSupply.update(
        req.body,
        async () => {
          let newSupply = new Supply(req.body);
          newSupply.setId(req.params.id);
          let supply = await supplyService.updateSupply(newSupply);
          if (supply != null) res.status(201).send(supply);
          else res.status(400).send("Erro ao atualizar Abastecimento");
        },
        () => {
          res.status(400).send("Erro ao atualizar Abastecimento,campos invalidos, ");
        }
      );
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
module.exports = SupplyApp;