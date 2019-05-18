using Google.Cloud.Firestore;
using System;
using System.Dynamic;
using Truckleer.Modules.CustomConvert;

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
        public string Id { get; set; }
        [FirestoreProperty("name")]
        public string Name { get; set; }
        [FirestoreProperty("cpf")]
        public string Cpf { get; set; }
        [FirestoreProperty(Name = "cnh", ConverterType = typeof(CustomCnhTypeConvert))]
        public CnhType Cnh { get; set; }
        [FirestoreProperty("cnh_number")]
        public string Cnh_number { get; set; }
        [FirestoreProperty(Name = "birth_date", ConverterType = typeof(CustomDateTimeConvert))]
        public DateTime Birth_date { get; set; }
        [FirestoreProperty("phone")]
        public string Phone { get; set; }
        [FirestoreProperty("email")]
        public string Email { get; set; }
        [FirestoreProperty(Name = "cnh_expiration", ConverterType = typeof(CustomDateTimeConvert))]
        public DateTime Cnh_expiration { get; set; }
        [FirestoreProperty("photo")]
        public string Photo { get; set; }
        [FirestoreProperty("obs")]
        public string Obs { get; set; }
        [FirestoreProperty(Name = "user", ConverterType = typeof(CustomUserConvert))]
        public User User { get; set; }
        public Message IsValid()
        {
            if (Name == null || Name.Length < 2 || Name.Length> 40)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O nome deve conter de 2 a 40 letras!"
                };
            if (Cpf == null || Validator.IsValidCpf(Cpf))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Cpf inválido!"
                };
            if (! (Cnh.GetType() == typeof(CnhType)))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Tipo de cnh inválida"
                };
            if (Cnh_number == null || Validator.IsValidCnh(Cnh_number))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Cnh inválida!"
                };
            if (Birth_date == null || Birth_date.Year > new DateTime().Year -18 )
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Data de nascimento inválida!"
                };
            if (Phone != null &&Phone.Length >15)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Telefone inválido!"
                };
            if (Email == null || Validator.IsValidEmail(Email))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Email inválido"
                };
            if (Cnh_expiration == null || Cnh_expiration.Year < 1900 || Cnh_expiration.Year > new DateTime().Year+5)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A data de experiração da cnh é inválida!"
                };
            if (Obs != null || Obs.Length <0 || Obs.Length>100)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A observação deve conter no máximo 100 caracteres!"
                };
            if (User == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Usuario é um campo obrigatório!"

                };
            else if (userService.FindOne(User.id) == null)
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
            if (Name != null)
                us.name = Name;
            if (Cpf != null)
                us.cpf = Cpf;
            if (Cnh.GetType() == typeof(CnhType))
                us.cnh = Cnh;
            if (Cnh_number != null)
                us.cnh_number = Cnh_number;
            if (Birth_date != null)
                us.birth_date = Birth_date;
            if (Phone != null)
                us.phone = Phone;
            if (Email != null)
                us.email = Email;
            if (Cnh_expiration != null)
                us.cnh_expiration = Cnh_expiration;
            if (Photo != null)
                us.photo = Photo;
            if (Obs != null)
                us.obs = Obs;
            if (User != null)
                us.user = User.id;
            return us;
        }
    }
}
