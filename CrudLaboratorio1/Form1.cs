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
                //es nuestra contrase�a para acceder al crud, se creo una condici�n si la cual dice que al
                //ingresar ese texto en la caja de texto podra desencadenar otra acci�n.
                //En la caja de texto esta un password char el cual nos sirve para a�adir un simbolo o letra
                //que permita ocultar los numeros que se ingresen en la caja de texto.
            {
                MessageBox.Show("Contrase�a Correcta"); //Mensaje que aparecera en caso la contrase�a ingresada
                // sea la correcta.
                Form2 crud = new Form2();
                crud.Show(); //Nos abrira un segundo formulario en donde estara el crud del pre-laboratorio I
            }
            else //Condici�n que sucede cuando la condici�n Si no funciona y se crea la alternartiva para que
            //el codigo no tenga error de sintaxis.
            {
                MessageBox.Show("Contrase�a Incorrecta"); //Mensaje que aparecera en caso la contrase�a ingresada
                //sea la incorrecta.
                textBox1.Clear(); //Limpiara el texto que haya en la caja de texto.
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
