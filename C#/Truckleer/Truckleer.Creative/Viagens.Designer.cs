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
            this.container = new System.Windows.Forms.Panel();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.filter = new System.Windows.Forms.Panel();
            this.titleDriver = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDataSupply = new System.Windows.Forms.Label();
            this.textBoxLitersSupply = new System.Windows.Forms.TextBox();
            this.labelLitrosSupply = new System.Windows.Forms.Label();
            this.boxRoute = new System.Windows.Forms.ComboBox();
            this.labelRouteSupplpy = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.container.Controls.Add(this.layoutFlex);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1096, 759);
            this.container.TabIndex = 2;
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
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.filter);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1067, 693);
            this.MainPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.boxRoute);
            this.panel4.Controls.Add(this.labelRouteSupplpy);
            this.panel4.Controls.Add(this.textBoxLitersSupply);
            this.panel4.Controls.Add(this.labelLitrosSupply);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.labelDataSupply);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1067, 615);
            this.panel4.TabIndex = 1;
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.Indigo;
            this.filter.Controls.Add(this.titleDriver);
            this.filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.filter.Location = new System.Drawing.Point(0, 0);
            this.filter.Margin = new System.Windows.Forms.Padding(0);
            this.filter.MaximumSize = new System.Drawing.Size(2000, 94);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(1067, 78);
            this.filter.TabIndex = 0;
            // 
            // titleDriver
            // 
            this.titleDriver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleDriver.AutoSize = true;
            this.titleDriver.Font = new System.Drawing.Font("Arial Narrow", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleDriver.ForeColor = System.Drawing.Color.Orange;
            this.titleDriver.Location = new System.Drawing.Point(526, 9);
            this.titleDriver.Name = "titleDriver";
            this.titleDriver.Size = new System.Drawing.Size(184, 63);
            this.titleDriver.TabIndex = 1;
            this.titleDriver.Text = "Viagens";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // labelDataSupply
            // 
            this.labelDataSupply.AutoSize = true;
            this.labelDataSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataSupply.ForeColor = System.Drawing.Color.Azure;
            this.labelDataSupply.Location = new System.Drawing.Point(92, 157);
            this.labelDataSupply.Name = "labelDataSupply";
            this.labelDataSupply.Size = new System.Drawing.Size(53, 25);
            this.labelDataSupply.TabIndex = 10;
            this.labelDataSupply.Text = "Data";
            // 
            // textBoxLitersSupply
            // 
            this.textBoxLitersSupply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLitersSupply.BackColor = System.Drawing.Color.Azure;
            this.textBoxLitersSupply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLitersSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLitersSupply.Location = new System.Drawing.Point(98, 95);
            this.textBoxLitersSupply.MaxLength = 10;
            this.textBoxLitersSupply.Name = "textBoxLitersSupply";
            this.textBoxLitersSupply.Size = new System.Drawing.Size(227, 31);
            this.textBoxLitersSupply.TabIndex = 23;
            // 
            // labelLitrosSupply
            // 
            this.labelLitrosSupply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLitrosSupply.AutoSize = true;
            this.labelLitrosSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLitrosSupply.ForeColor = System.Drawing.Color.Azure;
            this.labelLitrosSupply.Location = new System.Drawing.Point(92, 56);
            this.labelLitrosSupply.Name = "labelLitrosSupply";
            this.labelLitrosSupply.Size = new System.Drawing.Size(163, 25);
            this.labelLitrosSupply.TabIndex = 22;
            this.labelLitrosSupply.Text = "Nome da Viagem";
            // 
            // boxRoute
            // 
            this.boxRoute.AllowDrop = true;
            this.boxRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.boxRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxRoute.FormattingEnabled = true;
            this.boxRoute.Location = new System.Drawing.Point(98, 369);
            this.boxRoute.Name = "boxRoute";
            this.boxRoute.Size = new System.Drawing.Size(195, 33);
            this.boxRoute.TabIndex = 25;
            // 
            // labelRouteSupplpy
            // 
            this.labelRouteSupplpy.AutoSize = true;
            this.labelRouteSupplpy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRouteSupplpy.ForeColor = System.Drawing.Color.Azure;
            this.labelRouteSupplpy.Location = new System.Drawing.Point(93, 344);
            this.labelRouteSupplpy.Name = "labelRouteSupplpy";
            this.labelRouteSupplpy.Size = new System.Drawing.Size(52, 25);
            this.labelRouteSupplpy.TabIndex = 24;
            this.labelRouteSupplpy.Text = "Rota";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 33);
            this.comboBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(92, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Motorista";
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(98, 450);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 33);
            this.comboBox2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(93, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Veículo";
            // 
            // Viagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.container);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Viagens";
            this.Size = new System.Drawing.Size(1096, 759);
            this.Load += new System.EventHandler(this.Viagens_Load);
            this.container.ResumeLayout(false);
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.filter.ResumeLayout(false);
            this.filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel filter;
        private System.Windows.Forms.Label titleDriver;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDataSupply;
        private System.Windows.Forms.TextBox textBoxLitersSupply;
        private System.Windows.Forms.Label labelLitrosSupply;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxRoute;
        private System.Windows.Forms.Label labelRouteSupplpy;
    }
}
