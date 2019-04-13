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
            this.sideMenuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.backPage = new System.Windows.Forms.Panel();
            this.nameLogoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.brandLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerMenu = new System.Windows.Forms.Panel();
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.mainLayout.SuspendLayout();
            this.sideMenuLayout.SuspendLayout();
            this.nameLogoLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.mainLayout.Controls.Add(this.sideMenuLayout, 0, 1);
            this.mainLayout.Controls.Add(this.nameLogoLayout, 0, 0);
            this.mainLayout.Controls.Add(this.headerMenu, 1, 0);
            this.mainLayout.Controls.Add(this.mainContainer, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.mainLayout.Size = new System.Drawing.Size(1080, 720);
            this.mainLayout.TabIndex = 0;
            // 
            // sideMenuLayout
            // 
            this.sideMenuLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.sideMenuLayout.ColumnCount = 1;
            this.sideMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sideMenuLayout.Controls.Add(this.backPage, 0, 0);
            this.sideMenuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideMenuLayout.Location = new System.Drawing.Point(0, 43);
            this.sideMenuLayout.Margin = new System.Windows.Forms.Padding(0);
            this.sideMenuLayout.Name = "sideMenuLayout";
            this.sideMenuLayout.RowCount = 2;
            this.sideMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.sideMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.sideMenuLayout.Size = new System.Drawing.Size(194, 677);
            this.sideMenuLayout.TabIndex = 0;
            // 
            // backPage
            // 
            this.backPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.backPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPage.Location = new System.Drawing.Point(4, 4);
            this.backPage.Margin = new System.Windows.Forms.Padding(4);
            this.backPage.Name = "backPage";
            this.backPage.Size = new System.Drawing.Size(186, 59);
            this.backPage.TabIndex = 0;
            // 
            // nameLogoLayout
            // 
            this.nameLogoLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.nameLogoLayout.ColumnCount = 1;
            this.nameLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.nameLogoLayout.Controls.Add(this.brandLayout, 0, 0);
            this.nameLogoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLogoLayout.Location = new System.Drawing.Point(0, 0);
            this.nameLogoLayout.Margin = new System.Windows.Forms.Padding(0);
            this.nameLogoLayout.Name = "nameLogoLayout";
            this.nameLogoLayout.RowCount = 1;
            this.nameLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.nameLogoLayout.Size = new System.Drawing.Size(194, 43);
            this.nameLogoLayout.TabIndex = 1;
            // 
            // brandLayout
            // 
            this.brandLayout.ColumnCount = 2;
            this.brandLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.brandLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.brandLayout.Location = new System.Drawing.Point(3, 3);
            this.brandLayout.Name = "brandLayout";
            this.brandLayout.RowCount = 1;
            this.brandLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.brandLayout.Size = new System.Drawing.Size(188, 37);
            this.brandLayout.TabIndex = 0;
            // 
            // headerMenu
            // 
            this.headerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(95)))), ((int)(((byte)(201)))));
            this.headerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerMenu.Location = new System.Drawing.Point(194, 0);
            this.headerMenu.Margin = new System.Windows.Forms.Padding(0);
            this.headerMenu.Name = "headerMenu";
            this.headerMenu.Size = new System.Drawing.Size(886, 43);
            this.headerMenu.TabIndex = 2;
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 1;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(194, 43);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 1;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.Size = new System.Drawing.Size(886, 677);
            this.mainContainer.TabIndex = 3;
            // 
            // Truckleer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.mainLayout);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Truckleer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truckleer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainLayout.ResumeLayout(false);
            this.sideMenuLayout.ResumeLayout(false);
            this.nameLogoLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel sideMenuLayout;
        private System.Windows.Forms.TableLayoutPanel nameLogoLayout;
        private System.Windows.Forms.TableLayoutPanel brandLayout;
        private System.Windows.Forms.Panel headerMenu;
        private System.Windows.Forms.Panel backPage;
        private System.Windows.Forms.TableLayoutPanel mainContainer;
    }
}

