namespace StudentDGV
{
    partial class FrmStudent
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
            txtName = new TextBox();
            txtFamily = new TextBox();
            txtNationalCode = new TextBox();
            txtGender = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRemove = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(119, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 23);
            txtName.TabIndex = 0;
            // 
            // txtFamily
            // 
            txtFamily.Location = new Point(119, 84);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(176, 23);
            txtFamily.TabIndex = 0;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(119, 113);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(176, 23);
            txtNationalCode.TabIndex = 0;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(119, 142);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(176, 23);
            txtGender.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(264, 185);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 26);
            btnSave.TabIndex = 1;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 58);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 87);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 116);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "کدملی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 145);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 2;
            label4.Text = "جنسیت";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(82, 185);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(81, 26);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "حذف";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(169, 185);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(89, 26);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 346);
            Controls.Add(btnRemove);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(txtGender);
            Controls.Add(txtNationalCode);
            Controls.Add(txtFamily);
            Controls.Add(txtName);
            Name = "FrmStudent";
            Text = "FrmStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRemove;
        private Button btnEdit;
        public TextBox txtName;
        public TextBox txtFamily;
        public TextBox txtNationalCode;
        public TextBox txtGender;
    }
}