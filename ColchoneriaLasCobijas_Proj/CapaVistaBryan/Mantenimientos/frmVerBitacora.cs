using CapaControladorBryan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaBryan.Mantenimientos
{
    public partial class frmVerBitacora : Form
    {
        clsControlador Cn = new clsControlador();
        public frmVerBitacora()
        {
            InitializeComponent();
            DataTable Dt = Cn.funcLLenarBitacora();
            dgvPoliza.DataSource = Dt;
        }
    }
}
