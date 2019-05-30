using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    class ExpenseRepository
    {
        //Collection reference property
        readonly CollectionReference Reference;
        //Constructor Class
        public ExpenseRepository()
        {
            //Create firestore connection
            ConnectionFirestore coon = new ConnectionFirestore();
            //Initializate Reference
            Reference = coon.Db.Collection("expenses");
        }

        //Method for get All expenses
        async public Task<List<Expense>> FindAll()
        {
            //Create a list of expenses
            List<Expense> expenses = new List<Expense>();
            //Create a Query without any filter
            QuerySnapshot snapshot = await Reference.GetSnapshotAsync();

            //Pass all Documents
            foreach (DocumentSnapshot queryResult in snapshot.Documents)
            {
                //Convert Document in a Expense class
                Expense us = queryResult.ConvertTo<Expense>();
                //Set id of expense
                us.Id = queryResult.Id;
                //Add expense to list
                expenses.Add(us);
            }
            //Return List
            return expenses;
        }
        //Method for find One expense by Id
        async public Task<Expense> Find(string Id)
        {
            //Create a Document Reference with id like /expenses/id_value
            DocumentSnapshot DocRef = await Reference.Document(Id).GetSnapshotAsync();
            //Initializate a expense  with null value
            Expense us = null;
            //Check if document exists
            if (DocRef.Exists)
            {
                //Convert document to a Expense class
                us = DocRef.ConvertTo<Expense>();
                //Set id of expense
                us.Id = DocRef.Id;
            }
            //Return expense
            return us;
        }
        //Method for save or update Expense
        async public Task<bool> Save(Expense expense)
        {
            //Check if expense exisit
            if (expense.Id == null)//If not exist
            {
                //Create new expense
                DocumentReference snapshot = await Reference.AddAsync(expense);
                //return a bool if is successful
                return snapshot.Id != null;
            }
            else
            {
                //update expense and merge values
                WriteResult snapshot = await Reference.Document(expense.Id).SetAsync(expense, SetOptions.MergeAll);
                //return a bool if is successful
                return snapshot.UpdateTime != null;
            }
        }
    }
}
