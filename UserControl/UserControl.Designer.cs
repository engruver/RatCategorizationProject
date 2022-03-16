namespace UserControl
{
    partial class UserControl
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
            this.IPAddressBox = new System.Windows.Forms.TextBox();
            this.selectionGroupBox = new System.Windows.Forms.GroupBox();
            this.chamber4Select = new System.Windows.Forms.RadioButton();
            this.chamber3Select = new System.Windows.Forms.RadioButton();
            this.chamber2Select = new System.Windows.Forms.RadioButton();
            this.chamber1Select = new System.Windows.Forms.RadioButton();
            this.uxStartButton = new System.Windows.Forms.Button();
            this.selectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address";
            // 
            // IPAddressBox
            // 
            this.IPAddressBox.Location = new System.Drawing.Point(122, 202);
            this.IPAddressBox.Margin = new System.Windows.Forms.Padding(2);
            this.IPAddressBox.Name = "IPAddressBox";
            this.IPAddressBox.Size = new System.Drawing.Size(145, 20);
            this.IPAddressBox.TabIndex = 4;
            // 
            // selectionGroupBox
            // 
            this.selectionGroupBox.Controls.Add(this.chamber4Select);
            this.selectionGroupBox.Controls.Add(this.chamber3Select);
            this.selectionGroupBox.Controls.Add(this.chamber2Select);
            this.selectionGroupBox.Controls.Add(this.chamber1Select);
            this.selectionGroupBox.Location = new System.Drawing.Point(11, 116);
            this.selectionGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectionGroupBox.Name = "selectionGroupBox";
            this.selectionGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.selectionGroupBox.Size = new System.Drawing.Size(106, 103);
            this.selectionGroupBox.TabIndex = 3;
            this.selectionGroupBox.TabStop = false;
            this.selectionGroupBox.Text = "Chamber Selection";
            // 
            // chamber4Select
            // 
            this.chamber4Select.AutoSize = true;
            this.chamber4Select.Location = new System.Drawing.Point(56, 67);
            this.chamber4Select.Margin = new System.Windows.Forms.Padding(2);
            this.chamber4Select.Name = "chamber4Select";
            this.chamber4Select.Size = new System.Drawing.Size(31, 17);
            this.chamber4Select.TabIndex = 3;
            this.chamber4Select.Text = "4";
            this.chamber4Select.UseVisualStyleBackColor = true;
            // 
            // chamber3Select
            // 
            this.chamber3Select.AutoSize = true;
            this.chamber3Select.Location = new System.Drawing.Point(16, 67);
            this.chamber3Select.Margin = new System.Windows.Forms.Padding(2);
            this.chamber3Select.Name = "chamber3Select";
            this.chamber3Select.Size = new System.Drawing.Size(31, 17);
            this.chamber3Select.TabIndex = 2;
            this.chamber3Select.Text = "3";
            this.chamber3Select.UseVisualStyleBackColor = true;
            // 
            // chamber2Select
            // 
            this.chamber2Select.AutoSize = true;
            this.chamber2Select.Location = new System.Drawing.Point(56, 34);
            this.chamber2Select.Margin = new System.Windows.Forms.Padding(2);
            this.chamber2Select.Name = "chamber2Select";
            this.chamber2Select.Size = new System.Drawing.Size(31, 17);
            this.chamber2Select.TabIndex = 1;
            this.chamber2Select.Text = "2";
            this.chamber2Select.UseVisualStyleBackColor = true;
            // 
            // chamber1Select
            // 
            this.chamber1Select.AutoSize = true;
            this.chamber1Select.Checked = true;
            this.chamber1Select.Location = new System.Drawing.Point(16, 34);
            this.chamber1Select.Margin = new System.Windows.Forms.Padding(2);
            this.chamber1Select.Name = "chamber1Select";
            this.chamber1Select.Size = new System.Drawing.Size(31, 17);
            this.chamber1Select.TabIndex = 0;
            this.chamber1Select.TabStop = true;
            this.chamber1Select.Text = "1";
            this.chamber1Select.UseVisualStyleBackColor = true;
            // 
            // uxStartButton
            // 
            this.uxStartButton.Location = new System.Drawing.Point(13, 13);
            this.uxStartButton.Name = "uxStartButton";
            this.uxStartButton.Size = new System.Drawing.Size(104, 57);
            this.uxStartButton.TabIndex = 6;
            this.uxStartButton.Text = "Start/Stop";
            this.uxStartButton.UseVisualStyleBackColor = true;
            this.uxStartButton.Click += new System.EventHandler(this.uxStartButton_Click);
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 262);
            this.Controls.Add(this.uxStartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPAddressBox);
            this.Controls.Add(this.selectionGroupBox);
            this.Name = "UserControl";
            this.Text = "User Control";
            this.selectionGroupBox.ResumeLayout(false);
            this.selectionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPAddressBox;
        private System.Windows.Forms.GroupBox selectionGroupBox;
        private System.Windows.Forms.RadioButton chamber4Select;
        private System.Windows.Forms.RadioButton chamber3Select;
        private System.Windows.Forms.RadioButton chamber2Select;
        private System.Windows.Forms.RadioButton chamber1Select;
        private System.Windows.Forms.Button uxStartButton;
    }
}

