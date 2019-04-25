using System.Drawing;

namespace Truckleer.Creative
{
    partial class Truckleer
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Truckleer));
            this.supplyTimer = new System.Windows.Forms.Timer(this.components);
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.truckleerContainer1 = new System.Windows.Forms.TableLayoutPanel();
            this.truckleerContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupTrip = new System.Windows.Forms.Panel();
            this.btnListTrip = new System.Windows.Forms.Button();
            this.btnMakeTrip = new System.Windows.Forms.Button();
            this.btnTrip = new System.Windows.Forms.Button();
            this.groupMaintence = new System.Windows.Forms.Panel();
            this.btnAlertMaintence = new System.Windows.Forms.Button();
            this.btnListMaintence = new System.Windows.Forms.Button();
            this.btnMakeMaintence = new System.Windows.Forms.Button();
            this.btnMaintence = new System.Windows.Forms.Button();
            this.groupRoute = new System.Windows.Forms.Panel();
            this.btnListRoutes = new System.Windows.Forms.Button();
            this.btnMakeRoute = new System.Windows.Forms.Button();
            this.btnRoutes = new System.Windows.Forms.Button();
            this.groupDriver = new System.Windows.Forms.Panel();
            this.btnListDrivers = new System.Windows.Forms.Button();
            this.btnMakeDriver = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.groupVehicle = new System.Windows.Forms.Panel();
            this.btnListVehicle = new System.Windows.Forms.Button();
            this.btnMakeVehicle = new System.Windows.Forms.Button();
            this.btnVeiculo = new System.Windows.Forms.Button();
            this.groupSupply = new System.Windows.Forms.Panel();
            this.btnListAbastecimentos = new System.Windows.Forms.Button();
            this.btnAbastecer = new System.Windows.Forms.Button();
            this.btnAbastecimento = new System.Windows.Forms.Button();
            this.sideBarTop = new System.Windows.Forms.Panel();
            this.btnDash = new System.Windows.Forms.Button();
            this.truckleerCallcontainer = new System.Windows.Forms.TableLayoutPanel();
            this.vehicleTimer = new System.Windows.Forms.Timer(this.components);
            this.driverTimer = new System.Windows.Forms.Timer(this.components);
            this.routeTimer = new System.Windows.Forms.Timer(this.components);
            this.maintenceTimer = new System.Windows.Forms.Timer(this.components);
            this.tripTimer = new System.Windows.Forms.Timer(this.components);
            this.mainContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.truckleerContainer1.SuspendLayout();
            this.truckleerContainer.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupTrip.SuspendLayout();
            this.groupMaintence.SuspendLayout();
            this.groupRoute.SuspendLayout();
            this.groupDriver.SuspendLayout();
            this.groupVehicle.SuspendLayout();
            this.groupSupply.SuspendLayout();
            this.sideBarTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplyTimer
            // 
            this.supplyTimer.Interval = 15;
            this.supplyTimer.Tick += new System.EventHandler(this.supplyTimer_Tick);
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 1;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 1;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.Size = new System.Drawing.Size(1080, 102);
            this.mainContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelNavbar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1080, 102);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(918, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 38);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(756, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 38);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 38);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelNavbar
            // 
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavbar.Location = new System.Drawing.Point(0, 38);
            this.panelNavbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(756, 64);
            this.panelNavbar.TabIndex = 4;
            // 
            // truckleerContainer1
            // 
            this.truckleerContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.truckleerContainer1.ColumnCount = 1;
            this.truckleerContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.truckleerContainer1.Controls.Add(this.mainContainer, 0, 0);
            this.truckleerContainer1.Controls.Add(this.truckleerContainer, 0, 1);
            this.truckleerContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerContainer1.Location = new System.Drawing.Point(0, 0);
            this.truckleerContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.truckleerContainer1.Name = "truckleerContainer1";
            this.truckleerContainer1.RowCount = 2;
            this.truckleerContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.truckleerContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.truckleerContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.truckleerContainer1.Size = new System.Drawing.Size(1080, 720);
            this.truckleerContainer1.TabIndex = 0;
            // 
            // truckleerContainer
            // 
            this.truckleerContainer.ColumnCount = 2;
            this.truckleerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.truckleerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.truckleerContainer.Controls.Add(this.panelSideBar, 0, 0);
            this.truckleerContainer.Controls.Add(this.truckleerCallcontainer, 1, 0);
            this.truckleerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerContainer.Location = new System.Drawing.Point(0, 102);
            this.truckleerContainer.Margin = new System.Windows.Forms.Padding(0);
            this.truckleerContainer.Name = "truckleerContainer";
            this.truckleerContainer.RowCount = 1;
            this.truckleerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.truckleerContainer.Size = new System.Drawing.Size(1080, 618);
            this.truckleerContainer.TabIndex = 1;
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelSideBar.Controls.Add(this.tableLayoutPanel2);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(162, 618);
            this.panelSideBar.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.sideBarTop, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(162, 618);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupTrip);
            this.panel1.Controls.Add(this.groupMaintence);
            this.panel1.Controls.Add(this.groupRoute);
            this.panel1.Controls.Add(this.groupDriver);
            this.panel1.Controls.Add(this.groupVehicle);
            this.panel1.Controls.Add(this.groupSupply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 154);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 459);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupTrip
            // 
            this.groupTrip.Controls.Add(this.btnListTrip);
            this.groupTrip.Controls.Add(this.btnMakeTrip);
            this.groupTrip.Controls.Add(this.btnTrip);
            this.groupTrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTrip.Location = new System.Drawing.Point(0, 204);
            this.groupTrip.Margin = new System.Windows.Forms.Padding(0);
            this.groupTrip.MaximumSize = new System.Drawing.Size(0, 120);
            this.groupTrip.MinimumSize = new System.Drawing.Size(0, 40);
            this.groupTrip.Name = "groupTrip";
            this.groupTrip.Size = new System.Drawing.Size(152, 40);
            this.groupTrip.TabIndex = 5;
            // 
            // btnListTrip
            // 
            this.btnListTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnListTrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListTrip.FlatAppearance.BorderSize = 0;
            this.btnListTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnListTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListTrip.ForeColor = System.Drawing.Color.Silver;
            this.btnListTrip.Location = new System.Drawing.Point(0, 79);
            this.btnListTrip.Margin = new System.Windows.Forms.Padding(0);
            this.btnListTrip.Name = "btnListTrip";
            this.btnListTrip.Size = new System.Drawing.Size(152, 40);
            this.btnListTrip.TabIndex = 2;
            this.btnListTrip.Text = "Listar Viagens";
            this.btnListTrip.UseVisualStyleBackColor = false;
            // 
            // btnMakeTrip
            // 
            this.btnMakeTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMakeTrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeTrip.FlatAppearance.BorderSize = 0;
            this.btnMakeTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnMakeTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeTrip.ForeColor = System.Drawing.Color.Silver;
            this.btnMakeTrip.Location = new System.Drawing.Point(0, 39);
            this.btnMakeTrip.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeTrip.Name = "btnMakeTrip";
            this.btnMakeTrip.Size = new System.Drawing.Size(152, 40);
            this.btnMakeTrip.TabIndex = 1;
            this.btnMakeTrip.Text = "Abrir Viagem";
            this.btnMakeTrip.UseVisualStyleBackColor = false;
            this.btnMakeTrip.Click += new System.EventHandler(this.btnMakeTrip_Click);
            // 
            // btnTrip
            // 
            this.btnTrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrip.FlatAppearance.BorderSize = 0;
            this.btnTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrip.ForeColor = System.Drawing.Color.Silver;
            this.btnTrip.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrip.Location = new System.Drawing.Point(0, 0);
            this.btnTrip.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(152, 39);
            this.btnTrip.TabIndex = 0;
            this.btnTrip.Text = "Viagens";
            this.btnTrip.UseVisualStyleBackColor = true;
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click);
            // 
            // groupMaintence
            // 
            this.groupMaintence.Controls.Add(this.btnAlertMaintence);
            this.groupMaintence.Controls.Add(this.btnListMaintence);
            this.groupMaintence.Controls.Add(this.btnMakeMaintence);
            this.groupMaintence.Controls.Add(this.btnMaintence);
            this.groupMaintence.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupMaintence.Location = new System.Drawing.Point(0, 164);
            this.groupMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.groupMaintence.MaximumSize = new System.Drawing.Size(0, 161);
            this.groupMaintence.MinimumSize = new System.Drawing.Size(0, 40);
            this.groupMaintence.Name = "groupMaintence";
            this.groupMaintence.Size = new System.Drawing.Size(152, 40);
            this.groupMaintence.TabIndex = 4;
            // 
            // btnAlertMaintence
            // 
            this.btnAlertMaintence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAlertMaintence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlertMaintence.FlatAppearance.BorderSize = 0;
            this.btnAlertMaintence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAlertMaintence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertMaintence.ForeColor = System.Drawing.Color.Silver;
            this.btnAlertMaintence.Location = new System.Drawing.Point(0, 119);
            this.btnAlertMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlertMaintence.Name = "btnAlertMaintence";
            this.btnAlertMaintence.Size = new System.Drawing.Size(152, 40);
            this.btnAlertMaintence.TabIndex = 3;
            this.btnAlertMaintence.Text = "Alertas Manutenções";
            this.btnAlertMaintence.UseVisualStyleBackColor = false;
            // 
            // btnListMaintence
            // 
            this.btnListMaintence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnListMaintence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMaintence.FlatAppearance.BorderSize = 0;
            this.btnListMaintence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnListMaintence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMaintence.ForeColor = System.Drawing.Color.Silver;
            this.btnListMaintence.Location = new System.Drawing.Point(0, 79);
            this.btnListMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.btnListMaintence.Name = "btnListMaintence";
            this.btnListMaintence.Size = new System.Drawing.Size(152, 40);
            this.btnListMaintence.TabIndex = 2;
            this.btnListMaintence.Text = "Listar Manutenções";
            this.btnListMaintence.UseVisualStyleBackColor = false;
            // 
            // btnMakeMaintence
            // 
            this.btnMakeMaintence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMakeMaintence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeMaintence.FlatAppearance.BorderSize = 0;
            this.btnMakeMaintence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnMakeMaintence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeMaintence.ForeColor = System.Drawing.Color.Silver;
            this.btnMakeMaintence.Location = new System.Drawing.Point(0, 39);
            this.btnMakeMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeMaintence.Name = "btnMakeMaintence";
            this.btnMakeMaintence.Size = new System.Drawing.Size(152, 40);
            this.btnMakeMaintence.TabIndex = 1;
            this.btnMakeMaintence.Text = "Realizar Manutenção";
            this.btnMakeMaintence.UseVisualStyleBackColor = false;
            this.btnMakeMaintence.Click += new System.EventHandler(this.btnMakeMaintence_Click);
            // 
            // btnMaintence
            // 
            this.btnMaintence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintence.FlatAppearance.BorderSize = 0;
            this.btnMaintence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnMaintence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintence.ForeColor = System.Drawing.Color.Silver;
            this.btnMaintence.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaintence.Location = new System.Drawing.Point(0, 0);
            this.btnMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaintence.Name = "btnMaintence";
            this.btnMaintence.Size = new System.Drawing.Size(152, 39);
            this.btnMaintence.TabIndex = 0;
            this.btnMaintence.Text = "Manutenção";
            this.btnMaintence.UseVisualStyleBackColor = true;
            this.btnMaintence.Click += new System.EventHandler(this.btnMaintence_Click);
            // 
            // groupRoute
            // 
            this.groupRoute.Controls.Add(this.btnListRoutes);
            this.groupRoute.Controls.Add(this.btnMakeRoute);
            this.groupRoute.Controls.Add(this.btnRoutes);
            this.groupRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupRoute.Location = new System.Drawing.Point(0, 123);
            this.groupRoute.Margin = new System.Windows.Forms.Padding(0);
            this.groupRoute.MaximumSize = new System.Drawing.Size(0, 123);
            this.groupRoute.MinimumSize = new System.Drawing.Size(0, 41);
            this.groupRoute.Name = "groupRoute";
            this.groupRoute.Size = new System.Drawing.Size(152, 41);
            this.groupRoute.TabIndex = 3;
            // 
            // btnListRoutes
            // 
            this.btnListRoutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnListRoutes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListRoutes.FlatAppearance.BorderSize = 0;
            this.btnListRoutes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnListRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListRoutes.ForeColor = System.Drawing.Color.Silver;
            this.btnListRoutes.Location = new System.Drawing.Point(0, 80);
            this.btnListRoutes.Margin = new System.Windows.Forms.Padding(0);
            this.btnListRoutes.Name = "btnListRoutes";
            this.btnListRoutes.Size = new System.Drawing.Size(152, 40);
            this.btnListRoutes.TabIndex = 2;
            this.btnListRoutes.Text = "Listar Rotas";
            this.btnListRoutes.UseVisualStyleBackColor = false;
            // 
            // btnMakeRoute
            // 
            this.btnMakeRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMakeRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeRoute.FlatAppearance.BorderSize = 0;
            this.btnMakeRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnMakeRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeRoute.ForeColor = System.Drawing.Color.Silver;
            this.btnMakeRoute.Location = new System.Drawing.Point(0, 40);
            this.btnMakeRoute.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeRoute.Name = "btnMakeRoute";
            this.btnMakeRoute.Size = new System.Drawing.Size(152, 40);
            this.btnMakeRoute.TabIndex = 1;
            this.btnMakeRoute.Text = "Cadastrar Rota";
            this.btnMakeRoute.UseVisualStyleBackColor = false;
            this.btnMakeRoute.Click += new System.EventHandler(this.btnMakeRoute_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoutes.FlatAppearance.BorderSize = 0;
            this.btnRoutes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoutes.ForeColor = System.Drawing.Color.Silver;
            this.btnRoutes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoutes.Location = new System.Drawing.Point(0, 0);
            this.btnRoutes.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(152, 40);
            this.btnRoutes.TabIndex = 0;
            this.btnRoutes.Text = "Rotas";
            this.btnRoutes.UseVisualStyleBackColor = true;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // groupDriver
            // 
            this.groupDriver.Controls.Add(this.btnListDrivers);
            this.groupDriver.Controls.Add(this.btnMakeDriver);
            this.groupDriver.Controls.Add(this.btnDriver);
            this.groupDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDriver.Location = new System.Drawing.Point(0, 82);
            this.groupDriver.Margin = new System.Windows.Forms.Padding(0);
            this.groupDriver.MaximumSize = new System.Drawing.Size(0, 123);
            this.groupDriver.MinimumSize = new System.Drawing.Size(0, 41);
            this.groupDriver.Name = "groupDriver";
            this.groupDriver.Size = new System.Drawing.Size(152, 41);
            this.groupDriver.TabIndex = 2;
            // 
            // btnListDrivers
            // 
            this.btnListDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnListDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListDrivers.FlatAppearance.BorderSize = 0;
            this.btnListDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnListDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListDrivers.ForeColor = System.Drawing.Color.Silver;
            this.btnListDrivers.Location = new System.Drawing.Point(0, 80);
            this.btnListDrivers.Margin = new System.Windows.Forms.Padding(0);
            this.btnListDrivers.Name = "btnListDrivers";
            this.btnListDrivers.Size = new System.Drawing.Size(152, 40);
            this.btnListDrivers.TabIndex = 2;
            this.btnListDrivers.Text = "Listar Motoristas";
            this.btnListDrivers.UseVisualStyleBackColor = false;
            // 
            // btnMakeDriver
            // 
            this.btnMakeDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMakeDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeDriver.FlatAppearance.BorderSize = 0;
            this.btnMakeDriver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnMakeDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeDriver.ForeColor = System.Drawing.Color.Silver;
            this.btnMakeDriver.Location = new System.Drawing.Point(0, 40);
            this.btnMakeDriver.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeDriver.Name = "btnMakeDriver";
            this.btnMakeDriver.Size = new System.Drawing.Size(152, 40);
            this.btnMakeDriver.TabIndex = 1;
            this.btnMakeDriver.Text = "Cadastrar Motorista";
            this.btnMakeDriver.UseVisualStyleBackColor = false;
            this.btnMakeDriver.Click += new System.EventHandler(this.btnMakeDriver_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDriver.FlatAppearance.BorderSize = 0;
            this.btnDriver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver.ForeColor = System.Drawing.Color.Silver;
            this.btnDriver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDriver.Location = new System.Drawing.Point(0, 0);
            this.btnDriver.Margin = new System.Windows.Forms.Padding(0);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(152, 40);
            this.btnDriver.TabIndex = 0;
            this.btnDriver.Text = "Motorista";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // groupVehicle
            // 
            this.groupVehicle.Controls.Add(this.btnListVehicle);
            this.groupVehicle.Controls.Add(this.btnMakeVehicle);
            this.groupVehicle.Controls.Add(this.btnVeiculo);
            this.groupVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupVehicle.Location = new System.Drawing.Point(0, 41);
            this.groupVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.groupVehicle.MaximumSize = new System.Drawing.Size(0, 123);
            this.groupVehicle.MinimumSize = new System.Drawing.Size(0, 41);
            this.groupVehicle.Name = "groupVehicle";
            this.groupVehicle.Size = new System.Drawing.Size(152, 41);
            this.groupVehicle.TabIndex = 1;
            // 
            // btnListVehicle
            // 
            this.btnListVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnListVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListVehicle.FlatAppearance.BorderSize = 0;
            this.btnListVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnListVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnListVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListVehicle.ForeColor = System.Drawing.Color.Silver;
            this.btnListVehicle.Location = new System.Drawing.Point(0, 80);
            this.btnListVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.btnListVehicle.Name = "btnListVehicle";
            this.btnListVehicle.Size = new System.Drawing.Size(152, 40);
            this.btnListVehicle.TabIndex = 2;
            this.btnListVehicle.Text = "Listar Veículos";
            this.btnListVehicle.UseVisualStyleBackColor = false;
            // 
            // btnMakeVehicle
            // 
            this.btnMakeVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMakeVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeVehicle.FlatAppearance.BorderSize = 0;
            this.btnMakeVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMakeVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnMakeVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeVehicle.ForeColor = System.Drawing.Color.Silver;
            this.btnMakeVehicle.Location = new System.Drawing.Point(0, 40);
            this.btnMakeVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeVehicle.Name = "btnMakeVehicle";
            this.btnMakeVehicle.Size = new System.Drawing.Size(152, 40);
            this.btnMakeVehicle.TabIndex = 1;
            this.btnMakeVehicle.Text = "Cadastrar Veículo";
            this.btnMakeVehicle.UseVisualStyleBackColor = false;
            this.btnMakeVehicle.Click += new System.EventHandler(this.btnMakeVehicle_Click);
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeiculo.FlatAppearance.BorderSize = 0;
            this.btnVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculo.ForeColor = System.Drawing.Color.Silver;
            this.btnVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVeiculo.Location = new System.Drawing.Point(0, 0);
            this.btnVeiculo.Margin = new System.Windows.Forms.Padding(0);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(152, 40);
            this.btnVeiculo.TabIndex = 0;
            this.btnVeiculo.Text = "Veículo";
            this.btnVeiculo.UseVisualStyleBackColor = true;
            this.btnVeiculo.Click += new System.EventHandler(this.btnVeiculo_Click);
            // 
            // groupSupply
            // 
            this.groupSupply.BackColor = System.Drawing.Color.Transparent;
            this.groupSupply.Controls.Add(this.btnListAbastecimentos);
            this.groupSupply.Controls.Add(this.btnAbastecer);
            this.groupSupply.Controls.Add(this.btnAbastecimento);
            this.groupSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupSupply.Location = new System.Drawing.Point(0, 0);
            this.groupSupply.Margin = new System.Windows.Forms.Padding(0);
            this.groupSupply.MaximumSize = new System.Drawing.Size(0, 123);
            this.groupSupply.MinimumSize = new System.Drawing.Size(0, 41);
            this.groupSupply.Name = "groupSupply";
            this.groupSupply.Size = new System.Drawing.Size(152, 41);
            this.groupSupply.TabIndex = 0;
            // 
            // btnListAbastecimentos
            // 
            this.btnListAbastecimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnListAbastecimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListAbastecimentos.FlatAppearance.BorderSize = 0;
            this.btnListAbastecimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnListAbastecimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAbastecimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAbastecimentos.ForeColor = System.Drawing.Color.Silver;
            this.btnListAbastecimentos.Location = new System.Drawing.Point(0, 80);
            this.btnListAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.btnListAbastecimentos.Name = "btnListAbastecimentos";
            this.btnListAbastecimentos.Size = new System.Drawing.Size(152, 40);
            this.btnListAbastecimentos.TabIndex = 2;
            this.btnListAbastecimentos.Text = "Listar Abastecimentos";
            this.btnListAbastecimentos.UseVisualStyleBackColor = false;
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAbastecer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbastecer.FlatAppearance.BorderSize = 0;
            this.btnAbastecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAbastecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbastecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbastecer.ForeColor = System.Drawing.Color.Silver;
            this.btnAbastecer.Location = new System.Drawing.Point(0, 40);
            this.btnAbastecer.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(152, 40);
            this.btnAbastecer.TabIndex = 1;
            this.btnAbastecer.Text = "Abastecer";
            this.btnAbastecer.UseVisualStyleBackColor = false;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // btnAbastecimento
            // 
            this.btnAbastecimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbastecimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbastecimento.FlatAppearance.BorderSize = 0;
            this.btnAbastecimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnAbastecimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbastecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbastecimento.ForeColor = System.Drawing.Color.Silver;
            this.btnAbastecimento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbastecimento.Location = new System.Drawing.Point(0, 0);
            this.btnAbastecimento.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbastecimento.Name = "btnAbastecimento";
            this.btnAbastecimento.Size = new System.Drawing.Size(152, 40);
            this.btnAbastecimento.TabIndex = 0;
            this.btnAbastecimento.Text = "Abastecimento";
            this.btnAbastecimento.UseVisualStyleBackColor = true;
            this.btnAbastecimento.Click += new System.EventHandler(this.btnAbastecimento_Click);
            // 
            // sideBarTop
            // 
            this.sideBarTop.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTop.Controls.Add(this.btnDash);
            this.sideBarTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarTop.Location = new System.Drawing.Point(5, 5);
            this.sideBarTop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.sideBarTop.Name = "sideBarTop";
            this.sideBarTop.Size = new System.Drawing.Size(152, 149);
            this.sideBarTop.TabIndex = 1;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(137)))), ((int)(((byte)(186)))));
            this.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.Silver;
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDash.Location = new System.Drawing.Point(0, 109);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(152, 40);
            this.btnDash.TabIndex = 0;
            this.btnDash.Text = "DashBoard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // truckleerCallcontainer
            // 
            this.truckleerCallcontainer.ColumnCount = 1;
            this.truckleerCallcontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.truckleerCallcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerCallcontainer.Location = new System.Drawing.Point(162, 0);
            this.truckleerCallcontainer.Margin = new System.Windows.Forms.Padding(0);
            this.truckleerCallcontainer.Name = "truckleerCallcontainer";
            this.truckleerCallcontainer.RowCount = 1;
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.truckleerCallcontainer.Size = new System.Drawing.Size(918, 618);
            this.truckleerCallcontainer.TabIndex = 0;
            // 
            // vehicleTimer
            // 
            this.vehicleTimer.Interval = 15;
            this.vehicleTimer.Tick += new System.EventHandler(this.vehicleTimer_Tick);
            // 
            // driverTimer
            // 
            this.driverTimer.Interval = 15;
            this.driverTimer.Tick += new System.EventHandler(this.driverTimer_Tick);
            // 
            // routeTimer
            // 
            this.routeTimer.Interval = 15;
            this.routeTimer.Tick += new System.EventHandler(this.routeTimer_Tick);
            // 
            // maintenceTimer
            // 
            this.maintenceTimer.Interval = 15;
            this.maintenceTimer.Tick += new System.EventHandler(this.maintenceTimer_Tick);
            // 
            // tripTimer
            // 
            this.tripTimer.Interval = 15;
            this.tripTimer.Tick += new System.EventHandler(this.tripTimer_Tick);
            // 
            // Truckleer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.truckleerContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Truckleer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truckleer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.truckleerContainer1.ResumeLayout(false);
            this.truckleerContainer.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupTrip.ResumeLayout(false);
            this.groupMaintence.ResumeLayout(false);
            this.groupRoute.ResumeLayout(false);
            this.groupDriver.ResumeLayout(false);
            this.groupVehicle.ResumeLayout(false);
            this.groupSupply.ResumeLayout(false);
            this.sideBarTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer supplyTimer;
        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.TableLayoutPanel truckleerContainer1;
        private System.Windows.Forms.TableLayoutPanel truckleerContainer;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel groupSupply;
        private System.Windows.Forms.Button btnListAbastecimentos;
        private System.Windows.Forms.Button btnAbastecer;
        private System.Windows.Forms.Button btnAbastecimento;
        private System.Windows.Forms.TableLayoutPanel truckleerCallcontainer;
        private System.Windows.Forms.Panel sideBarTop;
        private System.Windows.Forms.Timer vehicleTimer;
        private System.Windows.Forms.Timer driverTimer;
        private System.Windows.Forms.Timer routeTimer;
        private System.Windows.Forms.Timer maintenceTimer;
        private System.Windows.Forms.Timer tripTimer;
        public System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Panel groupTrip;
        private System.Windows.Forms.Button btnListTrip;
        private System.Windows.Forms.Button btnMakeTrip;
        private System.Windows.Forms.Button btnTrip;
        private System.Windows.Forms.Panel groupMaintence;
        private System.Windows.Forms.Button btnAlertMaintence;
        private System.Windows.Forms.Button btnListMaintence;
        private System.Windows.Forms.Button btnMakeMaintence;
        private System.Windows.Forms.Button btnMaintence;
        private System.Windows.Forms.Panel groupRoute;
        private System.Windows.Forms.Button btnListRoutes;
        private System.Windows.Forms.Button btnMakeRoute;
        private System.Windows.Forms.Button btnRoutes;
        private System.Windows.Forms.Panel groupDriver;
        private System.Windows.Forms.Button btnListDrivers;
        private System.Windows.Forms.Button btnMakeDriver;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Panel groupVehicle;
        private System.Windows.Forms.Button btnListVehicle;
        private System.Windows.Forms.Button btnMakeVehicle;
        private System.Windows.Forms.Button btnVeiculo;
    }
}

