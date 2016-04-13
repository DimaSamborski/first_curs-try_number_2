﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AtP_Curs
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       

        private void Main_Load(object sender, EventArgs e)
        {
            Verification fVerification = new Verification();
            if (fVerification.ShowDialog() != DialogResult.OK) Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FSearchDatabase formSearch = new FSearchDatabase();
            Show(formSearch);
        }
    }
}
