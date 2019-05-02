﻿namespace Truckleer.Creative
{
    partial class ListarAbastecimentos
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
            this.components = new System.ComponentModel.Container();
            this.timerFilter = new System.Windows.Forms.Timer(this.components);
            this.listSupply = new System.Windows.Forms.Panel();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.filter = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.listSupply.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // listSupply
            // 
            this.listSupply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listSupply.Controls.Add(this.container);
            this.listSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSupply.Location = new System.Drawing.Point(0, 0);
            this.listSupply.Name = "listSupply";
            this.listSupply.Size = new System.Drawing.Size(900, 500);
            this.listSupply.TabIndex = 0;
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
            this.layoutFlex.Size = new System.Drawing.Size(871, 434);
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
            this.MainPanel.Size = new System.Drawing.Size(871, 434);
            this.MainPanel.TabIndex = 0;
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.filter.Location = new System.Drawing.Point(0, 0);
            this.filter.Margin = new System.Windows.Forms.Padding(0);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(871, 100);
            this.filter.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 334);
            this.panel4.TabIndex = 1;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.container.Controls.Add(this.layoutFlex);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(900, 500);
            this.container.TabIndex = 0;
            // 
            // ListarAbastecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.listSupply);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListarAbastecimentos";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.ListarAbastecimentos_Load);
            this.listSupply.ResumeLayout(false);
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerFilter;
        private System.Windows.Forms.Panel listSupply;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel filter;
    }
}