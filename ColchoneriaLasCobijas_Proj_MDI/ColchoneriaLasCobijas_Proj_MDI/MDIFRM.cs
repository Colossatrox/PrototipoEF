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

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("1310", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion de cuentas contables", 1310);
                CapaVistaBryan.Mantenimientos.frmCuentas Cuentas = new CapaVistaBryan.Mantenimientos.frmCuentas();
                Cuentas.MdiParent = this;
                Cuentas.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de cuentas contables", 1310);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
            
        }

        private void peticiónPolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("1309", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion de peticion poliza", 1309);
                frmPeticionPoliza asignacion = new frmPeticionPoliza(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de peticion poliza", 1309);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        

        private void opcionesDeSesionYSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioContraseña cambioContraseña = new frmCambioContraseña(txtUsuario.Text);
            cambioContraseña.MdiParent = this;
            cambioContraseña.Show();
        }

        private void transaccionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaFRM/AyudaFRM.chm", "MDI.html");
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("1311", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion de polizas", 1311);
                CapaVistaBryan.Mantenimientos.frmPolizas Cuentas = new CapaVistaBryan.Mantenimientos.frmPolizas();
                Cuentas.MdiParent = this;
                Cuentas.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de polizas", 1311);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void diarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("1312", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion de libro diario", 1312);
                CapaVistaBryan.Mantenimientos.frmLibroDiario Cuentas = new CapaVistaBryan.Mantenimientos.frmLibroDiario();
                Cuentas.MdiParent = this;
                Cuentas.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de libro diario", 1312);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaBryan.Mantenimientos.frmVerBitacora Cuentas = new CapaVistaBryan.Mantenimientos.frmVerBitacora();
            Cuentas.MdiParent = this;
            Cuentas.Show();
        }
    }
}
