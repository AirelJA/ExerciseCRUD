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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameAndLibraryDataSet1.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.gameAndLibraryDataSet1.books);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
