﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Classes_Centraliser
{
    public partial class AdaugaClasa : Form
    {
        public UnivClass cformClass;
        public AdaugaClasa(UnivClass c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new UnivClass();
                btAdauga.Text = "Adauga";
            }
            else
            {
                btAdauga.Text = "Editeaza";
                tbNumeClasa.Text = c.UnivClassName;
                tbDescriere.Text = c.Description;
                tbProfesor.Text = c.ProfessorName;
                tbCredite.Text = c.Credits.ToString();
            }
            cformClass = c;
        }

        private void AdaugaClasa_Load(object sender, EventArgs e)
        {

        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
            cformClass.UnivClassName = tbNumeClasa.Text;
            cformClass.Description = tbDescriere.Text;
            cformClass.ProfessorName = tbProfesor.Text;
            cformClass.Credits = Convert.ToInt32(tbCredite.Text);
        }
    }
}
