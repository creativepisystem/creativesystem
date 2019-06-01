using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Creative.Screens.CustomEvent;
using Truckleer.Modules;

namespace Truckleer.Creative.Screens.Despesas
{
    public partial class ListarDespesas : UserControl
    {
        public ChangeScreenEvent<List<Expense>> ChangeScreenEvent { get; set; }
        private ExpenseService expenseService;
        private List<Expense> expenses = new List<Expense>();

        public ListarDespesas()
        {
            InitializeComponent();
            expenseService = new ExpenseService();
        }

        private void ListarDespesas_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            expenseWorker.RunWorkerAsync();
        }

        public void UpdateList()
        {
            ProgressBar.Visible = true;

            RemoveExpenseList();

            expenseWorker.RunWorkerAsync();
        }

        private void GetExpense(object sender, DoWorkEventArgs e)
        {
            e.Result = expenseService.FindAll();
        }

        private void GetExpenseFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            expenses = (List<Expense>)e.Result;
            FlowDespesa.Controls.Clear();
            for (int i = 0; i < expenses.Count; i++)
                FlowDespesa.Controls.Add(new CustomExpenseList(i, expenses[i]));
        }

        private void RemoveExpenseList()
        {
            for (int i = FlowDespesa.Controls.Count - 1; i > -1; i--)
            {
                if (FlowDespesa.Controls[i].GetType() == typeof(CustomExpenseList))
                {
                    FlowDespesa.Controls.RemoveAt(i);
                }
            }
        }
    }
}
