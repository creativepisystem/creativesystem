namespace Truckleer.Creative
{
    partial class Motorista
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
            this.panelDriverContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelContainerDriver = new System.Windows.Forms.Panel();
            this.layoutDriver = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeftDriver = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMailDriver = new System.Windows.Forms.TextBox();
            this.labelMailDriver = new System.Windows.Forms.Label();
            this.textBoxPhoneDriver = new System.Windows.Forms.TextBox();
            this.labelPhoneDriver = new System.Windows.Forms.Label();
            this.labelCnhDriver = new System.Windows.Forms.Label();
            this.textBoxCpfDriver = new System.Windows.Forms.TextBox();
            this.labelCpfDriver = new System.Windows.Forms.Label();
            this.textBoxNameDriver = new System.Windows.Forms.TextBox();
            this.labelNameDriver = new System.Windows.Forms.Label();
            this.panelRightDriver = new System.Windows.Forms.Panel();
            this.panelFooterAbastecimentos = new System.Windows.Forms.Panel();
            this.panelTitleAbastecimentos = new System.Windows.Forms.Panel();
            this.titleDriver = new System.Windows.Forms.Label();
            this.textBoxCnhDriver = new System.Windows.Forms.TextBox();
            this.dateTimeBirthDriver = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDriver = new System.Windows.Forms.Label();
            this.dateTimeOverDue = new System.Windows.Forms.DateTimePicker();
            this.labelOverDue = new System.Windows.Forms.Label();
            this.labelObs = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelDriverContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelContainerDriver.SuspendLayout();
            this.layoutDriver.SuspendLayout();
            this.panelLeftDriver.SuspendLayout();
            this.panelRightDriver.SuspendLayout();
            this.panelTitleAbastecimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDriverContainer
            // 
            this.panelDriverContainer.Controls.Add(this.tableLayoutPanel1);
            this.panelDriverContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDriverContainer.Location = new System.Drawing.Point(0, 0);
            this.panelDriverContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelDriverContainer.Name = "panelDriverContainer";
            this.panelDriverContainer.Size = new System.Drawing.Size(1096, 759);
            this.panelDriverContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelContainerDriver, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1096, 759);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelContainerDriver
            // 
            this.panelContainerDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelContainerDriver.Controls.Add(this.layoutDriver);
            this.panelContainerDriver.Controls.Add(this.panelTitleAbastecimentos);
            this.panelContainerDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerDriver.Location = new System.Drawing.Point(219, 30);
            this.panelContainerDriver.Margin = new System.Windows.Forms.Padding(0, 30, 0, 50);
            this.panelContainerDriver.Name = "panelContainerDriver";
            this.panelContainerDriver.Size = new System.Drawing.Size(657, 679);
            this.panelContainerDriver.TabIndex = 0;
            // 
            // layoutDriver
            // 
            this.layoutDriver.ColumnCount = 2;
            this.layoutDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDriver.Controls.Add(this.panelLeftDriver, 0, 0);
            this.layoutDriver.Controls.Add(this.panelRightDriver, 1, 0);
            this.layoutDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDriver.Location = new System.Drawing.Point(0, 75);
            this.layoutDriver.Margin = new System.Windows.Forms.Padding(0);
            this.layoutDriver.Name = "layoutDriver";
            this.layoutDriver.RowCount = 1;
            this.layoutDriver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDriver.Size = new System.Drawing.Size(657, 604);
            this.layoutDriver.TabIndex = 2;
            // 
            // panelLeftDriver
            // 
            this.panelLeftDriver.Controls.Add(this.dateTimeBirthDriver);
            this.panelLeftDriver.Controls.Add(this.labelBirthDriver);
            this.panelLeftDriver.Controls.Add(this.panel1);
            this.panelLeftDriver.Controls.Add(this.textBoxPhoneDriver);
            this.panelLeftDriver.Controls.Add(this.labelPhoneDriver);
            this.panelLeftDriver.Controls.Add(this.textBoxCpfDriver);
            this.panelLeftDriver.Controls.Add(this.labelCpfDriver);
            this.panelLeftDriver.Controls.Add(this.textBoxNameDriver);
            this.panelLeftDriver.Controls.Add(this.labelNameDriver);
            this.panelLeftDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeftDriver.Location = new System.Drawing.Point(0, 0);
            this.panelLeftDriver.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeftDriver.Name = "panelLeftDriver";
            this.panelLeftDriver.Size = new System.Drawing.Size(328, 604);
            this.panelLeftDriver.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 577);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 27);
            this.panel1.TabIndex = 30;
            // 
            // textBoxMailDriver
            // 
            this.textBoxMailDriver.Location = new System.Drawing.Point(128, 192);
            this.textBoxMailDriver.Name = "textBoxMailDriver";
            this.textBoxMailDriver.Size = new System.Drawing.Size(201, 30);
            this.textBoxMailDriver.TabIndex = 29;
            // 
            // labelMailDriver
            // 
            this.labelMailDriver.AutoSize = true;
            this.labelMailDriver.Location = new System.Drawing.Point(28, 197);
            this.labelMailDriver.Margin = new System.Windows.Forms.Padding(0);
            this.labelMailDriver.Name = "labelMailDriver";
            this.labelMailDriver.Size = new System.Drawing.Size(68, 25);
            this.labelMailDriver.TabIndex = 28;
            this.labelMailDriver.Text = "E-Mail";
            // 
            // textBoxPhoneDriver
            // 
            this.textBoxPhoneDriver.Location = new System.Drawing.Point(121, 256);
            this.textBoxPhoneDriver.Name = "textBoxPhoneDriver";
            this.textBoxPhoneDriver.Size = new System.Drawing.Size(204, 30);
            this.textBoxPhoneDriver.TabIndex = 27;
            // 
            // labelPhoneDriver
            // 
            this.labelPhoneDriver.AutoSize = true;
            this.labelPhoneDriver.Location = new System.Drawing.Point(21, 261);
            this.labelPhoneDriver.Margin = new System.Windows.Forms.Padding(0);
            this.labelPhoneDriver.Name = "labelPhoneDriver";
            this.labelPhoneDriver.Size = new System.Drawing.Size(89, 25);
            this.labelPhoneDriver.TabIndex = 26;
            this.labelPhoneDriver.Text = "Telefone";
            // 
            // labelCnhDriver
            // 
            this.labelCnhDriver.AutoSize = true;
            this.labelCnhDriver.Location = new System.Drawing.Point(28, 130);
            this.labelCnhDriver.Margin = new System.Windows.Forms.Padding(0);
            this.labelCnhDriver.Name = "labelCnhDriver";
            this.labelCnhDriver.Size = new System.Drawing.Size(55, 25);
            this.labelCnhDriver.TabIndex = 24;
            this.labelCnhDriver.Text = "CNH";
            // 
            // textBoxCpfDriver
            // 
            this.textBoxCpfDriver.Location = new System.Drawing.Point(121, 190);
            this.textBoxCpfDriver.Name = "textBoxCpfDriver";
            this.textBoxCpfDriver.Size = new System.Drawing.Size(204, 30);
            this.textBoxCpfDriver.TabIndex = 23;
            // 
            // labelCpfDriver
            // 
            this.labelCpfDriver.AutoSize = true;
            this.labelCpfDriver.Location = new System.Drawing.Point(21, 195);
            this.labelCpfDriver.Margin = new System.Windows.Forms.Padding(0);
            this.labelCpfDriver.Name = "labelCpfDriver";
            this.labelCpfDriver.Size = new System.Drawing.Size(52, 25);
            this.labelCpfDriver.TabIndex = 22;
            this.labelCpfDriver.Text = "CPF";
            // 
            // textBoxNameDriver
            // 
            this.textBoxNameDriver.Location = new System.Drawing.Point(121, 125);
            this.textBoxNameDriver.Name = "textBoxNameDriver";
            this.textBoxNameDriver.Size = new System.Drawing.Size(204, 30);
            this.textBoxNameDriver.TabIndex = 21;
            // 
            // labelNameDriver
            // 
            this.labelNameDriver.AutoSize = true;
            this.labelNameDriver.Location = new System.Drawing.Point(21, 130);
            this.labelNameDriver.Name = "labelNameDriver";
            this.labelNameDriver.Size = new System.Drawing.Size(64, 25);
            this.labelNameDriver.TabIndex = 20;
            this.labelNameDriver.Text = "Nome";
            // 
            // panelRightDriver
            // 
            this.panelRightDriver.Controls.Add(this.textBox1);
            this.panelRightDriver.Controls.Add(this.dateTimeOverDue);
            this.panelRightDriver.Controls.Add(this.labelObs);
            this.panelRightDriver.Controls.Add(this.labelOverDue);
            this.panelRightDriver.Controls.Add(this.panelFooterAbastecimentos);
            this.panelRightDriver.Controls.Add(this.textBoxMailDriver);
            this.panelRightDriver.Controls.Add(this.labelCnhDriver);
            this.panelRightDriver.Controls.Add(this.labelMailDriver);
            this.panelRightDriver.Controls.Add(this.textBoxCnhDriver);
            this.panelRightDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRightDriver.Location = new System.Drawing.Point(328, 0);
            this.panelRightDriver.Margin = new System.Windows.Forms.Padding(0);
            this.panelRightDriver.Name = "panelRightDriver";
            this.panelRightDriver.Size = new System.Drawing.Size(329, 604);
            this.panelRightDriver.TabIndex = 1;
            // 
            // panelFooterAbastecimentos
            // 
            this.panelFooterAbastecimentos.BackColor = System.Drawing.Color.SteelBlue;
            this.panelFooterAbastecimentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterAbastecimentos.Location = new System.Drawing.Point(0, 577);
            this.panelFooterAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.panelFooterAbastecimentos.Name = "panelFooterAbastecimentos";
            this.panelFooterAbastecimentos.Size = new System.Drawing.Size(329, 27);
            this.panelFooterAbastecimentos.TabIndex = 2;
            // 
            // panelTitleAbastecimentos
            // 
            this.panelTitleAbastecimentos.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitleAbastecimentos.Controls.Add(this.titleDriver);
            this.panelTitleAbastecimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleAbastecimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleAbastecimentos.Location = new System.Drawing.Point(0, 0);
            this.panelTitleAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleAbastecimentos.Name = "panelTitleAbastecimentos";
            this.panelTitleAbastecimentos.Size = new System.Drawing.Size(657, 75);
            this.panelTitleAbastecimentos.TabIndex = 1;
            // 
            // titleDriver
            // 
            this.titleDriver.AutoSize = true;
            this.titleDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleDriver.ForeColor = System.Drawing.Color.Brown;
            this.titleDriver.Location = new System.Drawing.Point(263, 16);
            this.titleDriver.Name = "titleDriver";
            this.titleDriver.Size = new System.Drawing.Size(312, 39);
            this.titleDriver.TabIndex = 0;
            this.titleDriver.Text = " Cadastro Motorista";
            // 
            // textBoxCnhDriver
            // 
            this.textBoxCnhDriver.Location = new System.Drawing.Point(128, 125);
            this.textBoxCnhDriver.Name = "textBoxCnhDriver";
            this.textBoxCnhDriver.Size = new System.Drawing.Size(201, 30);
            this.textBoxCnhDriver.TabIndex = 25;
            // 
            // dateTimeBirthDriver
            // 
            this.dateTimeBirthDriver.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBirthDriver.Location = new System.Drawing.Point(190, 66);
            this.dateTimeBirthDriver.Name = "dateTimeBirthDriver";
            this.dateTimeBirthDriver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeBirthDriver.RightToLeftLayout = true;
            this.dateTimeBirthDriver.Size = new System.Drawing.Size(135, 30);
            this.dateTimeBirthDriver.TabIndex = 32;
            // 
            // labelBirthDriver
            // 
            this.labelBirthDriver.AutoSize = true;
            this.labelBirthDriver.Location = new System.Drawing.Point(23, 66);
            this.labelBirthDriver.Name = "labelBirthDriver";
            this.labelBirthDriver.Size = new System.Drawing.Size(161, 25);
            this.labelBirthDriver.TabIndex = 31;
            this.labelBirthDriver.Text = "Data Nascimento";
            // 
            // dateTimeOverDue
            // 
            this.dateTimeOverDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeOverDue.Location = new System.Drawing.Point(191, 66);
            this.dateTimeOverDue.Name = "dateTimeOverDue";
            this.dateTimeOverDue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeOverDue.RightToLeftLayout = true;
            this.dateTimeOverDue.Size = new System.Drawing.Size(138, 30);
            this.dateTimeOverDue.TabIndex = 34;
            // 
            // labelOverDue
            // 
            this.labelOverDue.AutoSize = true;
            this.labelOverDue.Location = new System.Drawing.Point(24, 66);
            this.labelOverDue.Name = "labelOverDue";
            this.labelOverDue.Size = new System.Drawing.Size(164, 25);
            this.labelOverDue.TabIndex = 33;
            this.labelOverDue.Text = "Vencimento CNH";
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(28, 261);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(119, 25);
            this.labelObs.TabIndex = 33;
            this.labelObs.Text = "Observação";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 289);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(296, 139);
            this.textBox1.TabIndex = 34;
            // 
            // Motorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.panelDriverContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Motorista";
            this.Size = new System.Drawing.Size(1096, 759);
            this.Load += new System.EventHandler(this.Motorista_Load);
            this.panelDriverContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelContainerDriver.ResumeLayout(false);
            this.layoutDriver.ResumeLayout(false);
            this.panelLeftDriver.ResumeLayout(false);
            this.panelLeftDriver.PerformLayout();
            this.panelRightDriver.ResumeLayout(false);
            this.panelRightDriver.PerformLayout();
            this.panelTitleAbastecimentos.ResumeLayout(false);
            this.panelTitleAbastecimentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDriverContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelContainerDriver;
        private System.Windows.Forms.Panel panelTitleAbastecimentos;
        private System.Windows.Forms.Label titleDriver;
        private System.Windows.Forms.TableLayoutPanel layoutDriver;
        private System.Windows.Forms.Panel panelLeftDriver;
        private System.Windows.Forms.Panel panelRightDriver;
        private System.Windows.Forms.Label labelCnhDriver;
        private System.Windows.Forms.TextBox textBoxCpfDriver;
        private System.Windows.Forms.Label labelCpfDriver;
        private System.Windows.Forms.TextBox textBoxNameDriver;
        private System.Windows.Forms.Label labelNameDriver;
        private System.Windows.Forms.TextBox textBoxMailDriver;
        private System.Windows.Forms.Label labelMailDriver;
        private System.Windows.Forms.TextBox textBoxPhoneDriver;
        private System.Windows.Forms.Label labelPhoneDriver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFooterAbastecimentos;
        private System.Windows.Forms.TextBox textBoxCnhDriver;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDriver;
        private System.Windows.Forms.Label labelBirthDriver;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.DateTimePicker dateTimeOverDue;
        private System.Windows.Forms.Label labelOverDue;
    }
}
