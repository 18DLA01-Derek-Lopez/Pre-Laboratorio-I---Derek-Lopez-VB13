using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrudLaboratorio1 //Nombre del proyecto el cual es CrudLaboratorioI
{
    public partial class Form2 : Form
    {
        static int seleccionarFila; //Se crea una varibale estatica publica que afectara a todo el programa, nos servira para el boton eliminar
        public Form2()
        {
            InitializeComponent(); //Inicializamos los componentes del programa
        }
        void limpiar() //Se usara void  para definir controladores de eventos, donde se requiere un tipo de valor devuelto void,
            //en este caso se llamara limpiar para limpiar las 10 cajas de textos que tiene el programa
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox1.Focus();//Indica donde debe enfocarse el cursor
        }
        private void button1_Click(object sender, EventArgs e) //Boton 
        {   
            object[] registrarDatos = //El object es una lista que agregara los elementos al dataGridView en un elemento estructurado
                {
                    textBox12.Text, //Caja de texto ID Alumno
                    textBox1.Text, //Caja de texto Nombres
                    textBox2.Text, //Caja de texto Apellidos
                    textBox3.Text, //Caja de texto Grado
                    textBox4.Text, //Caja de texto Sección
                    textBox5.Text, //Caja de texto Clave
                    textBox6.Text, //Caja de texto Carnet
                    textBox7.Text, //Caja de texto Numero de telefono
                    textBox8.Text, //Caja de texto Numero de matricula
                    textBox9.Text, //Caja de texto Ciclo académico actual
                    textBox11.Text, //Caja de texto Correo
                };
            dataGridView1.Rows.Add(registrarDatos); //Agregara toda la informacion que haya sido ingresada en el object de registrarDatos
            MessageBox.Show("Alumno Registrado", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar(); //Se usara el metodo adicional void para poder limpiar las cajas de texto luego de que se hayan registrados los datos en la tabla
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 creditos = new Form3(); //Creara un nombre para un formulario el cual sera el de Creditos
            creditos.Show(); //Ejecutara el formulario de Creditos
        }

        private void button2_Click(object sender, EventArgs e)
        {
                if (dataGridView1.RowCount != 0)
                {
                    int indice = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows[indice].Cells[0].Value = textBox12.Text;
                    dataGridView1.Rows[indice].Cells[1].Value = textBox1.Text;
                    dataGridView1.Rows[indice].Cells[2].Value = textBox2.Text;
                    dataGridView1.Rows[indice].Cells[3].Value = textBox3.Text;
                    dataGridView1.Rows[indice].Cells[4].Value = textBox4.Text;
                    dataGridView1.Rows[indice].Cells[5].Value = textBox5.Text;
                    dataGridView1.Rows[indice].Cells[6].Value = textBox6.Text;
                    dataGridView1.Rows[indice].Cells[7].Value = textBox7.Text;
                    dataGridView1.Rows[indice].Cells[8].Value = textBox8.Text;
                    dataGridView1.Rows[indice].Cells[9].Value = textBox9.Text;
                    dataGridView1.Rows[indice].Cells[10].Value = textBox11.Text;
                    MessageBox.Show("Alumno Modificado", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            limpiar();
        }   

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionarFila >= 0)
                {
                    dataGridView1.Rows.RemoveAt(seleccionarFila);
                    MessageBox.Show("Alumno Eliminado", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No hay alumnos", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay alumno/s seleccionado/s", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }
    }
}
