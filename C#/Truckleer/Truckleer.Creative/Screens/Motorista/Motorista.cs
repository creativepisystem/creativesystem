using System;
using System.ComponentModel;
using System.Windows.Forms;
using Truckleer.Modules;
using Message = Truckleer.Modules.Message;

namespace Truckleer.Creative
{
    public partial class Motorista : UserControl
    {
        private DriverService driverService;
        private Driver Driver;
        public Motorista()
        {
            InitializeComponent();
            driverService = new DriverService();
            Driver = new Driver();
        }

        private void Motorista_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void PanelRightDriver_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void SaveDriver(object sender, DoWorkEventArgs e)
        {
            e.Result = driverService.Save(Driver);
        }
        private void SaveDriverFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            bool isSave = (bool)e.Result;
            if (isSave)
            {
                MessageBox.Show("Motorista Salvo com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao Salvar o motorista");
            }
            ButtonSave.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ButtonSave.Enabled = false;
            Driver.Birth_date = DateBirthDay.Value;
            Driver.Cnh_expiration = DateCnhDue.Value;
            if (!string.IsNullOrEmpty(TextName.Text))
                Driver.Name = TextName.Text;
            if (!string.IsNullOrEmpty(TextCnh.Text))
                Driver.Cnh_number = TextCnh.Text;
            if (!string.IsNullOrEmpty(TextCpf.Text))
                Driver.Cpf = TextCpf.Text;
            if (BoxCnhType.SelectedIndex> -1)
                Driver.Cnh = (CnhType)BoxCnhType.SelectedIndex;
            if (!string.IsNullOrEmpty(TextPhone.Text))
                Driver.Phone = TextPhone.Text;
            if (!string.IsNullOrEmpty(TextEmail.Text))
                Driver.Email = TextEmail.Text;
            if (!string.IsNullOrEmpty(TextObservation.Text))
                Driver.Obs = TextObservation.Text;
            Message message = Driver.IsValid();
            if(message.Type == MessageType.ERROR)
            {
                Cursor = Cursors.Default;
                ButtonSave.Enabled = true;
                MessageBox.Show(message.MessageText);
            }
            else
            {
                driverWorker.RunWorkerAsync();
            }
        }
    }
}
