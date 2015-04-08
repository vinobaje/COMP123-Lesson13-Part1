using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Lesson13_Part1
{
    public partial class EndForm : Form
    {
        //private instance variables
        private Movie _selectedMovie;
        
        public EndForm(Movie selectedMovie)
        {
            InitializeComponent();

            this._selectedMovie = selectedMovie;

            MovieTitleTextBox.Text = this._selectedMovie.Title;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
