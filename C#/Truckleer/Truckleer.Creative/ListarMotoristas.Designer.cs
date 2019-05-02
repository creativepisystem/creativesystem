namespace Truckleer.Creative
{
    partial class ListarMotoristas
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.comboVehicle = new System.Windows.Forms.ComboBox();
            this.filterVehicle = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.listDriver = new System.Windows.Forms.TableLayoutPanel();
            this.containerLista = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.listDriver.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelFilter);
            this.panelTop.Controls.Add(this.filterPanel);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.ForeColor = System.Drawing.Color.Azure;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1170, 151);
            this.panelTop.TabIndex = 1;
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.filterPanel.Controls.Add(this.filterVehicle);
            this.filterPanel.Controls.Add(this.comboVehicle);
            this.filterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPanel.Location = new System.Drawing.Point(35, 43);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1101, 89);
            this.filterPanel.TabIndex = 2;
            // 
            // comboVehicle
            // 
            this.comboVehicle.AllowDrop = true;
            this.comboVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVehicle.FormattingEnabled = true;
            this.comboVehicle.Location = new System.Drawing.Point(31, 44);
            this.comboVehicle.Name = "comboVehicle";
            this.comboVehicle.Size = new System.Drawing.Size(191, 24);
            this.comboVehicle.TabIndex = 4;
            // 
            // filterVehicle
            // 
            this.filterVehicle.AutoSize = true;
            this.filterVehicle.ForeColor = System.Drawing.Color.Azure;
            this.filterVehicle.Location = new System.Drawing.Point(28, 15);
            this.filterVehicle.Name = "filterVehicle";
            this.filterVehicle.Size = new System.Drawing.Size(66, 17);
            this.filterVehicle.TabIndex = 7;
            this.filterVehicle.Text = "Motorista";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(47, 17);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(89, 31);
            this.labelFilter.TabIndex = 3;
            this.labelFilter.Text = "Filtros";
            // 
            // listDriver
            // 
            this.listDriver.ColumnCount = 1;
            this.listDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listDriver.Controls.Add(this.bodyPanel, 0, 1);
            this.listDriver.Controls.Add(this.panelTop, 0, 0);
            this.listDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDriver.Location = new System.Drawing.Point(0, 0);
            this.listDriver.Margin = new System.Windows.Forms.Padding(0);
            this.listDriver.Name = "listDriver";
            this.listDriver.RowCount = 2;
            this.listDriver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.listDriver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.listDriver.Size = new System.Drawing.Size(1170, 759);
            this.listDriver.TabIndex = 0;
            // 
            // containerLista
            // 
            this.containerLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.containerLista.Location = new System.Drawing.Point(35, 21);
            this.containerLista.Name = "containerLista";
            this.containerLista.Size = new System.Drawing.Size(1101, 479);
            this.containerLista.TabIndex = 0;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.containerLista);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyPanel.ForeColor = System.Drawing.Color.Azure;
            this.bodyPanel.Location = new System.Drawing.Point(0, 151);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1170, 608);
            this.bodyPanel.TabIndex = 3;
            // 
            // ListarMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.listDriver);
            this.Name = "ListarMotoristas";
            this.Size = new System.Drawing.Size(1170, 759);
            this.Load += new System.EventHandler(this.ListarMotoristas_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.listDriver.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label filterVehicle;
        private System.Windows.Forms.ComboBox comboVehicle;
        private System.Windows.Forms.TableLayoutPanel listDriver;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel containerLista;
    }
}
