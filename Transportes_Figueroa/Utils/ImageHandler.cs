using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportes_Figueroa.Utils
{
    internal class ImageHandler
    {
        public static (byte[] datosBinarios, string rutaImagen) GetImageData()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;
                    byte[] datosBinarios = File.ReadAllBytes(rutaImagen);

                    return (datosBinarios, rutaImagen);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún archivo.");
                    return (null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                return (null, null);
            }
        }

        public Image ConvertToImage(byte[] datosImagen)
        {
            try
            {
                if (datosImagen != null && datosImagen.Length > 0)
                {
                    using (MemoryStream memoryStream = new MemoryStream(datosImagen))
                    {
                        Image imagen = Image.FromStream(memoryStream);
                        return imagen;
                    }
                }
                else
                {
                    MessageBox.Show("Los datos de la imagen son nulos o vacíos.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al convertir los datos binarios en imagen: {ex.Message}");
                return null;
            }
        }
    }
}
