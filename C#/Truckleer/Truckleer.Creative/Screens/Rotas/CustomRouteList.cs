using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative.Screens.Rotas
{
    class CustomRouteList : Panel
    {
        //index - necessario
        readonly int index = 0;

        //Exemplo para classe Usuario
        readonly Route route;

        public CustomRouteList(int index, Route route)
        {
            this.index = index;

            ListViewItem listViewItem1 = new ListViewItem("São João");
            ListViewItem listViewItem2 = new ListViewItem("Dom Pedro");
            ListViewItem listViewItem3 = new ListViewItem("Não importa o tamanho da string");
            PanelIemList = new Panel();
            PanelTitle = new Panel();
            LabelName = new Label();
            LabelReceiveName = new Label();
            ButtonDelete = new Button();
            ButtonEdit = new Button();
            LabelOrigin = new Label();
            LabelDestination = new Label();
            LabelStops = new Label();
            listView1 = new ListView();
            SuspendLayout();
            PanelTitle.SuspendLayout();
            SuspendLayout();

            //Seta o Usuario
            this.route = route;
            InitializeCustomList();
        }

        private void InitializeCustomList()
        {
            // 
            // PanelIemList
            // 
            BackColor = System.Drawing.Color.LightGray;
            Controls.Add(listView1);
            Controls.Add(LabelStops);
            Controls.Add(LabelDestination);
            Controls.Add(LabelOrigin);
            Controls.Add(PanelTitle);
            Location = new System.Drawing.Point(168, 33);
            Margin = new System.Windows.Forms.Padding(30, 20, 0, 3);
            Name = "PanelIemList";
            Size = new System.Drawing.Size(338, 294);
            TabIndex = 2;
            // 
            // PanelTitle
            // 
            PanelTitle.BackColor = System.Drawing.Color.Orange;
            PanelTitle.Controls.Add(ButtonDelete);
            PanelTitle.Controls.Add(ButtonEdit);
            PanelTitle.Controls.Add(LabelReceiveName);
            PanelTitle.Controls.Add(LabelName);
            PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            PanelTitle.Location = new System.Drawing.Point(0, 0);
            PanelTitle.Name = "PanelTitle";
            PanelTitle.Size = new System.Drawing.Size(338, 61);
            PanelTitle.TabIndex = 1;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelName.Location = new System.Drawing.Point(17, 25);
            LabelName.Name = "LabelName";
            LabelName.Size = new System.Drawing.Size(63, 25);
            LabelName.TabIndex = 0;
            LabelName.Text = "Rota:";
            // 
            // LabelReceiveName
            // 
            LabelReceiveName.AutoSize = true;
            LabelReceiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveName.Location = new System.Drawing.Point(86, 33);
            LabelReceiveName.Name = "LabelReceiveName";
            LabelReceiveName.Size = new System.Drawing.Size(153, 17);
            LabelReceiveName.TabIndex = 1;
            LabelReceiveName.Text = "São Paulo x Indaiatuba";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            ButtonDelete.BackgroundImage = Properties.Resources.delete;
            ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonDelete.Location = new System.Drawing.Point(297, 11);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new System.Drawing.Size(25, 25);
            ButtonDelete.TabIndex = 108;
            ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ButtonEdit.BackColor = System.Drawing.Color.Teal;
            ButtonEdit.BackgroundImage = Properties.Resources.editNote;
            ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ButtonEdit.FlatAppearance.BorderSize = 0;
            ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonEdit.Location = new System.Drawing.Point(265, 11);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new System.Drawing.Size(25, 25);
            ButtonEdit.TabIndex = 107;
            ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // LabelOrigin
            // 
            LabelOrigin.AutoSize = true;
            LabelOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelOrigin.Location = new System.Drawing.Point(12, 90);
            LabelOrigin.Name = "LabelOrigin";
            LabelOrigin.Size = new System.Drawing.Size(68, 20);
            LabelOrigin.TabIndex = 2;
            LabelOrigin.Text = "Origem: ";
            // 
            // LabelDestination
            // 
            LabelDestination.AutoSize = true;
            LabelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelDestination.Location = new System.Drawing.Point(12, 126);
            LabelDestination.Name = "LabelDestination";
            LabelDestination.Size = new System.Drawing.Size(68, 20);
            LabelDestination.TabIndex = 3;
            LabelDestination.Text = "Destino:";
            // 
            // LabelStops
            // 
            LabelStops.AutoSize = true;
            LabelStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelStops.Location = new System.Drawing.Point(12, 175);
            LabelStops.Name = "LabelStops";
            LabelStops.Size = new System.Drawing.Size(72, 20);
            LabelStops.TabIndex = 4;
            LabelStops.Text = "Paradas:";
            // 
            // listView1
            // 
            listView1.BackColor = System.Drawing.Color.Azure;
            listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {});
            listView1.Location = new System.Drawing.Point(90, 175);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(232, 106);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Tile;
        }

        private readonly Panel PanelIemList;
        private Panel PanelTitle;
        private Label LabelReceiveName;
        private Label LabelName;
        private Label LabelOrigin;
        private Button ButtonDelete;
        private Button ButtonEdit;
        private Label LabelStops;
        private Label LabelDestination;
        private ListView listView1;
    }
}
