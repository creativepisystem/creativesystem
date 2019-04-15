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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelDash = new System.Windows.Forms.Panel();
            this.btnDash = new System.Windows.Forms.Button();
            this.truckleerContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnSupply = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnMaintence = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.mainContainer, 0, 0);
            this.mainLayout.Controls.Add(this.truckleerContainer, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.608696F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.3913F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(1080, 720);
            this.mainLayout.TabIndex = 0;
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
            this.mainContainer.Size = new System.Drawing.Size(1080, 54);
            this.mainContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.81894F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.52054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.89041F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelDash, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1080, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelDash
            // 
            this.panelDash.Controls.Add(this.btnMaintence);
            this.panelDash.Controls.Add(this.btnVehicle);
            this.panelDash.Controls.Add(this.btnRoute);
            this.panelDash.Controls.Add(this.btnDriver);
            this.panelDash.Controls.Add(this.btnSupply);
            this.panelDash.Controls.Add(this.btnDash);
            this.panelDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDash.Location = new System.Drawing.Point(0, 0);
            this.panelDash.Margin = new System.Windows.Forms.Padding(0);
            this.panelDash.Name = "panelDash";
            this.panelDash.Size = new System.Drawing.Size(674, 54);
            this.panelDash.TabIndex = 0;
            // 
            // btnDash
            // 
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.Location = new System.Drawing.Point(1, 13);
            this.btnDash.Margin = new System.Windows.Forms.Padding(0);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(108, 31);
            this.btnDash.TabIndex = 0;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = true;
            // 
            // truckleerContainer
            // 
            this.truckleerContainer.ColumnCount = 1;
            this.truckleerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.truckleerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckleerContainer.Location = new System.Drawing.Point(0, 54);
            this.truckleerContainer.Margin = new System.Windows.Forms.Padding(0);
            this.truckleerContainer.Name = "truckleerContainer";
            this.truckleerContainer.RowCount = 1;
            this.truckleerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.truckleerContainer.Size = new System.Drawing.Size(1080, 666);
            this.truckleerContainer.TabIndex = 2;
            // 
            // btnSupply
            // 
            this.btnSupply.FlatAppearance.BorderSize = 0;
            this.btnSupply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSupply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupply.Location = new System.Drawing.Point(111, 12);
            this.btnSupply.Margin = new System.Windows.Forms.Padding(0);
            this.btnSupply.Name = "btnSupply";
            this.btnSupply.Size = new System.Drawing.Size(146, 31);
            this.btnSupply.TabIndex = 1;
            this.btnSupply.Text = "Abastecimentos";
            this.btnSupply.UseVisualStyleBackColor = true;
            // 
            // btnDriver
            // 
            this.btnDriver.FlatAppearance.BorderSize = 0;
            this.btnDriver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDriver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver.Location = new System.Drawing.Point(257, 12);
            this.btnDriver.Margin = new System.Windows.Forms.Padding(0);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(96, 31);
            this.btnDriver.TabIndex = 2;
            this.btnDriver.Text = "Motoristas";
            this.btnDriver.UseVisualStyleBackColor = true;
            // 
            // btnRoute
            // 
            this.btnRoute.FlatAppearance.BorderSize = 0;
            this.btnRoute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoute.Location = new System.Drawing.Point(448, 13);
            this.btnRoute.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(74, 31);
            this.btnRoute.TabIndex = 3;
            this.btnRoute.Text = "Rotas";
            this.btnRoute.UseVisualStyleBackColor = true;
            // 
            // btnVehicle
            // 
            this.btnVehicle.FlatAppearance.BorderSize = 0;
            this.btnVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.Location = new System.Drawing.Point(353, 13);
            this.btnVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(95, 31);
            this.btnVehicle.TabIndex = 4;
            this.btnVehicle.Text = "Veículos";
            this.btnVehicle.UseVisualStyleBackColor = true;
            // 
            // btnMaintence
            // 
            this.btnMaintence.FlatAppearance.BorderSize = 0;
            this.btnMaintence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaintence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaintence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintence.Location = new System.Drawing.Point(522, 13);
            this.btnMaintence.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaintence.Name = "btnMaintence";
            this.btnMaintence.Size = new System.Drawing.Size(120, 31);
            this.btnMaintence.TabIndex = 5;
            this.btnMaintence.Text = "Manutenção";
            this.btnMaintence.UseVisualStyleBackColor = true;
            // 
            // Truckleer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.mainLayout);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Truckleer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truckleer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainLayout.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelDash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel truckleerContainer;
        public System.Windows.Forms.Panel panelDash;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnSupply;
        private System.Windows.Forms.Button btnMaintence;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnDriver;
    }
}

