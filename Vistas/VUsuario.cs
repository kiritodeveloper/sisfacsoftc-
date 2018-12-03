using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelos;
namespace facturacion.Vistas
{
    public partial class VUsuario : UserControl
    {
        int id_user = 0;
        public VUsuario()
        {
            InitializeComponent();
            botones(true,false,false,false,true);
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
            tb_usuario.Enabled = p;
            cb_tipo.Enabled = p;
        }

        private void cargar()
        {
            id_user= int.Parse(this.lista_usuario.CurrentRow.Cells["id"].Value.ToString());
            tb_nombre.Text = this.lista_usuario.CurrentRow.Cells["nombre"].Value.ToString();
            tb_ci.Text = this.lista_usuario.CurrentRow.Cells["ci"].Value.ToString();
            tb_telefono.Text = this.lista_usuario.CurrentRow.Cells["telefono"].Value.ToString();
            tb_direccion.Text = this.lista_usuario.CurrentRow.Cells["direccion"].Value.ToString();
            tb_usuario.Text = this.lista_usuario.CurrentRow.Cells["cuenta"].Value.ToString();
            cb_tipo.SelectedValue = this.lista_usuario.CurrentRow.Cells["tipo"].Value.ToString();
        }

        private void limpiar()
        {
            tb_nombre.Text = "";
            tb_ci.Text = "";
            tb_direccion.Text = "";
            tb_telefono.Text = "";
            tb_usuario.Text = "";
        }

        private void mostrar()
        {
            lista_usuario.DataSource = CUsuarios.Mostrar();
            lista_usuario.Columns["id"].Visible = false;
            lista_usuario.Columns["tipo"].Visible = false;
            lista_usuario.Columns["estado"].Visible = false;
            lista_usuario.Columns["direccion"].Visible = false;
            lista_usuario.Columns["telefono"].Visible = false;
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
                btn_cancelar.Command = newValue.UsuarioCommands.Cancel;
            }
            else
            {
                btn_cancelar.Command = null;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            habilitar(true);
            botones(false,false,false,true,true);
            id_user = 0;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (id_user != 0)
            {
                habilitar(true);
                botones(false, false, false, true, true);
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (id_user != 0)
            {
                if (MessageBox.Show("Estas seguro de eliminar este registro?", "DAR DE BAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CUsuarios.Eliminar(id_user, this))
                    {
                        botones(true, false, false, false, true);
                        habilitar(false);
                        mostrar();
                        id_user = 0;
                    }
                }
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (CValidar.ValidarUsuario(tb_nombre, tb_ci,cb_tipo,tb_usuario, errorIcono, this))
            {
                string time = DateTime.Now.ToString("yyyy_mm_dd hh_mm_ss");

                MUsuario us = new MUsuario(0,tb_nombre.Text,tb_ci.Text,tb_direccion.Text,tb_telefono.Text,cb_tipo.Items[cb_tipo.SelectedIndex].ToString(),"enable",tb_usuario.Text,CValidar.Encrypt(tb_ci.Text));
                
                if (id_user == 0)
                {
                    if (CUsuarios.Insertar(us, this))
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
                    if (CUsuarios.Editar(id_user, us, this))
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void lista_usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar();
            habilitar(false);
            botones(true,true,true,false,true);
        }

        private void lista_usuario_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                    if (this.lista_usuario.CurrentRow != null)
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
