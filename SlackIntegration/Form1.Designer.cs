namespace SlackIntegration
{
    partial class Form1
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
            this.btnSlack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSlack
            // 
            this.btnSlack.Location = new System.Drawing.Point(206, 96);
            this.btnSlack.Name = "btnSlack";
            this.btnSlack.Size = new System.Drawing.Size(235, 61);
            this.btnSlack.TabIndex = 0;
            this.btnSlack.Text = "Send Message To Slack";
            this.btnSlack.UseVisualStyleBackColor = true;
            this.btnSlack.Click += new System.EventHandler(this.btnSlack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSlack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSlack;
    }
}

