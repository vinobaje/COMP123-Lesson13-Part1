﻿using System;
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
    public partial class MovieForm : Form
    {

        //public Movie[] movies = new Movie[20];
        public List<Movie> movies = new List<Movie>();

        // private instance variables
        int _movieIndex;

        public MovieForm()
        {
            InitializeComponent();
            InitializeMovieList();
            InitializeMovieComboBox();
        }

        private void InitializeMovieList()
        {
            movies.Add(new Movie("Season of the Witch", "Sci-Fi", 2.99));
            movies.Add(new Movie("The Dilemma", "Action", 2.99));
            movies.Add(new Movie("The Green Hornet", "Comedy", 1.99));
            movies.Add(new Movie("Death Race 2", "Action", 2.99));
            
        }

        private void InitializeMovieComboBox()
        {
            foreach (var movie in movies)
            {
                MovieComboBox.Items.Add(movie.Title);
            }
            
        }


        private void MovieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._movieIndex = MovieComboBox.SelectedIndex;

            movies.Sort();
            MovieTitleTextBox.Text = movies[this._movieIndex].Title;
            MovieCategoryTextBox.Text = movies[this._movieIndex].Category;
            MovieCostTextBox.Text = movies[this._movieIndex].Cost.ToString();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            MovieComboBox.SelectedIndex = 0;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            EndForm endForm = new EndForm(movies[this._movieIndex]);

            this.Hide();
            endForm.Owner = this;
            endForm.Show();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();

            aboutBox.ShowDialog();
        }

    }
}
