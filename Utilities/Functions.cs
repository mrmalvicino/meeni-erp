using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Entities;

namespace Utilities
{
    public static class Functions
    {
        // METHODS

        public static void loadImage(PictureBox pictureBox, string imageUrl)
        {
            try
            {
                pictureBox.Load(imageUrl);
            }
            catch (Exception)
            {
                pictureBox.Load(".\\..\\..\\..\\images\\image_not_found.png");
            }
        }

        public static void exportCSV(DataGridView dataGridView, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        sw.Write(dataGridView.Columns[i].HeaderText);

                        if (i < dataGridView.Columns.Count - 1)
                            sw.Write(",");
                        else
                            sw.Write(sw.NewLine);
                    }

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            if (row.Cells[i].Value != null)
                            {
                                sw.Write(row.Cells[i].Value.ToString());
                            }

                            if (i < dataGridView.Columns.Count - 1)
                                sw.Write(",");
                            else
                                sw.Write(sw.NewLine);
                        }
                    }
                }

                MessageBox.Show("Archivo CSV exportado correctamente.", "Exportar CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void exportPDF()
        {

        }

        public static void fillDataGrid(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
