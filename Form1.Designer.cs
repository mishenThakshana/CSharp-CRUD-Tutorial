namespace CRUDTutorial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            inpId = new TextBox();
            inpDesign = new TextBox();
            label3 = new Label();
            inpName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbColor = new ComboBox();
            btnInsert = new Button();
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(341, 30);
            label1.Name = "label1";
            label1.Size = new Size(328, 65);
            label1.TabIndex = 0;
            label1.Text = "CRUD Tutorial";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(25, 134);
            label2.Name = "label2";
            label2.Size = new Size(197, 50);
            label2.TabIndex = 1;
            label2.Text = "Product ID";
            // 
            // inpId
            // 
            inpId.Location = new Point(299, 136);
            inpId.Name = "inpId";
            inpId.Size = new Size(564, 39);
            inpId.TabIndex = 2;
            // 
            // inpDesign
            // 
            inpDesign.Location = new Point(299, 324);
            inpDesign.Name = "inpDesign";
            inpDesign.Size = new Size(564, 39);
            inpDesign.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(25, 324);
            label3.Name = "label3";
            label3.Size = new Size(135, 50);
            label3.TabIndex = 3;
            label3.Text = "Design";
            // 
            // inpName
            // 
            inpName.Location = new Point(299, 228);
            inpName.Name = "inpName";
            inpName.Size = new Size(564, 39);
            inpName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(25, 226);
            label4.Name = "label4";
            label4.Size = new Size(204, 50);
            label4.TabIndex = 5;
            label4.Text = "Item Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(25, 424);
            label5.Name = "label5";
            label5.Size = new Size(111, 50);
            label5.TabIndex = 7;
            label5.Text = "Color";
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "Blue", "Purple", "Black", "Violet", "Gray" });
            cbColor.Location = new Point(299, 434);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(564, 40);
            cbColor.TabIndex = 8;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.DarkSlateBlue;
            btnInsert.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = SystemColors.ButtonFace;
            btnInsert.Location = new Point(25, 564);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(246, 72);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 662);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1028, 354);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSlateBlue;
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(286, 564);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(258, 72);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateBlue;
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(561, 564);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(228, 72);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkSlateBlue;
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(804, 564);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(228, 72);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1076, 1040);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(btnInsert);
            Controls.Add(cbColor);
            Controls.Add(label5);
            Controls.Add(inpName);
            Controls.Add(label4);
            Controls.Add(inpDesign);
            Controls.Add(label3);
            Controls.Add(inpId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inpId;
        private TextBox inpDesign;
        private Label label3;
        private TextBox inpName;
        private Label label4;
        private Label label5;
        private ComboBox cbColor;
        private Button btnInsert;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
    }
}
