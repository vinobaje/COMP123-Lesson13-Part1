namespace COMP123_Lesson13_Part1
{
    partial class MovieForm
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
            this.MovieComboBox = new System.Windows.Forms.ComboBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieCategoryLabel = new System.Windows.Forms.Label();
            this.MovieCategoryTextBox = new System.Windows.Forms.TextBox();
            this.MovieCostLabel = new System.Windows.Forms.Label();
            this.MovieCostTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MovieComboBox
            // 
            this.MovieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.MovieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieComboBox.FormattingEnabled = true;
            this.MovieComboBox.Location = new System.Drawing.Point(12, 12);
            this.MovieComboBox.Name = "MovieComboBox";
            this.MovieComboBox.Size = new System.Drawing.Size(260, 110);
            this.MovieComboBox.Sorted = true;
            this.MovieComboBox.TabIndex = 0;
            this.MovieComboBox.SelectedIndexChanged += new System.EventHandler(this.MovieComboBox_SelectedIndexChanged);
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleTextBox.Location = new System.Drawing.Point(12, 167);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(259, 29);
            this.MovieTitleTextBox.TabIndex = 1;
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.Location = new System.Drawing.Point(12, 140);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(45, 24);
            this.MovieTitleLabel.TabIndex = 2;
            this.MovieTitleLabel.Text = "Title";
            // 
            // MovieCategoryLabel
            // 
            this.MovieCategoryLabel.AutoSize = true;
            this.MovieCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCategoryLabel.Location = new System.Drawing.Point(12, 210);
            this.MovieCategoryLabel.Name = "MovieCategoryLabel";
            this.MovieCategoryLabel.Size = new System.Drawing.Size(85, 24);
            this.MovieCategoryLabel.TabIndex = 4;
            this.MovieCategoryLabel.Text = "Category";
            // 
            // MovieCategoryTextBox
            // 
            this.MovieCategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCategoryTextBox.Location = new System.Drawing.Point(12, 237);
            this.MovieCategoryTextBox.Name = "MovieCategoryTextBox";
            this.MovieCategoryTextBox.Size = new System.Drawing.Size(259, 29);
            this.MovieCategoryTextBox.TabIndex = 3;
            // 
            // MovieCostLabel
            // 
            this.MovieCostLabel.AutoSize = true;
            this.MovieCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCostLabel.Location = new System.Drawing.Point(12, 279);
            this.MovieCostLabel.Name = "MovieCostLabel";
            this.MovieCostLabel.Size = new System.Drawing.Size(47, 24);
            this.MovieCostLabel.TabIndex = 6;
            this.MovieCostLabel.Text = "Cost";
            // 
            // MovieCostTextBox
            // 
            this.MovieCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieCostTextBox.Location = new System.Drawing.Point(12, 306);
            this.MovieCostTextBox.Name = "MovieCostTextBox";
            this.MovieCostTextBox.Size = new System.Drawing.Size(259, 29);
            this.MovieCostTextBox.TabIndex = 5;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(102, 368);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 37);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 417);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MovieCostLabel);
            this.Controls.Add(this.MovieCostTextBox);
            this.Controls.Add(this.MovieCategoryLabel);
            this.Controls.Add(this.MovieCategoryTextBox);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.MovieTitleTextBox);
            this.Controls.Add(this.MovieComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Form";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MovieComboBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label MovieCategoryLabel;
        private System.Windows.Forms.TextBox MovieCategoryTextBox;
        private System.Windows.Forms.Label MovieCostLabel;
        private System.Windows.Forms.TextBox MovieCostTextBox;
        private System.Windows.Forms.Button NextButton;
    }
}

