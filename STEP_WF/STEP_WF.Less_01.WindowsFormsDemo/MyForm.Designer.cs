namespace STEP_WF.Less_01.WindowsFormsDemo
{
    partial class MyForm
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.plusBtn = new System.Windows.Forms.Button();
            this.resultBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(13, 13);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(447, 20);
            this.InputTextBox.TabIndex = 0;
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(13, 40);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(75, 23);
            this.GoBtn.TabIndex = 1;
            this.GoBtn.Text = "GO";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.ThirdHandler);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(95, 40);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(365, 20);
            this.ResultTextBox.TabIndex = 2;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.ForeColor = System.Drawing.Color.Red;
            this.resultLbl.Location = new System.Drawing.Point(12, 79);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(35, 13);
            this.resultLbl.TabIndex = 3;
            this.resultLbl.Text = "label1";
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(13, 109);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(447, 23);
            this.plusBtn.TabIndex = 4;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // resultBtn
            // 
            this.resultBtn.Location = new System.Drawing.Point(13, 138);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(447, 23);
            this.resultBtn.TabIndex = 5;
            this.resultBtn.Text = "=";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 251);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.InputTextBox);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "MyForm";
            this.Text = "First form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button resultBtn;
        internal System.Windows.Forms.Button plusBtn;
    }
}

