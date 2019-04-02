const express = require("express");
const validateUser = require("./../Validators/ValidateUser");
const validateRoute = require("./../Validators/ValidateRoute");
const users = require("./../Enum/UserEnum");
const Route = require("./../Class/Route");
// Importação do Service
const routeService = require("./../Service/RouteService");
RouteApp = express();
//Criar
RouteApp.post("/", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    user => {
      validateRoute.create(
        req.body,
        async () => {
          let route = await routeService.saveRoute(new Route(req.body));
          if (route != null) res.status(201).send(route.get());
          else res.status(400).send("Erro ao criar Rota");
        },
        () => {
          res.status(400).send("Erro ao criar Rota,campos invalidos, ");
        }
      );
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
//Listar
RouteApp.get("/", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      let routes = await routeService.getAll();
      if (routes != null) {
        res.status(200).send(routes);
      } else {
        res.status(400).send("Erro ao listar os Rotas");
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
//Detalhar
RouteApp.get("/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      let route = await routeService.getById(req.params.id);
      if (route != null) {
        res.status(200).send(route.get());
      } else {
        res.status(400).send("Erro ao detalhar o Rota");
      }
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});

//Atualizar
RouteApp.put("/:id", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      validateRoute.update(
        req.body,
        async () => {
          let newRoute = new Route(req.body);
          newRoute.setId(req.params.id);
          let route = await routeService.updateRoute(newRoute);
          if (route != null) res.status(201).send(route);
          else res.status(400).send("Erro ao atualizar Rota");
        },
        () => {
          res.status(400).send("Erro ao atualizar Rota,campos invalidos, ");
        }
      );
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});
module.exports = RouteApp;
