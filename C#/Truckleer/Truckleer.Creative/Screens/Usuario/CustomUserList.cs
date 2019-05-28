using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative.Screens.Usuario
{
    class CustomUserList : Panel
    {
        readonly int index = 0;

        readonly User user;


        public CustomUserList(int index, User user)
        {
            this.index = index;
            ItemListDriver = new Panel();
            BorderPanel2 = new Panel();
            BorderPanel1 = new Panel();
            LabelReceiveMail = new Label();
            LabelReceiveUser = new Label();
            LabelVehicle = new Label();
            LabelDate = new Label();
            TitleItemDriver = new Panel();
            LabelName = new Label();
            ButtonDelete = new Button();
            ButtonEdit = new Button();
            SuspendLayout();
            TitleItemDriver.SuspendLayout();
            SuspendLayout();
            this.user = user;

            InitializeUserList();
        }

        public void InitializeUserList()
        {
            // 
            // ItemListDriver
            // 
            BackColor = System.Drawing.Color.LightGray;
            Controls.Add(BorderPanel2);
            Controls.Add(BorderPanel1);
            Controls.Add(LabelReceiveMail);
            Controls.Add(LabelReceiveUser);
            Controls.Add(LabelVehicle);
            Controls.Add(LabelDate);
            Controls.Add(TitleItemDriver);
            Location = new System.Drawing.Point(126, 41);
            Margin = new Padding(10, 20, 5, 0);
            Name = "ItemListDriver";
            Size = new System.Drawing.Size(355, 176);
            TabIndex = 2;
            // 
            // BorderPanel2
            // 
            BorderPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            BorderPanel2.Location = new System.Drawing.Point(88, 143);
            BorderPanel2.Name = "BorderPanel2";
            BorderPanel2.Size = new System.Drawing.Size(190, 1);
            BorderPanel2.TabIndex = 16;
            // 
            // BorderPanel1
            // 
            BorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            BorderPanel1.Location = new System.Drawing.Point(88, 102);
            BorderPanel1.Name = "BorderPanel1";
            BorderPanel1.Size = new System.Drawing.Size(190, 1);
            BorderPanel1.TabIndex = 15;
            // 
            // LabelReceiveMail
            // 
            LabelReceiveMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveMail.Location = new System.Drawing.Point(88, 125);
            LabelReceiveMail.Name = "LabelReceiveMail";
            LabelReceiveMail.Size = new System.Drawing.Size(190, 19);
            LabelReceiveMail.TabIndex = 9;
            LabelReceiveMail.Text = user.Email;
            LabelReceiveMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveUser
            // 
            LabelReceiveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveUser.Location = new System.Drawing.Point(88, 86);
            LabelReceiveUser.Name = "LabelReceiveUser";
            LabelReceiveUser.Size = new System.Drawing.Size(187, 17);
            LabelReceiveUser.TabIndex = 8;
            LabelReceiveUser.Text = user.Login;
            LabelReceiveUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelVehicle
            // 
            LabelVehicle.AutoSize = true;
            LabelVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelVehicle.Location = new System.Drawing.Point(13, 127);
            LabelVehicle.Name = "LabelVehicle";
            LabelVehicle.Size = new System.Drawing.Size(53, 17);
            LabelVehicle.TabIndex = 3;
            LabelVehicle.Text = "E-Mail";
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelDate.Location = new System.Drawing.Point(13, 86);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new System.Drawing.Size(69, 17);
            LabelDate.TabIndex = 2;
            LabelDate.Text = "Usuário:";
            // 
            // TitleItemDriver
            // 
            TitleItemDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            TitleItemDriver.Controls.Add(ButtonDelete);
            TitleItemDriver.Controls.Add(ButtonEdit);
            TitleItemDriver.Controls.Add(LabelName);
            TitleItemDriver.Dock = DockStyle.Top;
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
            LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelName.Location = new System.Drawing.Point(86, 11);
            LabelName.Name = "LabelName";
            LabelName.Size = new System.Drawing.Size(160, 46);
            LabelName.TabIndex = 0;
            LabelName.Text = "TexLog";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            ButtonDelete.BackgroundImage = Properties.Resources.delete;
            ButtonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Location = new System.Drawing.Point(310, 18);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new System.Drawing.Size(25, 25);
            ButtonDelete.TabIndex = 110;
            ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            ButtonEdit.BackColor = System.Drawing.Color.Teal;
            ButtonEdit.BackgroundImage = Properties.Resources.editNote;
            ButtonEdit.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonEdit.FlatAppearance.BorderSize = 0;
            ButtonEdit.FlatStyle = FlatStyle.Flat;
            ButtonEdit.Location = new System.Drawing.Point(278, 18);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new System.Drawing.Size(25, 25);
            ButtonEdit.TabIndex = 109;
            ButtonEdit.UseVisualStyleBackColor = false;
        }

        private readonly Panel ItemListDriver;
        private Panel BorderPanel2;
        private Panel BorderPanel1;
        private Label LabelReceiveMail;
        private Label LabelReceiveUser;
        private Label LabelVehicle;
        private Label LabelDate;
        private Panel TitleItemDriver;
        private Button ButtonDelete;
        private Button ButtonEdit;
        private Label LabelName;
    }
}