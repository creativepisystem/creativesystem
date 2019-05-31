using System.ComponentModel;

namespace Truckleer.Creative
{
    partial class ListarMotoristas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private BackgroundWorker driverListWorker;

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
            this.driverListWorker = new System.ComponentModel.BackgroundWorker();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelListDriver = new System.Windows.Forms.Panel();
            this.FlowDriver = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleFilter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCadastro = new System.Windows.Forms.Button();
            this.LabelChn = new System.Windows.Forms.Label();
            this.BoxCnh = new System.Windows.Forms.ComboBox();
            this.LabelDriver = new System.Windows.Forms.Label();
            this.BoxDriver = new System.Windows.Forms.ComboBox();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.PageDescription = new System.Windows.Forms.Label();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelListDriver.SuspendLayout();
            this.FlowDriver.SuspendLayout();
            this.TitleFilter.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtro
            // 
            this.filtro.Tick += new System.EventHandler(this.Filtro_Tick);
            // 
            // driverListWorker
            // 
            this.driverListWorker.WorkerReportsProgress = true;
            this.driverListWorker.WorkerSupportsCancellation = true;
            this.driverListWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FilterDriver);
            this.driverListWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.FilterDriverProgress);
            this.driverListWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FilterDriverFinish);
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
            this.MainPanel.Controls.Add(this.PanelListDriver);
            this.MainPanel.Controls.Add(this.TitleFilter);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1141, 693);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelListDriver
            // 
            this.PanelListDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.PanelListDriver.Controls.Add(this.FlowDriver);
            this.PanelListDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListDriver.Location = new System.Drawing.Point(0, 100);
            this.PanelListDriver.Name = "PanelListDriver";
            this.PanelListDriver.Size = new System.Drawing.Size(1141, 593);
            this.PanelListDriver.TabIndex = 1;
            // 
            // FlowDriver
            // 
            this.FlowDriver.AutoScroll = true;
            this.FlowDriver.Controls.Add(this.ProgressBar);
            this.FlowDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowDriver.Location = new System.Drawing.Point(0, 0);
            this.FlowDriver.Name = "FlowDriver";
            this.FlowDriver.Size = new System.Drawing.Size(1141, 593);
            this.FlowDriver.TabIndex = 0;
            // 
            // TitleFilter
            // 
            this.TitleFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TitleFilter.Controls.Add(this.panel1);
            this.TitleFilter.Controls.Add(this.ButtonCadastro);
            this.TitleFilter.Controls.Add(this.LabelChn);
            this.TitleFilter.Controls.Add(this.BoxCnh);
            this.TitleFilter.Controls.Add(this.LabelDriver);
            this.TitleFilter.Controls.Add(this.BoxDriver);
            this.TitleFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFilter.Location = new System.Drawing.Point(0, 0);
            this.TitleFilter.Margin = new System.Windows.Forms.Padding(0);
            this.TitleFilter.MaximumSize = new System.Drawing.Size(2000, 100);
            this.TitleFilter.Name = "TitleFilter";
            this.TitleFilter.Size = new System.Drawing.Size(1141, 100);
            this.TitleFilter.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 1);
            this.panel1.TabIndex = 71;
            // 
            // ButtonCadastro
            // 
            this.ButtonCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCadastro.BackColor = System.Drawing.Color.Crimson;
            this.ButtonCadastro.FlatAppearance.BorderSize = 0;
            this.ButtonCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCadastro.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCadastro.ForeColor = System.Drawing.Color.Azure;
            this.ButtonCadastro.Location = new System.Drawing.Point(964, 53);
            this.ButtonCadastro.Name = "ButtonCadastro";
            this.ButtonCadastro.Size = new System.Drawing.Size(151, 32);
            this.ButtonCadastro.TabIndex = 70;
            this.ButtonCadastro.Text = "Cadastrar Motorista";
            this.ButtonCadastro.UseVisualStyleBackColor = false;
            this.ButtonCadastro.Click += new System.EventHandler(this.ButtonCadastro_Click);
            // 
            // LabelChn
            // 
            this.LabelChn.AutoSize = true;
            this.LabelChn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChn.ForeColor = System.Drawing.Color.Azure;
            this.LabelChn.Location = new System.Drawing.Point(267, 31);
            this.LabelChn.Name = "LabelChn";
            this.LabelChn.Size = new System.Drawing.Size(43, 20);
            this.LabelChn.TabIndex = 22;
            this.LabelChn.Text = "CNH";
            // 
            // BoxCnh
            // 
            this.BoxCnh.FormattingEnabled = true;
            this.BoxCnh.Location = new System.Drawing.Point(272, 54);
            this.BoxCnh.Name = "BoxCnh";
            this.BoxCnh.Size = new System.Drawing.Size(109, 21);
            this.BoxCnh.TabIndex = 21;
            // 
            // LabelDriver
            // 
            this.LabelDriver.AutoSize = true;
            this.LabelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDriver.ForeColor = System.Drawing.Color.Azure;
            this.LabelDriver.Location = new System.Drawing.Point(94, 31);
            this.LabelDriver.Name = "LabelDriver";
            this.LabelDriver.Size = new System.Drawing.Size(75, 20);
            this.LabelDriver.TabIndex = 20;
            this.LabelDriver.Text = "Motorista";
            // 
            // BoxDriver
            // 
            this.BoxDriver.FormattingEnabled = true;
            this.BoxDriver.Location = new System.Drawing.Point(99, 54);
            this.BoxDriver.Name = "BoxDriver";
            this.BoxDriver.Size = new System.Drawing.Size(109, 21);
            this.BoxDriver.TabIndex = 19;
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonFilter.FlatAppearance.BorderSize = 0;
            this.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFilter.Location = new System.Drawing.Point(32, 5);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(75, 28);
            this.ButtonFilter.TabIndex = 26;
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
            this.PageDescription.Location = new System.Drawing.Point(814, 3);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(229, 31);
            this.PageDescription.TabIndex = 46;
            this.PageDescription.Text = "Listar Motoristas /";
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(1037, 3);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(76, 31);
            this.ButtonHome.TabIndex = 47;
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
            this.ProgressBar.Location = new System.Drawing.Point(450, 150);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(450, 150, 3, 3);
            this.ProgressBar.MarqueeAnimationSpeed = 2000;
            this.ProgressBar.MaximumSize = new System.Drawing.Size(243, 224);
            this.ProgressBar.MinimumSize = new System.Drawing.Size(243, 224);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.OuterColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProgressBar.OuterMargin = -21;
            this.ProgressBar.OuterWidth = 15;
            this.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            this.ProgressBar.TabIndex = 2;
            this.ProgressBar.Text = "Loading...";
            this.ProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgressBar.Value = 20;
            // 
            // ListarMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.container);
            this.Name = "ListarMotoristas";
            this.Size = new System.Drawing.Size(1170, 759);
            this.Load += new System.EventHandler(this.ListarMotoristas_Load);
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelListDriver.ResumeLayout(false);
            this.FlowDriver.ResumeLayout(false);
            this.TitleFilter.ResumeLayout(false);
            this.TitleFilter.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer filtro;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelListDriver;
        private System.Windows.Forms.FlowLayoutPanel FlowDriver;
        private System.Windows.Forms.Panel TitleFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonCadastro;
        private System.Windows.Forms.Label LabelChn;
        private System.Windows.Forms.ComboBox BoxCnh;
        private System.Windows.Forms.Label LabelDriver;
        private System.Windows.Forms.ComboBox BoxDriver;
        private System.Windows.Forms.Button ButtonFilter;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Panel container;
        private CircularProgressBar.CircularProgressBar ProgressBar;
    }
}
