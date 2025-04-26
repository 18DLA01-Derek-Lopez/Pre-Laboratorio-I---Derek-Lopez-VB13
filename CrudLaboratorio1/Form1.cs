namespace CrudLaboratorio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345") //El valor que tendra la caja de texto sera 12345, la cual
                //es nuestra contraseña para acceder al crud, se creo una condición si la cual dice que al
                //ingresar ese texto en la caja de texto podra desencadenar otra acción.
                //En la caja de texto esta un password char el cual nos sirve para añadir un simbolo o letra
                //que permita ocultar los numeros que se ingresen en la caja de texto.
            {
                MessageBox.Show("Contraseña Correcta"); //Mensaje que aparecera en caso la contraseña ingresada
                // sea la correcta.
                Form2 crud = new Form2();
                crud.Show(); //Nos abrira un segundo formulario en donde estara el crud del pre-laboratorio I
            }
            else //Condición que sucede cuando la condición Si no funciona y se crea la alternartiva para que
            //el codigo no tenga error de sintaxis.
            {
                MessageBox.Show("Contraseña Incorrecta"); //Mensaje que aparecera en caso la contraseña ingresada
                //sea la incorrecta.
                textBox1.Clear(); //Limpiara el texto que haya en la caja de texto.
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
