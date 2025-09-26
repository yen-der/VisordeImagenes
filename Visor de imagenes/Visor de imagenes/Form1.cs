using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Visor_de_Imagenes
{
    public partial class Form1 : Form
    {
        // Carpeta donde se buscarán las imágenes al iniciar
        string carpetaImagenes = Path.Combine(Application.StartupPath, "C:\\Users\\ALEx\\Desktop\\Visor de imagenes\\Imagenes");

        public Form1()
        {
            InitializeComponent();
           
            this.btnSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(20, 20); // Ajusta la posición
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(150, 30);
            this.btnSeleccionarCarpeta.Text = "Seleccionar carpeta";
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            // Por defecto en Zoom
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            // Crear y asignar el menu contextual al pictureBox
            InicializarMenuContextualImagen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarImagenesIniciales();
        }

        private void InicializarMenuContextualImagen()
        {
            var cms = new ContextMenuStrip();

            var itemRotarIzq = new ToolStripMenuItem("Rotar izquierda");
            itemRotarIzq.Click += (s, e) => RotarActual(RotateFlipType.Rotate270FlipNone);

            var itemRotarDer = new ToolStripMenuItem("Rotar derecha");
            itemRotarDer.Click += (s, e) => RotarActual(RotateFlipType.Rotate90FlipNone);

            var itemCopiar = new ToolStripMenuItem("Copiar imagen");
            itemCopiar.Click += (s, e) => CopiarImagenAlPortapapeles();

            cms.Items.Add(itemRotarIzq);
            cms.Items.Add(itemRotarDer);
            cms.Items.Add(new ToolStripSeparator());
            cms.Items.Add(itemCopiar);

            // Habilitar/deshabilitar según exista o no imagen
            cms.Opening += (s, e) =>
            {
                bool tieneImagen = pictureBox1.Image != null;
                foreach (ToolStripItem it in cms.Items)
                {
                    if (it is ToolStripSeparator) continue;
                    it.Enabled = tieneImagen;
                }
            };

            pictureBox1.ContextMenuStrip = cms;
        }

        private void CargarImagenesIniciales()
        {
            if (!Directory.Exists(carpetaImagenes))
            {
                return;
            }

            string[] archivos = Directory.GetFiles(carpetaImagenes, "*.*")
                                         .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                     f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                                     f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                     f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                                     f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                                         .ToArray();

            listBox1.Items.Clear();

            foreach (string archivo in archivos)
            {
                listBox1.Items.Add(archivo);
            }

            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
                CargarImagen(listBox1.Text);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                CargarImagen(listBox1.Text);
        }

        private void CargarImagen(string ruta)
        {
            try
            {
                // liberar imagen anterior
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                using (var temp = Image.FromFile(ruta))
                {
                    pictureBox1.Image = new Bitmap(temp);
                }

                // Si está en escala de grises, aplicar filtro
                if (checkBoxGrises.Checked)
                {
                    pictureBox1.Image = ConvertirEscalaGrises(pictureBox1.Image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ConvertirEscalaGrises(Image original)
        {
            if (original == null) return null;
            Bitmap bmpOrig = new Bitmap(original);
            Bitmap bmp = new Bitmap(bmpOrig.Width, bmpOrig.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmpOrig.GetPixel(x, y);
                    int gray = (c.R + c.G + c.B) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            bmpOrig.Dispose();
            return bmp;
        }

        private void RotarActual(RotateFlipType tipo)
        {
            if (pictureBox1.Image == null) return;

            try
            {
                pictureBox1.Image.RotateFlip(tipo);
                pictureBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo rotar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopiarImagenAlPortapapeles()
        {
            if (pictureBox1.Image == null) return;

            try
            {
                // Crear una copia para evitar bloqueos
                using (var copia = new Bitmap(pictureBox1.Image))
                {
                    Clipboard.SetImage(new Bitmap(copia));
                }
                // Opcional: notificar al usuario
                // MessageBox.Show("Imagen copiada al portapapeles.", "Copiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo copiar la imagen al portapapeles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // === Navegación ===
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
                listBox1.SelectedIndex--;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                listBox1.SelectedIndex++;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        // === Vision (normal / grises) ===
        private void checkBoxNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNormal.Checked)
            {
                checkBoxGrises.Checked = false;
                if (listBox1.SelectedItem != null)
                    CargarImagen(listBox1.Text);
            }
        }

        private void checkBoxGrises_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrises.Checked)
            {
                checkBoxNormal.Checked = false;
                if (listBox1.SelectedItem != null)
                    CargarImagen(listBox1.Text);
            }
        }

        // === Tamaño ===
        private void radioButtonCentrada_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCentrada.Checked)
                CambiarModoImagen(PictureBoxSizeMode.CenterImage);


        }

        private void radioButtonAjustar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAjustar.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButtonZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonZoom.Checked)
                CambiarModoImagen(PictureBoxSizeMode.Zoom);

        }

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            using (var dialogo = new FolderBrowserDialog())
            {
                dialogo.Description = "Selecciona la carpeta que contiene las imágenes";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    carpetaImagenes = dialogo.SelectedPath;
                    CargarImagenesIniciales();
                }
            }
        }
        private void CambiarModoImagen(PictureBoxSizeMode modo)
        {
            pictureBox1.SizeMode = modo;
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
