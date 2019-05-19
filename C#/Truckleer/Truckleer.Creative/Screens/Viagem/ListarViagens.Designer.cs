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
            this.container = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.PageDescription = new System.Windows.Forms.Label();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelRoute = new System.Windows.Forms.Panel();
            this.LayoutRoute = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelFilter = new System.Windows.Forms.Panel();
            this.LabelFinal = new System.Windows.Forms.Label();
            this.DatePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.LabelInitial = new System.Windows.Forms.Label();
            this.DatePickerInitial = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonCadastro = new System.Windows.Forms.Button();
            this.TextTrip = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelRoute.SuspendLayout();
            this.PanelFilter.SuspendLayout();
            this.SuspendLayout();
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
            this.container.Size = new System.Drawing.Size(1220, 990);
            this.container.TabIndex = 5;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(1031, 5);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(76, 31);
            this.ButtonHome.TabIndex = 49;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(862, 3);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(175, 31);
            this.PageDescription.TabIndex = 48;
            this.PageDescription.Text = "Listar Rotas /";
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
            this.MainPanel.Controls.Add(this.PanelRoute);
            this.MainPanel.Controls.Add(this.PanelFilter);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1191, 924);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelRoute
            // 
            this.PanelRoute.BackColor = System.Drawing.Color.Gray;
            this.PanelRoute.Controls.Add(this.LayoutRoute);
            this.PanelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoute.Location = new System.Drawing.Point(0, 100);
            this.PanelRoute.Name = "PanelRoute";
            this.PanelRoute.Size = new System.Drawing.Size(1191, 824);
            this.PanelRoute.TabIndex = 17;
            // 
            // LayoutRoute
            // 
            this.LayoutRoute.AutoScroll = true;
            this.LayoutRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutRoute.Location = new System.Drawing.Point(0, 0);
            this.LayoutRoute.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutRoute.Name = "LayoutRoute";
            this.LayoutRoute.Size = new System.Drawing.Size(1191, 824);
            this.LayoutRoute.TabIndex = 0;
            // 
            // PanelFilter
            // 
            this.PanelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelFilter.Controls.Add(this.LabelFinal);
            this.PanelFilter.Controls.Add(this.DatePickerFinal);
            this.PanelFilter.Controls.Add(this.LabelInitial);
            this.PanelFilter.Controls.Add(this.DatePickerInitial);
            this.PanelFilter.Controls.Add(this.panel2);
            this.PanelFilter.Controls.Add(this.ButtonCadastro);
            this.PanelFilter.Controls.Add(this.TextTrip);
            this.PanelFilter.Controls.Add(this.LabelSearch);
            this.PanelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFilter.Location = new System.Drawing.Point(0, 0);
            this.PanelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.PanelFilter.MaximumSize = new System.Drawing.Size(2000, 100);
            this.PanelFilter.Name = "PanelFilter";
            this.PanelFilter.Size = new System.Drawing.Size(1191, 100);
            this.PanelFilter.TabIndex = 0;
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
            // DatePickerFinal
            // 
            this.DatePickerFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerFinal.Location = new System.Drawing.Point(176, 54);
            this.DatePickerFinal.Name = "DatePickerFinal";
            this.DatePickerFinal.Size = new System.Drawing.Size(94, 23);
            this.DatePickerFinal.TabIndex = 74;
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
            // DatePickerInitial
            // 
            this.DatePickerInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerInitial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerInitial.Location = new System.Drawing.Point(58, 54);
            this.DatePickerInitial.Name = "DatePickerInitial";
            this.DatePickerInitial.Size = new System.Drawing.Size(95, 23);
            this.DatePickerInitial.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 2);
            this.panel2.TabIndex = 71;
            // 
            // ButtonCadastro
            // 
            this.ButtonCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCadastro.BackColor = System.Drawing.Color.Crimson;
            this.ButtonCadastro.FlatAppearance.BorderSize = 0;
            this.ButtonCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCadastro.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCadastro.ForeColor = System.Drawing.Color.Azure;
            this.ButtonCadastro.Location = new System.Drawing.Point(1027, 50);
            this.ButtonCadastro.Name = "ButtonCadastro";
            this.ButtonCadastro.Size = new System.Drawing.Size(132, 32);
            this.ButtonCadastro.TabIndex = 70;
            this.ButtonCadastro.Text = "Cadastrar Rota";
            this.ButtonCadastro.UseVisualStyleBackColor = false;
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
            // ListarViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Name = "ListarViagens";
            this.Size = new System.Drawing.Size(1220, 990);
            this.Load += new System.EventHandler(this.ListarViagens_Load);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelRoute.ResumeLayout(false);
            this.PanelFilter.ResumeLayout(false);
            this.PanelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelRoute;
        private System.Windows.Forms.FlowLayoutPanel LayoutRoute;
        private System.Windows.Forms.Panel PanelFilter;
        private System.Windows.Forms.Label LabelFinal;
        private System.Windows.Forms.DateTimePicker DatePickerFinal;
        private System.Windows.Forms.Label LabelInitial;
        private System.Windows.Forms.DateTimePicker DatePickerInitial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonCadastro;
        private System.Windows.Forms.TextBox TextTrip;
        private System.Windows.Forms.Label LabelSearch;
    }
}
