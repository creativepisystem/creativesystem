const driverService = require("./../Service/DriverService");
const validarCpf = require("validar-cpf");
module.exports = {
  create: async function(driver, success, error) {
    if (driver === undefined ||
      driver.name === undefined ||
      driver.cpf === undefined ||
      driver.cnh === undefined ||
      driver.cnh_number === undefined
    )
      error();
    else if (driver.name.length < 3 || driver.name.length > 60) error();
    else if (!validarCpf(driver.cpf)) error();
    else if (driver.cnh_number.length != 11) error();
    else if (["A","B","C","D","E"].indexOf(driver.cnh) < 0) error();
    else if(driver.email != undefined && 
    !/^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    .test(driver.email)) error();
    else if(driver.phone != undefined && (driver.phone.length != 10 && driver.phone.length != 11)) error();
    else success();
  },
  update:async function(driver, success, error) {
    if (driver === undefined)
      error();
    else if (driver.name !== undefined &&(driver.name.length < 3 || driver.name.length > 60)) error();
    else if (driver.cpf !== undefined &&(!validarCpf(driver.cpf))) error();
    else if (driver.cnh_number !== undefined &&(driver.cnh_number.length != 11)) error();
    else if (driver.cnh !== undefined &&(["A","B","C","D","E"].indexOf(driver.cnh) < 0)) error();
    else if(driver.email != undefined && 
    !/^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    .test(driver.email)) error();
    else if(driver.phone != undefined && (driver.phone.length != 10 && driver.phone.length != 11)) error();
    else success();
  }
};
