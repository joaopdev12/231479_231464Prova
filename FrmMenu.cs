﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231479_231464
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banco.CriarBanco();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            FrmCidades form = new FrmCidades();
            form.Show();

        }

    }
}
