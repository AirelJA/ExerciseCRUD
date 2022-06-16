using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseCRUD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameAndLibraryDataSet2.movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.gameAndLibraryDataSet2.movies);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
