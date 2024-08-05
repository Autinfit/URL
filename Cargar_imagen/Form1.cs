namespace Cargar_imagen
{
    public partial class Form1 : Form
    {
        string[] url = File.ReadAllLines("image_urls.txt");
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            i = url.Length - 1;
            imagen.Load(url[i]);
            label1.Text = "Imagen de " + (i + 1) + " de " + url.Length;
        }

        private void EventoCambiarImagen(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
            }
            else
            {
                i = url.Length - 1;
            }

            imagen.Load(url[i]);
            label1.Text = "Imagen de " + (i + 1) + " de " + url.Length;
        }
    }
}