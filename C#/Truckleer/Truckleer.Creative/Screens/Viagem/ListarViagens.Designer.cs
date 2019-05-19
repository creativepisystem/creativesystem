namespace Truckleer.Creative.Screens.Viagem
{
    partial class ListarViagens
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
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelFilter = new System.Windows.Forms.Panel();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.TextTrip = new System.Windows.Forms.TextBox();
            this.ButtonCadastro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatePickerInitial = new System.Windows.Forms.DateTimePicker();
            this.LabelInitial = new System.Windows.Forms.Label();
            this.DatePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.LabelFinal = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LayoutHeader = new System.Windows.Forms.TableLayoutPanel();
            this.PanelHeaderDate = new System.Windows.Forms.Panel();
            this.LabelHeaderDate = new System.Windows.Forms.Label();
            this.PanelHeaderTrip = new System.Windows.Forms.Panel();
            this.LabelHeaderTrip = new System.Windows.Forms.Label();
            this.PanelHeaderVehicle = new System.Windows.Forms.Panel();
            this.LabelHeaderVehicle = new System.Windows.Forms.Label();
            this.PanelHeaderDriver = new System.Windows.Forms.Panel();
            this.LabelHeaderDriver = new System.Windows.Forms.Label();
            this.PanelHeaderRoute = new System.Windows.Forms.Panel();
            this.LabelHeaderRoute = new System.Windows.Forms.Label();
            this.PanelRoute = new System.Windows.Forms.Panel();
            this.PageDescription = new System.Windows.Forms.Label();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelFilter.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.LayoutHeader.SuspendLayout();
            this.PanelHeaderDate.SuspendLayout();
            this.PanelHeaderTrip.SuspendLayout();
            this.PanelHeaderVehicle.SuspendLayout();
            this.PanelHeaderDriver.SuspendLayout();
            this.PanelHeaderRoute.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
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
            this.layoutFlex.Size = new System.Drawing.Size(1141, 693);
            this.layoutFlex.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.PanelRoute);
            this.MainPanel.Controls.Add(this.PanelHeader);
            this.MainPanel.Controls.Add(this.PanelFilter);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1141, 693);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelFilter
            // 
            this.PanelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelFilter.Controls.Add(this.LabelFinal);
            this.PanelFilter.Controls.Add(this.DatePickerFinal);
            this.PanelFilter.Controls.Add(this.LabelInitial);
            this.PanelFilter.Controls.Add(this.DatePickerInitial);
            this.PanelFilter.Controls.Add(this.panel1);
            this.PanelFilter.Controls.Add(this.ButtonCadastro);
            this.PanelFilter.Controls.Add(this.TextTrip);
            this.PanelFilter.Controls.Add(this.LabelSearch);
            this.PanelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFilter.Location = new System.Drawing.Point(0, 0);
            this.PanelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.PanelFilter.MaximumSize = new System.Drawing.Size(2000, 100);
            this.PanelFilter.Name = "PanelFilter";
            this.PanelFilter.Size = new System.Drawing.Size(1141, 100);
            this.PanelFilter.TabIndex = 0;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.ForeColor = System.Drawing.Color.Azure;
            this.LabelSearch.Location = new System.Drawing.Point(343, 19);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(145, 25);
            this.LabelSearch.TabIndex = 0;
            this.LabelSearch.Text = "Buscar Viagem";
            // 
            // TextTrip
            // 
            this.TextTrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTrip.Location = new System.Drawing.Point(348, 46);
            this.TextTrip.Name = "TextTrip";
            this.TextTrip.Size = new System.Drawing.Size(299, 31);
            this.TextTrip.TabIndex = 1;
            // 
            // ButtonCadastro
            // 
            this.ButtonCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCadastro.BackColor = System.Drawing.Color.Crimson;
            this.ButtonCadastro.FlatAppearance.BorderSize = 0;
            this.ButtonCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCadastro.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCadastro.ForeColor = System.Drawing.Color.Azure;
            this.ButtonCadastro.Location = new System.Drawing.Point(977, 50);
            this.ButtonCadastro.Name = "ButtonCadastro";
            this.ButtonCadastro.Size = new System.Drawing.Size(132, 32);
            this.ButtonCadastro.TabIndex = 70;
            this.ButtonCadastro.Text = "Cadastrar Rota";
            this.ButtonCadastro.UseVisualStyleBackColor = false;
            this.ButtonCadastro.Click += new System.EventHandler(this.ButtonCadastro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 2);
            this.panel1.TabIndex = 71;
            // 
            // DatePickerInitial
            // 
            this.DatePickerInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerInitial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerInitial.Location = new System.Drawing.Point(58, 54);
            this.DatePickerInitial.Name = "DatePickerInitial";
            this.DatePickerInitial.Size = new System.Drawing.Size(95, 23);
            this.DatePickerInitial.TabIndex = 72;
            // 
            // LabelInitial
            // 
            this.LabelInitial.AutoSize = true;
            this.LabelInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInitial.ForeColor = System.Drawing.Color.Azure;
            this.LabelInitial.Location = new System.Drawing.Point(54, 23);
            this.LabelInitial.Name = "LabelInitial";
            this.LabelInitial.Size = new System.Drawing.Size(100, 20);
            this.LabelInitial.TabIndex = 73;
            this.LabelInitial.Text = "Data Inicial";
            // 
            // DatePickerFinal
            // 
            this.DatePickerFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerFinal.Location = new System.Drawing.Point(176, 54);
            this.DatePickerFinal.Name = "DatePickerFinal";
            this.DatePickerFinal.Size = new System.Drawing.Size(94, 23);
            this.DatePickerFinal.TabIndex = 74;
            // 
            // LabelFinal
            // 
            this.LabelFinal.AutoSize = true;
            this.LabelFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFinal.ForeColor = System.Drawing.Color.Azure;
            this.LabelFinal.Location = new System.Drawing.Point(172, 23);
            this.LabelFinal.Name = "LabelFinal";
            this.LabelFinal.Size = new System.Drawing.Size(92, 20);
            this.LabelFinal.TabIndex = 75;
            this.LabelFinal.Text = "Data Final";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelHeader.Controls.Add(this.LayoutHeader);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 100);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1141, 45);
            this.PanelHeader.TabIndex = 16;
            // 
            // LayoutHeader
            // 
            this.LayoutHeader.ColumnCount = 6;
            this.LayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33F));
            this.LayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.33F));
            this.LayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.34F));
            this.LayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.33F));
            this.LayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.34F));
            this.LayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.33F));
            this.LayoutHeader.Controls.Add(this.PanelHeaderRoute, 4, 0);
            this.LayoutHeader.Controls.Add(this.PanelHeaderDriver, 3, 0);
            this.LayoutHeader.Controls.Add(this.PanelHeaderVehicle, 2, 0);
            this.LayoutHeader.Controls.Add(this.PanelHeaderTrip, 1, 0);
            this.LayoutHeader.Controls.Add(this.PanelHeaderDate, 0, 0);
            this.LayoutHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutHeader.Location = new System.Drawing.Point(0, 0);
            this.LayoutHeader.Name = "LayoutHeader";
            this.LayoutHeader.RowCount = 1;
            this.LayoutHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutHeader.Size = new System.Drawing.Size(1141, 45);
            this.LayoutHeader.TabIndex = 0;
            // 
            // PanelHeaderDate
            // 
            this.PanelHeaderDate.Controls.Add(this.LabelHeaderDate);
            this.PanelHeaderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderDate.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderDate.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderDate.Name = "PanelHeaderDate";
            this.PanelHeaderDate.Size = new System.Drawing.Size(186, 45);
            this.PanelHeaderDate.TabIndex = 0;
            // 
            // LabelHeaderDate
            // 
            this.LabelHeaderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHeaderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderDate.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderDate.Location = new System.Drawing.Point(0, 0);
            this.LabelHeaderDate.Name = "LabelHeaderDate";
            this.LabelHeaderDate.Size = new System.Drawing.Size(186, 45);
            this.LabelHeaderDate.TabIndex = 0;
            this.LabelHeaderDate.Text = "Data";
            this.LabelHeaderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeaderTrip
            // 
            this.PanelHeaderTrip.Controls.Add(this.LabelHeaderTrip);
            this.PanelHeaderTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderTrip.Location = new System.Drawing.Point(186, 0);
            this.PanelHeaderTrip.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderTrip.Name = "PanelHeaderTrip";
            this.PanelHeaderTrip.Size = new System.Drawing.Size(209, 45);
            this.PanelHeaderTrip.TabIndex = 1;
            // 
            // LabelHeaderTrip
            // 
            this.LabelHeaderTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHeaderTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderTrip.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderTrip.Location = new System.Drawing.Point(0, 0);
            this.LabelHeaderTrip.Name = "LabelHeaderTrip";
            this.LabelHeaderTrip.Size = new System.Drawing.Size(209, 45);
            this.LabelHeaderTrip.TabIndex = 1;
            this.LabelHeaderTrip.Text = "Viagem";
            this.LabelHeaderTrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeaderVehicle
            // 
            this.PanelHeaderVehicle.Controls.Add(this.LabelHeaderVehicle);
            this.PanelHeaderVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderVehicle.Location = new System.Drawing.Point(395, 0);
            this.PanelHeaderVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderVehicle.Name = "PanelHeaderVehicle";
            this.PanelHeaderVehicle.Size = new System.Drawing.Size(186, 45);
            this.PanelHeaderVehicle.TabIndex = 2;
            // 
            // LabelHeaderVehicle
            // 
            this.LabelHeaderVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHeaderVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderVehicle.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderVehicle.Location = new System.Drawing.Point(0, 0);
            this.LabelHeaderVehicle.Name = "LabelHeaderVehicle";
            this.LabelHeaderVehicle.Size = new System.Drawing.Size(186, 45);
            this.LabelHeaderVehicle.TabIndex = 1;
            this.LabelHeaderVehicle.Text = "Veículo";
            this.LabelHeaderVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeaderDriver
            // 
            this.PanelHeaderDriver.Controls.Add(this.LabelHeaderDriver);
            this.PanelHeaderDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderDriver.Location = new System.Drawing.Point(581, 0);
            this.PanelHeaderDriver.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderDriver.Name = "PanelHeaderDriver";
            this.PanelHeaderDriver.Size = new System.Drawing.Size(231, 45);
            this.PanelHeaderDriver.TabIndex = 3;
            // 
            // LabelHeaderDriver
            // 
            this.LabelHeaderDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHeaderDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderDriver.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderDriver.Location = new System.Drawing.Point(0, 0);
            this.LabelHeaderDriver.Name = "LabelHeaderDriver";
            this.LabelHeaderDriver.Size = new System.Drawing.Size(231, 45);
            this.LabelHeaderDriver.TabIndex = 1;
            this.LabelHeaderDriver.Text = "Motorista";
            this.LabelHeaderDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeaderRoute
            // 
            this.PanelHeaderRoute.Controls.Add(this.LabelHeaderRoute);
            this.PanelHeaderRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeaderRoute.Location = new System.Drawing.Point(812, 0);
            this.PanelHeaderRoute.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeaderRoute.Name = "PanelHeaderRoute";
            this.PanelHeaderRoute.Size = new System.Drawing.Size(209, 45);
            this.PanelHeaderRoute.TabIndex = 4;
            // 
            // LabelHeaderRoute
            // 
            this.LabelHeaderRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHeaderRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderRoute.ForeColor = System.Drawing.Color.Azure;
            this.LabelHeaderRoute.Location = new System.Drawing.Point(0, 0);
            this.LabelHeaderRoute.Name = "LabelHeaderRoute";
            this.LabelHeaderRoute.Size = new System.Drawing.Size(209, 45);
            this.LabelHeaderRoute.TabIndex = 1;
            this.LabelHeaderRoute.Text = "Rota";
            this.LabelHeaderRoute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRoute
            // 
            this.PanelRoute.BackColor = System.Drawing.Color.Gray;
            this.PanelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoute.Location = new System.Drawing.Point(0, 145);
            this.PanelRoute.Name = "PanelRoute";
            this.PanelRoute.Size = new System.Drawing.Size(1141, 548);
            this.PanelRoute.TabIndex = 17;
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(812, 3);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(175, 31);
            this.PageDescription.TabIndex = 48;
            this.PageDescription.Text = "Listar Rotas /";
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(981, 5);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(76, 31);
            this.ButtonHome.TabIndex = 49;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.container.Controls.Add(this.ButtonHome);
            this.container.Controls.Add(this.PageDescription);
            this.container.Controls.Add(this.layoutFlex);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1170, 759);
            this.container.TabIndex = 2;
            // 
            // ListarViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Name = "ListarViagens";
            this.Size = new System.Drawing.Size(1170, 759);
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelFilter.ResumeLayout(false);
            this.PanelFilter.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.LayoutHeader.ResumeLayout(false);
            this.PanelHeaderDate.ResumeLayout(false);
            this.PanelHeaderTrip.ResumeLayout(false);
            this.PanelHeaderVehicle.ResumeLayout(false);
            this.PanelHeaderDriver.ResumeLayout(false);
            this.PanelHeaderRoute.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelRoute;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.TableLayoutPanel LayoutHeader;
        private System.Windows.Forms.Panel PanelHeaderRoute;
        private System.Windows.Forms.Label LabelHeaderRoute;
        private System.Windows.Forms.Panel PanelHeaderDriver;
        private System.Windows.Forms.Label LabelHeaderDriver;
        private System.Windows.Forms.Panel PanelHeaderVehicle;
        private System.Windows.Forms.Label LabelHeaderVehicle;
        private System.Windows.Forms.Panel PanelHeaderTrip;
        private System.Windows.Forms.Label LabelHeaderTrip;
        private System.Windows.Forms.Panel PanelHeaderDate;
        private System.Windows.Forms.Label LabelHeaderDate;
        private System.Windows.Forms.Panel PanelFilter;
        private System.Windows.Forms.Label LabelFinal;
        private System.Windows.Forms.DateTimePicker DatePickerFinal;
        private System.Windows.Forms.Label LabelInitial;
        private System.Windows.Forms.DateTimePicker DatePickerInitial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonCadastro;
        private System.Windows.Forms.TextBox TextTrip;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Panel container;
    }
}
