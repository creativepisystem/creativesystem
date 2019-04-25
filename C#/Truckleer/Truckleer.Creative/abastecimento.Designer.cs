namespace Truckleer.Creative
{
    partial class Abastecimento
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
            this.panelAbastecimentos = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelContainerAbastecimentos = new System.Windows.Forms.Panel();
            this.tableLayoutItems = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeftAbastecimentos = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBoxStation = new System.Windows.Forms.ListBox();
            this.labelStationSupply = new System.Windows.Forms.Label();
            this.listBoxRoute = new System.Windows.Forms.ListBox();
            this.labelRouteSupplpy = new System.Windows.Forms.Label();
            this.listBoxVehicle = new System.Windows.Forms.ListBox();
            this.labelVeiculoSupply = new System.Windows.Forms.Label();
            this.listBoxDriver = new System.Windows.Forms.ListBox();
            this.labelDataSupply = new System.Windows.Forms.Label();
            this.labelMotoristaSupply = new System.Windows.Forms.Label();
            this.panelRightAbastecimentos = new System.Windows.Forms.Panel();
            this.textBoxLitersSupply = new System.Windows.Forms.TextBox();
            this.textBoxPriceSupply = new System.Windows.Forms.TextBox();
            this.textBoxKMSupply = new System.Windows.Forms.TextBox();
            this.listBoxTrip = new System.Windows.Forms.ListBox();
            this.labelTripSupply = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalSupply = new System.Windows.Forms.Label();
            this.labelLitrosSupply = new System.Windows.Forms.Label();
            this.labelPriceSupply = new System.Windows.Forms.Label();
            this.labelKmSupply = new System.Windows.Forms.Label();
            this.panelFooterAbastecimentos = new System.Windows.Forms.Panel();
            this.panelTitleAbastecimentos = new System.Windows.Forms.Panel();
            this.titleSupply = new System.Windows.Forms.Label();
            this.panelAbastecimentos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelContainerAbastecimentos.SuspendLayout();
            this.tableLayoutItems.SuspendLayout();
            this.panelLeftAbastecimentos.SuspendLayout();
            this.panelRightAbastecimentos.SuspendLayout();
            this.panelTitleAbastecimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAbastecimentos
            // 
            this.panelAbastecimentos.Controls.Add(this.tableLayoutPanel1);
            this.panelAbastecimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAbastecimentos.Location = new System.Drawing.Point(0, 0);
            this.panelAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.panelAbastecimentos.Name = "panelAbastecimentos";
            this.panelAbastecimentos.Size = new System.Drawing.Size(1220, 990);
            this.panelAbastecimentos.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelContainerAbastecimentos, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1220, 990);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelContainerAbastecimentos
            // 
            this.panelContainerAbastecimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelContainerAbastecimentos.Controls.Add(this.tableLayoutItems);
            this.panelContainerAbastecimentos.Controls.Add(this.panelFooterAbastecimentos);
            this.panelContainerAbastecimentos.Controls.Add(this.panelTitleAbastecimentos);
            this.panelContainerAbastecimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerAbastecimentos.Location = new System.Drawing.Point(244, 10);
            this.panelContainerAbastecimentos.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelContainerAbastecimentos.Name = "panelContainerAbastecimentos";
            this.panelContainerAbastecimentos.Size = new System.Drawing.Size(732, 970);
            this.panelContainerAbastecimentos.TabIndex = 0;
            // 
            // tableLayoutItems
            // 
            this.tableLayoutItems.ColumnCount = 2;
            this.tableLayoutItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutItems.Controls.Add(this.panelLeftAbastecimentos, 0, 0);
            this.tableLayoutItems.Controls.Add(this.panelRightAbastecimentos, 1, 0);
            this.tableLayoutItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutItems.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutItems.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutItems.Name = "tableLayoutItems";
            this.tableLayoutItems.RowCount = 1;
            this.tableLayoutItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 637F));
            this.tableLayoutItems.Size = new System.Drawing.Size(732, 868);
            this.tableLayoutItems.TabIndex = 2;
            // 
            // panelLeftAbastecimentos
            // 
            this.panelLeftAbastecimentos.Controls.Add(this.dateTimePicker1);
            this.panelLeftAbastecimentos.Controls.Add(this.listBoxStation);
            this.panelLeftAbastecimentos.Controls.Add(this.labelStationSupply);
            this.panelLeftAbastecimentos.Controls.Add(this.listBoxRoute);
            this.panelLeftAbastecimentos.Controls.Add(this.labelRouteSupplpy);
            this.panelLeftAbastecimentos.Controls.Add(this.listBoxVehicle);
            this.panelLeftAbastecimentos.Controls.Add(this.labelVeiculoSupply);
            this.panelLeftAbastecimentos.Controls.Add(this.listBoxDriver);
            this.panelLeftAbastecimentos.Controls.Add(this.labelDataSupply);
            this.panelLeftAbastecimentos.Controls.Add(this.labelMotoristaSupply);
            this.panelLeftAbastecimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftAbastecimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeftAbastecimentos.Location = new System.Drawing.Point(0, 0);
            this.panelLeftAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeftAbastecimentos.Name = "panelLeftAbastecimentos";
            this.panelLeftAbastecimentos.Size = new System.Drawing.Size(366, 868);
            this.panelLeftAbastecimentos.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 30);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // listBoxStation
            // 
            this.listBoxStation.FormattingEnabled = true;
            this.listBoxStation.ItemHeight = 25;
            this.listBoxStation.Location = new System.Drawing.Point(130, 360);
            this.listBoxStation.Name = "listBoxStation";
            this.listBoxStation.Size = new System.Drawing.Size(195, 29);
            this.listBoxStation.TabIndex = 8;
            // 
            // labelStationSupply
            // 
            this.labelStationSupply.AutoSize = true;
            this.labelStationSupply.Location = new System.Drawing.Point(32, 360);
            this.labelStationSupply.Name = "labelStationSupply";
            this.labelStationSupply.Size = new System.Drawing.Size(62, 25);
            this.labelStationSupply.TabIndex = 7;
            this.labelStationSupply.Text = "Posto";
            // 
            // listBoxRoute
            // 
            this.listBoxRoute.FormattingEnabled = true;
            this.listBoxRoute.ItemHeight = 25;
            this.listBoxRoute.Location = new System.Drawing.Point(130, 275);
            this.listBoxRoute.Name = "listBoxRoute";
            this.listBoxRoute.Size = new System.Drawing.Size(195, 29);
            this.listBoxRoute.TabIndex = 6;
            // 
            // labelRouteSupplpy
            // 
            this.labelRouteSupplpy.AutoSize = true;
            this.labelRouteSupplpy.Location = new System.Drawing.Point(32, 275);
            this.labelRouteSupplpy.Name = "labelRouteSupplpy";
            this.labelRouteSupplpy.Size = new System.Drawing.Size(52, 25);
            this.labelRouteSupplpy.TabIndex = 5;
            this.labelRouteSupplpy.Text = "Rota";
            // 
            // listBoxVehicle
            // 
            this.listBoxVehicle.FormattingEnabled = true;
            this.listBoxVehicle.ItemHeight = 25;
            this.listBoxVehicle.Location = new System.Drawing.Point(130, 196);
            this.listBoxVehicle.Name = "listBoxVehicle";
            this.listBoxVehicle.Size = new System.Drawing.Size(195, 29);
            this.listBoxVehicle.TabIndex = 4;
            // 
            // labelVeiculoSupply
            // 
            this.labelVeiculoSupply.AutoSize = true;
            this.labelVeiculoSupply.Location = new System.Drawing.Point(32, 196);
            this.labelVeiculoSupply.Name = "labelVeiculoSupply";
            this.labelVeiculoSupply.Size = new System.Drawing.Size(77, 25);
            this.labelVeiculoSupply.TabIndex = 3;
            this.labelVeiculoSupply.Text = "Veículo";
            // 
            // listBoxDriver
            // 
            this.listBoxDriver.FormattingEnabled = true;
            this.listBoxDriver.ItemHeight = 25;
            this.listBoxDriver.Location = new System.Drawing.Point(130, 119);
            this.listBoxDriver.Name = "listBoxDriver";
            this.listBoxDriver.Size = new System.Drawing.Size(195, 29);
            this.listBoxDriver.TabIndex = 2;
            // 
            // labelDataSupply
            // 
            this.labelDataSupply.AutoSize = true;
            this.labelDataSupply.Location = new System.Drawing.Point(32, 55);
            this.labelDataSupply.Name = "labelDataSupply";
            this.labelDataSupply.Size = new System.Drawing.Size(53, 25);
            this.labelDataSupply.TabIndex = 1;
            this.labelDataSupply.Text = "Data";
            // 
            // labelMotoristaSupply
            // 
            this.labelMotoristaSupply.AutoSize = true;
            this.labelMotoristaSupply.Location = new System.Drawing.Point(32, 119);
            this.labelMotoristaSupply.Name = "labelMotoristaSupply";
            this.labelMotoristaSupply.Size = new System.Drawing.Size(92, 25);
            this.labelMotoristaSupply.TabIndex = 0;
            this.labelMotoristaSupply.Text = "Motorista";
            // 
            // panelRightAbastecimentos
            // 
            this.panelRightAbastecimentos.Controls.Add(this.textBoxLitersSupply);
            this.panelRightAbastecimentos.Controls.Add(this.textBoxPriceSupply);
            this.panelRightAbastecimentos.Controls.Add(this.textBoxKMSupply);
            this.panelRightAbastecimentos.Controls.Add(this.listBoxTrip);
            this.panelRightAbastecimentos.Controls.Add(this.labelTripSupply);
            this.panelRightAbastecimentos.Controls.Add(this.label1);
            this.panelRightAbastecimentos.Controls.Add(this.labelTotalSupply);
            this.panelRightAbastecimentos.Controls.Add(this.labelLitrosSupply);
            this.panelRightAbastecimentos.Controls.Add(this.labelPriceSupply);
            this.panelRightAbastecimentos.Controls.Add(this.labelKmSupply);
            this.panelRightAbastecimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightAbastecimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRightAbastecimentos.Location = new System.Drawing.Point(366, 0);
            this.panelRightAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.panelRightAbastecimentos.Name = "panelRightAbastecimentos";
            this.panelRightAbastecimentos.Size = new System.Drawing.Size(366, 868);
            this.panelRightAbastecimentos.TabIndex = 1;
            // 
            // textBoxLitersSupply
            // 
            this.textBoxLitersSupply.Location = new System.Drawing.Point(120, 270);
            this.textBoxLitersSupply.Name = "textBoxLitersSupply";
            this.textBoxLitersSupply.Size = new System.Drawing.Size(201, 30);
            this.textBoxLitersSupply.TabIndex = 21;
            // 
            // textBoxPriceSupply
            // 
            this.textBoxPriceSupply.Location = new System.Drawing.Point(120, 200);
            this.textBoxPriceSupply.Name = "textBoxPriceSupply";
            this.textBoxPriceSupply.Size = new System.Drawing.Size(198, 30);
            this.textBoxPriceSupply.TabIndex = 20;
            // 
            // textBoxKMSupply
            // 
            this.textBoxKMSupply.Location = new System.Drawing.Point(120, 125);
            this.textBoxKMSupply.Name = "textBoxKMSupply";
            this.textBoxKMSupply.Size = new System.Drawing.Size(201, 30);
            this.textBoxKMSupply.TabIndex = 19;
            // 
            // listBoxTrip
            // 
            this.listBoxTrip.FormattingEnabled = true;
            this.listBoxTrip.ItemHeight = 25;
            this.listBoxTrip.Location = new System.Drawing.Point(120, 56);
            this.listBoxTrip.Name = "listBoxTrip";
            this.listBoxTrip.Size = new System.Drawing.Size(201, 29);
            this.listBoxTrip.TabIndex = 18;
            // 
            // labelTripSupply
            // 
            this.labelTripSupply.AutoSize = true;
            this.labelTripSupply.Location = new System.Drawing.Point(28, 56);
            this.labelTripSupply.Name = "labelTripSupply";
            this.labelTripSupply.Size = new System.Drawing.Size(79, 25);
            this.labelTripSupply.TabIndex = 17;
            this.labelTripSupply.Text = "Viagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(221, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total Price";
            // 
            // labelTotalSupply
            // 
            this.labelTotalSupply.AutoSize = true;
            this.labelTotalSupply.Location = new System.Drawing.Point(37, 364);
            this.labelTotalSupply.Name = "labelTotalSupply";
            this.labelTotalSupply.Size = new System.Drawing.Size(56, 25);
            this.labelTotalSupply.TabIndex = 15;
            this.labelTotalSupply.Text = "Total";
            // 
            // labelLitrosSupply
            // 
            this.labelLitrosSupply.AutoSize = true;
            this.labelLitrosSupply.Location = new System.Drawing.Point(25, 275);
            this.labelLitrosSupply.Name = "labelLitrosSupply";
            this.labelLitrosSupply.Size = new System.Drawing.Size(59, 25);
            this.labelLitrosSupply.TabIndex = 13;
            this.labelLitrosSupply.Text = "Litros";
            // 
            // labelPriceSupply
            // 
            this.labelPriceSupply.AutoSize = true;
            this.labelPriceSupply.Location = new System.Drawing.Point(22, 200);
            this.labelPriceSupply.Name = "labelPriceSupply";
            this.labelPriceSupply.Size = new System.Drawing.Size(63, 25);
            this.labelPriceSupply.TabIndex = 11;
            this.labelPriceSupply.Text = "Preço";
            // 
            // labelKmSupply
            // 
            this.labelKmSupply.AutoSize = true;
            this.labelKmSupply.Location = new System.Drawing.Point(22, 125);
            this.labelKmSupply.Name = "labelKmSupply";
            this.labelKmSupply.Size = new System.Drawing.Size(92, 25);
            this.labelKmSupply.TabIndex = 9;
            this.labelKmSupply.Text = "Km Atual";
            // 
            // panelFooterAbastecimentos
            // 
            this.panelFooterAbastecimentos.BackColor = System.Drawing.Color.SteelBlue;
            this.panelFooterAbastecimentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterAbastecimentos.Location = new System.Drawing.Point(0, 943);
            this.panelFooterAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.panelFooterAbastecimentos.Name = "panelFooterAbastecimentos";
            this.panelFooterAbastecimentos.Size = new System.Drawing.Size(732, 27);
            this.panelFooterAbastecimentos.TabIndex = 1;
            // 
            // panelTitleAbastecimentos
            // 
            this.panelTitleAbastecimentos.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitleAbastecimentos.Controls.Add(this.titleSupply);
            this.panelTitleAbastecimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleAbastecimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleAbastecimentos.Location = new System.Drawing.Point(0, 0);
            this.panelTitleAbastecimentos.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleAbastecimentos.Name = "panelTitleAbastecimentos";
            this.panelTitleAbastecimentos.Size = new System.Drawing.Size(732, 75);
            this.panelTitleAbastecimentos.TabIndex = 0;
            // 
            // titleSupply
            // 
            this.titleSupply.AutoSize = true;
            this.titleSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSupply.ForeColor = System.Drawing.Color.Brown;
            this.titleSupply.Location = new System.Drawing.Point(281, 16);
            this.titleSupply.Name = "titleSupply";
            this.titleSupply.Size = new System.Drawing.Size(170, 39);
            this.titleSupply.TabIndex = 0;
            this.titleSupply.Text = "Abastecer";
            // 
            // Abastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.panelAbastecimentos);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Abastecimento";
            this.Size = new System.Drawing.Size(1220, 990);
            this.Load += new System.EventHandler(this.Abastecimento_Load);
            this.panelAbastecimentos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelContainerAbastecimentos.ResumeLayout(false);
            this.tableLayoutItems.ResumeLayout(false);
            this.panelLeftAbastecimentos.ResumeLayout(false);
            this.panelLeftAbastecimentos.PerformLayout();
            this.panelRightAbastecimentos.ResumeLayout(false);
            this.panelRightAbastecimentos.PerformLayout();
            this.panelTitleAbastecimentos.ResumeLayout(false);
            this.panelTitleAbastecimentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAbastecimentos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelContainerAbastecimentos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutItems;
        private System.Windows.Forms.Panel panelLeftAbastecimentos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxStation;
        private System.Windows.Forms.Label labelStationSupply;
        private System.Windows.Forms.ListBox listBoxRoute;
        private System.Windows.Forms.Label labelRouteSupplpy;
        private System.Windows.Forms.ListBox listBoxVehicle;
        private System.Windows.Forms.Label labelVeiculoSupply;
        private System.Windows.Forms.ListBox listBoxDriver;
        private System.Windows.Forms.Label labelDataSupply;
        private System.Windows.Forms.Label labelMotoristaSupply;
        private System.Windows.Forms.Panel panelRightAbastecimentos;
        private System.Windows.Forms.TextBox textBoxLitersSupply;
        private System.Windows.Forms.TextBox textBoxPriceSupply;
        private System.Windows.Forms.TextBox textBoxKMSupply;
        private System.Windows.Forms.ListBox listBoxTrip;
        private System.Windows.Forms.Label labelTripSupply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalSupply;
        private System.Windows.Forms.Label labelLitrosSupply;
        private System.Windows.Forms.Label labelPriceSupply;
        private System.Windows.Forms.Label labelKmSupply;
        private System.Windows.Forms.Panel panelFooterAbastecimentos;
        private System.Windows.Forms.Panel panelTitleAbastecimentos;
        private System.Windows.Forms.Label titleSupply;
    }
}
