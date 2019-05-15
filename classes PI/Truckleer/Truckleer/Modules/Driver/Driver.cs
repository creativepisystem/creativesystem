using Google.Cloud.Firestore;
using System;
using System.Dynamic;
namespace Truckleer.Modules
{
    [FirestoreData]
    public class Driver : IModule
    {
        UserService userService;
        //Constructor
        public Driver()
        {
            userService = new UserService();
        }
        //Atributes
        public string id { get; set; }
        [FirestoreProperty]
        public string name { get; set; }
        [FirestoreProperty]
        public string cpf { get; set; }
        [FirestoreProperty]
        public CnhType cnh { get; set; }
        [FirestoreProperty]
        public string cnh_number { get; set; }
        [FirestoreProperty]
        public DateTime birth_date { get; set; }
        [FirestoreProperty]
        public string phone { get; set; }
        [FirestoreProperty]
        public string email { get; set; }
        [FirestoreProperty]
        public DateTime cnh_expiration { get; set; }
        [FirestoreProperty]
        public string photo { get; set; }
        [FirestoreProperty]
        public string obs { get; set; }
        public User user { get; set; }
        public Message IsValid()
        {
            if (name == null || name.Length < 2 || name.Length> 40)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O nome deve conter de 2 a 40 letras!"
                };
            if (cpf == null || Validator.IsValidCpf(cpf))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Cpf inválido!"
                };
            if (! (cnh.GetType() == typeof(CnhType)))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Tipo de cnh inválida"
                };
            if (cnh_number == null || Validator.IsValidCnh(cnh_number))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Cnh inválida!"
                };
            if (birth_date == null || birth_date.Year > new DateTime().Year -18 )
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Data de nascimento inválida!"
                };
            if (phone != null &&phone.Length >15)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Telefone inválido!"
                };
            if (email == null || Validator.IsValidEmail(email))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Email inválido"
                };
            if (cnh_expiration == null || cnh_expiration.Year < 1900 || cnh_expiration.Year > new DateTime().Year+5)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A data de experiração da cnh é inválida!"
                };
            if (obs != null || obs.Length <0 || obs.Length>100)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A observação deve conter no máximo 100 caracteres!"
                };
            if (user == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Usuario é um campo obrigatório!"

                };
            else if (userService.FindOne(user.id) == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Usuario inválido!"

                };
            return new Message()
            {
                Type = MessageType.VALID,
                MessageText = "Motorista válido!"

            };
        }

        public dynamic ToObject()
        {
            //Initializate us
            dynamic us = new ExpandoObject();
            if (name != null)
                us.name = name;
            if (cpf != null)
                us.cpf = cpf;
            if (cnh.GetType() == typeof(CnhType))
                us.cnh = cnh;
            if (cnh_number != null)
                us.cnh_number = cnh_number;
            if (birth_date != null)
                us.birth_date = birth_date;
            if (phone != null)
                us.phone = phone;
            if (email != null)
                us.email = email;
            if (cnh_expiration != null)
                us.cnh_expiration = cnh_expiration;
            if (photo != null)
                us.photo = photo;
            if (obs != null)
                us.obs = obs;
            if (user != null)
                us.user = user.id;
            return us;
        }
    }
}
