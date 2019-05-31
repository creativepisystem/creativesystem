using System.ComponentModel;

namespace Truckleer.Creative
{
    partial class ListarVeiculos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private BackgroundWorker vehicleListWorker;

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
            this.components = new System.ComponentModel.Container();
            this.filtro = new System.Windows.Forms.Timer(this.components);
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FlowVehiclePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelFuelType = new System.Windows.Forms.Label();
            this.BoxFuelType = new System.Windows.Forms.ComboBox();
            this.LabelYearMod = new System.Windows.Forms.Label();
            this.BoxYearMod = new System.Windows.Forms.ComboBox();
            this.LabelPlate = new System.Windows.Forms.Label();
            this.BoxPlate = new System.Windows.Forms.ComboBox();
            this.vehicleListWorker = new System.ComponentModel.BackgroundWorker();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.PageDescription = new System.Windows.Forms.Label();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.FlowVehiclePanel.SuspendLayout();
            this.filter.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtro
            // 
            this.filtro.Interval = 10;
            this.filtro.Tick += new System.EventHandler(this.Filtro_Tick);
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
            this.layoutFlex.Size = new System.Drawing.Size(1141, 710);
            this.layoutFlex.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.filter);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1141, 710);
            this.MainPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel4.Controls.Add(this.FlowVehiclePanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1141, 616);
            this.panel4.TabIndex = 1;
            // 
            // FlowVehiclePanel
            // 
            this.FlowVehiclePanel.AutoScroll = true;
            this.FlowVehiclePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.FlowVehiclePanel.Controls.Add(this.ProgressBar);
            this.FlowVehiclePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowVehiclePanel.Location = new System.Drawing.Point(0, 0);
            this.FlowVehiclePanel.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.FlowVehiclePanel.Name = "FlowVehiclePanel";
            this.FlowVehiclePanel.Size = new System.Drawing.Size(1141, 616);
            this.FlowVehiclePanel.TabIndex = 0;
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.Firebrick;
            this.filter.Controls.Add(this.panel1);
            this.filter.Controls.Add(this.ButtonSave);
            this.filter.Controls.Add(this.LabelFuelType);
            this.filter.Controls.Add(this.BoxFuelType);
            this.filter.Controls.Add(this.LabelYearMod);
            this.filter.Controls.Add(this.BoxYearMod);
            this.filter.Controls.Add(this.LabelPlate);
            this.filter.Controls.Add(this.BoxPlate);
            this.filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.filter.Location = new System.Drawing.Point(0, 0);
            this.filter.Margin = new System.Windows.Forms.Padding(0);
            this.filter.MaximumSize = new System.Drawing.Size(2000, 94);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(1141, 94);
            this.filter.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 2);
            this.panel1.TabIndex = 71;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.Crimson;
            this.ButtonSave.FlatAppearance.BorderSize = 0;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.Azure;
            this.ButtonSave.Location = new System.Drawing.Point(974, 44);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(140, 32);
            this.ButtonSave.TabIndex = 70;
            this.ButtonSave.Text = "Cadastrar Veículo";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelFuelType
            // 
            this.LabelFuelType.AutoSize = true;
            this.LabelFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFuelType.ForeColor = System.Drawing.Color.Azure;
            this.LabelFuelType.Location = new System.Drawing.Point(238, 28);
            this.LabelFuelType.Name = "LabelFuelType";
            this.LabelFuelType.Size = new System.Drawing.Size(151, 20);
            this.LabelFuelType.TabIndex = 24;
            this.LabelFuelType.Text = "Tipo de Combustível";
            // 
            // BoxFuelType
            // 
            this.BoxFuelType.FormattingEnabled = true;
            this.BoxFuelType.Location = new System.Drawing.Point(242, 51);
            this.BoxFuelType.Name = "BoxFuelType";
            this.BoxFuelType.Size = new System.Drawing.Size(121, 21);
            this.BoxFuelType.TabIndex = 23;
            // 
            // LabelYearMod
            // 
            this.LabelYearMod.AutoSize = true;
            this.LabelYearMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYearMod.ForeColor = System.Drawing.Color.Azure;
            this.LabelYearMod.Location = new System.Drawing.Point(423, 28);
            this.LabelYearMod.Name = "LabelYearMod";
            this.LabelYearMod.Size = new System.Drawing.Size(94, 20);
            this.LabelYearMod.TabIndex = 20;
            this.LabelYearMod.Text = "Ano Modelo";
            // 
            // BoxYearMod
            // 
            this.BoxYearMod.FormattingEnabled = true;
            this.BoxYearMod.Location = new System.Drawing.Point(427, 51);
            this.BoxYearMod.Name = "BoxYearMod";
            this.BoxYearMod.Size = new System.Drawing.Size(121, 21);
            this.BoxYearMod.TabIndex = 19;
            // 
            // LabelPlate
            // 
            this.LabelPlate.AutoSize = true;
            this.LabelPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlate.ForeColor = System.Drawing.Color.Azure;
            this.LabelPlate.Location = new System.Drawing.Point(85, 28);
            this.LabelPlate.Name = "LabelPlate";
            this.LabelPlate.Size = new System.Drawing.Size(48, 20);
            this.LabelPlate.TabIndex = 18;
            this.LabelPlate.Text = "Placa";
            // 
            // BoxPlate
            // 
            this.BoxPlate.FormattingEnabled = true;
            this.BoxPlate.Location = new System.Drawing.Point(90, 51);
            this.BoxPlate.Name = "BoxPlate";
            this.BoxPlate.Size = new System.Drawing.Size(109, 21);
            this.BoxPlate.TabIndex = 13;
            // 
            // vehicleListWorker
            // 
            this.vehicleListWorker.WorkerReportsProgress = true;
            this.vehicleListWorker.WorkerSupportsCancellation = true;
            this.vehicleListWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FilterVehicle);
            this.vehicleListWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.FilterVehicleProgress);
            this.vehicleListWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FilterVehicleFinish);
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonFilter.FlatAppearance.BorderSize = 0;
            this.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFilter.Location = new System.Drawing.Point(32, 5);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(75, 28);
            this.ButtonFilter.TabIndex = 25;
            this.ButtonFilter.Text = "Filtros";
            this.ButtonFilter.UseVisualStyleBackColor = false;
            this.ButtonFilter.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(825, 3);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(206, 31);
            this.PageDescription.TabIndex = 44;
            this.PageDescription.Text = "Listar Veículos /";
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(1023, 3);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(76, 31);
            this.ButtonHome.TabIndex = 45;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.container.Controls.Add(this.ButtonHome);
            this.container.Controls.Add(this.PageDescription);
            this.container.Controls.Add(this.ButtonFilter);
            this.container.Controls.Add(this.layoutFlex);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1170, 759);
            this.container.TabIndex = 1;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ProgressBar.AnimationSpeed = 500;
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.ProgressBar.InnerMargin = 2;
            this.ProgressBar.InnerWidth = -1;
            this.ProgressBar.Location = new System.Drawing.Point(470, 150);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(470, 150, 3, 3);
            this.ProgressBar.MarqueeAnimationSpeed = 2000;
            this.ProgressBar.MaximumSize = new System.Drawing.Size(243, 224);
            this.ProgressBar.MinimumSize = new System.Drawing.Size(243, 224);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.OuterColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProgressBar.OuterMargin = -21;
            this.ProgressBar.OuterWidth = 15;
            this.ProgressBar.ProgressColor = System.Drawing.Color.Firebrick;
            this.ProgressBar.ProgressWidth = 30;
            this.ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ProgressBar.Size = new System.Drawing.Size(243, 224);
            this.ProgressBar.StartAngle = 0;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgressBar.SubscriptText = "";
            this.ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgressBar.SuperscriptText = "";
            this.ProgressBar.TabIndex = 1;
            this.ProgressBar.Text = "Loading...";
            this.ProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgressBar.Value = 20;
            // 
            // ListarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.container);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListarVeiculos";
            this.Size = new System.Drawing.Size(1170, 759);
            this.Load += new System.EventHandler(this.ListarVeiculos_Load_1);
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.FlowVehiclePanel.ResumeLayout(false);
            this.filter.ResumeLayout(false);
            this.filter.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer filtro;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel filter;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelFuelType;
        private System.Windows.Forms.ComboBox BoxFuelType;
        private System.Windows.Forms.Label LabelYearMod;
        private System.Windows.Forms.ComboBox BoxYearMod;
        private System.Windows.Forms.Label LabelPlate;
        private System.Windows.Forms.ComboBox BoxPlate;
        private System.Windows.Forms.Button ButtonFilter;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel FlowVehiclePanel;
        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar ProgressBar;
    }
}
