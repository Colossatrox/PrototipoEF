using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaBryan.Mantenimientos;
using CapaVistaJose.Mantenimientos;
using CapaVistaSeguridad;
using CapaVistaSeguridad.Formularios.Mantenimientos;
using CapaVistaSeguridad.Formularios;

namespace ColchoneriaLasCobijas_Proj_MDI
{
    public partial class MDIFRM : Form
    {
        clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
        clsVistaBitacora bit = new clsVistaBitacora();
        public MDIFRM()
        {
            InitializeComponent();
        }

        private void MDIFRM_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }   
        }

        

        
    }
}
