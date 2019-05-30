using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative.Screens.Despesas
{
    class CustomExpenseList : Panel
    {
        //index - necessario
        readonly int index = 0;

        //Exemplo para classe Usuario
        readonly Expense expense;

        public CustomExpenseList(int index, Expense expense)
        {
            ItemListDriver = new Panel();
            LabelReceiveData = new Label();
            LabelreceiveDriver = new Label();
            LabelReceiveTrip = new Label();
            LabelReceiveObs = new Label();
            panel4 = new Panel();
            LabelReceivePrice = new Label();
            LabelPrice = new Label();
            panel3 = new Panel();
            LabelObservation = new Label();
            panel1 = new Panel();
            BorderPanel3 = new Panel();
            BorderPanel1 = new Panel();
            LabelDriver = new Label();
            LabelDate = new Label();
            LabelRoute = new Label();
            TitleItemDriver = new Panel();
            ButtonDelete = new Button();
            ButtonEdit = new Button();
            LabelReceiveName = new Label();
            LabelName = new Label();
            SuspendLayout();
            TitleItemDriver.SuspendLayout();
            SuspendLayout();

            //Seta o Usuario
            this.expense = expense;
            InitializeCustomList();
        }

        private void InitializeCustomList()
        {
            // 
            // ItemListDriver
            // 
            BackColor = System.Drawing.Color.LightGray;
            Controls.Add(LabelReceiveData);
            Controls.Add(LabelObservation);
            Controls.Add(panel3);
            Controls.Add(LabelreceiveDriver);
            Controls.Add(LabelReceiveObs);
            Controls.Add(LabelReceiveTrip);
            Controls.Add(panel1);
            Controls.Add(LabelPrice);
            Controls.Add(panel4);
            Controls.Add(BorderPanel3);
            Controls.Add(LabelReceivePrice);
            Controls.Add(BorderPanel1);
            Controls.Add(LabelDriver);
            Controls.Add(LabelDate);
            Controls.Add(LabelRoute);
            Controls.Add(TitleItemDriver);
            Location = new System.Drawing.Point(186, 46);
            Margin = new Padding(10, 20, 5, 0);
            Name = "ItemListDriver";
            Size = new System.Drawing.Size(355, 278);
            TabIndex = 2;
            // 
            // LabelReceiveData
            // 
            LabelReceiveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveData.Location = new System.Drawing.Point(67, 74);
            LabelReceiveData.Name = "LabelReceiveData";
            LabelReceiveData.Size = new System.Drawing.Size(111, 20);
            LabelReceiveData.TabIndex = 126;
            LabelReceiveData.Text = expense.Date.ToShortDateString();
            LabelReceiveData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelreceiveDriver
            // 
            LabelreceiveDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelreceiveDriver.Location = new System.Drawing.Point(94, 116);
            LabelreceiveDriver.Name = "LabelreceiveDriver";
            LabelreceiveDriver.Size = new System.Drawing.Size(230, 20);
            LabelreceiveDriver.TabIndex = 124;
            LabelreceiveDriver.Text = expense.Driver.Name;
            LabelreceiveDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveTrip
            // 
            LabelReceiveTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveTrip.Location = new System.Drawing.Point(85, 153);
            LabelReceiveTrip.Name = "LabelReceiveTrip";
            LabelReceiveTrip.Size = new System.Drawing.Size(227, 20);
            LabelReceiveTrip.TabIndex = 123;
            LabelReceiveTrip.Text = expense.Trip.Name;
            LabelReceiveTrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveObs
            // 
            LabelReceiveObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveObs.Location = new System.Drawing.Point(117, 237);
            LabelReceiveObs.Name = "LabelReceiveObs";
            LabelReceiveObs.Size = new System.Drawing.Size(189, 20);
            LabelReceiveObs.TabIndex = 121;
            LabelReceiveObs.Text = expense.Obs.ToString() ?? "-";
            LabelReceiveObs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            panel4.Location = new System.Drawing.Point(95, 214);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(150, 1);
            panel4.TabIndex = 120;
            // 
            // LabelReceivePrice
            // 
            LabelReceivePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceivePrice.Location = new System.Drawing.Point(98, 195);
            LabelReceivePrice.Name = "LabelReceivePrice";
            LabelReceivePrice.Size = new System.Drawing.Size(144, 20);
            LabelReceivePrice.TabIndex = 119;
            LabelReceivePrice.Text = expense.Value.ToString();
            LabelReceivePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrice
            // 
            LabelPrice.AutoSize = true;
            LabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelPrice.Location = new System.Drawing.Point(13, 198);
            LabelPrice.Name = "LabelPrice";
            LabelPrice.Size = new System.Drawing.Size(55, 17);
            LabelPrice.TabIndex = 118;
            LabelPrice.Text = "Preço:";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            panel3.Location = new System.Drawing.Point(116, 258);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(190, 1);
            panel3.TabIndex = 117;
            // 
            // LabelObservation
            // 
            LabelObservation.AutoSize = true;
            LabelObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelObservation.Location = new System.Drawing.Point(11, 243);
            LabelObservation.Name = "LabelObservation";
            LabelObservation.Size = new System.Drawing.Size(100, 17);
            LabelObservation.TabIndex = 115;
            LabelObservation.Text = "Obesrvação:";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            panel1.Location = new System.Drawing.Point(82, 174);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(230, 1);
            panel1.TabIndex = 20;
            // 
            // BorderPanel3
            // 
            BorderPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            BorderPanel3.Location = new System.Drawing.Point(94, 137);
            BorderPanel3.Name = "BorderPanel3";
            BorderPanel3.Size = new System.Drawing.Size(230, 1);
            BorderPanel3.TabIndex = 18;
            // 
            // BorderPanel1
            // 
            BorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            BorderPanel1.Location = new System.Drawing.Point(68, 94);
            BorderPanel1.Name = "BorderPanel1";
            BorderPanel1.Size = new System.Drawing.Size(110, 1);
            BorderPanel1.TabIndex = 15;
            // 
            // LabelDriver
            // 
            LabelDriver.AutoSize = true;
            LabelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelDriver.Location = new System.Drawing.Point(11, 122);
            LabelDriver.Name = "LabelDriver";
            LabelDriver.Size = new System.Drawing.Size(80, 17);
            LabelDriver.TabIndex = 6;
            LabelDriver.Text = "Motorista:";
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelDate.Location = new System.Drawing.Point(13, 79);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new System.Drawing.Size(47, 17);
            LabelDate.TabIndex = 2;
            LabelDate.Text = "Data:";
            // 
            // LabelRoute
            // 
            LabelRoute.AutoSize = true;
            LabelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelRoute.Location = new System.Drawing.Point(11, 159);
            LabelRoute.Name = "LabelRoute";
            LabelRoute.Size = new System.Drawing.Size(66, 17);
            LabelRoute.TabIndex = 1;
            LabelRoute.Text = "Viagem:";
            // 
            // TitleItemDriver
            // 
            TitleItemDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            TitleItemDriver.Controls.Add(ButtonDelete);
            TitleItemDriver.Controls.Add(ButtonEdit);
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
            // 
            // LabelReceiveName
            // 
            LabelReceiveName.AutoSize = true;
            LabelReceiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveName.Location = new System.Drawing.Point(107, 32);
            LabelReceiveName.Name = "LabelReceiveName";
            LabelReceiveName.Size = new System.Drawing.Size(115, 20);
            LabelReceiveName.TabIndex = 1;
            LabelReceiveName.Text = "Despesa Hotel";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelName.Location = new System.Drawing.Point(9, 27);
            LabelName.Name = "LabelName";
            LabelName.Size = new System.Drawing.Size(104, 25);
            LabelName.TabIndex = 0;
            LabelName.Text = "Despesa:";
        }

        private readonly Panel ItemListDriver;
        private Panel panel4;
        private Label LabelReceivePrice;
        private Label LabelPrice;
        private Panel panel3;
        private Label LabelObservation;
        private Panel panel1;
        private Panel BorderPanel3;
        private Panel BorderPanel1;
        private Label LabelDriver;
        private Label LabelDate;
        private Label LabelRoute;
        private Panel TitleItemDriver;
        private Button ButtonDelete;
        private Button ButtonEdit;
        private Label LabelReceiveName;
        private Label LabelName;
        private Label LabelReceiveData;
        private Label LabelreceiveDriver;
        private Label LabelReceiveTrip;
        private Label LabelReceiveObs;
    }
}