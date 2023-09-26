﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Consulta : Form
    {
        string emp = "empleados";
        Controlador cn = new Controlador();

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
           dataGridView1.DataSource = dt;

        }


        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}