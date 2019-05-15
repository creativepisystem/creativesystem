using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    [FirestoreData]
    class User:IModule
    {
        //Constructor
        public User()
        {
        }

        //Properties
        public string id { get; set; }
        [FirestoreProperty]
        public string user { get; set; }
        [FirestoreProperty]
        public string password { get; set; }
        [FirestoreProperty]
        public UserType type { get; set; }
        [FirestoreProperty]
        public string auth { get; set; }
        [FirestoreProperty]
        public string email { get; set; }

        //Convert user to dynamic object
        public dynamic ToObject()
        {
            //Initializate us
            dynamic us = new ExpandoObject();
            //verify properties and set in dynamic object
            if (user != null)
                us.user = user;
            if (password != null)
                us.password = password;
            if (email != null)
                us.email = email;
            if (type == UserType.ADMIN || type == UserType.DRIVER || type == UserType.CLIENT)
                us.type = type;
            if (auth != null)
                us.auth = auth;
            //return us
            return us;
        }
        //Method to check if values of user is valid 
        public Message IsValid()
        {
            //Check if has a user and the length
            if (user == null || user.Length < 5 || user.Length > 30)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O usuário deve conter no mínimo 5 e no máximo 30 letras!"
                };
            //Check if has a password and the length
            if (password == null || password.Length < 5 || password.Length > 30)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A senha deve conter no mínimo 5 e no máximo 30 letras!"
                };
            //Check if type is valid
            if (type != UserType.ADMIN && type != UserType.DRIVER && type != UserType.CLIENT)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O tipo do usário é inválido!"
                };
            //check if email is valid
            if (email == null || !Validator.IsValidEmail(email))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O email deve ser similar a example@example.com !"
                };
            //Check if user exist
            if(id == null)
            {
                //Check if user is unique
                if (new UserService().FindByUser(user) != null)
                    return new Message()
                    {
                        Type = MessageType.ERROR,
                        MessageText = "Alguém ja esta usando esse usuário!"
                    };
            }
            else
            {
                //Check if user is unique
                User us = new UserService().FindByUser(user);
                if (us != null)
                {
                    if(us.id != id)
                        return new Message()
                        {
                            Type = MessageType.ERROR,
                            MessageText = "Alguém ja esta usando esse usuário!"
                        };
                }
            }
            //Return a valid message
            return new Message()
            {
                Type = MessageType.VALID,
                MessageText = "O usuário é válido!"
            };

        }

    }

}
