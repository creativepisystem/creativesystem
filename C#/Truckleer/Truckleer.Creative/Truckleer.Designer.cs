using System.Drawing;

namespace Truckleer.Creative
{
    partial class Truckleer
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Truckleer));
            this.supplyTimer = new System.Windows.Forms.Timer(this.components);
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.truckleerContainer1 = new System.Windows.Forms.TableLayoutPanel();
            this.truckleerContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupSupply = new System.Windows.Forms.Panel();
            this.btnListAbastecimentos = new System.Windows.Forms.Button();
            this.btnAbastecer = new System.Windows.Forms.Button();
            this.btnAbastecimento = new System.Windows.Forms.Button();
            this.sideBarTop = new System.Windows.Forms.Panel();
            this.btnDash = new System.Windows.Forms.Button();
            this.truckleerCallcontainer = new System.Windows.Forms.TableLayoutPanel();
            this.mainContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.truckleerContainer1.SuspendLayout();
            this.truckleerContainer.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupSupply.SuspendLayout();
            this.sideBarTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplyTimer
            // 
            this.supplyTimer.Interval = 15;
            this.supplyTimer.Tick += new System.EventHandler(this.supplyTimer_Tick);
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 1;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 1;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.Size = new System.Drawing.Size(1080, 102);
            this.mainContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelNavbar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1080, 102);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(918, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 38);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(756, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 38);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 38);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelNavbar
            // 
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavbar.Location = new System.Drawing.Point(0, 38);
            this.panelNavbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(756, 64);
            this.panelNavbar.TabIndex = 4;
            // 
            // truckleerContainer1
            // 
            this.truckleerContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.truckleerContainer1.ColumnCount = 1;
            this.truckleerContainer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.truckleerContainer1.Controls.Add(this.mainContainer, 0, 0);
            this.truckleerContainer1.Controls.Add(this.truckleerContainer, 0, 1);
            this.truckleerContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerContainer1.Location = new System.Drawing.Point(0, 0);
            this.truckleerContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.truckleerContainer1.Name = "truckleerContainer1";
            this.truckleerContainer1.RowCount = 2;
            this.truckleerContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.truckleerContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.truckleerContainer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.truckleerContainer1.Size = new System.Drawing.Size(1080, 720);
            this.truckleerContainer1.TabIndex = 0;
            // 
            // truckleerContainer
            // 
            this.truckleerContainer.ColumnCount = 2;
            this.truckleerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.truckleerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.truckleerContainer.Controls.Add(this.panelSideBar, 0, 0);
            this.truckleerContainer.Controls.Add(this.truckleerCallcontainer, 1, 0);
            this.truckleerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerContainer.Location = new System.Drawing.Point(0, 102);
            this.truckleerContainer.Margin = new System.Windows.Forms.Padding(0);
            this.truckleerContainer.Name = "truckleerContainer";
            this.truckleerContainer.RowCount = 1;
            this.truckleerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.truckleerContainer.Size = new System.Drawing.Size(1080, 618);
            this.truckleerContainer.TabIndex = 1;
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelSideBar.Controls.Add(this.tableLayoutPanel2);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(162, 618);
            this.panelSideBar.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.sideBarTop, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(162, 618);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.groupSupply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 154);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 459);
            this.panel1.TabIndex = 0;
            // 
            // groupSupply
            // 
            this.groupSupply.BackColor = System.Drawing.Color.Transparent;
            this.groupSupply.Controls.Add(this.btnListAbastecimentos);
            this.groupSupply.Controls.Add(this.btnAbastecer);
            this.groupSupply.Controls.Add(this.btnAbastecimento);
            this.groupSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupSupply.Location = new System.Drawing.Point(0, 0);
            this.groupSupply.Margin = new System.Windows.Forms.Padding(0);
            this.groupSupply.MaximumSize = new System.Drawing.Size(0, 147);
            this.groupSupply.MinimumSize = new System.Drawing.Size(0, 49);
            this.groupSupply.Name = "groupSupply";
            this.groupSupply.Size = new System.Drawing.Size(152, 49);
            this.groupSupply.TabIndex = 0;
            // 
            // btnListAbastecimentos
            // 
            this.btnListAbastecimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListAbastecimentos.Location = new System.Drawing.Point(0, 96);
            this.btnListAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.btnListAbastecimentos.Name = "btnListAbastecimentos";
            this.btnListAbastecimentos.Size = new System.Drawing.Size(152, 48);
            this.btnListAbastecimentos.TabIndex = 2;
            this.btnListAbastecimentos.Text = "Listar Abastecimentos";
            this.btnListAbastecimentos.UseVisualStyleBackColor = true;
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbastecer.Location = new System.Drawing.Point(0, 48);
            this.btnAbastecer.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(152, 48);
            this.btnAbastecer.TabIndex = 1;
            this.btnAbastecer.Text = "Abastecer";
            this.btnAbastecer.UseVisualStyleBackColor = true;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // btnAbastecimento
            // 
            this.btnAbastecimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbastecimento.Location = new System.Drawing.Point(0, 0);
            this.btnAbastecimento.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbastecimento.Name = "btnAbastecimento";
            this.btnAbastecimento.Size = new System.Drawing.Size(152, 48);
            this.btnAbastecimento.TabIndex = 0;
            this.btnAbastecimento.Text = "Abastecimento";
            this.btnAbastecimento.UseVisualStyleBackColor = true;
            this.btnAbastecimento.Click += new System.EventHandler(this.btnAbastecimento_Click);
            // 
            // sideBarTop
            // 
            this.sideBarTop.BackColor = System.Drawing.Color.Gray;
            this.sideBarTop.Controls.Add(this.btnDash);
            this.sideBarTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarTop.Location = new System.Drawing.Point(5, 5);
            this.sideBarTop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.sideBarTop.Name = "sideBarTop";
            this.sideBarTop.Size = new System.Drawing.Size(152, 149);
            this.sideBarTop.TabIndex = 1;
            // 
            // btnDash
            // 
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDash.Location = new System.Drawing.Point(0, 101);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(152, 48);
            this.btnDash.TabIndex = 0;
            this.btnDash.Text = "DashBoard";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // truckleerCallcontainer
            // 
            this.truckleerCallcontainer.ColumnCount = 1;
            this.truckleerCallcontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.truckleerCallcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerCallcontainer.Location = new System.Drawing.Point(162, 0);
            this.truckleerCallcontainer.Margin = new System.Windows.Forms.Padding(0);
            this.truckleerCallcontainer.Name = "truckleerCallcontainer";
            this.truckleerCallcontainer.RowCount = 1;
            this.truckleerCallcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.truckleerCallcontainer.Size = new System.Drawing.Size(918, 618);
            this.truckleerCallcontainer.TabIndex = 0;
            // 
            // Truckleer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.truckleerContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Truckleer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truckleer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.truckleerContainer1.ResumeLayout(false);
            this.truckleerContainer.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupSupply.ResumeLayout(false);
            this.sideBarTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer supplyTimer;
        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.TableLayoutPanel truckleerContainer1;
        private System.Windows.Forms.TableLayoutPanel truckleerContainer;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel groupSupply;
        private System.Windows.Forms.Button btnListAbastecimentos;
        private System.Windows.Forms.Button btnAbastecer;
        private System.Windows.Forms.Button btnAbastecimento;
        private System.Windows.Forms.TableLayoutPanel truckleerCallcontainer;
        private System.Windows.Forms.Panel sideBarTop;
        private System.Windows.Forms.Button btnDash;
    }
}

