namespace HouseofPain
{
    partial class Finduser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chckinButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addmButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonComboBox3 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.TextNameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCustom2;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonDataGridView1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.detailsButton);
            this.kryptonGroupBox1.Panel.Controls.Add(this.chckinButton);
            this.kryptonGroupBox1.Panel.Controls.Add(this.addmButton);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonBorderEdge2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonBorderEdge1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonComboBox3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonComboBox2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonComboBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.TextNameBox);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(821, 600);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Text = "Find Users";
            this.kryptonGroupBox1.Values.Heading = "Find Users";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.card,
            this.phone,
            this.cell,
            this.add,
            this.email});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(10, 141);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(797, 425);
            this.kryptonDataGridView1.TabIndex = 6;
            this.kryptonDataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.kryptonDataGridView1_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.FillWeight = 150F;
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // card
            // 
            this.card.FillWeight = 75F;
            this.card.Frozen = true;
            this.card.HeaderText = "Card";
            this.card.Name = "card";
            this.card.ReadOnly = true;
            this.card.Width = 75;
            // 
            // phone
            // 
            this.phone.Frozen = true;
            this.phone.HeaderText = "Home Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // cell
            // 
            this.cell.FillWeight = 125F;
            this.cell.Frozen = true;
            this.cell.HeaderText = "Cell Phone";
            this.cell.Name = "cell";
            this.cell.ReadOnly = true;
            this.cell.Width = 125;
            // 
            // add
            // 
            this.add.FillWeight = 175F;
            this.add.Frozen = true;
            this.add.HeaderText = "Address";
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Width = 175;
            // 
            // email
            // 
            this.email.FillWeight = 150F;
            this.email.Frozen = true;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(323, 87);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(128, 41);
            this.detailsButton.TabIndex = 5;
            this.detailsButton.Values.Text = "Show Details";
            // 
            // chckinButton
            // 
            this.chckinButton.Location = new System.Drawing.Point(490, 87);
            this.chckinButton.Name = "chckinButton";
            this.chckinButton.Size = new System.Drawing.Size(128, 41);
            this.chckinButton.TabIndex = 5;
            this.chckinButton.Values.Text = "Check in Member";
            // 
            // addmButton
            // 
            this.addmButton.Location = new System.Drawing.Point(655, 87);
            this.addmButton.Name = "addmButton";
            this.addmButton.Size = new System.Drawing.Size(128, 41);
            this.addmButton.TabIndex = 5;
            this.addmButton.Values.Text = "Add Member";
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(10, 134);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(797, 1);
            this.kryptonBorderEdge2.Text = "kryptonBorderEdge1";
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(10, 80);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(797, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonComboBox3
            // 
            this.kryptonComboBox3.DropDownWidth = 276;
            this.kryptonComboBox3.Location = new System.Drawing.Point(481, 12);
            this.kryptonComboBox3.Name = "kryptonComboBox3";
            this.kryptonComboBox3.Size = new System.Drawing.Size(276, 21);
            this.kryptonComboBox3.TabIndex = 2;
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.DropDownWidth = 276;
            this.kryptonComboBox2.Location = new System.Drawing.Point(481, 53);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.Size = new System.Drawing.Size(276, 21);
            this.kryptonComboBox2.TabIndex = 2;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 276;
            this.kryptonComboBox1.Location = new System.Drawing.Point(87, 52);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(276, 21);
            this.kryptonComboBox1.TabIndex = 2;
            // 
            // TextNameBox
            // 
            this.TextNameBox.Location = new System.Drawing.Point(87, 12);
            this.TextNameBox.Name = "TextNameBox";
            this.TextNameBox.Size = new System.Drawing.Size(276, 20);
            this.TextNameBox.TabIndex = 1;
            this.TextNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextNameBox_KeyDown);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(400, 53);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel4.TabIndex = 0;
            this.kryptonLabel4.Values.Text = "Programme";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(10, 53);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Visited";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(400, 12);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "Modified";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "User Name";
            // 
            // Finduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "Finduser";
            this.Text = "HOP - Search";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Finduser_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextNameBox;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn card;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private ComponentFactory.Krypton.Toolkit.KryptonButton detailsButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton chckinButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addmButton;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;

    }
}