using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace simpleCRUD
{
    public partial class frmBank : Form
    {
        private string action = "";
        public frmBank()
        {
            InitializeComponent();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            //deja un tab 
            tabs.TabPages.Remove(tabForm);

            //carga los datos en el datagridView
            //deshabilita controles
            fillDataGridView();
            controlsDisable();

        }

        //utilizado para mostrar los registros en el datagridview
        public void fillDataGridView()
        {
            //instancia de la clase libro| Book
            Bank bank = new Bank();

            clearDataGridView();

            dtgBank.Columns.Add("bankId", "BANK ID");
            dtgBank.Columns.Add("nombre", "NOMBRE");
            dtgBank.Columns.Add("direccion", "DIRECCION");
            dtgBank.Columns.Add("clientnumber", "CLIENT NUMBER");
            dtgBank.Columns.Add("phonenumber", "PHONE NUMBER");

            //llamado al medoto getBooks() de la clase Book
            MySqlDataReader dataReader = book.getAllBank();

            //leer el resultado y mostrarlo en el datagridview
            while(dataReader.Read())
            {
                dtgBank.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4)
                       );
            }
        }

        public void clearDataGridView()
        {
            dtgBank.Columns.Clear();
            dtgBank.Rows.Clear();
        }
        //deshabilita los controles de formulario
        public void controlsDisable()
        {
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtClientnumber.Enabled = false;
            dtPhonenumber.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        //habilitar los controles de formulario
        public void controlsEnable()
        {
            txtId.Enabled = false;
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtClientnumber.Enabled = true;
            dtPhonenumber.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        //limpiar el contenido de los controles
        public void clearControls()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtClientnumber.Text = "";
            dtPhonenumber.Text = "";
        }

          
       
        private void dtgBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tabs.TabPages.Remove(tabData);//ocultar el tab de el datagridview
            tabs.TabPages.Add(tabForm); //mostrar el formulario para los datos
            tabs.TabPages[0].Text = "EDIT BANK";

            action = "edit";
            controlsEnable();

            txtId.Visible = true;
            txtId.ReadOnly = true;
            lblId.Visible = true;

            //cargar datos en controles
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //mediante este boton se programara para guardar y editar
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            //codigo del boton salir
            string mensaje = "¿Está seguró que desea salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void lNew_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(tabForm);//mostrar el formulario
            tabs.TabPages.Remove(tabData); //ocultar el  tab del dataagridview
            tabs.TabPages[0].Text = "NEW BOOK"; //agregar texto al tab

            txtId.Visible = false;
            lblId.Visible = false;
            txtNombre.Focus(); //enviar enfoque al titulo
            action = "new";
            controlsEnable();
            clearControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();
                controlsDisable();


                tabs.TabPages.Remove(tabForm);
                tabs.TabPages.Add(tabData);
                tabs.TabPages[0].Text = "BOOK LIST";
            }
        }

        private void tabForm_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el nombre", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus(); //enviamos el enfoque a la caja de texto
                
            }
            else
            {

                Bank bank = new Bank(); //instancia de la clase Libro
                                        //evaluar la accion
                if (action == "edit")
                {
                    bank._bankId = Convert.ToInt32(txtId.Text);
                }


                book._nombre = txtNombre.Text;
                book._direccion = txtDireccion.Text;
                book._clientnumber = dtClientnumber.Text;
                book._phonenumber = txtPhonenumber.Text;

                string mensaje = "Esta seguro que desea guardar el registro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //LLAMAR AL METODO PARA GUARDAR
                    if (book.newEditBank(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente!",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    clearControls();
                    controlsDisable();
                    fillDataGridView();
                    tabs.TabPages.Remove(tabForm);
                    tabs.TabPages.Add(tabData);
                    tabs.TabPages[0].Text = "BOOK LIST";
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(tabData);
            tabs.TabPages.Add(tabForm);
            tabs.TabPages[0].Text = "EDIT BOOK";
            controlsEnable();

            txtId.Visible = true;
            txtId.ReadOnly = true;
            lblId.Visible = true;

            //pasar los valores del datagridview hacia los texbox
            txtId.Text = dtgBank.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgBank.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dtgBank.CurrentRow.Cells[2].Value.ToString();
            txtClientnumber.Text = dtgBank.CurrentRow.Cells[3].Value.ToString();
            dtPhonenumber.Text = dtgBank.CurrentRow.Cells[4].Value.ToString();

            //enviar aaccion
            action = "edit";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea eliminar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Bank bank = new Book();
                bank._bankId = Convert.ToInt32(dtgBank.CurrentRow.Cells[0].Value);

                //llamado al metodo deleteBook() de la clase Book
                if (bank.deleteBank())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente!",
                        "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //actualizar datagridview
                    fillDataGridView();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han podido eliminar",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
