namespace FinalTest.Views
{
    partial class AddFavourite
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
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtUrl = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(184, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 51);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(390, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(193, 51);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 18);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 69);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 3;
            label2.Text = "Enter Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 158);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Enter URL:";
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(399, 31);
            txtName.TabIndex = 5;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(184, 155);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(399, 31);
            txtUrl.TabIndex = 6;
            txtUrl.TextChanged += textBox2_TextChanged;
            // 
            // AddFavourite
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUrl);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "AddFavourite";
            Text = "AddFavourite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtUrl;
    }
}