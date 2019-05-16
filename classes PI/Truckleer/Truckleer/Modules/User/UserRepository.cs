using Google.Cloud.Firestore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    //User repository class
    class UserRepository
    {
        //Collection reference property
        readonly CollectionReference Reference;
        //Constructor Class
        public UserRepository()
        {
            //Create firestore connection
            ConnectionFirestore coon = new ConnectionFirestore();
            //Initializate Reference
            Reference = coon.Db.Collection("users");
        }

        //Method for get All users
        async public Task<List<User>> FindAll()
        {
            //Create a list of users
            List<User> users = new List<User>();
            //Create a Query without any filter
            QuerySnapshot snapshot = await Reference.GetSnapshotAsync();

            //Pass all Documents
            foreach (DocumentSnapshot queryResult in snapshot.Documents)
            {
                //Convert Document in a User class
                User us = queryResult.ConvertTo<User>();
                //Set id of user
                us.id = queryResult.Id;
                //Add user to list
                users.Add(us);
            }
            //Return List
            return users;
        }
        //Method for find One user by Id
        async public Task<User> Find(string Id)
        {
            //Create a Document Reference with id like /users/id_value
            DocumentSnapshot DocRef = await Reference.Document(Id).GetSnapshotAsync();
            //Initializate a user  with null value
            User us = null;
            //Check if document exists
            if (DocRef.Exists)
            {
                //Convert document to a User class
                us = DocRef.ConvertTo<User>();
                //Set id of user
                us.id = DocRef.Id;
            }
            //Return user
            return us;
        }
        //Method for find one User By user value
        async public Task<User> FindByUser(string user)
        {
            //crete a query for return one User By user like SELECT * from users where user LIKE user;
            QuerySnapshot result = await Reference.OrderBy("user").StartAt(user).
                EndAt(user + '\uf8ff').GetSnapshotAsync();
            //Initializate a user  with null value
            User us = null;
            if (result.Documents.Count > 0)
            {
                //Convert document to a User class
                us = result.Documents[0].ConvertTo<User>();
                //Set id of user
                us.id = result.Documents[0].Id;
            }
            //Return User
            return us;
        }
        //Method for save or update User
        async public Task<bool> Save(User user)
        { 
            //Check if user exisit
            if (user.id == null)//If not exist
            {
                //Create new user
                DocumentReference snapshot = await Reference.AddAsync(user.ToObject());
                //return a bool if is successful
                return snapshot.Id != null;
            }
            else
            {
                //update user and merge values
                WriteResult snapshot = await Reference.Document(user.id).SetAsync(user.ToObject(), SetOptions.MergeAll);
                //return a bool if is successful
                return snapshot.UpdateTime != null;
            }
        }
    }
}
