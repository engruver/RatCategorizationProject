namespace RatCategorizationForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonStar = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(12, 117);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(186, 170);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonStar
            // 
            this.buttonStar.Location = new System.Drawing.Point(310, 117);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(186, 170);
            this.buttonStar.TabIndex = 1;
            this.buttonStar.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(602, 117);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(186, 170);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonStar);
            this.Controls.Add(this.buttonLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonLeft;
        private Button buttonStar;
        private Button buttonRight;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}