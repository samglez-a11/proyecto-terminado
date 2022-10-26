namespace analizador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textLexico.Text = "";
            textErrorLexico.Text = "";
            textCodigo.Text = "";
            textErrorSeman.Text = "";
            textArbol.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text != "")
            {
                compilador analizador = new compilador();
                analizador.Analizador(textCodigo.Text.ToString());

                textLexico.Text = analizador.dameListaToken();
                textErrorLexico.Text = analizador.dameListaErrores();
                textErrorSeman.Text = analizador.dameListaErroresSemanticos();
                textArbol.Text = analizador.muestraArbol();
                mostrarSintactico(analizador.dameListaSintactico(), analizador.dameSalida(), analizador.dameEntrada());

            }
            else
            {
                MessageBox.Show("No ha ingresado el codigo");
            }
        }

        private void mostrarSintactico(List<String> lista, List<String> salida, List<String> entrada)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add(lista[i], salida[i], entrada[i]);
            }
        }
    }
}