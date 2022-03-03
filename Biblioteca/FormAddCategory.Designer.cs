
namespace Biblioteca
{
    partial class FormAddCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.radioButton0_5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton19_99 = new System.Windows.Forms.RadioButton();
            this.radioButton13_18 = new System.Windows.Forms.RadioButton();
            this.radioButton6_12 = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(18, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(770, 31);
            this.textBoxName.TabIndex = 1;
            // 
            // radioButton0_5
            // 
            this.radioButton0_5.AutoSize = true;
            this.radioButton0_5.Location = new System.Drawing.Point(19, 30);
            this.radioButton0_5.Name = "radioButton0_5";
            this.radioButton0_5.Size = new System.Drawing.Size(91, 29);
            this.radioButton0_5.TabIndex = 3;
            this.radioButton0_5.TabStop = true;
            this.radioButton0_5.Text = "0 a 5";
            this.radioButton0_5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton19_99);
            this.groupBox1.Controls.Add(this.radioButton13_18);
            this.groupBox1.Controls.Add(this.radioButton6_12);
            this.groupBox1.Controls.Add(this.radioButton0_5);
            this.groupBox1.Location = new System.Drawing.Point(18, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Age";
            // 
            // radioButton19_99
            // 
            this.radioButton19_99.AutoSize = true;
            this.radioButton19_99.Location = new System.Drawing.Point(532, 30);
            this.radioButton19_99.Name = "radioButton19_99";
            this.radioButton19_99.Size = new System.Drawing.Size(115, 29);
            this.radioButton19_99.TabIndex = 6;
            this.radioButton19_99.TabStop = true;
            this.radioButton19_99.Text = "19 a 99";
            this.radioButton19_99.UseVisualStyleBackColor = true;
            // 
            // radioButton13_18
            // 
            this.radioButton13_18.AutoSize = true;
            this.radioButton13_18.Location = new System.Drawing.Point(361, 30);
            this.radioButton13_18.Name = "radioButton13_18";
            this.radioButton13_18.Size = new System.Drawing.Size(115, 29);
            this.radioButton13_18.TabIndex = 5;
            this.radioButton13_18.TabStop = true;
            this.radioButton13_18.Text = "13 a 18";
            this.radioButton13_18.UseVisualStyleBackColor = true;
            // 
            // radioButton6_12
            // 
            this.radioButton6_12.AutoSize = true;
            this.radioButton6_12.Location = new System.Drawing.Point(190, 30);
            this.radioButton6_12.Name = "radioButton6_12";
            this.radioButton6_12.Size = new System.Drawing.Size(103, 29);
            this.radioButton6_12.TabIndex = 4;
            this.radioButton6_12.TabStop = true;
            this.radioButton6_12.Text = "6 a 12";
            this.radioButton6_12.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(18, 187);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(110, 50);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(134, 187);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 50);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 256);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddCategory";
            this.Text = "FormAddCategory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RadioButton radioButton0_5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton19_99;
        private System.Windows.Forms.RadioButton radioButton13_18;
        private System.Windows.Forms.RadioButton radioButton6_12;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}