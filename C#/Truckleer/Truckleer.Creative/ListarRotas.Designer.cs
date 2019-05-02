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
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.containerLista = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelFilter = new System.Windows.Forms.Label();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.filterVehicle = new System.Windows.Forms.Label();
            this.comboVehicle = new System.Windows.Forms.ComboBox();
            this.bodyPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.bodyPanel.TabIndex = 4;
            // 
            // containerLista
            // 
            this.containerLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.containerLista.Location = new System.Drawing.Point(35, 21);
            this.containerLista.Name = "containerLista";
            this.containerLista.Size = new System.Drawing.Size(1101, 479);
            this.containerLista.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bodyPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1170, 759);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.panelTop.TabIndex = 2;
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
            // filterVehicle
            // 
            this.filterVehicle.AutoSize = true;
            this.filterVehicle.ForeColor = System.Drawing.Color.Azure;
            this.filterVehicle.Location = new System.Drawing.Point(28, 15);
            this.filterVehicle.Name = "filterVehicle";
            this.filterVehicle.Size = new System.Drawing.Size(45, 17);
            this.filterVehicle.TabIndex = 7;
            this.filterVehicle.Text = "Rotas";
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
            // ListarRotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListarRotas";
            this.Size = new System.Drawing.Size(1170, 759);
            this.Load += new System.EventHandler(this.ListarRotas_Load);
            this.bodyPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel containerLista;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label filterVehicle;
        private System.Windows.Forms.ComboBox comboVehicle;
    }
}
