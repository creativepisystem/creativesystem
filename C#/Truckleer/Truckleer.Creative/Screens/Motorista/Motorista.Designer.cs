using System.ComponentModel;

namespace Truckleer.Creative
{
    partial class Motorista
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private BackgroundWorker driverWorker;
        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelDriver = new System.Windows.Forms.Panel();
            this.BoxCnhType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.DivPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BorderPanel5 = new System.Windows.Forms.Panel();
            this.BorderPanel4 = new System.Windows.Forms.Panel();
            this.BorderPanel3 = new System.Windows.Forms.Panel();
            this.BorderPanel2 = new System.Windows.Forms.Panel();
            this.BorderPanel1 = new System.Windows.Forms.Panel();
            this.TextObservation = new System.Windows.Forms.TextBox();
            this.DateCnhDue = new System.Windows.Forms.DateTimePicker();
            this.LabelObservation = new System.Windows.Forms.Label();
            this.LabelCnhDue = new System.Windows.Forms.Label();
            this.LabelCnh = new System.Windows.Forms.Label();
            this.TextCnh = new System.Windows.Forms.TextBox();
            this.DateBirthDay = new System.Windows.Forms.DateTimePicker();
            this.LabelBirth = new System.Windows.Forms.Label();
            this.TextPhone = new System.Windows.Forms.TextBox();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.TextCpf = new System.Windows.Forms.TextBox();
            this.LabelCpf = new System.Windows.Forms.Label();
            this.LabelCnhType = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.PageDescription = new System.Windows.Forms.Label();
            this.driverWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelMain.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.PanelDriver.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.PanelMain.Controls.Add(this.ButtonHome);
            this.PanelMain.Controls.Add(this.layoutFlex);
            this.PanelMain.Controls.Add(this.PageDescription);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1220, 990);
            this.PanelMain.TabIndex = 6;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(1116, 5);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(76, 31);
            this.ButtonHome.TabIndex = 43;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            // 
            // layoutFlex
            // 
            this.layoutFlex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutFlex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.layoutFlex.ColumnCount = 1;
            this.layoutFlex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutFlex.Controls.Add(this.MainPanel, 0, 0);
            this.layoutFlex.Location = new System.Drawing.Point(15, 36);
            this.layoutFlex.Margin = new System.Windows.Forms.Padding(0);
            this.layoutFlex.Name = "layoutFlex";
            this.layoutFlex.RowCount = 1;
            this.layoutFlex.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutFlex.Size = new System.Drawing.Size(1191, 924);
            this.layoutFlex.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.PanelContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1191, 924);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelContainer.Controls.Add(this.PanelDriver);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1191, 924);
            this.PanelContainer.TabIndex = 1;
            // 
            // PanelDriver
            // 
            this.PanelDriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDriver.BackColor = System.Drawing.Color.LightGray;
            this.PanelDriver.Controls.Add(this.BoxCnhType);
            this.PanelDriver.Controls.Add(this.panel1);
            this.PanelDriver.Controls.Add(this.TextEmail);
            this.PanelDriver.Controls.Add(this.DivPanel);
            this.PanelDriver.Controls.Add(this.label1);
            this.PanelDriver.Controls.Add(this.BorderPanel5);
            this.PanelDriver.Controls.Add(this.BorderPanel4);
            this.PanelDriver.Controls.Add(this.BorderPanel3);
            this.PanelDriver.Controls.Add(this.BorderPanel2);
            this.PanelDriver.Controls.Add(this.BorderPanel1);
            this.PanelDriver.Controls.Add(this.TextObservation);
            this.PanelDriver.Controls.Add(this.DateCnhDue);
            this.PanelDriver.Controls.Add(this.LabelObservation);
            this.PanelDriver.Controls.Add(this.LabelCnhDue);
            this.PanelDriver.Controls.Add(this.LabelCnh);
            this.PanelDriver.Controls.Add(this.TextCnh);
            this.PanelDriver.Controls.Add(this.DateBirthDay);
            this.PanelDriver.Controls.Add(this.LabelBirth);
            this.PanelDriver.Controls.Add(this.TextPhone);
            this.PanelDriver.Controls.Add(this.LabelPhone);
            this.PanelDriver.Controls.Add(this.TextCpf);
            this.PanelDriver.Controls.Add(this.LabelCpf);
            this.PanelDriver.Controls.Add(this.LabelCnhType);
            this.PanelDriver.Controls.Add(this.TextName);
            this.PanelDriver.Controls.Add(this.LabelName);
            this.PanelDriver.Controls.Add(this.ButtonCancel);
            this.PanelDriver.Controls.Add(this.ButtonSave);
            this.PanelDriver.Controls.Add(this.PanelTitle);
            this.PanelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelDriver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelDriver.Location = new System.Drawing.Point(107, 40);
            this.PanelDriver.Name = "PanelDriver";
            this.PanelDriver.Size = new System.Drawing.Size(970, 589);
            this.PanelDriver.TabIndex = 0;
            // 
            // BoxCnhType
            // 
            this.BoxCnhType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.BoxCnhType.BackColor = System.Drawing.Color.LightGray;
            this.BoxCnhType.ForeColor = System.Drawing.Color.Black;
            this.BoxCnhType.FormattingEnabled = true;
            this.BoxCnhType.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "C",
            "D",
            "E"});
            this.BoxCnhType.Location = new System.Drawing.Point(659, 267);
            this.BoxCnhType.Name = "BoxCnhType";
            this.BoxCnhType.Size = new System.Drawing.Size(190, 28);
            this.BoxCnhType.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(602, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 2);
            this.panel1.TabIndex = 93;
            // 
            // TextEmail
            // 
            this.TextEmail.BackColor = System.Drawing.Color.LightGray;
            this.TextEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextEmail.Location = new System.Drawing.Point(602, 335);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(242, 19);
            this.TextEmail.TabIndex = 92;
            // 
            // DivPanel
            // 
            this.DivPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DivPanel.Location = new System.Drawing.Point(466, 126);
            this.DivPanel.Name = "DivPanel";
            this.DivPanel.Size = new System.Drawing.Size(2, 343);
            this.DivPanel.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(529, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "E-Mail";
            // 
            // BorderPanel5
            // 
            this.BorderPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BorderPanel5.Location = new System.Drawing.Point(659, 296);
            this.BorderPanel5.Name = "BorderPanel5";
            this.BorderPanel5.Size = new System.Drawing.Size(190, 2);
            this.BorderPanel5.TabIndex = 90;
            // 
            // BorderPanel4
            // 
            this.BorderPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BorderPanel4.Location = new System.Drawing.Point(603, 236);
            this.BorderPanel4.Name = "BorderPanel4";
            this.BorderPanel4.Size = new System.Drawing.Size(241, 2);
            this.BorderPanel4.TabIndex = 88;
            // 
            // BorderPanel3
            // 
            this.BorderPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BorderPanel3.Location = new System.Drawing.Point(202, 356);
            this.BorderPanel3.Name = "BorderPanel3";
            this.BorderPanel3.Size = new System.Drawing.Size(204, 2);
            this.BorderPanel3.TabIndex = 89;
            // 
            // BorderPanel2
            // 
            this.BorderPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BorderPanel2.Location = new System.Drawing.Point(202, 292);
            this.BorderPanel2.Name = "BorderPanel2";
            this.BorderPanel2.Size = new System.Drawing.Size(204, 2);
            this.BorderPanel2.TabIndex = 88;
            // 
            // BorderPanel1
            // 
            this.BorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BorderPanel1.Location = new System.Drawing.Point(202, 231);
            this.BorderPanel1.Name = "BorderPanel1";
            this.BorderPanel1.Size = new System.Drawing.Size(204, 2);
            this.BorderPanel1.TabIndex = 87;
            // 
            // TextObservation
            // 
            this.TextObservation.Location = new System.Drawing.Point(110, 420);
            this.TextObservation.Multiline = true;
            this.TextObservation.Name = "TextObservation";
            this.TextObservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextObservation.Size = new System.Drawing.Size(296, 139);
            this.TextObservation.TabIndex = 85;
            // 
            // DateCnhDue
            // 
            this.DateCnhDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateCnhDue.Location = new System.Drawing.Point(707, 144);
            this.DateCnhDue.Name = "DateCnhDue";
            this.DateCnhDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateCnhDue.RightToLeftLayout = true;
            this.DateCnhDue.Size = new System.Drawing.Size(138, 26);
            this.DateCnhDue.TabIndex = 86;
            // 
            // LabelObservation
            // 
            this.LabelObservation.AutoSize = true;
            this.LabelObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelObservation.ForeColor = System.Drawing.Color.Gray;
            this.LabelObservation.Location = new System.Drawing.Point(106, 397);
            this.LabelObservation.Name = "LabelObservation";
            this.LabelObservation.Size = new System.Drawing.Size(104, 20);
            this.LabelObservation.TabIndex = 83;
            this.LabelObservation.Text = "Observação";
            // 
            // LabelCnhDue
            // 
            this.LabelCnhDue.AutoSize = true;
            this.LabelCnhDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCnhDue.ForeColor = System.Drawing.Color.Gray;
            this.LabelCnhDue.Location = new System.Drawing.Point(530, 144);
            this.LabelCnhDue.Name = "LabelCnhDue";
            this.LabelCnhDue.Size = new System.Drawing.Size(146, 20);
            this.LabelCnhDue.TabIndex = 84;
            this.LabelCnhDue.Text = "Vencimento CNH";
            // 
            // LabelCnh
            // 
            this.LabelCnh.AutoSize = true;
            this.LabelCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCnh.ForeColor = System.Drawing.Color.Gray;
            this.LabelCnh.Location = new System.Drawing.Point(530, 213);
            this.LabelCnh.Margin = new System.Windows.Forms.Padding(0);
            this.LabelCnh.Name = "LabelCnh";
            this.LabelCnh.Size = new System.Drawing.Size(46, 20);
            this.LabelCnh.TabIndex = 81;
            this.LabelCnh.Text = "CNH";
            // 
            // TextCnh
            // 
            this.TextCnh.BackColor = System.Drawing.Color.LightGray;
            this.TextCnh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextCnh.Location = new System.Drawing.Point(603, 215);
            this.TextCnh.Name = "TextCnh";
            this.TextCnh.Size = new System.Drawing.Size(242, 19);
            this.TextCnh.TabIndex = 82;
            // 
            // DateBirthDay
            // 
            this.DateBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBirthDay.Location = new System.Drawing.Point(271, 144);
            this.DateBirthDay.Name = "DateBirthDay";
            this.DateBirthDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateBirthDay.RightToLeftLayout = true;
            this.DateBirthDay.Size = new System.Drawing.Size(135, 26);
            this.DateBirthDay.TabIndex = 80;
            // 
            // LabelBirth
            // 
            this.LabelBirth.AutoSize = true;
            this.LabelBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBirth.ForeColor = System.Drawing.Color.Gray;
            this.LabelBirth.Location = new System.Drawing.Point(106, 144);
            this.LabelBirth.Name = "LabelBirth";
            this.LabelBirth.Size = new System.Drawing.Size(147, 20);
            this.LabelBirth.TabIndex = 79;
            this.LabelBirth.Text = "Data Nascimento";
            // 
            // TextPhone
            // 
            this.TextPhone.BackColor = System.Drawing.Color.LightGray;
            this.TextPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPhone.Location = new System.Drawing.Point(202, 335);
            this.TextPhone.Name = "TextPhone";
            this.TextPhone.Size = new System.Drawing.Size(204, 19);
            this.TextPhone.TabIndex = 76;
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhone.ForeColor = System.Drawing.Color.Gray;
            this.LabelPhone.Location = new System.Drawing.Point(106, 338);
            this.LabelPhone.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(79, 20);
            this.LabelPhone.TabIndex = 75;
            this.LabelPhone.Text = "Telefone";
            // 
            // TextCpf
            // 
            this.TextCpf.BackColor = System.Drawing.Color.LightGray;
            this.TextCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextCpf.Location = new System.Drawing.Point(202, 271);
            this.TextCpf.Name = "TextCpf";
            this.TextCpf.Size = new System.Drawing.Size(204, 19);
            this.TextCpf.TabIndex = 74;
            // 
            // LabelCpf
            // 
            this.LabelCpf.AutoSize = true;
            this.LabelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCpf.ForeColor = System.Drawing.Color.Gray;
            this.LabelCpf.Location = new System.Drawing.Point(106, 272);
            this.LabelCpf.Margin = new System.Windows.Forms.Padding(0);
            this.LabelCpf.Name = "LabelCpf";
            this.LabelCpf.Size = new System.Drawing.Size(43, 20);
            this.LabelCpf.TabIndex = 73;
            this.LabelCpf.Text = "CPF";
            // 
            // LabelCnhType
            // 
            this.LabelCnhType.AutoSize = true;
            this.LabelCnhType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCnhType.ForeColor = System.Drawing.Color.Gray;
            this.LabelCnhType.Location = new System.Drawing.Point(530, 278);
            this.LabelCnhType.Margin = new System.Windows.Forms.Padding(0);
            this.LabelCnhType.Name = "LabelCnhType";
            this.LabelCnhType.Size = new System.Drawing.Size(110, 20);
            this.LabelCnhType.TabIndex = 77;
            this.LabelCnhType.Text = "Tipo da CNH";
            // 
            // TextName
            // 
            this.TextName.BackColor = System.Drawing.Color.LightGray;
            this.TextName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextName.Location = new System.Drawing.Point(202, 210);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(204, 19);
            this.TextName.TabIndex = 72;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.Gray;
            this.LabelName.Location = new System.Drawing.Point(106, 209);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(55, 20);
            this.LabelName.TabIndex = 71;
            this.LabelName.Text = "Nome";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonCancel.FlatAppearance.BorderSize = 2;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonCancel.Location = new System.Drawing.Point(818, 524);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(97, 32);
            this.ButtonCancel.TabIndex = 70;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.FlatAppearance.BorderSize = 0;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.Azure;
            this.ButtonSave.Location = new System.Drawing.Point(707, 524);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 32);
            this.ButtonSave.TabIndex = 69;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PanelTitle.Controls.Add(this.title);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(970, 87);
            this.PanelTitle.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Azure;
            this.title.Location = new System.Drawing.Point(35, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(380, 48);
            this.title.TabIndex = 41;
            this.title.Text = "Cadastro de Motorista";
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(854, 5);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(268, 31);
            this.PageDescription.TabIndex = 42;
            this.PageDescription.Text = "Cadastrar Motorista /";
            // 
            // driverWorker
            // 
            this.driverWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SaveDriver);
            this.driverWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SaveDriverFinish);
            // 
            // Motorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.PanelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Motorista";
            this.Size = new System.Drawing.Size(1220, 990);
            this.Load += new System.EventHandler(this.Motorista_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelDriver.ResumeLayout(false);
            this.PanelDriver.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelDriver;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.TextBox TextObservation;
        private System.Windows.Forms.DateTimePicker DateCnhDue;
        private System.Windows.Forms.Label LabelObservation;
        private System.Windows.Forms.Label LabelCnhDue;
        private System.Windows.Forms.Label LabelCnh;
        private System.Windows.Forms.TextBox TextCnh;
        private System.Windows.Forms.DateTimePicker DateBirthDay;
        private System.Windows.Forms.Label LabelBirth;
        private System.Windows.Forms.TextBox TextPhone;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.TextBox TextCpf;
        private System.Windows.Forms.Label LabelCpf;
        private System.Windows.Forms.Label LabelCnhType;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel BorderPanel3;
        private System.Windows.Forms.Panel BorderPanel2;
        private System.Windows.Forms.Panel BorderPanel1;
        private System.Windows.Forms.Panel BorderPanel5;
        private System.Windows.Forms.Panel BorderPanel4;
        private System.Windows.Forms.Panel DivPanel;
        private System.Windows.Forms.ComboBox BoxCnhType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.Label label1;
    }
}
