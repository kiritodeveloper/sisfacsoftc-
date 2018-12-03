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
    public partial class VCodigo : UserControl
    {
        public VCodigo()
        {
            InitializeComponent();
            DateTime now= DateTime.Now;
            dt_fec_inicio.Text = now.ToString();
            now=now.AddDays(180);
            dt_fech_final.Text = now.ToString();
            mostrar();
            
        }

        private void mostrar()
        {
            lista_codigo.DataSource = CCodigo.Mostrar();
            lista_codigo.Columns["id"].Visible = false;
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
                btn_cancelar.Command = newValue.CodigoCommands.Cancel;
            }
            else
            {
                btn_cancelar.Command = null;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string ini = dt_fec_inicio.Text;
            string fin = dt_fech_final.Text;
            string des = tb_clave.Text;
            string aut = tb_autorizacion.Text;
            MCodigo cod= new MCodigo(0,DateTime.Parse(ini),DateTime.Parse(fin),des,aut);
            if (CCodigo.Insertar(cod, this)) {
                mostrar();
                tb_clave.Text = "";
            }
            
        }

        private void lista_codigo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar();
        }

        private void lista_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                    if (this.lista_codigo.CurrentRow != null)
                    {
                        cargar();
                    }
                    break;
            }
        }

        private void cargar()
        {
            this.lb_codigo.Text = Convert.ToString(this.lista_codigo.CurrentRow.Cells["clave"].Value);
        }
    }
}
