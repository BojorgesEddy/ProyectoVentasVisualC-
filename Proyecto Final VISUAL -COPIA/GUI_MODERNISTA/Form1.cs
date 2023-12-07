using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_MODERNISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormProductos(object formProduct) {

            if (this.panelContenedor.Controls.Count > 0) 
                this.panelContenedor.Controls.RemoveAt(0);
            Form fp = formProduct as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fp);
            this.panelContenedor.Tag = fp;
            fp.Show();
            
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFormProductos(new Productos());
        }

        private void AbrirFormModificar(object formModificar) {

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fm = formModificar as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fm);
            this.panelContenedor.Tag = fm;
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormProductos(new EditarProductos());
        }


        private void AbrirFormClientes(object formClientes)
        {

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fc = formClientes as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fc);
            this.panelContenedor.Tag = fc;
            fc.Show();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormClientes(new Clientes());
        }

        private void AbrirFormVerClientes(object formVerClientes)
        {

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fvc = formVerClientes as Form;
            fvc.TopLevel = false;
            fvc.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fvc);
            this.panelContenedor.Tag = fvc;
            fvc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormVerClientes(new VerClientes());
        }

        private void AbrirFormCompras(object formCompras)
        {

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fvc = formCompras as Form;
            fvc.TopLevel = false;
            fvc.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fvc);
            this.panelContenedor.Tag = fvc;
            fvc.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormCompras(new compras());
        }

        private void AbrirFormListaCompras(object formListaCompras)
        {

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fvc = formListaCompras as Form;
            fvc.TopLevel = false;
            fvc.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fvc);
            this.panelContenedor.Tag = fvc;
            fvc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormListaCompras(new ListaCompras());
        }
    }
}
