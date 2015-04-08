namespace COMP123_Lesson13_Part1
{
    partial class EndForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(103, 212);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 37);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.Location = new System.Drawing.Point(13, 58);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(45, 24);
            this.MovieTitleLabel.TabIndex = 10;
            this.MovieTitleLabel.Text = "Title";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleTextBox.Location = new System.Drawing.Point(13, 85);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(259, 29);
            this.MovieTitleTextBox.TabIndex = 9;
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.MovieTitleTextBox);
            this.Controls.Add(this.ExitButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
    }
}