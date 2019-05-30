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
            this.index = index;
            this.ItemListDriver = new Panel();
            this.panel2 = new Panel();
            this.LabelStatus = new Label();
            this.panel1 = new Panel();
            this.BorderPanel3 = new Panel();
            this.BorderPanel2 = new Panel();
            this.BorderPanel1 = new Panel();
            this.LabelDriver = new Label();
            this.LabelVehicle = new Label();
            this.LabelDate = new Label();
            this.LabelRoute = new Label();
            this.TitleItemDriver = new Panel();
            this.ButtonDelete = new Button();
            this.ButtonEdit = new Button();
            this.LabelReceiveName = new Label();
            this.LabelName = new Label();
            this.panel3 = new Panel();
            this.LabelObservation = new Label();
            this.panel4 = new Panel();
            this.LabelReceivePrice = new Label();
            this.LabelPrice = new Label();
            this.LabelReceiveObs = new Label();
            this.LabelReceiveStatus = new Label();
            this.LabelReceiveTrip = new Label();
            this.LabelreceiveDriver = new Label();
            this.LabelReceiveVehicle = new Label();
            this.LabelReceiveData = new Label();
            this.ItemListDriver.SuspendLayout();
            this.TitleItemDriver.SuspendLayout();
            this.SuspendLayout();

            //Seta o Usuario
            this.expense = expense;
            InitializeCustomList();
        }

        private void InitializeCustomList()
        {
            // 
            // ItemListDriver
            // 
            this.ItemListDriver.BackColor = System.Drawing.Color.LightGray;
            this.ItemListDriver.Controls.Add(this.LabelReceiveData);
            this.ItemListDriver.Controls.Add(this.LabelReceiveVehicle);
            this.ItemListDriver.Controls.Add(this.LabelreceiveDriver);
            this.ItemListDriver.Controls.Add(this.LabelReceiveTrip);
            this.ItemListDriver.Controls.Add(this.LabelReceiveStatus);
            this.ItemListDriver.Controls.Add(this.LabelReceiveObs);
            this.ItemListDriver.Controls.Add(this.panel4);
            this.ItemListDriver.Controls.Add(this.LabelReceivePrice);
            this.ItemListDriver.Controls.Add(this.LabelPrice);
            this.ItemListDriver.Controls.Add(this.panel3);
            this.ItemListDriver.Controls.Add(this.LabelObservation);
            this.ItemListDriver.Controls.Add(this.panel2);
            this.ItemListDriver.Controls.Add(this.LabelStatus);
            this.ItemListDriver.Controls.Add(this.panel1);
            this.ItemListDriver.Controls.Add(this.BorderPanel3);
            this.ItemListDriver.Controls.Add(this.BorderPanel2);
            this.ItemListDriver.Controls.Add(this.BorderPanel1);
            this.ItemListDriver.Controls.Add(this.LabelDriver);
            this.ItemListDriver.Controls.Add(this.LabelVehicle);
            this.ItemListDriver.Controls.Add(this.LabelDate);
            this.ItemListDriver.Controls.Add(this.LabelRoute);
            this.ItemListDriver.Controls.Add(this.TitleItemDriver);
            this.ItemListDriver.Location = new System.Drawing.Point(186, 46);
            this.ItemListDriver.Margin = new Padding(10, 20, 5, 0);
            this.ItemListDriver.Name = "ItemListDriver";
            this.ItemListDriver.Size = new System.Drawing.Size(355, 362);
            this.ItemListDriver.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(74, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 1);
            this.panel2.TabIndex = 114;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(11, 230);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(59, 17);
            this.LabelStatus.TabIndex = 112;
            this.LabelStatus.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(82, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 20;
            // 
            // BorderPanel3
            // 
            this.BorderPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BorderPanel3.Location = new System.Drawing.Point(94, 171);
            this.BorderPanel3.Name = "BorderPanel3";
            this.BorderPanel3.Size = new System.Drawing.Size(230, 1);
            this.BorderPanel3.TabIndex = 18;
            // 
            // BorderPanel2
            // 
            this.BorderPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BorderPanel2.Location = new System.Drawing.Point(95, 136);
            this.BorderPanel2.Name = "BorderPanel2";
            this.BorderPanel2.Size = new System.Drawing.Size(100, 1);
            this.BorderPanel2.TabIndex = 16;
            // 
            // BorderPanel1
            // 
            this.BorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BorderPanel1.Location = new System.Drawing.Point(68, 94);
            this.BorderPanel1.Name = "BorderPanel1";
            this.BorderPanel1.Size = new System.Drawing.Size(110, 1);
            this.BorderPanel1.TabIndex = 15;
            // 
            // LabelDriver
            // 
            this.LabelDriver.AutoSize = true;
            this.LabelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDriver.Location = new System.Drawing.Point(11, 156);
            this.LabelDriver.Name = "LabelDriver";
            this.LabelDriver.Size = new System.Drawing.Size(80, 17);
            this.LabelDriver.TabIndex = 6;
            this.LabelDriver.Text = "Motorista:";
            // 
            // LabelVehicle
            // 
            this.LabelVehicle.AutoSize = true;
            this.LabelVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicle.Location = new System.Drawing.Point(13, 120);
            this.LabelVehicle.Name = "LabelVehicle";
            this.LabelVehicle.Size = new System.Drawing.Size(71, 17);
            this.LabelVehicle.TabIndex = 3;
            this.LabelVehicle.Text = "Veículo: ";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(13, 79);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(47, 17);
            this.LabelDate.TabIndex = 2;
            this.LabelDate.Text = "Data:";
            // 
            // LabelRoute
            // 
            this.LabelRoute.AutoSize = true;
            this.LabelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoute.Location = new System.Drawing.Point(11, 193);
            this.LabelRoute.Name = "LabelRoute";
            this.LabelRoute.Size = new System.Drawing.Size(66, 17);
            this.LabelRoute.TabIndex = 1;
            this.LabelRoute.Text = "Viagem:";
            // 
            // TitleItemDriver
            // 
            this.TitleItemDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TitleItemDriver.Controls.Add(this.ButtonDelete);
            this.TitleItemDriver.Controls.Add(this.ButtonEdit);
            this.TitleItemDriver.Controls.Add(this.LabelReceiveName);
            this.TitleItemDriver.Controls.Add(this.LabelName);
            this.TitleItemDriver.Dock = DockStyle.Top;
            this.TitleItemDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleItemDriver.ForeColor = System.Drawing.Color.Azure;
            this.TitleItemDriver.Location = new System.Drawing.Point(0, 0);
            this.TitleItemDriver.Name = "TitleItemDriver";
            this.TitleItemDriver.Size = new System.Drawing.Size(355, 67);
            this.TitleItemDriver.TabIndex = 0;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            this.ButtonDelete.BackgroundImage = Properties.Resources.delete;
            this.ButtonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = FlatStyle.Flat;
            this.ButtonDelete.Location = new System.Drawing.Point(310, 18);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(25, 25);
            this.ButtonDelete.TabIndex = 110;
            this.ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.ButtonEdit.BackColor = System.Drawing.Color.Teal;
            this.ButtonEdit.BackgroundImage = Properties.Resources.editNote;
            this.ButtonEdit.BackgroundImageLayout = ImageLayout.Stretch;
            this.ButtonEdit.FlatAppearance.BorderSize = 0;
            this.ButtonEdit.FlatStyle = FlatStyle.Flat;
            this.ButtonEdit.Location = new System.Drawing.Point(278, 18);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(25, 25);
            this.ButtonEdit.TabIndex = 109;
            this.ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // LabelReceiveName
            // 
            this.LabelReceiveName.AutoSize = true;
            this.LabelReceiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReceiveName.Location = new System.Drawing.Point(107, 32);
            this.LabelReceiveName.Name = "LabelReceiveName";
            this.LabelReceiveName.Size = new System.Drawing.Size(115, 20);
            this.LabelReceiveName.TabIndex = 1;
            this.LabelReceiveName.Text = "Despesa Hotel";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(9, 27);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(104, 25);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Despesa:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(116, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 1);
            this.panel3.TabIndex = 117;
            // 
            // LabelObservation
            // 
            this.LabelObservation.AutoSize = true;
            this.LabelObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelObservation.Location = new System.Drawing.Point(11, 270);
            this.LabelObservation.Name = "LabelObservation";
            this.LabelObservation.Size = new System.Drawing.Size(100, 17);
            this.LabelObservation.TabIndex = 115;
            this.LabelObservation.Text = "Obesrvação:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(95, 324);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 1);
            this.panel4.TabIndex = 120;
            // 
            // LabelReceivePrice
            // 
            this.LabelReceivePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReceivePrice.Location = new System.Drawing.Point(98, 305);
            this.LabelReceivePrice.Name = "LabelReceivePrice";
            this.LabelReceivePrice.Size = new System.Drawing.Size(144, 20);
            this.LabelReceivePrice.TabIndex = 119;
            this.LabelReceivePrice.Text = "R$ 300.00";
            this.LabelReceivePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.Location = new System.Drawing.Point(13, 308);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(55, 17);
            this.LabelPrice.TabIndex = 118;
            this.LabelPrice.Text = "Preço:";
            // 
            // LabelReceiveObs
            // 
            this.LabelReceiveObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReceiveObs.Location = new System.Drawing.Point(117, 264);
            this.LabelReceiveObs.Name = "LabelReceiveObs";
            this.LabelReceiveObs.Size = new System.Drawing.Size(189, 20);
            this.LabelReceiveObs.TabIndex = 121;
            this.LabelReceiveObs.Text = "Gasto Necessário";
            this.LabelReceiveObs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveStatus
            // 
            this.LabelReceiveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReceiveStatus.Location = new System.Drawing.Point(76, 225);
            this.LabelReceiveStatus.Name = "LabelReceiveStatus";
            this.LabelReceiveStatus.Size = new System.Drawing.Size(188, 20);
            this.LabelReceiveStatus.TabIndex = 122;
            this.LabelReceiveStatus.Text = "ABERTA";
            this.LabelReceiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveTrip
            // 
            this.LabelReceiveTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReceiveTrip.Location = new System.Drawing.Point(85, 187);
            this.LabelReceiveTrip.Name = "LabelReceiveTrip";
            this.LabelReceiveTrip.Size = new System.Drawing.Size(227, 20);
            this.LabelReceiveTrip.TabIndex = 123;
            this.LabelReceiveTrip.Text = "Viagem 1";
            this.LabelReceiveTrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelreceiveDriver
            // 
            this.LabelreceiveDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelreceiveDriver.Location = new System.Drawing.Point(94, 150);
            this.LabelreceiveDriver.Name = "LabelreceiveDriver";
            this.LabelreceiveDriver.Size = new System.Drawing.Size(230, 20);
            this.LabelreceiveDriver.TabIndex = 124;
            this.LabelreceiveDriver.Text = "Felipe Barbosa Goulart";
            this.LabelreceiveDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveVehicle
            // 
            this.LabelReceiveVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReceiveVehicle.Location = new System.Drawing.Point(98, 115);
            this.LabelReceiveVehicle.Name = "LabelReceiveVehicle";
            this.LabelReceiveVehicle.Size = new System.Drawing.Size(97, 20);
            this.LabelReceiveVehicle.TabIndex = 125;
            this.LabelReceiveVehicle.Text = "XXX0000";
            this.LabelReceiveVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveData
            // 
            this.LabelReceiveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReceiveData.Location = new System.Drawing.Point(67, 74);
            this.LabelReceiveData.Name = "LabelReceiveData";
            this.LabelReceiveData.Size = new System.Drawing.Size(111, 20);
            this.LabelReceiveData.TabIndex = 126;
            this.LabelReceiveData.Text = "24/05/2019";
            this.LabelReceiveData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private Panel ItemListDriver;
        private Panel panel4;
        private Label LabelReceivePrice;
        private Label LabelPrice;
        private Panel panel3;
        private Label LabelObservation;
        private Panel panel2;
        private Label LabelStatus;
        private Panel panel1;
        private Panel BorderPanel3;
        private Panel BorderPanel2;
        private Panel BorderPanel1;
        private Label LabelDriver;
        private Label LabelVehicle;
        private Label LabelDate;
        private Label LabelRoute;
        private Panel TitleItemDriver;
        private Button ButtonDelete;
        private Button ButtonEdit;
        private Label LabelReceiveName;
        private Label LabelName;
        private Label LabelReceiveData;
        private Label LabelReceiveVehicle;
        private Label LabelreceiveDriver;
        private Label LabelReceiveTrip;
        private Label LabelReceiveStatus;
        private Label LabelReceiveObs;
    }
}