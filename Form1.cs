namespace FormularioContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxName.Text) ||
                 string.IsNullOrWhiteSpace(TextBoxEmail.Text) ||
                 string.IsNullOrWhiteSpace(TextBoxMessage.Text))
            
                LabelEstado.Text = "Por favor, complete todos los campos";
          else
                {
                    LabelEstado.Text = $"Los datos fueron ingresados correctamente!";
                }
            }
            private void TextBoxName_TextChanged(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }
        }
    }

