using System;
using System.IO;
using System.Windows.Forms;

namespace ArchivosBinarios
{
    public partial class Form1 : Form
    {
        private const string archivoBinario = "datos.bin"; // Nombre del archivo binario
        public Form1()
        {
            InitializeComponent();
        }


        private void btnEscribir_Click(object sender, EventArgs e)
        {
            try
            {
                // Datos a escribir en el archivo
                string[] datos = { "Dato 1", "Dato 2", "Dato 3" };

                using (BinaryWriter writer = new BinaryWriter(File.Open(archivoBinario, FileMode.Create)))
                {
                    foreach (string dato in datos)
                    {
                        writer.Write(dato);
                    }
                }

                MessageBox.Show("Datos escritos correctamente en el archivo binario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error al escribir en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(archivoBinario))
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(archivoBinario, FileMode.Open)))
                    {
                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            string dato = reader.ReadString();
                            MessageBox.Show($"Dato leído: {dato}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo binario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        
    

    





