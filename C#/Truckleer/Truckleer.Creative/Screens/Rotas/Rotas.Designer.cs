namespace Truckleer.Creative
{
    partial class Rotas
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
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelRoute = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelStops = new System.Windows.Forms.Label();
            this.TextDetination = new System.Windows.Forms.TextBox();
            this.LabelDestination = new System.Windows.Forms.Label();
            this.TextOrigin = new System.Windows.Forms.TextBox();
            this.LabelOrigin = new System.Windows.Forms.Label();
            this.DivPanel = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.PageDescription = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.PanelRoute.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.PanelMain.Controls.Add(this.ButtonHome);
            this.PanelMain.Controls.Add(this.layoutFlex);
            this.PanelMain.Controls.Add(this.PageDescription);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1220, 990);
            this.PanelMain.TabIndex = 7;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(1077, 5);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(76, 31);
            this.ButtonHome.TabIndex = 43;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
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
            this.MainPanel.Controls.Add(this.PanelContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1191, 924);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelContainer.Controls.Add(this.PanelRoute);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1191, 924);
            this.PanelContainer.TabIndex = 1;
            // 
            // PanelRoute
            // 
            this.PanelRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRoute.BackColor = System.Drawing.Color.LightGray;
            this.PanelRoute.Controls.Add(this.panel2);
            this.PanelRoute.Controls.Add(this.panel1);
            this.PanelRoute.Controls.Add(this.LabelStops);
            this.PanelRoute.Controls.Add(this.TextDetination);
            this.PanelRoute.Controls.Add(this.LabelDestination);
            this.PanelRoute.Controls.Add(this.TextOrigin);
            this.PanelRoute.Controls.Add(this.LabelOrigin);
            this.PanelRoute.Controls.Add(this.DivPanel);
            this.PanelRoute.Controls.Add(this.ButtonCancel);
            this.PanelRoute.Controls.Add(this.ButtonSave);
            this.PanelRoute.Controls.Add(this.PanelTitle);
            this.PanelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelRoute.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelRoute.Location = new System.Drawing.Point(107, 40);
            this.PanelRoute.Name = "PanelRoute";
            this.PanelRoute.Size = new System.Drawing.Size(970, 411);
            this.PanelRoute.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(105, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 2);
            this.panel2.TabIndex = 95;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(103, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 2);
            this.panel1.TabIndex = 94;
            // 
            // LabelStops
            // 
            this.LabelStops.AutoSize = true;
            this.LabelStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStops.ForeColor = System.Drawing.Color.Gray;
            this.LabelStops.Location = new System.Drawing.Point(548, 144);
            this.LabelStops.Name = "LabelStops";
            this.LabelStops.Size = new System.Drawing.Size(75, 20);
            this.LabelStops.TabIndex = 93;
            this.LabelStops.Text = "Paradas";
            // 
            // TextDetination
            // 
            this.TextDetination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextDetination.BackColor = System.Drawing.Color.LightGray;
            this.TextDetination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextDetination.Location = new System.Drawing.Point(103, 292);
            this.TextDetination.Name = "TextDetination";
            this.TextDetination.Size = new System.Drawing.Size(201, 19);
            this.TextDetination.TabIndex = 92;
            // 
            // LabelDestination
            // 
            this.LabelDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDestination.AutoSize = true;
            this.LabelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDestination.ForeColor = System.Drawing.Color.Gray;
            this.LabelDestination.Location = new System.Drawing.Point(98, 255);
            this.LabelDestination.Name = "LabelDestination";
            this.LabelDestination.Size = new System.Drawing.Size(71, 20);
            this.LabelDestination.TabIndex = 91;
            this.LabelDestination.Text = "Destino";
            // 
            // TextOrigin
            // 
            this.TextOrigin.BackColor = System.Drawing.Color.LightGray;
            this.TextOrigin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextOrigin.Location = new System.Drawing.Point(102, 184);
            this.TextOrigin.Name = "TextOrigin";
            this.TextOrigin.Size = new System.Drawing.Size(201, 19);
            this.TextOrigin.TabIndex = 90;
            // 
            // LabelOrigin
            // 
            this.LabelOrigin.AutoSize = true;
            this.LabelOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOrigin.ForeColor = System.Drawing.Color.Gray;
            this.LabelOrigin.Location = new System.Drawing.Point(97, 144);
            this.LabelOrigin.Name = "LabelOrigin";
            this.LabelOrigin.Size = new System.Drawing.Size(66, 20);
            this.LabelOrigin.TabIndex = 89;
            this.LabelOrigin.Text = "Origem";
            // 
            // DivPanel
            // 
            this.DivPanel.BackColor = System.Drawing.Color.Orange;
            this.DivPanel.Location = new System.Drawing.Point(466, 105);
            this.DivPanel.Name = "DivPanel";
            this.DivPanel.Size = new System.Drawing.Size(2, 283);
            this.DivPanel.TabIndex = 88;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.ButtonCancel.FlatAppearance.BorderSize = 2;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Orange;
            this.ButtonCancel.Location = new System.Drawing.Point(818, 346);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(97, 32);
            this.ButtonCancel.TabIndex = 70;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.Orange;
            this.ButtonSave.FlatAppearance.BorderSize = 0;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.Azure;
            this.ButtonSave.Location = new System.Drawing.Point(707, 346);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 32);
            this.ButtonSave.TabIndex = 69;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseVisualStyleBackColor = false;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.Orange;
            this.PanelTitle.Controls.Add(this.title);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(970, 87);
            this.PanelTitle.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Azure;
            this.title.Location = new System.Drawing.Point(35, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(316, 48);
            this.title.TabIndex = 41;
            this.title.Text = "Cadastro de Rotas";
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(854, 5);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(228, 31);
            this.PageDescription.TabIndex = 42;
            this.PageDescription.Text = "Cadastrar Rotas /";
            // 
            // Rotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.PanelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Rotas";
            this.Size = new System.Drawing.Size(1220, 990);
            this.Load += new System.EventHandler(this.Rotas_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelRoute.ResumeLayout(false);
            this.PanelRoute.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelRoute;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.Label LabelStops;
        private System.Windows.Forms.TextBox TextDetination;
        private System.Windows.Forms.Label LabelDestination;
        private System.Windows.Forms.TextBox TextOrigin;
        private System.Windows.Forms.Label LabelOrigin;
        private System.Windows.Forms.Panel DivPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
