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
    public class User:IModule
    {
        //Constructor
        public User()
        {
        }

        //Properties
        public string id { get; set; }
        [FirestoreProperty("user")]
        public string Login { get; set; }
        [FirestoreProperty("password")]
        public string Password { get; set; }
        [FirestoreProperty("type")]
        public UserType Type { get; set; }
        [FirestoreProperty("auth")]
        public string Auth { get; set; }
        [FirestoreProperty("email")]
        public string Email { get; set; }

        //Method to check if values of user is valid 
        public Message IsValid()
        {
            //Check if has a user and the length
            if (Login == null || Login.Length < 5 || Login.Length > 30)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O usuário deve conter no mínimo 5 e no máximo 30 letras!"
                };
            //Check if has a password and the length
            if (Password == null || Password.Length < 5 || Password.Length > 30)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A senha deve conter no mínimo 5 e no máximo 30 letras!"
                };
            //Check if type is valid
            if (Type != UserType.ADMIN && Type != UserType.DRIVER && Type != UserType.CLIENT)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O tipo do usário é inválido!"
                };
            //check if email is valid
            if (Email == null || !Validator.IsValidEmail(Email))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O email deve ser similar a example@example.com !"
                };
            //Check if user exist
            if(id == null)
            {
                //Check if user is unique
                if (new UserService().FindByUser(Login) != null)
                    return new Message()
                    {
                        Type = MessageType.ERROR,
                        MessageText = "Alguém ja esta usando esse usuário!"
                    };
            }
            else
            {
                //Check if user is unique
                User us = new UserService().FindByUser(Login);
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
