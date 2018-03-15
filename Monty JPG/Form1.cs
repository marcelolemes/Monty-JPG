using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monty_JPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Desenho.desenhar(textBox1.Text.ToString()); //Recuperando caminho da foto, de dentro do text box, e mandando pro método de desenho
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            Array ay = (Array)e.Data.GetData(DataFormats.FileDrop);
            textBox1.Text = ay.GetValue(0).ToString();
        }
    }
}
