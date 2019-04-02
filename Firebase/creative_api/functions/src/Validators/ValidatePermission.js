const users = require("./../Enum/UserEnum");
const User = require("./../Class/User");
module.exports = (user, admin, client, driver, error) => {
  if (!user instanceof User || user.getType() === undefined) {
    error();
    return;
  } else
    switch (user.getType()) {
      case users.ADMIN:
        admin();
        break;
      case users.CLIENT:
        client();
        break;
      case users.DRIVER:
        driver();
        break;
      default:
        error();
        break;
    }
};
