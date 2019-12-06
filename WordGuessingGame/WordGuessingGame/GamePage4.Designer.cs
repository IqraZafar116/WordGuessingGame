namespace WordGuessingGame
{
    partial class GamePage4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button28 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button22 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(253, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 126;
            this.textBox1.Text = "Score : 30";
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.White;
            this.button28.BackgroundImage = global::WordGuessingGame.Properties.Resources.home_png_icon_11;
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button28.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button28.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button28.Location = new System.Drawing.Point(120, 41);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(30, 30);
            this.button28.TabIndex = 125;
            this.button28.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button28.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Red;
            this.richTextBox1.Font = new System.Drawing.Font("Modern No. 20", 15.65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(120, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(203, 105);
            this.richTextBox1.TabIndex = 123;
            this.richTextBox1.Text = "                             You Lose!";
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.Control;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(190, 260);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 32);
            this.button22.TabIndex = 127;
            this.button22.Text = "Play Again";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // GamePage4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(477, 517);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.richTextBox1);
            this.Name = "GamePage4";
            this.Text = "GamePage4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button22;
    }
}