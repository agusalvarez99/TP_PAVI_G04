﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Formularios.FrmReportesListados
{
    public partial class RepEmpleadosPorBarrio : Form
    {
        public RepEmpleadosPorBarrio()
        {
            InitializeComponent();
        }

        private void RepEmpleadosPorBarrio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}