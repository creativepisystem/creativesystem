namespace Truckleer.Creative
{
    partial class ListarRotas
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
            this.PanelR = new System.Windows.Forms.Panel();
            this.FlowRoute = new System.Windows.Forms.FlowLayoutPanel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.PanelFilter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCadastro = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelR.SuspendLayout();
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
            this.container.Size = new System.Drawing.Size(1170, 759);
            this.container.TabIndex = 1;
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
            this.MainPanel.Controls.Add(this.PanelR);
            this.MainPanel.Controls.Add(this.PanelFilter);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1141, 693);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelR
            // 
            this.PanelR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.PanelR.Controls.Add(this.FlowRoute);
            this.PanelR.Controls.Add(this.panel20);
            this.PanelR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelR.Location = new System.Drawing.Point(0, 100);
            this.PanelR.Name = "PanelR";
            this.PanelR.Size = new System.Drawing.Size(1141, 593);
            this.PanelR.TabIndex = 1;
            // 
            // FlowRoute
            // 
            this.FlowRoute.AutoScroll = true;
            this.FlowRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowRoute.Location = new System.Drawing.Point(0, 0);
            this.FlowRoute.Name = "FlowRoute";
            this.FlowRoute.Size = new System.Drawing.Size(1141, 593);
            this.FlowRoute.TabIndex = 14;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Azure;
            this.panel20.Location = new System.Drawing.Point(509, 401);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(10, 42);
            this.panel20.TabIndex = 13;
            // 
            // PanelFilter
            // 
            this.PanelFilter.BackColor = System.Drawing.Color.Orange;
            this.PanelFilter.Controls.Add(this.panel1);
            this.PanelFilter.Controls.Add(this.ButtonCadastro);
            this.PanelFilter.Controls.Add(this.textBox1);
            this.PanelFilter.Controls.Add(this.label1);
            this.PanelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFilter.Location = new System.Drawing.Point(0, 0);
            this.PanelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.PanelFilter.MaximumSize = new System.Drawing.Size(2000, 100);
            this.PanelFilter.Name = "PanelFilter";
            this.PanelFilter.Size = new System.Drawing.Size(1141, 100);
            this.PanelFilter.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Rota";
            // 
            // ListarRotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.container);
            this.Name = "ListarRotas";
            this.Size = new System.Drawing.Size(1170, 759);
            this.Load += new System.EventHandler(this.ListarRotas_Load);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelR.ResumeLayout(false);
            this.PanelFilter.ResumeLayout(false);
            this.PanelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelR;
        private System.Windows.Forms.Panel PanelFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.Button ButtonCadastro;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.FlowLayoutPanel FlowRoute;
        private System.Windows.Forms.Panel panel1;
    }
}
