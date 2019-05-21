using System.Collections.Generic;
namespace Truckleer.Modules
{
    //UserService Class
    class UserService
    {
        //User repository property
        readonly UserRepository repository;
        //Class constructor
        public UserService()
        {
            //initializate user repository property
            repository = new UserRepository();
        }
        //Method to findAll users
        public List<User> FindAll()
        {
            return repository.FindAll().Result;
        }
        //Method to find one specific user by id
        public User FindOne(string Id)
        {
            return repository.Find(Id).Result;
        }
        //Method to find one specific user by user
        public User FindByUser(string user)
        {
            return repository.FindByUser(user).Result;
        }
        //Method to Save or Update user
        public bool Save(User user)
        {
            return repository.Save(user).Result;
        }
    }
}
