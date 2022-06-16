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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameAndLibraryDataSet.games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.gameAndLibraryDataSet.games);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
