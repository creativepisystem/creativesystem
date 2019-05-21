using System.Drawing;

namespace Truckleer.Creative
{
    partial class Truckleer
    {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Truckleer));
            this.truckleerContainer1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.BtnLogoName = new System.Windows.Forms.Button();
            this.hamburguerMenu = new System.Windows.Forms.Button();
            this.truckleerContainer = new System.Windows.Forms.TableLayoutPanel();
            this.truckleerMainContainer = new System.Windows.Forms.Panel();
            this.truckleerCallcontainer = new System.Windows.Forms.TableLayoutPanel();
            this.sideBarMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.groupUser = new System.Windows.Forms.Panel();
            this.BtnListUser = new System.Windows.Forms.Button();
            this.BtnNewUser = new System.Windows.Forms.Button();
            this.BtnUser = new System.Windows.Forms.Button();
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
            this.btnDash = new System.Windows.Forms.Button();
            this.sideBarTop = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.subMenuCollapsed = new System.Windows.Forms.Timer(this.components);
            this.timerSideMenu = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.truckleerContainer1.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelNavbar.SuspendLayout();
            this.truckleerContainer.SuspendLayout();
            this.truckleerMainContainer.SuspendLayout();
            this.sideBarMenu.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.groupUser.SuspendLayout();
            this.groupTrip.SuspendLayout();
            this.groupMaintence.SuspendLayout();
            this.groupRoute.SuspendLayout();
            this.groupDriver.SuspendLayout();
            this.groupVehicle.SuspendLayout();
            this.groupSupply.SuspendLayout();
            this.sideBarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // truckleerContainer1
            // 
            this.truckleerContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.truckleerContainer1.ColumnCount = 1;
            this.truckleerContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.truckleerContainer1.Controls.Add(this.mainContainer, 0, 0);
            this.truckleerContainer1.Controls.Add(this.truckleerContainer, 1, 1);
            this.truckleerContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerContainer1.Location = new System.Drawing.Point(0, 0);
            this.truckleerContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.truckleerContainer1.Name = "truckleerContainer1";
            this.truckleerContainer1.RowCount = 2;
            this.truckleerContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.truckleerContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.truckleerContainer1.Size = new System.Drawing.Size(1080, 720);
            this.truckleerContainer1.TabIndex = 0;
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
            this.mainContainer.Size = new System.Drawing.Size(1080, 43);
            this.mainContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panelNavbar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1080, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelNavbar
            // 
            this.panelNavbar.Controls.Add(this.BtnLogoName);
            this.panelNavbar.Controls.Add(this.hamburguerMenu);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(756, 43);
            this.panelNavbar.TabIndex = 5;
            // 
            // BtnLogoName
            // 
            this.BtnLogoName.FlatAppearance.BorderSize = 0;
            this.BtnLogoName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogoName.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogoName.ForeColor = System.Drawing.Color.Silver;
            this.BtnLogoName.Location = new System.Drawing.Point(-4, 4);
            this.BtnLogoName.Name = "BtnLogoName";
            this.BtnLogoName.Size = new System.Drawing.Size(198, 35);
            this.BtnLogoName.TabIndex = 1;
            this.BtnLogoName.Text = "TRUCKLEER";
            this.BtnLogoName.UseVisualStyleBackColor = true;
            // 
            // hamburguerMenu
            // 
            this.hamburguerMenu.BackgroundImage = global::Truckleer.Creative.Properties.Resources.menu;
            this.hamburguerMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hamburguerMenu.FlatAppearance.BorderSize = 0;
            this.hamburguerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hamburguerMenu.Location = new System.Drawing.Point(191, 8);
            this.hamburguerMenu.Name = "hamburguerMenu";
            this.hamburguerMenu.Size = new System.Drawing.Size(40, 28);
            this.hamburguerMenu.TabIndex = 0;
            this.hamburguerMenu.UseVisualStyleBackColor = true;
            this.hamburguerMenu.Click += new System.EventHandler(this.HamburguerMenu_Click);
            // 
            // truckleerContainer
            // 
            this.truckleerContainer.ColumnCount = 1;
            this.truckleerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.truckleerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.truckleerContainer.Controls.Add(this.truckleerMainContainer, 0, 0);
            this.truckleerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerContainer.Location = new System.Drawing.Point(0, 43);
            this.truckleerContainer.Margin = new System.Windows.Forms.Padding(0);
            this.truckleerContainer.Name = "truckleerContainer";
            this.truckleerContainer.RowCount = 1;
            this.truckleerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.truckleerContainer.Size = new System.Drawing.Size(1080, 677);
            this.truckleerContainer.TabIndex = 1;
            // 
            // truckleerMainContainer
            // 
            this.truckleerMainContainer.Controls.Add(this.truckleerCallcontainer);
            this.truckleerMainContainer.Controls.Add(this.sideBarMenu);
            this.truckleerMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerMainContainer.Location = new System.Drawing.Point(0, 0);
            this.truckleerMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.truckleerMainContainer.Name = "truckleerMainContainer";
            this.truckleerMainContainer.Size = new System.Drawing.Size(1080, 677);
            this.truckleerMainContainer.TabIndex = 1;
            // 
            // truckleerCallcontainer
            // 
            this.truckleerCallcontainer.ColumnCount = 1;
            this.truckleerCallcontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.truckleerCallcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerCallcontainer.Location = new System.Drawing.Point(200, 0);
            this.truckleerCallcontainer.Name = "truckleerCallcontainer";
            this.truckleerCallcontainer.RowCount = 1;
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 677F));
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 677F));
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 677F));
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 677F));
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 677F));
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 677F));
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 677F));
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 677F));
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 677F));
            this.truckleerCallcontainer.Size = new System.Drawing.Size(880, 677);
            this.truckleerCallcontainer.TabIndex = 1;
            // 
            // sideBarMenu
            // 
            this.sideBarMenu.Controls.Add(this.tableLayoutPanel3);
            this.sideBarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarMenu.Location = new System.Drawing.Point(0, 0);
            this.sideBarMenu.MaximumSize = new System.Drawing.Size(200, 677);
            this.sideBarMenu.MinimumSize = new System.Drawing.Size(50, 677);
            this.sideBarMenu.Name = "sideBarMenu";
            this.sideBarMenu.Size = new System.Drawing.Size(200, 677);
            this.sideBarMenu.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panelMenu, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.sideBarTop, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 677);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.menuPanel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(5, 101);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(190, 571);
            this.panelMenu.TabIndex = 3;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.groupUser);
            this.menuPanel.Controls.Add(this.groupTrip);
            this.menuPanel.Controls.Add(this.groupMaintence);
            this.menuPanel.Controls.Add(this.groupRoute);
            this.menuPanel.Controls.Add(this.groupDriver);
            this.menuPanel.Controls.Add(this.groupVehicle);
            this.menuPanel.Controls.Add(this.groupSupply);
            this.menuPanel.Controls.Add(this.btnDash);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(190, 504);
            this.menuPanel.TabIndex = 13;
            // 
            // groupUser
            // 
            this.groupUser.Controls.Add(this.BtnListUser);
            this.groupUser.Controls.Add(this.BtnNewUser);
            this.groupUser.Controls.Add(this.BtnUser);
            this.groupUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupUser.Location = new System.Drawing.Point(0, 284);
            this.groupUser.MaximumSize = new System.Drawing.Size(190, 121);
            this.groupUser.MinimumSize = new System.Drawing.Size(190, 41);
            this.groupUser.Name = "groupUser";
            this.groupUser.Size = new System.Drawing.Size(190, 41);
            this.groupUser.TabIndex = 21;
            // 
            // BtnListUser
            // 
            this.BtnListUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnListUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnListUser.FlatAppearance.BorderSize = 0;
            this.BtnListUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.BtnListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListUser.ForeColor = System.Drawing.Color.Silver;
            this.BtnListUser.Location = new System.Drawing.Point(0, 81);
            this.BtnListUser.Margin = new System.Windows.Forms.Padding(0);
            this.BtnListUser.Name = "BtnListUser";
            this.BtnListUser.Size = new System.Drawing.Size(190, 40);
            this.BtnListUser.TabIndex = 24;
            this.BtnListUser.Text = "Listar Usuários";
            this.BtnListUser.UseVisualStyleBackColor = false;
            // 
            // BtnNewUser
            // 
            this.BtnNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNewUser.FlatAppearance.BorderSize = 0;
            this.BtnNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.BtnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewUser.ForeColor = System.Drawing.Color.Silver;
            this.BtnNewUser.Location = new System.Drawing.Point(0, 41);
            this.BtnNewUser.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNewUser.Name = "BtnNewUser";
            this.BtnNewUser.Size = new System.Drawing.Size(190, 40);
            this.BtnNewUser.TabIndex = 23;
            this.BtnNewUser.Text = "Novo Usuário";
            this.BtnNewUser.UseVisualStyleBackColor = false;
            this.BtnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // BtnUser
            // 
            this.BtnUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUser.BackgroundImage")));
            this.BtnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUser.FlatAppearance.BorderSize = 0;
            this.BtnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUser.ForeColor = System.Drawing.Color.Silver;
            this.BtnUser.Image = global::Truckleer.Creative.Properties.Resources.tripMin;
            this.BtnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUser.Location = new System.Drawing.Point(0, 0);
            this.BtnUser.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(190, 41);
            this.BtnUser.TabIndex = 21;
            this.BtnUser.Text = "Usuário";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // groupTrip
            // 
            this.groupTrip.Controls.Add(this.btnListTrip);
            this.groupTrip.Controls.Add(this.btnMakeTrip);
            this.groupTrip.Controls.Add(this.btnTrip);
            this.groupTrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTrip.Location = new System.Drawing.Point(0, 244);
            this.groupTrip.Margin = new System.Windows.Forms.Padding(0);
            this.groupTrip.MaximumSize = new System.Drawing.Size(0, 120);
            this.groupTrip.MinimumSize = new System.Drawing.Size(195, 40);
            this.groupTrip.Name = "groupTrip";
            this.groupTrip.Size = new System.Drawing.Size(195, 40);
            this.groupTrip.TabIndex = 19;
            // 
            // btnListTrip
            // 
            this.btnListTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnListTrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListTrip.FlatAppearance.BorderSize = 0;
            this.btnListTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnListTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListTrip.ForeColor = System.Drawing.Color.Silver;
            this.btnListTrip.Location = new System.Drawing.Point(0, 81);
            this.btnListTrip.Margin = new System.Windows.Forms.Padding(0);
            this.btnListTrip.Name = "btnListTrip";
            this.btnListTrip.Size = new System.Drawing.Size(195, 40);
            this.btnListTrip.TabIndex = 4;
            this.btnListTrip.Text = "Listar Viagens";
            this.btnListTrip.UseVisualStyleBackColor = false;
            this.btnListTrip.Click += new System.EventHandler(this.BtnListTrip_Click);
            // 
            // btnMakeTrip
            // 
            this.btnMakeTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMakeTrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeTrip.FlatAppearance.BorderSize = 0;
            this.btnMakeTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnMakeTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeTrip.ForeColor = System.Drawing.Color.Silver;
            this.btnMakeTrip.Location = new System.Drawing.Point(0, 41);
            this.btnMakeTrip.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeTrip.Name = "btnMakeTrip";
            this.btnMakeTrip.Size = new System.Drawing.Size(195, 40);
            this.btnMakeTrip.TabIndex = 3;
            this.btnMakeTrip.Text = "Abrir Viagem";
            this.btnMakeTrip.UseVisualStyleBackColor = false;
            this.btnMakeTrip.Click += new System.EventHandler(this.BtnMakeTrip_Click);
            // 
            // btnTrip
            // 
            this.btnTrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrip.BackgroundImage")));
            this.btnTrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrip.FlatAppearance.BorderSize = 0;
            this.btnTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrip.ForeColor = System.Drawing.Color.Silver;
            this.btnTrip.Image = global::Truckleer.Creative.Properties.Resources.tripMin;
            this.btnTrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrip.Location = new System.Drawing.Point(0, 0);
            this.btnTrip.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(195, 41);
            this.btnTrip.TabIndex = 0;
            this.btnTrip.Text = "Viagens";
            this.btnTrip.UseVisualStyleBackColor = true;
            this.btnTrip.Click += new System.EventHandler(this.BtnTrip_Click);
            // 
            // groupMaintence
            // 
            this.groupMaintence.Controls.Add(this.btnAlertMaintence);
            this.groupMaintence.Controls.Add(this.btnListMaintence);
            this.groupMaintence.Controls.Add(this.btnMakeMaintence);
            this.groupMaintence.Controls.Add(this.btnMaintence);
            this.groupMaintence.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupMaintence.Location = new System.Drawing.Point(0, 204);
            this.groupMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.groupMaintence.MaximumSize = new System.Drawing.Size(0, 161);
            this.groupMaintence.MinimumSize = new System.Drawing.Size(195, 40);
            this.groupMaintence.Name = "groupMaintence";
            this.groupMaintence.Size = new System.Drawing.Size(195, 40);
            this.groupMaintence.TabIndex = 18;
            // 
            // btnAlertMaintence
            // 
            this.btnAlertMaintence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAlertMaintence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlertMaintence.FlatAppearance.BorderSize = 0;
            this.btnAlertMaintence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAlertMaintence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertMaintence.ForeColor = System.Drawing.Color.Silver;
            this.btnAlertMaintence.Location = new System.Drawing.Point(0, 121);
            this.btnAlertMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlertMaintence.Name = "btnAlertMaintence";
            this.btnAlertMaintence.Size = new System.Drawing.Size(195, 40);
            this.btnAlertMaintence.TabIndex = 3;
            this.btnAlertMaintence.Text = "Alertas Manutenções";
            this.btnAlertMaintence.UseVisualStyleBackColor = false;
            this.btnAlertMaintence.Click += new System.EventHandler(this.BtnAlertMaintence_Click_1);
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
            this.btnListMaintence.Location = new System.Drawing.Point(0, 81);
            this.btnListMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.btnListMaintence.Name = "btnListMaintence";
            this.btnListMaintence.Size = new System.Drawing.Size(195, 40);
            this.btnListMaintence.TabIndex = 2;
            this.btnListMaintence.Text = "Listar Manutenções";
            this.btnListMaintence.UseVisualStyleBackColor = false;
            this.btnListMaintence.Click += new System.EventHandler(this.BtnListMaintence_Click);
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
            this.btnMakeMaintence.Location = new System.Drawing.Point(0, 41);
            this.btnMakeMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeMaintence.Name = "btnMakeMaintence";
            this.btnMakeMaintence.Size = new System.Drawing.Size(195, 40);
            this.btnMakeMaintence.TabIndex = 1;
            this.btnMakeMaintence.Text = "Realizar Manutenção";
            this.btnMakeMaintence.UseVisualStyleBackColor = false;
            this.btnMakeMaintence.Click += new System.EventHandler(this.BtnMakeMaintence_Click);
            // 
            // btnMaintence
            // 
            this.btnMaintence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaintence.BackgroundImage")));
            this.btnMaintence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaintence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintence.FlatAppearance.BorderSize = 0;
            this.btnMaintence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnMaintence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintence.ForeColor = System.Drawing.Color.Silver;
            this.btnMaintence.Image = global::Truckleer.Creative.Properties.Resources.maintenceMin;
            this.btnMaintence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintence.Location = new System.Drawing.Point(0, 0);
            this.btnMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaintence.Name = "btnMaintence";
            this.btnMaintence.Size = new System.Drawing.Size(195, 41);
            this.btnMaintence.TabIndex = 0;
            this.btnMaintence.Text = "Manutenção";
            this.btnMaintence.UseVisualStyleBackColor = true;
            this.btnMaintence.Click += new System.EventHandler(this.BtnMaintence_Click);
            // 
            // groupRoute
            // 
            this.groupRoute.Controls.Add(this.btnListRoutes);
            this.groupRoute.Controls.Add(this.btnMakeRoute);
            this.groupRoute.Controls.Add(this.btnRoutes);
            this.groupRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupRoute.Location = new System.Drawing.Point(0, 163);
            this.groupRoute.Margin = new System.Windows.Forms.Padding(0);
            this.groupRoute.MaximumSize = new System.Drawing.Size(0, 123);
            this.groupRoute.MinimumSize = new System.Drawing.Size(195, 41);
            this.groupRoute.Name = "groupRoute";
            this.groupRoute.Size = new System.Drawing.Size(195, 41);
            this.groupRoute.TabIndex = 17;
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
            this.btnListRoutes.Location = new System.Drawing.Point(0, 81);
            this.btnListRoutes.Margin = new System.Windows.Forms.Padding(0);
            this.btnListRoutes.Name = "btnListRoutes";
            this.btnListRoutes.Size = new System.Drawing.Size(195, 40);
            this.btnListRoutes.TabIndex = 2;
            this.btnListRoutes.Text = "Listar Rotas";
            this.btnListRoutes.UseVisualStyleBackColor = false;
            this.btnListRoutes.Click += new System.EventHandler(this.BtnListRoutes_Click);
            // 
            // btnMakeRoute
            // 
            this.btnMakeRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMakeRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeRoute.FlatAppearance.BorderSize = 0;
            this.btnMakeRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnMakeRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeRoute.ForeColor = System.Drawing.Color.Silver;
            this.btnMakeRoute.Location = new System.Drawing.Point(0, 41);
            this.btnMakeRoute.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeRoute.Name = "btnMakeRoute";
            this.btnMakeRoute.Size = new System.Drawing.Size(195, 40);
            this.btnMakeRoute.TabIndex = 1;
            this.btnMakeRoute.Text = "Cadastrar Rota";
            this.btnMakeRoute.UseVisualStyleBackColor = false;
            this.btnMakeRoute.Click += new System.EventHandler(this.BtnMakeRoute_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoutes.BackgroundImage")));
            this.btnRoutes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoutes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoutes.FlatAppearance.BorderSize = 0;
            this.btnRoutes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoutes.ForeColor = System.Drawing.Color.Silver;
            this.btnRoutes.Image = global::Truckleer.Creative.Properties.Resources.routeMin;
            this.btnRoutes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoutes.Location = new System.Drawing.Point(0, 0);
            this.btnRoutes.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(195, 41);
            this.btnRoutes.TabIndex = 0;
            this.btnRoutes.Text = "Rotas";
            this.btnRoutes.UseVisualStyleBackColor = true;
            this.btnRoutes.Click += new System.EventHandler(this.BtnRoutes_Click);
            // 
            // groupDriver
            // 
            this.groupDriver.Controls.Add(this.btnListDrivers);
            this.groupDriver.Controls.Add(this.btnMakeDriver);
            this.groupDriver.Controls.Add(this.btnDriver);
            this.groupDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDriver.Location = new System.Drawing.Point(0, 122);
            this.groupDriver.Margin = new System.Windows.Forms.Padding(0);
            this.groupDriver.MaximumSize = new System.Drawing.Size(0, 123);
            this.groupDriver.MinimumSize = new System.Drawing.Size(195, 41);
            this.groupDriver.Name = "groupDriver";
            this.groupDriver.Size = new System.Drawing.Size(195, 41);
            this.groupDriver.TabIndex = 16;
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
            this.btnListDrivers.Location = new System.Drawing.Point(0, 81);
            this.btnListDrivers.Margin = new System.Windows.Forms.Padding(0);
            this.btnListDrivers.Name = "btnListDrivers";
            this.btnListDrivers.Size = new System.Drawing.Size(195, 40);
            this.btnListDrivers.TabIndex = 2;
            this.btnListDrivers.Text = "Listar Motoristas";
            this.btnListDrivers.UseVisualStyleBackColor = false;
            this.btnListDrivers.Click += new System.EventHandler(this.BtnListDrivers_Click);
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
            this.btnMakeDriver.Location = new System.Drawing.Point(0, 41);
            this.btnMakeDriver.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeDriver.Name = "btnMakeDriver";
            this.btnMakeDriver.Size = new System.Drawing.Size(195, 40);
            this.btnMakeDriver.TabIndex = 1;
            this.btnMakeDriver.Text = "Cadastrar Motorista";
            this.btnMakeDriver.UseVisualStyleBackColor = false;
            this.btnMakeDriver.Click += new System.EventHandler(this.BtnMakeDriver_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDriver.BackgroundImage")));
            this.btnDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDriver.FlatAppearance.BorderSize = 0;
            this.btnDriver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver.ForeColor = System.Drawing.Color.Silver;
            this.btnDriver.Image = global::Truckleer.Creative.Properties.Resources.driverMin;
            this.btnDriver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDriver.Location = new System.Drawing.Point(0, 0);
            this.btnDriver.Margin = new System.Windows.Forms.Padding(0);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(195, 41);
            this.btnDriver.TabIndex = 0;
            this.btnDriver.Text = "Motorista";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.BtnDriver_Click_1);
            // 
            // groupVehicle
            // 
            this.groupVehicle.Controls.Add(this.btnListVehicle);
            this.groupVehicle.Controls.Add(this.btnMakeVehicle);
            this.groupVehicle.Controls.Add(this.btnVeiculo);
            this.groupVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupVehicle.Location = new System.Drawing.Point(0, 81);
            this.groupVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.groupVehicle.MaximumSize = new System.Drawing.Size(0, 123);
            this.groupVehicle.MinimumSize = new System.Drawing.Size(195, 41);
            this.groupVehicle.Name = "groupVehicle";
            this.groupVehicle.Size = new System.Drawing.Size(195, 41);
            this.groupVehicle.TabIndex = 15;
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
            this.btnListVehicle.Location = new System.Drawing.Point(0, 81);
            this.btnListVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.btnListVehicle.Name = "btnListVehicle";
            this.btnListVehicle.Size = new System.Drawing.Size(195, 40);
            this.btnListVehicle.TabIndex = 2;
            this.btnListVehicle.Text = "Listar Veículos";
            this.btnListVehicle.UseVisualStyleBackColor = false;
            this.btnListVehicle.Click += new System.EventHandler(this.BtnListVehicle_Click);
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
            this.btnMakeVehicle.Location = new System.Drawing.Point(0, 41);
            this.btnMakeVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeVehicle.Name = "btnMakeVehicle";
            this.btnMakeVehicle.Size = new System.Drawing.Size(195, 40);
            this.btnMakeVehicle.TabIndex = 1;
            this.btnMakeVehicle.Text = "Cadastrar Veículo";
            this.btnMakeVehicle.UseVisualStyleBackColor = false;
            this.btnMakeVehicle.Click += new System.EventHandler(this.BtnMakeVehicle_Click);
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVeiculo.BackgroundImage")));
            this.btnVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeiculo.FlatAppearance.BorderSize = 0;
            this.btnVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculo.ForeColor = System.Drawing.Color.Silver;
            this.btnVeiculo.Image = global::Truckleer.Creative.Properties.Resources.truckMin;
            this.btnVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeiculo.Location = new System.Drawing.Point(0, 0);
            this.btnVeiculo.Margin = new System.Windows.Forms.Padding(0);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(195, 41);
            this.btnVeiculo.TabIndex = 0;
            this.btnVeiculo.Text = "Veículo";
            this.btnVeiculo.UseVisualStyleBackColor = true;
            this.btnVeiculo.Click += new System.EventHandler(this.BtnVeiculo_Click);
            // 
            // groupSupply
            // 
            this.groupSupply.BackColor = System.Drawing.Color.Transparent;
            this.groupSupply.Controls.Add(this.btnListAbastecimentos);
            this.groupSupply.Controls.Add(this.btnAbastecer);
            this.groupSupply.Controls.Add(this.btnAbastecimento);
            this.groupSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupSupply.Location = new System.Drawing.Point(0, 40);
            this.groupSupply.Margin = new System.Windows.Forms.Padding(0);
            this.groupSupply.MaximumSize = new System.Drawing.Size(0, 123);
            this.groupSupply.MinimumSize = new System.Drawing.Size(195, 41);
            this.groupSupply.Name = "groupSupply";
            this.groupSupply.Size = new System.Drawing.Size(195, 41);
            this.groupSupply.TabIndex = 14;
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
            this.btnListAbastecimentos.Location = new System.Drawing.Point(0, 81);
            this.btnListAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.btnListAbastecimentos.Name = "btnListAbastecimentos";
            this.btnListAbastecimentos.Size = new System.Drawing.Size(195, 40);
            this.btnListAbastecimentos.TabIndex = 2;
            this.btnListAbastecimentos.Text = "Listar Abastecimentos";
            this.btnListAbastecimentos.UseVisualStyleBackColor = false;
            this.btnListAbastecimentos.Click += new System.EventHandler(this.BtnListAbastecimentos_Click);
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
            this.btnAbastecer.Location = new System.Drawing.Point(0, 41);
            this.btnAbastecer.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(195, 40);
            this.btnAbastecer.TabIndex = 1;
            this.btnAbastecer.Text = "Abastecer";
            this.btnAbastecer.UseVisualStyleBackColor = false;
            this.btnAbastecer.Click += new System.EventHandler(this.BtnAbastecer_Click);
            // 
            // btnAbastecimento
            // 
            this.btnAbastecimento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbastecimento.BackgroundImage")));
            this.btnAbastecimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbastecimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbastecimento.FlatAppearance.BorderSize = 0;
            this.btnAbastecimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnAbastecimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbastecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbastecimento.ForeColor = System.Drawing.Color.Silver;
            this.btnAbastecimento.Image = global::Truckleer.Creative.Properties.Resources.supplyMin;
            this.btnAbastecimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbastecimento.Location = new System.Drawing.Point(0, 0);
            this.btnAbastecimento.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbastecimento.Name = "btnAbastecimento";
            this.btnAbastecimento.Size = new System.Drawing.Size(195, 41);
            this.btnAbastecimento.TabIndex = 0;
            this.btnAbastecimento.Text = "Abastecimento";
            this.btnAbastecimento.UseVisualStyleBackColor = true;
            this.btnAbastecimento.Click += new System.EventHandler(this.BtnAbastecimento_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(137)))), ((int)(((byte)(186)))));
            this.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.Silver;
            this.btnDash.Image = global::Truckleer.Creative.Properties.Resources.homeMin;
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.Location = new System.Drawing.Point(0, 0);
            this.btnDash.MinimumSize = new System.Drawing.Size(195, 0);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(195, 40);
            this.btnDash.TabIndex = 13;
            this.btnDash.Text = "DashBoard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.BtnDash_Click);
            // 
            // sideBarTop
            // 
            this.sideBarTop.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTop.Controls.Add(this.pictureBox3);
            this.sideBarTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarTop.Location = new System.Drawing.Point(5, 5);
            this.sideBarTop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.sideBarTop.Name = "sideBarTop";
            this.sideBarTop.Size = new System.Drawing.Size(190, 96);
            this.sideBarTop.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(190, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 1;
            this.timerMenu.Tick += new System.EventHandler(this.TimerMenu_Tick);
            // 
            // timerSideMenu
            // 
            this.timerSideMenu.Interval = 1;
            this.timerSideMenu.Tick += new System.EventHandler(this.TimerSideMenu_Tick);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
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
            this.truckleerContainer1.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelNavbar.ResumeLayout(false);
            this.truckleerContainer.ResumeLayout(false);
            this.truckleerMainContainer.ResumeLayout(false);
            this.sideBarMenu.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.groupUser.ResumeLayout(false);
            this.groupTrip.ResumeLayout(false);
            this.groupMaintence.ResumeLayout(false);
            this.groupRoute.ResumeLayout(false);
            this.groupDriver.ResumeLayout(false);
            this.groupVehicle.ResumeLayout(false);
            this.groupSupply.ResumeLayout(false);
            this.sideBarTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TableLayoutPanel truckleerContainer1;
        public System.Windows.Forms.TableLayoutPanel mainContainer;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panelNavbar;
        public System.Windows.Forms.TableLayoutPanel truckleerContainer;
        public System.Windows.Forms.Panel truckleerMainContainer;
        public System.Windows.Forms.Panel sideBarMenu;
        public System.Windows.Forms.Button hamburguerMenu;
        public System.Windows.Forms.Timer timerMenu;
        public System.Windows.Forms.Button BtnLogoName;
        public System.Windows.Forms.Timer subMenuCollapsed;
        public System.Windows.Forms.Timer timerSideMenu;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Panel menuPanel;
        public System.Windows.Forms.Panel groupTrip;
        public System.Windows.Forms.Button btnTrip;
        public System.Windows.Forms.Panel groupMaintence;
        public System.Windows.Forms.Button btnAlertMaintence;
        public System.Windows.Forms.Button btnListMaintence;
        public System.Windows.Forms.Button btnMakeMaintence;
        public System.Windows.Forms.Button btnMaintence;
        public System.Windows.Forms.Panel groupRoute;
        public System.Windows.Forms.Button btnListRoutes;
        public System.Windows.Forms.Button btnMakeRoute;
        public System.Windows.Forms.Button btnRoutes;
        public System.Windows.Forms.Panel groupDriver;
        public System.Windows.Forms.Button btnListDrivers;
        public System.Windows.Forms.Button btnMakeDriver;
        public System.Windows.Forms.Button btnDriver;
        public System.Windows.Forms.Panel groupVehicle;
        public System.Windows.Forms.Button btnListVehicle;
        public System.Windows.Forms.Button btnMakeVehicle;
        public System.Windows.Forms.Button btnVeiculo;
        public System.Windows.Forms.Panel groupSupply;
        public System.Windows.Forms.Button btnListAbastecimentos;
        public System.Windows.Forms.Button btnAbastecer;
        public System.Windows.Forms.Button btnAbastecimento;
        public System.Windows.Forms.Button btnDash;
        public System.Windows.Forms.Panel sideBarTop;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Button btnListTrip;
        public System.Windows.Forms.Button btnMakeTrip;
        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Panel groupUser;
        public System.Windows.Forms.Button BtnUser;
        public System.Windows.Forms.Button BtnNewUser;
        public System.Windows.Forms.Button BtnListUser;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.TableLayoutPanel truckleerCallcontainer;
    }
}

