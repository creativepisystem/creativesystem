namespace Truckleer.Creative
{
    partial class Viagens
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelCadastro = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BorderPanel1 = new System.Windows.Forms.Panel();
            this.BoxVehicle = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.BoxRoute = new System.Windows.Forms.ComboBox();
            this.BoxDriver = new System.Windows.Forms.ComboBox();
            this.labelRouteSupplpy = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLitrosSupply = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.labelDataSupply = new System.Windows.Forms.Label();
            this.driverWorker = new System.ComponentModel.BackgroundWorker();
            this.routeWorker = new System.ComponentModel.BackgroundWorker();
            this.vehicleWorker = new System.ComponentModel.BackgroundWorker();
            this.tripWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelMain.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.PanelCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.PanelMain.Controls.Add(this.layoutFlex);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1096, 759);
            this.PanelMain.TabIndex = 4;
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
            this.layoutFlex.Size = new System.Drawing.Size(1067, 693);
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
            this.MainPanel.Size = new System.Drawing.Size(1067, 693);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelContainer.Controls.Add(this.PanelCadastro);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1067, 693);
            this.PanelContainer.TabIndex = 1;
            // 
            // PanelCadastro
            // 
            this.PanelCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCadastro.AutoSize = true;
            this.PanelCadastro.BackColor = System.Drawing.Color.Azure;
            this.PanelCadastro.Controls.Add(this.panel4);
            this.PanelCadastro.Controls.Add(this.panel3);
            this.PanelCadastro.Controls.Add(this.panel2);
            this.PanelCadastro.Controls.Add(this.panel1);
            this.PanelCadastro.Controls.Add(this.BorderPanel1);
            this.PanelCadastro.Controls.Add(this.BoxVehicle);
            this.PanelCadastro.Controls.Add(this.title);
            this.PanelCadastro.Controls.Add(this.label2);
            this.PanelCadastro.Controls.Add(this.ButtonCancel);
            this.PanelCadastro.Controls.Add(this.BoxRoute);
            this.PanelCadastro.Controls.Add(this.BoxDriver);
            this.PanelCadastro.Controls.Add(this.labelRouteSupplpy);
            this.PanelCadastro.Controls.Add(this.ButtonSave);
            this.PanelCadastro.Controls.Add(this.label1);
            this.PanelCadastro.Controls.Add(this.labelLitrosSupply);
            this.PanelCadastro.Controls.Add(this.TxtName);
            this.PanelCadastro.Controls.Add(this.Date);
            this.PanelCadastro.Controls.Add(this.labelDataSupply);
            this.PanelCadastro.Location = new System.Drawing.Point(154, 91);
            this.PanelCadastro.Name = "PanelCadastro";
            this.PanelCadastro.Size = new System.Drawing.Size(502, 519);
            this.PanelCadastro.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(29, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 2);
            this.panel4.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(29, 439);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 2);
            this.panel3.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(27, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 2);
            this.panel2.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(27, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 2);
            this.panel1.TabIndex = 42;
            // 
            // BorderPanel1
            // 
            this.BorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderPanel1.Location = new System.Drawing.Point(29, 115);
            this.BorderPanel1.Name = "BorderPanel1";
            this.BorderPanel1.Size = new System.Drawing.Size(444, 2);
            this.BorderPanel1.TabIndex = 41;
            // 
            // BoxVehicle
            // 
            this.BoxVehicle.AllowDrop = true;
            this.BoxVehicle.BackColor = System.Drawing.Color.Azure;
            this.BoxVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxVehicle.FormattingEnabled = true;
            this.BoxVehicle.Location = new System.Drawing.Point(30, 413);
            this.BoxVehicle.Name = "BoxVehicle";
            this.BoxVehicle.Size = new System.Drawing.Size(195, 28);
            this.BoxVehicle.TabIndex = 39;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(273, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(211, 26);
            this.title.TabIndex = 40;
            this.title.Text = "Cadastro de Viagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(26, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Veículo";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonCancel.FlatAppearance.BorderSize = 2;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonCancel.Location = new System.Drawing.Point(389, 465);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(97, 32);
            this.ButtonCancel.TabIndex = 39;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // BoxRoute
            // 
            this.BoxRoute.AllowDrop = true;
            this.BoxRoute.BackColor = System.Drawing.Color.Azure;
            this.BoxRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRoute.FormattingEnabled = true;
            this.BoxRoute.Location = new System.Drawing.Point(28, 330);
            this.BoxRoute.Name = "BoxRoute";
            this.BoxRoute.Size = new System.Drawing.Size(266, 28);
            this.BoxRoute.TabIndex = 35;
            // 
            // BoxDriver
            // 
            this.BoxDriver.AllowDrop = true;
            this.BoxDriver.BackColor = System.Drawing.Color.Azure;
            this.BoxDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDriver.FormattingEnabled = true;
            this.BoxDriver.Location = new System.Drawing.Point(28, 242);
            this.BoxDriver.Name = "BoxDriver";
            this.BoxDriver.Size = new System.Drawing.Size(345, 28);
            this.BoxDriver.TabIndex = 37;
            // 
            // labelRouteSupplpy
            // 
            this.labelRouteSupplpy.AutoSize = true;
            this.labelRouteSupplpy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRouteSupplpy.ForeColor = System.Drawing.Color.Gray;
            this.labelRouteSupplpy.Location = new System.Drawing.Point(26, 302);
            this.labelRouteSupplpy.Name = "labelRouteSupplpy";
            this.labelRouteSupplpy.Size = new System.Drawing.Size(48, 20);
            this.labelRouteSupplpy.TabIndex = 34;
            this.labelRouteSupplpy.Text = "Rota";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonSave.FlatAppearance.BorderSize = 0;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.Azure;
            this.ButtonSave.Location = new System.Drawing.Point(278, 465);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 32);
            this.ButtonSave.TabIndex = 38;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(27, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Motorista";
            // 
            // labelLitrosSupply
            // 
            this.labelLitrosSupply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLitrosSupply.AutoSize = true;
            this.labelLitrosSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLitrosSupply.ForeColor = System.Drawing.Color.Gray;
            this.labelLitrosSupply.Location = new System.Drawing.Point(24, 61);
            this.labelLitrosSupply.Name = "labelLitrosSupply";
            this.labelLitrosSupply.Size = new System.Drawing.Size(145, 20);
            this.labelLitrosSupply.TabIndex = 32;
            this.labelLitrosSupply.Text = "Nome da Viagem";
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.BackColor = System.Drawing.Color.Azure;
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(28, 92);
            this.TxtName.MaxLength = 10;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(444, 23);
            this.TxtName.TabIndex = 33;
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(28, 160);
            this.Date.Name = "Date";
            this.Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Date.RightToLeftLayout = true;
            this.Date.Size = new System.Drawing.Size(141, 26);
            this.Date.TabIndex = 31;
            // 
            // labelDataSupply
            // 
            this.labelDataSupply.AutoSize = true;
            this.labelDataSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataSupply.ForeColor = System.Drawing.Color.Gray;
            this.labelDataSupply.Location = new System.Drawing.Point(26, 137);
            this.labelDataSupply.Name = "labelDataSupply";
            this.labelDataSupply.Size = new System.Drawing.Size(48, 20);
            this.labelDataSupply.TabIndex = 30;
            this.labelDataSupply.Text = "Data";
            // 
            // driverWorker
            // 
            this.driverWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GetDrivers);
            this.driverWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GetDriversFinish);
            // 
            // routeWorker
            // 
            this.routeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GetRoutes);
            this.routeWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GetRoutesFinish);
            // 
            // vehicleWorker
            // 
            this.vehicleWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GetVehicles);
            this.vehicleWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GetVehiclesFinish);
            // 
            // tripWorker
            // 
            this.tripWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SaveTrip);
            this.tripWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SaveTripFinish);
            // 
            // Viagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.PanelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Viagens";
            this.Size = new System.Drawing.Size(1096, 759);
            this.Load += new System.EventHandler(this.Viagens_Load);
            this.PanelMain.ResumeLayout(false);
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.PanelCadastro.ResumeLayout(false);
            this.PanelCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelCadastro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BorderPanel1;
        private System.Windows.Forms.ComboBox BoxVehicle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox BoxRoute;
        private System.Windows.Forms.ComboBox BoxDriver;
        private System.Windows.Forms.Label labelRouteSupplpy;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLitrosSupply;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label labelDataSupply;
        private System.ComponentModel.BackgroundWorker driverWorker;
        private System.ComponentModel.BackgroundWorker routeWorker;
        private System.ComponentModel.BackgroundWorker vehicleWorker;
        private System.ComponentModel.BackgroundWorker tripWorker;
    }
}
