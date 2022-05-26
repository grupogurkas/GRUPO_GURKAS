using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace pl_Gurkas.ExportacionExcel.Logistica
{
    class ExportarDataExcelLogistica
    {
        public void ExportarDatosExcelProveedores(DataGridView dgView, ProgressBar pBar)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Base de datos de proveedores";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    if (pBar != null)
                    {
                        pBar.Maximum = dgView.RowCount;
                        pBar.Value = 0;
                        if (!pBar.Visible) pBar.Visible = true;
                    }

                    //CREACIÓN DE LOS OBJETOS DE EXCEL
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();

                    Excel.Range formatRange;

                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);


                    //AGREGAMOS LOS ENCABEZADOS
                    int iFil = 0, iCol = 0;


                    foreach (DataGridViewColumn columna in dgView.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                    {
                        iCol++;
                        hoja_trabajo.Cells[1, iCol] = columna.Name;

                    }

                    foreach (DataGridViewRow fila in dgView.Rows) //Aquí leemos las filas de las columnas leídas
                    {
                        iFil++;
                        iCol = 0;
                        foreach (DataGridViewColumn columna in dgView.Columns)
                        {
                            iCol++;
                            hoja_trabajo.Cells[iFil + 1, iCol] = fila.Cells[columna.Name].Value;
                            formatRange = hoja_trabajo.get_Range("C" + (iFil + 1), "C" + (iFil + 1));
                            formatRange.NumberFormat = "@";
                            formatRange = hoja_trabajo.get_Range("F" + (iFil + 1), "F" + (iFil + 1));
                            formatRange.NumberFormat = "@";
                            formatRange = hoja_trabajo.get_Range("G" + (iFil + 1), "G" + (iFil + 1));
                            formatRange.NumberFormat = "@";
                            formatRange = hoja_trabajo.get_Range("T" + (iFil + 1), "T" + (iFil + 1));
                            formatRange.NumberFormat = "@";
                        }
                        pBar.Value += 1;
                    }
                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Exportacion Exitozamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                if (pBar != null)
                {
                    pBar.Value = 0;
                    pBar.Visible = false;
                }
            }
        }
    }
}
