class Driver {
  constructor(object = null) {
    if (object != null) {
      this.driver = {
        id: object.id,
        name: object.name,
        cpf: object.cpf,
        cnh: object.cnh,
        cnh_number: object.cnh_number,
        birth_date: object.birth_date,
        phone: object.phone,
        email: object.email,
        cnh_expiration: object.cnh_expiration,
        photo: object.photo,
        obs: object.obs
      };
      Object.keys(this.driver).forEach(k => {
        if (this.driver[k] === undefined || this.driver[k] === null)
          delete this.driver[k];
      });
    } else {
      this.driver = {};
    }
  }

  get() {
    return this.driver;
  }
  set(driver) {
    Object.keys(driver).forEach(k => {
      if (driver[k] === undefined || driver[k] === null) delete driver[k];
    });
    this.driver = driver;
  }
  getId() {
    return this.driver.id;
  }
  setId(id) {
    this.driver.id = id;
  }
  getName() {
    return this.driver.name;
  }
  setName(name) {
    this.driver.name = name;
  }
  getCpf() {
    return this.driver.cpf;
  }
  setCpf(cpf) {
    this.driver.cpf = cpf;
  }
  getBirthDate() {
    return this.driver.birth_date;
  }
  setBirthDate(birth_date) {
    this.driver.birth_date = birth_date;
  }
  getPhone() {
    return this.driver.phone;
  }
  setPhone(phone) {
    this.driver.phone = phone;
  }
  getEmail() {
    return this.driver.email;
  }
  setEmail(email) {
    this.driver.email = email;
  }
  getCnhExpiration() {
    return this.driver.cnh_expiration;
  }
  setCnhExpiration(cnh_expiration) {
    this.driver.cnh_expiration = cnh_expiration;
  }
  getPhoto() {
    return this.driver.photo;
  }
  setPhoto(photo) {
    this.driver.photo = photo;
  }
  getObs() {
    return this.driver.obs;
  }
  setObs(obs) {
    this.driver.obs = obs;
  }
  getCnhNumber() {
    return this.driver.cnh_number;
  }
  setCnhNumber(cnh_number) {
    this.driver.cnh_number = cnh_number;
  }
}
module.exports = Driver;
