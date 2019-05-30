using System.Collections.Generic;

namespace Truckleer.Modules
{
    class ExpenseService
    {
        //Expense repository property
        readonly ExpenseRepository repository;
        //Class constructor
        public ExpenseService()
        {
            //initializate expense repository property
            repository = new ExpenseRepository();
        }
        //Method to findAll expenses
        public List<Expense> FindAll()
        {
            return repository.FindAll().Result;
        }
        //Method to find one specific expense by id
        public Expense FindOne(string Id)
        {
            return repository.Find(Id).Result;
        }
        //Method to Save or Update expense
        public bool Save(Expense expense)
        {
            return repository.Save(expense).Result;
        }
    }
}
