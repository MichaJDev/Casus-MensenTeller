﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensenteller_B3
{
    public partial class ModifyZones : Form
    {
        public ModifyZones()
        {
            InitializeComponent();
        }

        private void ModifyZones_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            CreateLocatie createLocatie = new CreateLocatie();
            createLocatie.Show();
        }
    }
}