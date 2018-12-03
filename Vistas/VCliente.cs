using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controladores;

namespace facturacion.Vistas
{
    public partial class VCliente : UserControl
    {
        int id_user=0;
        public VCliente()
        {
            InitializeComponent();
            botones(true, false, false, false, true);
            mostrar();
            limpiar();
            //cargar();
            habilitar(false);
        }
        private void habilitar(bool p)
        {
            tb_nombre.Enabled = p;
            tb_ci.Enabled = p;
            tb_direccion.Enabled = p;
            tb_telefono.Enabled = p;
        }

        private void cargar()
        {
            id_user = int.Parse(this.lista_clientes.CurrentRow.Cells["id"].Value.ToString());
            tb_nombre.Text = this.lista_clientes.CurrentRow.Cells["nombre"].Value.ToString();
            tb_ci.Text = this.lista_clientes.CurrentRow.Cells["ci"].Value.ToString();
            tb_telefono.Text = this.lista_clientes.CurrentRow.Cells["telefono"].Value.ToString();
            tb_direccion.Text = this.lista_clientes.CurrentRow.Cells["direccion"].Value.ToString();
        }

        private void limpiar()
        {
            tb_nombre.Text = "";
            tb_ci.Text = "";
            tb_direccion.Text = "";
            tb_telefono.Text = "";
        }

        private void mostrar()
        {
            lista_clientes.DataSource = CCliente.mostrar();
            lista_clientes.Columns["id"].Visible = false;
        }

        private void botones(bool p1, bool p2, bool p3, bool p4, bool p5)
        {
            btn_nuevo.Enabled = p1;
            btn_editar.Enabled = p2;
            btn_eliminar.Enabled = p3;
            btn_guardar.Enabled = p4;
            btn_cancelar.Enabled = p5;
        }

        private MetroBillCommands _Commands;
        public MetroBillCommands Commands
        {
            get { return _Commands; }
            set
            {
                if (value != _Commands)
                {
                    MetroBillCommands oldValue = _Commands;
                    _Commands = value;
                    OnCommandsChanged(oldValue, value);
                }
            }
        }
        protected virtual void OnCommandsChanged(MetroBillCommands oldValue, MetroBillCommands newValue)
        {
            if (newValue != null)
            {
                btn_cancelar.Command = newValue.ClienteCommands.Cancel;
            }
            else
            {
                btn_cancelar.Command = null;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            botones(false, false, false, true, true);
            id_user = 0;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (id_user != 0)
            {
                habilitar(true);
                botones(false, false, false, true, true);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (id_user != 0)
            {
                if (MessageBox.Show("Estas seguro de eliminar este registro?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CCliente.Eliminar(id_user, this))
                    {
                        botones(true, false, false, false, true);
                        habilitar(false);
                        mostrar();
                        id_user = 0;
                    }
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (CValidar.ValidarCliente(tb_nombre, tb_ci, errorIcono, this))
            {
                string time = DateTime.Now.ToString("yyyy_mm_dd hh_mm_ss");


                MClientes cli = new MClientes(0, tb_nombre.Text, tb_ci.Text, tb_direccion.Text, tb_telefono.Text,DateTime.Now);

                if (id_user == 0)
                {
                    if (CCliente.Insertar(cli, this))
                    {
                        botones(false, false, false, true, true);
                        mostrar();
                        habilitar(true);
                        limpiar();
                        id_user = 0;
                    }
                }
                else
                {
                    if (CCliente.Editar(id_user, cli, this))
                    {
                        botones(true, false, false, false, true);
                        mostrar();
                        habilitar(true);
                        limpiar();
                        id_user = 0;
                    }
                }
            }
        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lista_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar();
            habilitar(false);
            botones(true, true, true, false, true);
        }

        private void lista_clientes_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                    if (this.lista_clientes.CurrentRow != null)
                    {
                        cargar();
                        habilitar(false);
                        botones(true, true, true, false, true);
                    }
                    break;
            }
        }
    }
}
