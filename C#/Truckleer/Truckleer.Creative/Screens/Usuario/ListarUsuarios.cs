using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;
using Truckleer.Creative.Screens.CustomEvent;

namespace Truckleer.Creative.Screens.Usuario
{
    public partial class ListarUsuarios : UserControl
    {
        public ChangeScreenEvent<List<User>> ChangeScreenEvent { get; set; }
        private UserService userService;
        private List<User> users = new List<User>();

        public ListarUsuarios()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void ListarUsuarios_Load_1(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            userListWorker.RunWorkerAsync();
        }

        public void UpdateList()
        {
            ProgressBar.Visible = true;

            RemoveUserList();

            userListWorker.RunWorkerAsync();
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {

        }

        private void FilterUser(object sender, DoWorkEventArgs e)
        {
            e.Result = userService.FindAll();
        }

        private void FilterUserFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.Visible = false;
            users = (List<User>)e.Result;
            FlowUserPanel.Controls.Clear();
            for (int i = 0; i < users.Count; i++)
                FlowUserPanel.Controls.Add(new CustomUserList(i, users[i]));
        }

        private void RemoveUserList()
        {
            for (int i = FlowUserPanel.Controls.Count - 1; i > -1; i--)
            {
                if (FlowUserPanel.Controls[i].GetType() == typeof(CustomUserList))
                {
                    FlowUserPanel.Controls.RemoveAt(i);
                }
            }
        }
    }
}
