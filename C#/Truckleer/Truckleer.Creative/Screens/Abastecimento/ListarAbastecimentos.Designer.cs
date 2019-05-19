namespace Truckleer.Creative
{
    partial class ListarAbastecimentos
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
            this.components = new System.ComponentModel.Container();
            this.timerFilter = new System.Windows.Forms.Timer(this.components);
            this.listSupply = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.PageDescription = new System.Windows.Forms.Label();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.HeaderList = new System.Windows.Forms.Panel();
            this.PanelHeaderInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelHeaderTrip = new System.Windows.Forms.Panel();
            this.LabelHeaderTrip = new System.Windows.Forms.Label();
            this.PanelHeaderTotalPrice = new System.Windows.Forms.Panel();
            this.LabelHeaderTotalPrice = new System.Windows.Forms.Label();
            this.PanelHeaderStation = new System.Windows.Forms.Panel();
            this.LabelHeaderStation = new System.Windows.Forms.Label();
            this.PanelHeaderRoute = new System.Windows.Forms.Panel();
            this.LabelHeaderRoute = new System.Windows.Forms.Label();
            this.PanelHeaderKm = new System.Windows.Forms.Panel();
            this.LabelHeaderKm = new System.Windows.Forms.Label();
            this.PanelHeaderPrice = new System.Windows.Forms.Panel();
            this.LabelHeaderPrice = new System.Windows.Forms.Label();
            this.PanelHeaderLiters = new System.Windows.Forms.Panel();
            this.LabelHeaderLiters = new System.Windows.Forms.Label();
            this.PanelHeaderDriver = new System.Windows.Forms.Panel();
            this.LabelHeaderDriver = new System.Windows.Forms.Label();
            this.PanelHeaderPlate = new System.Windows.Forms.Panel();
            this.LabelHeaderPlate = new System.Windows.Forms.Label();
            this.PanelHeaderDate = new System.Windows.Forms.Panel();
            this.LabelHeaderDate = new System.Windows.Forms.Label();
            this.panel33 = new System.Windows.Forms.Panel();
            this.TitleFilter = new System.Windows.Forms.Panel();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelTrip = new System.Windows.Forms.Label();
            this.BoxTrip = new System.Windows.Forms.ComboBox();
            this.LabelRoute = new System.Windows.Forms.Label();
            this.BoxRoute = new System.Windows.Forms.ComboBox();
            this.LabelPlate = new System.Windows.Forms.Label();
            this.BoxPlate = new System.Windows.Forms.ComboBox();
            this.LabelDriver = new System.Windows.Forms.Label();
            this.LabelFinal = new System.Windows.Forms.Label();
            this.DatePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.LabelInitial = new System.Windows.Forms.Label();
            this.DatePickerInitial = new System.Windows.Forms.DateTimePicker();
            this.BoxDriver = new System.Windows.Forms.ComboBox();
            this.listSupply.SuspendLayout();
            this.container.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.HeaderList.SuspendLayout();
            this.PanelHeaderInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelHeaderTrip.SuspendLayout();
            this.PanelHeaderTotalPrice.SuspendLayout();
            this.PanelHeaderStation.SuspendLayout();
            this.PanelHeaderRoute.SuspendLayout();
            this.PanelHeaderKm.SuspendLayout();
            this.PanelHeaderPrice.SuspendLayout();
            this.PanelHeaderLiters.SuspendLayout();
            this.PanelHeaderDriver.SuspendLayout();
            this.PanelHeaderPlate.SuspendLayout();
            this.PanelHeaderDate.SuspendLayout();
            this.TitleFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerFilter
            // 
            this.timerFilter.Tick += new System.EventHandler(this.TimerFilter_Tick);
            // 
            // listSupply
            // 
            this.listSupply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listSupply.Controls.Add(this.container);
            this.listSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSupply.Location = new System.Drawing.Point(0, 0);
            this.listSupply.Name = "listSupply";
            this.listSupply.Size = new System.Drawing.Size(900, 500);
            this.listSupply.TabIndex = 0;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.container.Controls.Add(this.ButtonHome);
            this.container.Controls.Add(this.PageDescription);
            this.container.Controls.Add(this.ButtonFilter);
            this.container.Controls.Add(this.layoutFlex);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(900, 500);
            this.container.TabIndex = 0;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(711, 5);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(76, 31);
            this.ButtonHome.TabIndex = 3;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(418, 5);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(297, 31);
            this.PageDescription.TabIndex = 2;
            this.PageDescription.Text = "Listar Abastecimentos /";
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonFilter.FlatAppearance.BorderSize = 0;
            this.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFilter.Location = new System.Drawing.Point(36, 5);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(75, 28);
            this.ButtonFilter.TabIndex = 1;
            this.ButtonFilter.Text = "Filtros";
            this.ButtonFilter.UseVisualStyleBackColor = false;
            this.ButtonFilter.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // layoutFlex
            // 
            this.layoutFlex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutFlex.BackColor = System.Drawing.Color.Transparent;
            this.layoutFlex.ColumnCount = 1;
            this.layoutFlex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutFlex.Controls.Add(this.MainPanel, 0, 0);
            this.layoutFlex.Location = new System.Drawing.Point(15, 36);
            this.layoutFlex.Margin = new System.Windows.Forms.Padding(0);
            this.layoutFlex.Name = "layoutFlex";
            this.layoutFlex.RowCount = 1;
            this.layoutFlex.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutFlex.Size = new System.Drawing.Size(871, 434);
            this.layoutFlex.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.ListPanel);
            this.MainPanel.Controls.Add(this.HeaderList);
            this.MainPanel.Controls.Add(this.TitleFilter);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(871, 434);
            this.MainPanel.TabIndex = 0;
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 175);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(871, 259);
            this.ListPanel.TabIndex = 1;
            // 
            // HeaderList
            // 
            this.HeaderList.BackColor = System.Drawing.Color.DimGray;
            this.HeaderList.Controls.Add(this.PanelHeaderInfo);
            this.HeaderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderList.Location = new System.Drawing.Point(0, 134);
            this.HeaderList.Name = "HeaderList";
            this.HeaderList.Size = new System.Drawing.Size(871, 41);
            this.HeaderList.TabIndex = 0;
            // 
            // PanelHeaderInfo
            // 
            this.PanelHeaderInfo.Controls.Add(this.tableLayoutPanel1);
            this.PanelHeaderInfo.Controls.Add(this.panel33);
            this.PanelHeaderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelHeaderInfo.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderInfo.Name = "PanelHeaderInfo";
            this.PanelHeaderInfo.Size = new System.Drawing.Size(871, 41);
            this.PanelHeaderInfo.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.08F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.09F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.09F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.09F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.09F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.09F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.08F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.08F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.11F));
            this.tableLayoutPanel1.Controls.Add(this.PanelHeaderTrip, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelHeaderTotalPrice, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelHeaderStation, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelHeaderRoute, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelHeaderKm, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelHeaderPrice, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelHeaderLiters, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelHeaderDriver, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelHeaderPlate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelHeaderDate, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 38);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PanelHeaderTrip
            // 
            this.PanelHeaderTrip.Controls.Add(this.LabelHeaderTrip);
            this.PanelHeaderTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderTrip.Location = new System.Drawing.Point(725, 0);
            this.PanelHeaderTrip.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderTrip.Name = "PanelHeaderTrip";
            this.PanelHeaderTrip.Size = new System.Drawing.Size(96, 38);
            this.PanelHeaderTrip.TabIndex = 9;
            // 
            // LabelHeaderTrip
            // 
            this.LabelHeaderTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderTrip.AutoSize = true;
            this.LabelHeaderTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderTrip.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderTrip.Location = new System.Drawing.Point(11, 10);
            this.LabelHeaderTrip.Name = "LabelHeaderTrip";
            this.LabelHeaderTrip.Size = new System.Drawing.Size(63, 18);
            this.LabelHeaderTrip.TabIndex = 1;
            this.LabelHeaderTrip.Text = "Viagem";
            // 
            // PanelHeaderTotalPrice
            // 
            this.PanelHeaderTotalPrice.Controls.Add(this.LabelHeaderTotalPrice);
            this.PanelHeaderTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderTotalPrice.Location = new System.Drawing.Point(646, 0);
            this.PanelHeaderTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderTotalPrice.Name = "PanelHeaderTotalPrice";
            this.PanelHeaderTotalPrice.Size = new System.Drawing.Size(79, 38);
            this.PanelHeaderTotalPrice.TabIndex = 8;
            // 
            // LabelHeaderTotalPrice
            // 
            this.LabelHeaderTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderTotalPrice.AutoSize = true;
            this.LabelHeaderTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderTotalPrice.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderTotalPrice.Location = new System.Drawing.Point(2, 10);
            this.LabelHeaderTotalPrice.Name = "LabelHeaderTotalPrice";
            this.LabelHeaderTotalPrice.Size = new System.Drawing.Size(46, 18);
            this.LabelHeaderTotalPrice.TabIndex = 1;
            this.LabelHeaderTotalPrice.Text = "Total";
            // 
            // PanelHeaderStation
            // 
            this.PanelHeaderStation.Controls.Add(this.LabelHeaderStation);
            this.PanelHeaderStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderStation.Location = new System.Drawing.Point(567, 0);
            this.PanelHeaderStation.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderStation.Name = "PanelHeaderStation";
            this.PanelHeaderStation.Size = new System.Drawing.Size(79, 38);
            this.PanelHeaderStation.TabIndex = 7;
            // 
            // LabelHeaderStation
            // 
            this.LabelHeaderStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderStation.AutoSize = true;
            this.LabelHeaderStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderStation.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderStation.Location = new System.Drawing.Point(18, 10);
            this.LabelHeaderStation.Name = "LabelHeaderStation";
            this.LabelHeaderStation.Size = new System.Drawing.Size(53, 18);
            this.LabelHeaderStation.TabIndex = 1;
            this.LabelHeaderStation.Text = "Posto";
            // 
            // PanelHeaderRoute
            // 
            this.PanelHeaderRoute.Controls.Add(this.LabelHeaderRoute);
            this.PanelHeaderRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderRoute.Location = new System.Drawing.Point(480, 0);
            this.PanelHeaderRoute.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderRoute.Name = "PanelHeaderRoute";
            this.PanelHeaderRoute.Size = new System.Drawing.Size(87, 38);
            this.PanelHeaderRoute.TabIndex = 6;
            // 
            // LabelHeaderRoute
            // 
            this.LabelHeaderRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderRoute.AutoSize = true;
            this.LabelHeaderRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderRoute.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderRoute.Location = new System.Drawing.Point(22, 10);
            this.LabelHeaderRoute.Name = "LabelHeaderRoute";
            this.LabelHeaderRoute.Size = new System.Drawing.Size(44, 18);
            this.LabelHeaderRoute.TabIndex = 1;
            this.LabelHeaderRoute.Text = "Rota";
            // 
            // PanelHeaderKm
            // 
            this.PanelHeaderKm.Controls.Add(this.LabelHeaderKm);
            this.PanelHeaderKm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderKm.Location = new System.Drawing.Point(384, 0);
            this.PanelHeaderKm.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderKm.Name = "PanelHeaderKm";
            this.PanelHeaderKm.Size = new System.Drawing.Size(96, 38);
            this.PanelHeaderKm.TabIndex = 5;
            // 
            // LabelHeaderKm
            // 
            this.LabelHeaderKm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderKm.AutoSize = true;
            this.LabelHeaderKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderKm.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderKm.Location = new System.Drawing.Point(27, 10);
            this.LabelHeaderKm.Name = "LabelHeaderKm";
            this.LabelHeaderKm.Size = new System.Drawing.Size(33, 18);
            this.LabelHeaderKm.TabIndex = 1;
            this.LabelHeaderKm.Text = "Km";
            // 
            // PanelHeaderPrice
            // 
            this.PanelHeaderPrice.Controls.Add(this.LabelHeaderPrice);
            this.PanelHeaderPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderPrice.Location = new System.Drawing.Point(323, 0);
            this.PanelHeaderPrice.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderPrice.Name = "PanelHeaderPrice";
            this.PanelHeaderPrice.Size = new System.Drawing.Size(61, 38);
            this.PanelHeaderPrice.TabIndex = 4;
            // 
            // LabelHeaderPrice
            // 
            this.LabelHeaderPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderPrice.AutoSize = true;
            this.LabelHeaderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderPrice.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderPrice.Location = new System.Drawing.Point(4, 10);
            this.LabelHeaderPrice.Name = "LabelHeaderPrice";
            this.LabelHeaderPrice.Size = new System.Drawing.Size(53, 18);
            this.LabelHeaderPrice.TabIndex = 1;
            this.LabelHeaderPrice.Text = "Preço";
            // 
            // PanelHeaderLiters
            // 
            this.PanelHeaderLiters.Controls.Add(this.LabelHeaderLiters);
            this.PanelHeaderLiters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderLiters.Location = new System.Drawing.Point(262, 0);
            this.PanelHeaderLiters.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderLiters.Name = "PanelHeaderLiters";
            this.PanelHeaderLiters.Size = new System.Drawing.Size(61, 38);
            this.PanelHeaderLiters.TabIndex = 3;
            // 
            // LabelHeaderLiters
            // 
            this.LabelHeaderLiters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderLiters.AutoSize = true;
            this.LabelHeaderLiters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderLiters.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderLiters.Location = new System.Drawing.Point(7, 10);
            this.LabelHeaderLiters.Name = "LabelHeaderLiters";
            this.LabelHeaderLiters.Size = new System.Drawing.Size(51, 18);
            this.LabelHeaderLiters.TabIndex = 1;
            this.LabelHeaderLiters.Text = "Litros";
            // 
            // PanelHeaderDriver
            // 
            this.PanelHeaderDriver.Controls.Add(this.LabelHeaderDriver);
            this.PanelHeaderDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderDriver.Location = new System.Drawing.Point(175, 0);
            this.PanelHeaderDriver.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderDriver.Name = "PanelHeaderDriver";
            this.PanelHeaderDriver.Size = new System.Drawing.Size(87, 38);
            this.PanelHeaderDriver.TabIndex = 2;
            // 
            // LabelHeaderDriver
            // 
            this.LabelHeaderDriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderDriver.AutoSize = true;
            this.LabelHeaderDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderDriver.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderDriver.Location = new System.Drawing.Point(6, 10);
            this.LabelHeaderDriver.Name = "LabelHeaderDriver";
            this.LabelHeaderDriver.Size = new System.Drawing.Size(80, 18);
            this.LabelHeaderDriver.TabIndex = 1;
            this.LabelHeaderDriver.Text = "Motorista";
            // 
            // PanelHeaderPlate
            // 
            this.PanelHeaderPlate.Controls.Add(this.LabelHeaderPlate);
            this.PanelHeaderPlate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderPlate.Location = new System.Drawing.Point(96, 0);
            this.PanelHeaderPlate.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderPlate.Name = "PanelHeaderPlate";
            this.PanelHeaderPlate.Size = new System.Drawing.Size(79, 38);
            this.PanelHeaderPlate.TabIndex = 1;
            // 
            // LabelHeaderPlate
            // 
            this.LabelHeaderPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderPlate.AutoSize = true;
            this.LabelHeaderPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderPlate.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderPlate.Location = new System.Drawing.Point(18, 10);
            this.LabelHeaderPlate.Name = "LabelHeaderPlate";
            this.LabelHeaderPlate.Size = new System.Drawing.Size(50, 18);
            this.LabelHeaderPlate.TabIndex = 1;
            this.LabelHeaderPlate.Text = "Placa";
            // 
            // PanelHeaderDate
            // 
            this.PanelHeaderDate.Controls.Add(this.LabelHeaderDate);
            this.PanelHeaderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderDate.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderDate.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderDate.Name = "PanelHeaderDate";
            this.PanelHeaderDate.Size = new System.Drawing.Size(96, 38);
            this.PanelHeaderDate.TabIndex = 0;
            // 
            // LabelHeaderDate
            // 
            this.LabelHeaderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderDate.AutoSize = true;
            this.LabelHeaderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderDate.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderDate.Location = new System.Drawing.Point(24, 10);
            this.LabelHeaderDate.Name = "LabelHeaderDate";
            this.LabelHeaderDate.Size = new System.Drawing.Size(43, 18);
            this.LabelHeaderDate.TabIndex = 0;
            this.LabelHeaderDate.Text = "Data";
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel33.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel33.Location = new System.Drawing.Point(0, 38);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(871, 3);
            this.panel33.TabIndex = 0;
            // 
            // TitleFilter
            // 
            this.TitleFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.TitleFilter.Controls.Add(this.ButtonSave);
            this.TitleFilter.Controls.Add(this.LabelTrip);
            this.TitleFilter.Controls.Add(this.BoxTrip);
            this.TitleFilter.Controls.Add(this.LabelRoute);
            this.TitleFilter.Controls.Add(this.BoxRoute);
            this.TitleFilter.Controls.Add(this.LabelPlate);
            this.TitleFilter.Controls.Add(this.BoxPlate);
            this.TitleFilter.Controls.Add(this.LabelDriver);
            this.TitleFilter.Controls.Add(this.LabelFinal);
            this.TitleFilter.Controls.Add(this.DatePickerFinal);
            this.TitleFilter.Controls.Add(this.LabelInitial);
            this.TitleFilter.Controls.Add(this.DatePickerInitial);
            this.TitleFilter.Controls.Add(this.BoxDriver);
            this.TitleFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFilter.Location = new System.Drawing.Point(0, 0);
            this.TitleFilter.Margin = new System.Windows.Forms.Padding(0);
            this.TitleFilter.MaximumSize = new System.Drawing.Size(2000, 134);
            this.TitleFilter.Name = "TitleFilter";
            this.TitleFilter.Size = new System.Drawing.Size(871, 134);
            this.TitleFilter.TabIndex = 0;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.Crimson;
            this.ButtonSave.FlatAppearance.BorderSize = 0;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.Azure;
            this.ButtonSave.Location = new System.Drawing.Point(669, 79);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(188, 41);
            this.ButtonSave.TabIndex = 70;
            this.ButtonSave.Text = "Cadastrar Abastecimento";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelTrip
            // 
            this.LabelTrip.AutoSize = true;
            this.LabelTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrip.ForeColor = System.Drawing.Color.Azure;
            this.LabelTrip.Location = new System.Drawing.Point(361, 26);
            this.LabelTrip.Name = "LabelTrip";
            this.LabelTrip.Size = new System.Drawing.Size(63, 20);
            this.LabelTrip.TabIndex = 12;
            this.LabelTrip.Text = "Viagem";
            // 
            // BoxTrip
            // 
            this.BoxTrip.FormattingEnabled = true;
            this.BoxTrip.Location = new System.Drawing.Point(365, 49);
            this.BoxTrip.Name = "BoxTrip";
            this.BoxTrip.Size = new System.Drawing.Size(121, 21);
            this.BoxTrip.TabIndex = 11;
            // 
            // LabelRoute
            // 
            this.LabelRoute.AutoSize = true;
            this.LabelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoute.ForeColor = System.Drawing.Color.Azure;
            this.LabelRoute.Location = new System.Drawing.Point(536, 26);
            this.LabelRoute.Name = "LabelRoute";
            this.LabelRoute.Size = new System.Drawing.Size(44, 20);
            this.LabelRoute.TabIndex = 10;
            this.LabelRoute.Text = "Rota";
            // 
            // BoxRoute
            // 
            this.BoxRoute.FormattingEnabled = true;
            this.BoxRoute.Location = new System.Drawing.Point(540, 49);
            this.BoxRoute.Name = "BoxRoute";
            this.BoxRoute.Size = new System.Drawing.Size(121, 21);
            this.BoxRoute.TabIndex = 9;
            // 
            // LabelPlate
            // 
            this.LabelPlate.AutoSize = true;
            this.LabelPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlate.ForeColor = System.Drawing.Color.Azure;
            this.LabelPlate.Location = new System.Drawing.Point(361, 83);
            this.LabelPlate.Name = "LabelPlate";
            this.LabelPlate.Size = new System.Drawing.Size(48, 20);
            this.LabelPlate.TabIndex = 8;
            this.LabelPlate.Text = "Placa";
            // 
            // BoxPlate
            // 
            this.BoxPlate.FormattingEnabled = true;
            this.BoxPlate.Location = new System.Drawing.Point(365, 106);
            this.BoxPlate.Name = "BoxPlate";
            this.BoxPlate.Size = new System.Drawing.Size(121, 21);
            this.BoxPlate.TabIndex = 7;
            // 
            // LabelDriver
            // 
            this.LabelDriver.AutoSize = true;
            this.LabelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDriver.ForeColor = System.Drawing.Color.Azure;
            this.LabelDriver.Location = new System.Drawing.Point(78, 79);
            this.LabelDriver.Name = "LabelDriver";
            this.LabelDriver.Size = new System.Drawing.Size(75, 20);
            this.LabelDriver.TabIndex = 6;
            this.LabelDriver.Text = "Motorista";
            // 
            // LabelFinal
            // 
            this.LabelFinal.AutoSize = true;
            this.LabelFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFinal.ForeColor = System.Drawing.Color.Azure;
            this.LabelFinal.Location = new System.Drawing.Point(196, 22);
            this.LabelFinal.Name = "LabelFinal";
            this.LabelFinal.Size = new System.Drawing.Size(82, 20);
            this.LabelFinal.TabIndex = 5;
            this.LabelFinal.Text = "Data Final";
            // 
            // DatePickerFinal
            // 
            this.DatePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerFinal.Location = new System.Drawing.Point(200, 45);
            this.DatePickerFinal.Name = "DatePickerFinal";
            this.DatePickerFinal.Size = new System.Drawing.Size(94, 20);
            this.DatePickerFinal.TabIndex = 4;
            // 
            // LabelInitial
            // 
            this.LabelInitial.AutoSize = true;
            this.LabelInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInitial.ForeColor = System.Drawing.Color.Azure;
            this.LabelInitial.Location = new System.Drawing.Point(78, 22);
            this.LabelInitial.Name = "LabelInitial";
            this.LabelInitial.Size = new System.Drawing.Size(88, 20);
            this.LabelInitial.TabIndex = 3;
            this.LabelInitial.Text = "Data Inicial";
            // 
            // DatePickerInitial
            // 
            this.DatePickerInitial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerInitial.Location = new System.Drawing.Point(82, 45);
            this.DatePickerInitial.Name = "DatePickerInitial";
            this.DatePickerInitial.Size = new System.Drawing.Size(95, 20);
            this.DatePickerInitial.TabIndex = 2;
            // 
            // BoxDriver
            // 
            this.BoxDriver.FormattingEnabled = true;
            this.BoxDriver.Location = new System.Drawing.Point(83, 102);
            this.BoxDriver.Name = "BoxDriver";
            this.BoxDriver.Size = new System.Drawing.Size(211, 21);
            this.BoxDriver.TabIndex = 0;
            // 
            // ListarAbastecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.listSupply);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListarAbastecimentos";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.ListarAbastecimentos_Load);
            this.listSupply.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.HeaderList.ResumeLayout(false);
            this.PanelHeaderInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelHeaderTrip.ResumeLayout(false);
            this.PanelHeaderTrip.PerformLayout();
            this.PanelHeaderTotalPrice.ResumeLayout(false);
            this.PanelHeaderTotalPrice.PerformLayout();
            this.PanelHeaderStation.ResumeLayout(false);
            this.PanelHeaderStation.PerformLayout();
            this.PanelHeaderRoute.ResumeLayout(false);
            this.PanelHeaderRoute.PerformLayout();
            this.PanelHeaderKm.ResumeLayout(false);
            this.PanelHeaderKm.PerformLayout();
            this.PanelHeaderPrice.ResumeLayout(false);
            this.PanelHeaderPrice.PerformLayout();
            this.PanelHeaderLiters.ResumeLayout(false);
            this.PanelHeaderLiters.PerformLayout();
            this.PanelHeaderDriver.ResumeLayout(false);
            this.PanelHeaderDriver.PerformLayout();
            this.PanelHeaderPlate.ResumeLayout(false);
            this.PanelHeaderPlate.PerformLayout();
            this.PanelHeaderDate.ResumeLayout(false);
            this.PanelHeaderDate.PerformLayout();
            this.TitleFilter.ResumeLayout(false);
            this.TitleFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerFilter;
        private System.Windows.Forms.Panel listSupply;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Button ButtonFilter;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel HeaderList;
        private System.Windows.Forms.Panel PanelHeaderInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelHeaderTrip;
        private System.Windows.Forms.Label LabelHeaderTrip;
        private System.Windows.Forms.Panel PanelHeaderTotalPrice;
        private System.Windows.Forms.Label LabelHeaderTotalPrice;
        private System.Windows.Forms.Panel PanelHeaderStation;
        private System.Windows.Forms.Label LabelHeaderStation;
        private System.Windows.Forms.Panel PanelHeaderRoute;
        private System.Windows.Forms.Label LabelHeaderRoute;
        private System.Windows.Forms.Panel PanelHeaderKm;
        private System.Windows.Forms.Label LabelHeaderKm;
        private System.Windows.Forms.Panel PanelHeaderPrice;
        private System.Windows.Forms.Label LabelHeaderPrice;
        private System.Windows.Forms.Panel PanelHeaderLiters;
        private System.Windows.Forms.Label LabelHeaderLiters;
        private System.Windows.Forms.Panel PanelHeaderDriver;
        private System.Windows.Forms.Label LabelHeaderDriver;
        private System.Windows.Forms.Panel PanelHeaderPlate;
        private System.Windows.Forms.Label LabelHeaderPlate;
        private System.Windows.Forms.Panel PanelHeaderDate;
        private System.Windows.Forms.Label LabelHeaderDate;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel TitleFilter;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelTrip;
        private System.Windows.Forms.ComboBox BoxTrip;
        private System.Windows.Forms.Label LabelRoute;
        private System.Windows.Forms.ComboBox BoxRoute;
        private System.Windows.Forms.Label LabelPlate;
        private System.Windows.Forms.ComboBox BoxPlate;
        private System.Windows.Forms.Label LabelDriver;
        private System.Windows.Forms.Label LabelFinal;
        private System.Windows.Forms.DateTimePicker DatePickerFinal;
        private System.Windows.Forms.Label LabelInitial;
        private System.Windows.Forms.DateTimePicker DatePickerInitial;
        private System.Windows.Forms.ComboBox BoxDriver;
    }
}
