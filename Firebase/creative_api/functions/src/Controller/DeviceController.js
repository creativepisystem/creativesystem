const express = require("express");
const validateUser = require("./../Validators/ValidateUser");
const deviceService = require("./../Service/DeviceService");

DeviceApp = express();
DeviceApp.post("/login", async (req, res) => {
  let auth = await deviceService.login({
    user: req.header("user"),
    password: req.header("password")
  });
  if (auth === null) {
    res.status(400).send("Erro");
  } else {
    res.status(200).send(auth);
  }
});

DeviceApp.post("/config", (req, res) => {
  validateUser.auth(
    {
      user: req.header("user"),
      auth: req.header("auth")
    },
    async user => {
      let config = await deviceService.getConfig(user);
      res.status(200).send(config.get());
    },
    () => {
      res.status(401).send("não autorizado");
    }
  );
});

module.exports = DeviceApp;