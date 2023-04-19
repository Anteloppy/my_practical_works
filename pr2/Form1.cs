using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2
{
    public partial class Form1 : Form
    {
        public Exists _books;
        public Form1()
        {
            InitializeComponent();
            _books = new Exists(); _books.Initialize();
            dgv.DataSource = _books.Books.ToList();
        }
        private void poV_click(object sender, EventArgs e)
        {
            List<Books> _Plus = _books.Books.OrderBy(x => x.Pages).ToList();
            dgv.DataSource = _Plus;
        }
        private void poU_Click(object sender, EventArgs e)
        {
            List<Books> _Minus = _books.Books.OrderByDescending(x => x.Pages).ToList();
            dgv.DataSource = _Minus;
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            List<Books> _Found = _books.Books.Where(x => x.author.ToLower().Contains(tb.Text.ToLower())).ToList();
            dgv.DataSource = _Found;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dgv.DataSource = _books.Books.ToList();
            tb.Text = "";
        }
    }
}
