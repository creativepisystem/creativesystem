using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative.Screens.Motorista
{
    class CustomDriverList : Panel
    {
        //index - necessario
        readonly int index = 0;

        //Exemplo para classe Usuario
        readonly Driver driver;

        public CustomDriverList(int index, Driver driver)
        {
            this.index = index;

            ItemListDriver = new Panel();
            BorderPanel7 = new Panel();
            BorderPanel6 = new Panel();
            BorderPanel5 = new Panel();
            BorderPanel4 = new Panel();
            BorderPanel3 = new Panel();
            BorderPanel2 = new Panel();
            BorderPanel1 = new Panel();
            LabelReceiveObscervation = new Label();
            LabelReceiveCnhDue = new Label();
            LAbelReceiveCnh = new Label();
            LabelReceiveBirthDate = new Label();
            LabelReceiveMail = new Label();
            LabelReceivePhone = new Label();
            LabelReceiveCpf = new Label();
            LabelObservation = new Label();
            LabelMail = new Label();
            LabelCnh = new Label();
            LabelCnhDue = new Label();
            LabelPhone = new Label();
            LabelCpf = new Label();
            LabelBirthDate = new Label();
            TitleItemDriver = new Panel();
            LabelReceiveName = new Label();
            LabelName = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            TitleItemDriver.SuspendLayout();
            SuspendLayout();

            //Seta o Usuario
            this.driver = driver;
            InitializeCustomList();
        }

        private void InitializeCustomList()
        {
            // 
            // ItemListDriver
            // 
            BackColor = System.Drawing.Color.LightGray;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BorderPanel7);
            Controls.Add(BorderPanel6);
            Controls.Add(BorderPanel5);
            Controls.Add(BorderPanel4);
            Controls.Add(BorderPanel3);
            Controls.Add(BorderPanel2);
            Controls.Add(BorderPanel1);
            Controls.Add(LabelReceiveObscervation);
            Controls.Add(LabelReceiveCnhDue);
            Controls.Add(LAbelReceiveCnh);
            Controls.Add(LabelReceiveBirthDate);
            Controls.Add(LabelReceiveMail);
            Controls.Add(LabelReceivePhone);
            Controls.Add(LabelReceiveCpf);
            Controls.Add(LabelObservation);
            Controls.Add(LabelMail);
            Controls.Add(LabelCnh);
            Controls.Add(LabelCnhDue);
            Controls.Add(LabelPhone);
            Controls.Add(LabelCpf);
            Controls.Add(LabelBirthDate);
            Controls.Add(TitleItemDriver);
            Location = new System.Drawing.Point(127, 20);
            Margin = new Padding(10, 20, 5, 0);
            Name = "ItemListDriver";
            Size = new System.Drawing.Size(355, 325);
            TabIndex = 0;
            // 
            // BorderPanel7
            // 
            BorderPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel7.Location = new System.Drawing.Point(112, 301);
            BorderPanel7.Name = "BorderPanel7";
            BorderPanel7.Size = new System.Drawing.Size(230, 1);
            BorderPanel7.TabIndex = 21;
            // 
            // BorderPanel6
            // 
            BorderPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel6.Location = new System.Drawing.Point(144, 268);
            BorderPanel6.Name = "BorderPanel6";
            BorderPanel6.Size = new System.Drawing.Size(110, 1);
            BorderPanel6.TabIndex = 20;
            // 
            // BorderPanel5
            // 
            BorderPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel5.Location = new System.Drawing.Point(58, 206);
            BorderPanel5.Name = "BorderPanel5";
            BorderPanel5.Size = new System.Drawing.Size(120, 1);
            BorderPanel5.TabIndex = 19;
            // 
            // BorderPanel4
            // 
            BorderPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel4.Location = new System.Drawing.Point(170, 174);
            BorderPanel4.Name = "BorderPanel4";
            BorderPanel4.Size = new System.Drawing.Size(100, 1);
            BorderPanel4.TabIndex = 18;
            // 
            // BorderPanel3
            // 
            BorderPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel3.Location = new System.Drawing.Point(75, 148);
            BorderPanel3.Name = "BorderPanel3";
            BorderPanel3.Size = new System.Drawing.Size(250, 1);
            BorderPanel3.TabIndex = 17;
            // 
            // BorderPanel2
            // 
            BorderPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel2.Location = new System.Drawing.Point(93, 121);
            BorderPanel2.Name = "BorderPanel2";
            BorderPanel2.Size = new System.Drawing.Size(120, 1);
            BorderPanel2.TabIndex = 16;
            // 
            // BorderPanel1
            // 
            BorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel1.Location = new System.Drawing.Point(66, 92);
            BorderPanel1.Name = "BorderPanel1";
            BorderPanel1.Size = new System.Drawing.Size(110, 1);
            BorderPanel1.TabIndex = 15;
            // 
            // LabelReceiveObscervation
            // 
            LabelReceiveObscervation.AutoSize = true;
            LabelReceiveObscervation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveObscervation.Location = new System.Drawing.Point(109, 285);
            LabelReceiveObscervation.Name = "LabelReceiveObscervation";
            LabelReceiveObscervation.Size = new System.Drawing.Size(232, 17);
            LabelReceiveObscervation.TabIndex = 14;
            LabelReceiveObscervation.Text = driver.Obs ?? "-";
            // 
            // LabelReceiveCnhDue
            // 
            LabelReceiveCnhDue.AutoSize = true;
            LabelReceiveCnhDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveCnhDue.Location = new System.Drawing.Point(156, 252);
            LabelReceiveCnhDue.Name = "LabelReceiveCnhDue";
            LabelReceiveCnhDue.Size = new System.Drawing.Size(80, 17);
            LabelReceiveCnhDue.TabIndex = 13;
            LabelReceiveCnhDue.Text = driver.Cnh_expiration.ToShortDateString();
            // 
            // LAbelReceiveCnh
            // 
            LAbelReceiveCnh.AutoSize = true;
            LAbelReceiveCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LAbelReceiveCnh.Location = new System.Drawing.Point(72, 190);
            LAbelReceiveCnh.Name = "LAbelReceiveCnh";
            LAbelReceiveCnh.Size = new System.Drawing.Size(88, 17);
            LAbelReceiveCnh.TabIndex = 12;
            LAbelReceiveCnh.Text = driver.Cnh_number.ToString();
            // 
            // LabelReceiveBirthDate
            // 
            LabelReceiveBirthDate.AutoSize = true;
            LabelReceiveBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveBirthDate.Location = new System.Drawing.Point(179, 158);
            LabelReceiveBirthDate.Name = "LabelReceiveBirthDate";
            LabelReceiveBirthDate.Size = new System.Drawing.Size(80, 17);
            LabelReceiveBirthDate.TabIndex = 11;
            LabelReceiveBirthDate.Text = driver.Birth_date.ToShortDateString();
            // 
            // LabelReceiveMail
            // 
            LabelReceiveMail.AutoSize = true;
            LabelReceiveMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveMail.Location = new System.Drawing.Point(90, 132);
            LabelReceiveMail.Name = "LabelReceiveMail";
            LabelReceiveMail.Size = new System.Drawing.Size(199, 17);
            LabelReceiveMail.TabIndex = 10;
            LabelReceiveMail.Text = driver.Email;
            // 
            // LabelReceivePhone
            // 
            LabelReceivePhone.AutoSize = true;
            LabelReceivePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceivePhone.Location = new System.Drawing.Point(91, 105);
            LabelReceivePhone.Name = "LabelReceivePhone";
            LabelReceivePhone.Size = new System.Drawing.Size(115, 17);
            LabelReceivePhone.TabIndex = 9;
            LabelReceivePhone.Text = driver.Phone ?? "-";
            // 
            // LabelReceiveCpf
            // 
            LabelReceiveCpf.AutoSize = true;
            LabelReceiveCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveCpf.Location = new System.Drawing.Point(69, 76);
            LabelReceiveCpf.Name = "LabelReceiveCpf";
            LabelReceiveCpf.Size = new System.Drawing.Size(109, 17);
            LabelReceiveCpf.TabIndex = 8;
            LabelReceiveCpf.Text = driver.Cpf.ToString();
            // 
            // LabelObservation
            // 
            LabelObservation.AutoSize = true;
            LabelObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelObservation.Location = new System.Drawing.Point(11, 285);
            LabelObservation.Name = "LabelObservation";
            LabelObservation.Size = new System.Drawing.Size(95, 17);
            LabelObservation.TabIndex = 7;
            LabelObservation.Text = "Observação";
            // 
            // LabelMail
            // 
            LabelMail.AutoSize = true;
            LabelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelMail.Location = new System.Drawing.Point(11, 133);
            LabelMail.Name = "LabelMail";
            LabelMail.Size = new System.Drawing.Size(53, 17);
            LabelMail.TabIndex = 6;
            LabelMail.Text = "E-Mail";
            // 
            // LabelCnh
            // 
            LabelCnh.AutoSize = true;
            LabelCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelCnh.Location = new System.Drawing.Point(9, 190);
            LabelCnh.Name = "LabelCnh";
            LabelCnh.Size = new System.Drawing.Size(50, 17);
            LabelCnh.TabIndex = 5;
            LabelCnh.Text = "CNH: ";
            // 
            // LabelCnhDue
            // 
            LabelCnhDue.AutoSize = true;
            LabelCnhDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelCnhDue.Location = new System.Drawing.Point(11, 255);
            LabelCnhDue.Name = "LabelCnhDue";
            LabelCnhDue.Size = new System.Drawing.Size(139, 17);
            LabelCnhDue.TabIndex = 4;
            LabelCnhDue.Text = "Vencimento CNH: ";
            // 
            // LabelPhone
            // 
            LabelPhone.AutoSize = true;
            LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelPhone.Location = new System.Drawing.Point(11, 105);
            LabelPhone.Name = "LabelPhone";
            LabelPhone.Size = new System.Drawing.Size(82, 17);
            LabelPhone.TabIndex = 3;
            LabelPhone.Text = "Telefone: ";
            // 
            // LabelCpf
            // 
            LabelCpf.AutoSize = true;
            LabelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelCpf.Location = new System.Drawing.Point(11, 77);
            LabelCpf.Name = "LabelCpf";
            LabelCpf.Size = new System.Drawing.Size(42, 17);
            LabelCpf.TabIndex = 2;
            LabelCpf.Text = "CPF:";
            // 
            // LabelBirthDate
            // 
            LabelBirthDate.AutoSize = true;
            LabelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelBirthDate.Location = new System.Drawing.Point(9, 158);
            LabelBirthDate.Name = "LabelBirthDate";
            LabelBirthDate.Size = new System.Drawing.Size(164, 17);
            LabelBirthDate.TabIndex = 1;
            LabelBirthDate.Text = "Data de Nascimento: ";
            // 
            // TitleItemDriver
            // 
            TitleItemDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            TitleItemDriver.Controls.Add(BtnCancelar);
            TitleItemDriver.Controls.Add(BtnSalvar);
            TitleItemDriver.Controls.Add(LabelReceiveName);
            TitleItemDriver.Controls.Add(LabelName);
            TitleItemDriver.Dock = DockStyle.Top;
            TitleItemDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TitleItemDriver.ForeColor = System.Drawing.Color.Azure;
            TitleItemDriver.Location = new System.Drawing.Point(0, 0);
            TitleItemDriver.Name = "TitleItemDriver";
            TitleItemDriver.Size = new System.Drawing.Size(355, 67);
            TitleItemDriver.TabIndex = 0;
            // 
            // LabelReceiveName
            // 
            LabelReceiveName.AutoSize = true;
            LabelReceiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveName.Location = new System.Drawing.Point(90, 33);
            LabelReceiveName.Name = "LabelReceiveName";
            LabelReceiveName.Size = new System.Drawing.Size(114, 20);
            LabelReceiveName.TabIndex = 1;
            LabelReceiveName.Text = "Felipe Creative";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelName.Location = new System.Drawing.Point(9, 28);
            LabelName.Name = "LabelName";
            LabelName.Size = new System.Drawing.Size(75, 25);
            LabelName.TabIndex = 0;
            LabelName.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(11, 225);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 17);
            label1.TabIndex = 22;
            label1.Text = "Categoria: ";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            panel1.Location = new System.Drawing.Point(105, 241);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(47, 1);
            panel1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(120, 225);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 17);
            label2.TabIndex = 20;
            label2.Text = driver.Cnh.ToString();
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = System.Drawing.Color.Teal;
            BtnSalvar.BackgroundImage = Properties.Resources.editNote;
            BtnSalvar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSalvar.FlatAppearance.BorderSize = 0;
            BtnSalvar.FlatStyle = FlatStyle.Flat;
            BtnSalvar.Location = new System.Drawing.Point(273, 12);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new System.Drawing.Size(25, 25);
            BtnSalvar.TabIndex = 2;
            BtnSalvar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = System.Drawing.Color.Crimson;
            BtnCancelar.BackgroundImage = Properties.Resources.delete;
            BtnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Location = new System.Drawing.Point(316, 12);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new System.Drawing.Size(25, 25);
            BtnCancelar.TabIndex = 1;
            BtnCancelar.UseVisualStyleBackColor = false;
        }

        private readonly Panel ItemListDriver;
        private Label LabelBirthDate;
        private Panel TitleItemDriver;
        private Label LabelReceiveName;
        private Label LabelName;
        private Label LabelObservation;
        private Label LabelMail;
        private Label LabelCnh;
        private Label LabelCnhDue;
        private Label LabelPhone;
        private Label LabelCpf;
        private Label LabelReceiveCpf;
        private Panel BorderPanel3;
        private Panel BorderPanel2;
        private Panel BorderPanel1;
        private Label LabelReceiveObscervation;
        private Label LabelReceiveCnhDue;
        private Label LAbelReceiveCnh;
        private Label LabelReceiveBirthDate;
        private Label LabelReceiveMail;
        private Label LabelReceivePhone;
        private Panel BorderPanel7;
        private Panel BorderPanel6;
        private Panel BorderPanel5;
        private Panel BorderPanel4;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button BtnSalvar;
        private Button BtnCancelar;
    }
}
