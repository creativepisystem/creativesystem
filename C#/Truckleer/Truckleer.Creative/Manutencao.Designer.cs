namespace Truckleer.Creative
{
    partial class Manutencao
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.containerMaintence = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeftMaintence = new System.Windows.Forms.Panel();
            this.listBoxMaintenceDriver = new System.Windows.Forms.ListBox();
            this.labelDriverMaintence = new System.Windows.Forms.Label();
            this.radioButtonCorretiva = new System.Windows.Forms.RadioButton();
            this.radioButtonPreventiva = new System.Windows.Forms.RadioButton();
            this.textBoxKMSupply = new System.Windows.Forms.TextBox();
            this.listBoxVehicle = new System.Windows.Forms.ListBox();
            this.labelNameMaintence = new System.Windows.Forms.Label();
            this.labelVeiculoSupply = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.labelObsMaintence = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelQtd = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeMaintence = new System.Windows.Forms.DateTimePicker();
            this.labelDataMaintence = new System.Windows.Forms.Label();
            this.panelFooterAbastecimentos = new System.Windows.Forms.Panel();
            this.panelTitleAbastecimentos = new System.Windows.Forms.Panel();
            this.titleMaintence = new System.Windows.Forms.Label();
            this.listBoxPreventiva = new System.Windows.Forms.ListBox();
            this.listBoxPiecePrev = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.containerMaintence.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelLeftMaintence.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelTitleAbastecimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.containerMaintence, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1096, 759);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // containerMaintence
            // 
            this.containerMaintence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.containerMaintence.Controls.Add(this.tableLayoutPanel2);
            this.containerMaintence.Controls.Add(this.panelFooterAbastecimentos);
            this.containerMaintence.Controls.Add(this.panelTitleAbastecimentos);
            this.containerMaintence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerMaintence.Location = new System.Drawing.Point(219, 30);
            this.containerMaintence.Margin = new System.Windows.Forms.Padding(0, 30, 0, 30);
            this.containerMaintence.Name = "containerMaintence";
            this.containerMaintence.Size = new System.Drawing.Size(657, 699);
            this.containerMaintence.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panelLeftMaintence, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelCenter, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(657, 597);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panelLeftMaintence
            // 
            this.panelLeftMaintence.Controls.Add(this.listBoxPreventiva);
            this.panelLeftMaintence.Controls.Add(this.listBoxMaintenceDriver);
            this.panelLeftMaintence.Controls.Add(this.labelDriverMaintence);
            this.panelLeftMaintence.Controls.Add(this.radioButtonCorretiva);
            this.panelLeftMaintence.Controls.Add(this.radioButtonPreventiva);
            this.panelLeftMaintence.Controls.Add(this.textBoxKMSupply);
            this.panelLeftMaintence.Controls.Add(this.listBoxVehicle);
            this.panelLeftMaintence.Controls.Add(this.labelNameMaintence);
            this.panelLeftMaintence.Controls.Add(this.labelVeiculoSupply);
            this.panelLeftMaintence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeftMaintence.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeftMaintence.Name = "panelLeftMaintence";
            this.panelLeftMaintence.Size = new System.Drawing.Size(328, 597);
            this.panelLeftMaintence.TabIndex = 0;
            // 
            // listBoxMaintenceDriver
            // 
            this.listBoxMaintenceDriver.FormattingEnabled = true;
            this.listBoxMaintenceDriver.ItemHeight = 25;
            this.listBoxMaintenceDriver.Location = new System.Drawing.Point(33, 308);
            this.listBoxMaintenceDriver.Name = "listBoxMaintenceDriver";
            this.listBoxMaintenceDriver.Size = new System.Drawing.Size(195, 29);
            this.listBoxMaintenceDriver.TabIndex = 10;
            // 
            // labelDriverMaintence
            // 
            this.labelDriverMaintence.AutoSize = true;
            this.labelDriverMaintence.Location = new System.Drawing.Point(28, 280);
            this.labelDriverMaintence.Name = "labelDriverMaintence";
            this.labelDriverMaintence.Size = new System.Drawing.Size(92, 25);
            this.labelDriverMaintence.TabIndex = 9;
            this.labelDriverMaintence.Text = "Motorista";
            // 
            // radioButtonCorretiva
            // 
            this.radioButtonCorretiva.AutoSize = true;
            this.radioButtonCorretiva.Location = new System.Drawing.Point(173, 39);
            this.radioButtonCorretiva.Name = "radioButtonCorretiva";
            this.radioButtonCorretiva.Size = new System.Drawing.Size(109, 29);
            this.radioButtonCorretiva.TabIndex = 8;
            this.radioButtonCorretiva.TabStop = true;
            this.radioButtonCorretiva.Text = "Corretiva";
            this.radioButtonCorretiva.UseVisualStyleBackColor = true;
            // 
            // radioButtonPreventiva
            // 
            this.radioButtonPreventiva.AutoSize = true;
            this.radioButtonPreventiva.Location = new System.Drawing.Point(39, 39);
            this.radioButtonPreventiva.Name = "radioButtonPreventiva";
            this.radioButtonPreventiva.Size = new System.Drawing.Size(122, 29);
            this.radioButtonPreventiva.TabIndex = 7;
            this.radioButtonPreventiva.TabStop = true;
            this.radioButtonPreventiva.Text = "Preventiva";
            this.radioButtonPreventiva.UseVisualStyleBackColor = true;
            // 
            // textBoxKMSupply
            // 
            this.textBoxKMSupply.Location = new System.Drawing.Point(33, 131);
            this.textBoxKMSupply.Name = "textBoxKMSupply";
            this.textBoxKMSupply.Size = new System.Drawing.Size(201, 30);
            this.textBoxKMSupply.TabIndex = 27;
            // 
            // listBoxVehicle
            // 
            this.listBoxVehicle.FormattingEnabled = true;
            this.listBoxVehicle.ItemHeight = 25;
            this.listBoxVehicle.Location = new System.Drawing.Point(33, 230);
            this.listBoxVehicle.Name = "listBoxVehicle";
            this.listBoxVehicle.Size = new System.Drawing.Size(195, 29);
            this.listBoxVehicle.TabIndex = 6;
            // 
            // labelNameMaintence
            // 
            this.labelNameMaintence.AutoSize = true;
            this.labelNameMaintence.Location = new System.Drawing.Point(28, 103);
            this.labelNameMaintence.Name = "labelNameMaintence";
            this.labelNameMaintence.Size = new System.Drawing.Size(178, 25);
            this.labelNameMaintence.TabIndex = 26;
            this.labelNameMaintence.Text = "Nome Manutenção";
            // 
            // labelVeiculoSupply
            // 
            this.labelVeiculoSupply.AutoSize = true;
            this.labelVeiculoSupply.Location = new System.Drawing.Point(28, 202);
            this.labelVeiculoSupply.Name = "labelVeiculoSupply";
            this.labelVeiculoSupply.Size = new System.Drawing.Size(77, 25);
            this.labelVeiculoSupply.TabIndex = 5;
            this.labelVeiculoSupply.Text = "Veículo";
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.listBoxPiecePrev);
            this.panelCenter.Controls.Add(this.labelObsMaintence);
            this.panelCenter.Controls.Add(this.richTextBox1);
            this.panelCenter.Controls.Add(this.label3);
            this.panelCenter.Controls.Add(this.labelTotal);
            this.panelCenter.Controls.Add(this.numericUpDown1);
            this.panelCenter.Controls.Add(this.labelQtd);
            this.panelCenter.Controls.Add(this.textBox2);
            this.panelCenter.Controls.Add(this.label2);
            this.panelCenter.Controls.Add(this.textBox1);
            this.panelCenter.Controls.Add(this.label1);
            this.panelCenter.Controls.Add(this.dateTimeMaintence);
            this.panelCenter.Controls.Add(this.labelDataMaintence);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCenter.Location = new System.Drawing.Point(328, 0);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(329, 597);
            this.panelCenter.TabIndex = 1;
            // 
            // labelObsMaintence
            // 
            this.labelObsMaintence.AutoSize = true;
            this.labelObsMaintence.Location = new System.Drawing.Point(19, 248);
            this.labelObsMaintence.Name = "labelObsMaintence";
            this.labelObsMaintence.Size = new System.Drawing.Size(119, 25);
            this.labelObsMaintence.TabIndex = 36;
            this.labelObsMaintence.Text = "Observação";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 276);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(329, 133);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(225, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total Price";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(19, 202);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 25);
            this.labelTotal.TabIndex = 28;
            this.labelTotal.Text = "Total";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(290, 142);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 30);
            this.numericUpDown1.TabIndex = 33;
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Location = new System.Drawing.Point(170, 144);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(114, 25);
            this.labelQtd.TabIndex = 32;
            this.labelQtd.Text = "Quantidade";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 30);
            this.textBox2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "preço";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 30);
            this.textBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Peça";
            // 
            // dateTimeMaintence
            // 
            this.dateTimeMaintence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeMaintence.Location = new System.Drawing.Point(81, 39);
            this.dateTimeMaintence.Name = "dateTimeMaintence";
            this.dateTimeMaintence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeMaintence.RightToLeftLayout = true;
            this.dateTimeMaintence.Size = new System.Drawing.Size(133, 30);
            this.dateTimeMaintence.TabIndex = 25;
            // 
            // labelDataMaintence
            // 
            this.labelDataMaintence.AutoSize = true;
            this.labelDataMaintence.Location = new System.Drawing.Point(16, 39);
            this.labelDataMaintence.Name = "labelDataMaintence";
            this.labelDataMaintence.Size = new System.Drawing.Size(53, 25);
            this.labelDataMaintence.TabIndex = 24;
            this.labelDataMaintence.Text = "Data";
            // 
            // panelFooterAbastecimentos
            // 
            this.panelFooterAbastecimentos.BackColor = System.Drawing.Color.SteelBlue;
            this.panelFooterAbastecimentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterAbastecimentos.Location = new System.Drawing.Point(0, 672);
            this.panelFooterAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.panelFooterAbastecimentos.Name = "panelFooterAbastecimentos";
            this.panelFooterAbastecimentos.Size = new System.Drawing.Size(657, 27);
            this.panelFooterAbastecimentos.TabIndex = 2;
            // 
            // panelTitleAbastecimentos
            // 
            this.panelTitleAbastecimentos.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitleAbastecimentos.Controls.Add(this.titleMaintence);
            this.panelTitleAbastecimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleAbastecimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleAbastecimentos.Location = new System.Drawing.Point(0, 0);
            this.panelTitleAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleAbastecimentos.Name = "panelTitleAbastecimentos";
            this.panelTitleAbastecimentos.Size = new System.Drawing.Size(657, 75);
            this.panelTitleAbastecimentos.TabIndex = 1;
            // 
            // titleMaintence
            // 
            this.titleMaintence.AutoSize = true;
            this.titleMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMaintence.ForeColor = System.Drawing.Color.Brown;
            this.titleMaintence.Location = new System.Drawing.Point(274, 17);
            this.titleMaintence.Name = "titleMaintence";
            this.titleMaintence.Size = new System.Drawing.Size(204, 39);
            this.titleMaintence.TabIndex = 0;
            this.titleMaintence.Text = "Manutenção";
            // 
            // listBoxPreventiva
            // 
            this.listBoxPreventiva.FormattingEnabled = true;
            this.listBoxPreventiva.ItemHeight = 25;
            this.listBoxPreventiva.Location = new System.Drawing.Point(33, 167);
            this.listBoxPreventiva.Name = "listBoxPreventiva";
            this.listBoxPreventiva.Size = new System.Drawing.Size(201, 29);
            this.listBoxPreventiva.TabIndex = 28;
            this.listBoxPreventiva.Visible = false;
            // 
            // listBoxPiecePrev
            // 
            this.listBoxPiecePrev.FormattingEnabled = true;
            this.listBoxPiecePrev.ItemHeight = 25;
            this.listBoxPiecePrev.Location = new System.Drawing.Point(81, 103);
            this.listBoxPiecePrev.Name = "listBoxPiecePrev";
            this.listBoxPiecePrev.Size = new System.Drawing.Size(233, 29);
            this.listBoxPiecePrev.TabIndex = 37;
            this.listBoxPiecePrev.Visible = false;
            // 
            // Manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Manutencao";
            this.Size = new System.Drawing.Size(1096, 759);
            this.Load += new System.EventHandler(this.Manutencao_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.containerMaintence.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelLeftMaintence.ResumeLayout(false);
            this.panelLeftMaintence.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelTitleAbastecimentos.ResumeLayout(false);
            this.panelTitleAbastecimentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel containerMaintence;
        private System.Windows.Forms.Panel panelTitleAbastecimentos;
        private System.Windows.Forms.Label titleMaintence;
        private System.Windows.Forms.Panel panelFooterAbastecimentos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelLeftMaintence;
        private System.Windows.Forms.ListBox listBoxVehicle;
        private System.Windows.Forms.Label labelVeiculoSupply;
        private System.Windows.Forms.RadioButton radioButtonCorretiva;
        private System.Windows.Forms.RadioButton radioButtonPreventiva;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.TextBox textBoxKMSupply;
        private System.Windows.Forms.Label labelNameMaintence;
        private System.Windows.Forms.DateTimePicker dateTimeMaintence;
        private System.Windows.Forms.Label labelDataMaintence;
        private System.Windows.Forms.ListBox listBoxMaintenceDriver;
        private System.Windows.Forms.Label labelDriverMaintence;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelQtd;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelObsMaintence;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBoxPreventiva;
        private System.Windows.Forms.ListBox listBoxPiecePrev;
    }
}
