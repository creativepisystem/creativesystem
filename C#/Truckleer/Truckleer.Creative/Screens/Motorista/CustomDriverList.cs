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
            TitleItemDriver = new Panel();
            LabelName = new Label();
            LabelReceiveName = new Label();
            LabelBirthDate = new Label();
            LabelCpf = new Label();
            LabelPhone = new Label();
            LabelCnhDue = new Label();
            LabelCnh = new Label();
            LabelMail = new Label();
            LabelObservation = new Label();
            LabelReceiveCpf = new Label();
            LabelReceivePhone = new Label();
            LabelReceiveMail = new Label();
            LabelReceiveBirthDate = new Label();
            LAbelReceiveCnh = new Label();
            LabelReceiveCnhDue = new Label();
            LabelReceiveObscervation = new Label();
            BorderPanel1 = new Panel();
            BorderPanel2 = new Panel();
            BorderPanel3 = new Panel();
            BorderPanel4 = new Panel();
            BorderPanel5 = new Panel();
            BorderPanel6 = new Panel();
            BorderPanel7 = new Panel();
            ButtonDelete = new Button();
            ButtonEdit = new Button();
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
            Margin = new System.Windows.Forms.Padding(10, 20, 5, 0);
            Name = "ItemListDriver";
            Size = new System.Drawing.Size(355, 300);
            TabIndex = 0;
            // 
            // TitleItemDriver
            // 
            TitleItemDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            TitleItemDriver.Controls.Add(ButtonDelete);
            TitleItemDriver.Controls.Add(ButtonEdit);
            TitleItemDriver.Controls.Add(LabelReceiveName);
            TitleItemDriver.Controls.Add(LabelName);
            TitleItemDriver.Dock = System.Windows.Forms.DockStyle.Top;
            TitleItemDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TitleItemDriver.ForeColor = System.Drawing.Color.Azure;
            TitleItemDriver.Location = new System.Drawing.Point(0, 0);
            TitleItemDriver.Name = "TitleItemDriver";
            TitleItemDriver.Size = new System.Drawing.Size(355, 67);
            TitleItemDriver.TabIndex = 0;
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
            // LabelReceiveName
            // 
            LabelReceiveName.AutoSize = true;
            LabelReceiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveName.Location = new System.Drawing.Point(90, 33);
            LabelReceiveName.MaximumSize = new System.Drawing.Size(150, 20);
            LabelReceiveName.Name = "LabelReceiveName";
            LabelReceiveName.Size = new System.Drawing.Size(116, 20);
            LabelReceiveName.TabIndex = 1;
            LabelReceiveName.Text = "Felipe Barbosa";
            // 
            // LabelBirthDate
            // 
            LabelBirthDate.AutoSize = true;
            LabelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelBirthDate.Location = new System.Drawing.Point(11, 167);
            LabelBirthDate.Name = "LabelBirthDate";
            LabelBirthDate.Size = new System.Drawing.Size(164, 17);
            LabelBirthDate.TabIndex = 1;
            LabelBirthDate.Text = "Data de Nascimento: ";
            // 
            // LabelCpf
            // 
            LabelCpf.AutoSize = true;
            LabelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelCpf.Location = new System.Drawing.Point(13, 86);
            LabelCpf.Name = "LabelCpf";
            LabelCpf.Size = new System.Drawing.Size(42, 17);
            LabelCpf.TabIndex = 2;
            LabelCpf.Text = "CPF:";
            // 
            // LabelPhone
            // 
            LabelPhone.AutoSize = true;
            LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelPhone.Location = new System.Drawing.Point(13, 114);
            LabelPhone.Name = "LabelPhone";
            LabelPhone.Size = new System.Drawing.Size(82, 17);
            LabelPhone.TabIndex = 3;
            LabelPhone.Text = "Telefone: ";
            // 
            // LabelCnhDue
            // 
            LabelCnhDue.AutoSize = true;
            LabelCnhDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelCnhDue.Location = new System.Drawing.Point(13, 229);
            LabelCnhDue.Name = "LabelCnhDue";
            LabelCnhDue.Size = new System.Drawing.Size(139, 17);
            LabelCnhDue.TabIndex = 4;
            LabelCnhDue.Text = "Vencimento CNH: ";
            // 
            // LabelCnh
            // 
            LabelCnh.AutoSize = true;
            LabelCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelCnh.Location = new System.Drawing.Point(11, 199);
            LabelCnh.Name = "LabelCnh";
            LabelCnh.Size = new System.Drawing.Size(50, 17);
            LabelCnh.TabIndex = 5;
            LabelCnh.Text = "CNH: ";
            // 
            // LabelMail
            // 
            LabelMail.AutoSize = true;
            LabelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelMail.Location = new System.Drawing.Point(13, 142);
            LabelMail.Name = "LabelMail";
            LabelMail.Size = new System.Drawing.Size(53, 17);
            LabelMail.TabIndex = 6;
            LabelMail.Text = "E-Mail";
            // 
            // LabelObservation
            // 
            LabelObservation.AutoSize = true;
            LabelObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelObservation.Location = new System.Drawing.Point(13, 259);
            LabelObservation.Name = "LabelObservation";
            LabelObservation.Size = new System.Drawing.Size(95, 17);
            LabelObservation.TabIndex = 7;
            LabelObservation.Text = "Observação";
            // 
            // LabelReceiveCpf
            // 
            LabelReceiveCpf.AutoSize = true;
            LabelReceiveCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveCpf.Location = new System.Drawing.Point(65, 85);
            LabelReceiveCpf.Name = "LabelReceiveCpf";
            LabelReceiveCpf.Size = new System.Drawing.Size(109, 17);
            LabelReceiveCpf.TabIndex = 8;
            LabelReceiveCpf.Text = "397.327.198-42";
            // 
            // LabelReceivePhone
            // 
            LabelReceivePhone.AutoSize = true;
            LabelReceivePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceivePhone.Location = new System.Drawing.Point(98, 112);
            LabelReceivePhone.Name = "LabelReceivePhone";
            LabelReceivePhone.Size = new System.Drawing.Size(115, 17);
            LabelReceivePhone.TabIndex = 9;
            LabelReceivePhone.Text = "(19) 98316-6632";
            // 
            // LabelReceiveMail
            // 
            LabelReceiveMail.AutoSize = true;
            LabelReceiveMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveMail.Location = new System.Drawing.Point(74, 140);
            LabelReceiveMail.Name = "LabelReceiveMail";
            LabelReceiveMail.Size = new System.Drawing.Size(199, 17);
            LabelReceiveMail.TabIndex = 10;
            LabelReceiveMail.Text = "felipe.goulart1999@gmail.com";
            // 
            // LabelReceiveBirthDate
            // 
            LabelReceiveBirthDate.AutoSize = true;
            LabelReceiveBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveBirthDate.Location = new System.Drawing.Point(176, 168);
            LabelReceiveBirthDate.Name = "LabelReceiveBirthDate";
            LabelReceiveBirthDate.Size = new System.Drawing.Size(80, 17);
            LabelReceiveBirthDate.TabIndex = 11;
            LabelReceiveBirthDate.Text = "19/10/1999";
            // 
            // LAbelReceiveCnh
            // 
            LAbelReceiveCnh.AutoSize = true;
            LAbelReceiveCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LAbelReceiveCnh.Location = new System.Drawing.Point(64, 199);
            LAbelReceiveCnh.Name = "LAbelReceiveCnh";
            LAbelReceiveCnh.Size = new System.Drawing.Size(88, 17);
            LAbelReceiveCnh.TabIndex = 12;
            LAbelReceiveCnh.Text = "257.6844.88";
            // 
            // LabelReceiveCnhDue
            // 
            LabelReceiveCnhDue.AutoSize = true;
            LabelReceiveCnhDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveCnhDue.Location = new System.Drawing.Point(152, 226);
            LabelReceiveCnhDue.Name = "LabelReceiveCnhDue";
            LabelReceiveCnhDue.Size = new System.Drawing.Size(80, 17);
            LabelReceiveCnhDue.TabIndex = 13;
            LabelReceiveCnhDue.Text = "04/06/2022";
            // 
            // LabelReceiveObscervation
            // 
            LabelReceiveObscervation.AutoSize = true;
            LabelReceiveObscervation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveObscervation.Location = new System.Drawing.Point(111, 259);
            LabelReceiveObscervation.Name = "LabelReceiveObscervation";
            LabelReceiveObscervation.Size = new System.Drawing.Size(232, 17);
            LabelReceiveObscervation.TabIndex = 14;
            LabelReceiveObscervation.Text = "Nunca capotou o corsa literalmente";
            // 
            // BorderPanel1
            // 
            BorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel1.Location = new System.Drawing.Point(68, 101);
            BorderPanel1.Name = "BorderPanel1";
            BorderPanel1.Size = new System.Drawing.Size(110, 1);
            BorderPanel1.TabIndex = 15;
            // 
            // BorderPanel2
            // 
            BorderPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel2.Location = new System.Drawing.Point(95, 130);
            BorderPanel2.Name = "BorderPanel2";
            BorderPanel2.Size = new System.Drawing.Size(120, 1);
            BorderPanel2.TabIndex = 16;
            // 
            // BorderPanel3
            // 
            BorderPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel3.Location = new System.Drawing.Point(77, 157);
            BorderPanel3.Name = "BorderPanel3";
            BorderPanel3.Size = new System.Drawing.Size(220, 1);
            BorderPanel3.TabIndex = 17;
            // 
            // BorderPanel4
            // 
            BorderPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel4.Location = new System.Drawing.Point(172, 183);
            BorderPanel4.Name = "BorderPanel4";
            BorderPanel4.Size = new System.Drawing.Size(100, 1);
            BorderPanel4.TabIndex = 18;
            // 
            // BorderPanel5
            // 
            BorderPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel5.Location = new System.Drawing.Point(60, 215);
            BorderPanel5.Name = "BorderPanel5";
            BorderPanel5.Size = new System.Drawing.Size(130, 1);
            BorderPanel5.TabIndex = 19;
            // 
            // BorderPanel6
            // 
            BorderPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel6.Location = new System.Drawing.Point(146, 242);
            BorderPanel6.Name = "BorderPanel6";
            BorderPanel6.Size = new System.Drawing.Size(110, 1);
            BorderPanel6.TabIndex = 20;
            // 
            // BorderPanel7
            // 
            BorderPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            BorderPanel7.Location = new System.Drawing.Point(114, 275);
            BorderPanel7.Name = "BorderPanel7";
            BorderPanel7.Size = new System.Drawing.Size(230, 1);
            BorderPanel7.TabIndex = 21;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            ButtonDelete.BackgroundImage = Properties.Resources.delete;
            ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonDelete.Location = new System.Drawing.Point(313, 14);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new System.Drawing.Size(25, 25);
            ButtonDelete.TabIndex = 108;
            ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ButtonEdit.BackColor = System.Drawing.Color.Teal;
            ButtonEdit.BackgroundImage = Properties.Resources.editNote;
            ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ButtonEdit.FlatAppearance.BorderSize = 0;
            ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonEdit.Location = new System.Drawing.Point(282, 14);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new System.Drawing.Size(25, 25);
            ButtonEdit.TabIndex = 107;
            ButtonEdit.UseVisualStyleBackColor = false;
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
        private Button ButtonDelete;
        private Button ButtonEdit;
    }
}
