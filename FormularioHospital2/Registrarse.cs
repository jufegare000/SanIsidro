﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioHospital2
{
    
    public partial class Registrarse : Form
    {

        private Login loginForm = null;
        public Registrarse(Login loginFormLlamada)
        {
            loginForm = loginFormLlamada as Login;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreStr = nombre.Text;
            string usuario;
            string contresena;


           // Program.usuarios;
        }
    }
}