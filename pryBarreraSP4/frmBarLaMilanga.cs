using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace pryBarreraSP4
{
    /// <summary>
    /// Formulario de control de ventas diarias por mozo y categoría para Bar La Milanga.
    /// Implementa matriz bidimensional, validación, búsqueda de máximo y exportación CSV.
    /// </summary>
    public partial class frmBarLaMilanga : Form
    {
        // =========================================================================
        // VARIABLES Y ESTRUCTURAS DE DATOS
        // =========================================================================

        /// <summary>Matriz bidimensional que almacena las ventas: 5 mozos x 4 categorías.</summary>
        private float[,] ventas = new float[5, 4];

        /// <summary>Vectores constantes con nombres de mozos y categorías.</summary>
        private string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        private string[] categorias = { "Comidas", "Bebidas s/alc", "Bebidas c/alc", "Postres" };

        // =========================================================================
        // CONSTRUCTOR E INICIALIZACIÓN
        // =========================================================================

        public frmBarLaMilanga()
        {
            InitializeComponent();
        }

        private void frmBarLaMilanga_Load(object sender, EventArgs e)
        {
            // Cargar la fecha actual en el header.
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");

            // Configurar la grilla con columnas y filas.
            ConfigurarGrilla();

            // Deshabilitar botones de consulta inicialmente.
            btnMozoDelDia.Enabled = false;
            btnTotales.Enabled = false;

            // Limpiar campos de resultados.
            LimpiarResultados();
        }

        // =========================================================================
        // CONFIGURACIÓN DE LA GRILLA
        // =========================================================================

        /// <summary>
        /// Configura la grilla DataGridView con exactamente 4 columnas (categorías)
        /// y 5 filas (mozos), sin permitir agregar ni eliminar filas.
        /// </summary>
        private void ConfigurarGrilla()
        {
            // Limpiar cualquier configuración anterior.
            dgvVentas.Columns.Clear();
            dgvVentas.Rows.Clear();

            // Propiedades de control de la grilla.
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.MultiSelect = false;
            dgvVentas.ReadOnly = false;
            // Habilitar edición directa al escribir o presionar F2
            dgvVentas.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            // Crear 4 columnas con nombres de categorías.
            for (int c = 0; c < 4; c++)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "col" + c;
                col.HeaderText = categorias[c];
                col.Width = 100;
                col.ReadOnly = false;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.DefaultCellStyle.Format = "F2";
                dgvVentas.Columns.Add(col);
            }

            // Crear 5 filas con nombres de mozos en el RowHeader.
            for (int f = 0; f < 5; f++)
            {
                dgvVentas.Rows.Add();
                dgvVentas.Rows[f].HeaderCell.Value = mozos[f];
                dgvVentas.Rows[f].Height = 25;

                // Inicializar todas las celdas en 0 y permitir edición.
                for (int c = 0; c < 4; c++)
                {
                    dgvVentas[c, f].Value = 0;
                    dgvVentas[c, f].ReadOnly = false;  // Asegurar que la celda es editable
                }
            }

            // Configurar el ancho del row header para mostrar nombres completos.
            dgvVentas.RowHeadersWidth = 120;
        }

        // =========================================================================
        // VALIDACIÓN DE DATOS
        // =========================================================================

        /// <summary>
        /// Valida todas las celdas de la grilla: cada una debe ser un número >= 0.
        /// Si la validación es exitosa, carga los valores en la matriz ventas[,].
        /// </summary>
        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Recorrer todas las celdas (filas 0-4, columnas 0-3).
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    // Obtener el valor de la celda.
                    object valorCelda = dgvVentas[c, f].Value;

                    // Validar con float.TryParse.
                    if (!float.TryParse(valorCelda?.ToString() ?? "", out float valor) || valor < 0)
                    {
                        // Error: mostrar mensaje y abortar.
                        MessageBox.Show(
                            $"Error en la celda [{mozos[f]}, {categorias[c]}].\n\n" +
                            $"Debe contener un número mayor o igual a 0.",
                            "Validación fallida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        // Deshabilitar botones de consulta.
                        btnMozoDelDia.Enabled = false;
                        btnTotales.Enabled = false;

                        return;
                    }

                    // Cargar el valor validado en la matriz.
                    ventas[f, c] = valor;
                }
            }

            // Validación exitosa: habilitar botones y mostrar mensaje de éxito.
            btnMozoDelDia.Enabled = true;
            btnTotales.Enabled = true;

            MessageBox.Show(
                "Datos validados y matriz sincronizada correctamente.\n\n" +
                "Ya puede consultar el Mozo del Día y calcular totales.",
                "Validación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================================================================
        // BÚSQUEDA DE MÁXIMO: MOZO DEL DÍA
        // =========================================================================

        /// <summary>
        /// Calcula el total vendido por cada mozo acumulando todas sus categorías,
        /// luego busca el máximo y muestra el mozo ganador con su importe total.
        /// </summary>
        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            // Vector para almacenar el total por cada mozo.
            float[] totalPorMozo = new float[5];

            // Recorrer filas (mozos) y acumular totales.
            for (int f = 0; f < 5; f++)
            {
                totalPorMozo[f] = 0;

                // Sumar todas las columnas (categorías) para este mozo.
                for (int c = 0; c < 4; c++)
                {
                    totalPorMozo[f] += ventas[f, c];
                }
            }

            // Buscar el máximo: inicializar con el mozo 0.
            int indiceMozoMaximo = 0;
            float maxiVentas = totalPorMozo[0];

            // Comparar con los demás mozos.
            for (int f = 1; f < 5; f++)
            {
                if (totalPorMozo[f] > maxiVentas)
                {
                    maxiVentas = totalPorMozo[f];
                    indiceMozoMaximo = f;
                }
            }

            // Mostrar el nombre del mozo ganador y su importe en formato moneda.
            txtMozoDelDia.Text = mozos[indiceMozoMaximo];
            txtImporteMozoDelDia.Text = maxiVentas.ToString("C2");
        }

        // =========================================================================
        // CÁLCULO DE TOTALES POR CATEGORÍA Y GRAN TOTAL
        // =========================================================================

        /// <summary>
        /// Calcula totales por cada categoría (columna) sumando todos los mozos,
        /// y el gran total de toda la matriz. Muestra los resultados en campos de solo lectura.
        /// </summary>
        private void btnTotales_Click(object sender, EventArgs e)
        {
            // Vectores para almacenar totales.
            float[] totalPorCategoria = new float[4];
            float granTotal = 0;

            // Recorrer columnas (categorías) y acumular totales.
            for (int c = 0; c < 4; c++)
            {
                totalPorCategoria[c] = 0;

                // Sumar todas las filas (mozos) para esta categoría.
                for (int f = 0; f < 5; f++)
                {
                    totalPorCategoria[c] += ventas[f, c];
                }

                // Acumular en el gran total.
                granTotal += totalPorCategoria[c];
            }

            // Mostrar totales por categoría en formato moneda.
            txtTotalComidas.Text = totalPorCategoria[0].ToString("C2");
            txtTotalBebSinAlc.Text = totalPorCategoria[1].ToString("C2");
            txtTotalBebConAlc.Text = totalPorCategoria[2].ToString("C2");
            txtTotalPostres.Text = totalPorCategoria[3].ToString("C2");

            // Mostrar gran total.
            txtGranTotal.Text = granTotal.ToString("C2");
        }

        // =========================================================================
        // EXPORTACIÓN A CSV
        // =========================================================================

        /// <summary>
        /// Abre un diálogo SaveFileDialog para guardar los datos en un archivo CSV
        /// con delimitador ';' y codificación UTF-8, compatible con Excel en español.
        /// </summary>
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            // Diálogo para seleccionar ubicación y nombre de archivo.
            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Title = "Guardar reporte de ventas";
                dialogo.Filter = "Archivo CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
                dialogo.FileName = "BarLaMilanga_Ventas_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                dialogo.AddExtension = true;
                dialogo.DefaultExt = "csv";

                // Si el usuario no cancela.
                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    // Crear archivo con codificación UTF-8.
                    using (StreamWriter archivo = new StreamWriter(dialogo.FileName, false, Encoding.UTF8))
                    {
                        // ========== ENCABEZADO ==========
                        archivo.WriteLine("BAR LA MILANGA - REPORTE DE VENTAS DIARIAS");
                        archivo.WriteLine($"Fecha: {DateTime.Now:dd/MM/yyyy}");
                        archivo.WriteLine("");

                        // ========== TABLA PRINCIPAL ==========
                        // Encabezado de categorías.
                        archivo.Write("Mozo;");
                        for (int c = 0; c < 4; c++)
                        {
                            archivo.Write(categorias[c]);
                            if (c < 3) archivo.Write(";");
                        }
                        archivo.WriteLine(";Total Mozo");

                        // Filas de datos con totales por mozo.
                        for (int f = 0; f < 5; f++)
                        {
                            archivo.Write(mozos[f] + ";");

                            float totalMozo = 0;

                            // Escribir valores de cada categoría.
                            for (int c = 0; c < 4; c++)
                            {
                                archivo.Write(ventas[f, c].ToString("F2"));
                                if (c < 3) archivo.Write(";");
                                totalMozo += ventas[f, c];
                            }

                            archivo.WriteLine(";" + totalMozo.ToString("F2"));
                        }

                        // Fila de totales por categoría.
                        archivo.Write("TOTAL;");
                        float granTotal = 0;

                        for (int c = 0; c < 4; c++)
                        {
                            float totalCategoria = 0;

                            // Sumar todos los mozos para esta categoría.
                            for (int f = 0; f < 5; f++)
                            {
                                totalCategoria += ventas[f, c];
                            }

                            archivo.Write(totalCategoria.ToString("F2"));
                            if (c < 3) archivo.Write(";");
                            granTotal += totalCategoria;
                        }

                        archivo.WriteLine(";" + granTotal.ToString("F2"));

                        // ========== SECCIÓN MOZO DEL DÍA ==========
                        archivo.WriteLine("");
                        archivo.WriteLine("MOZO DEL DÍA:");
                        archivo.WriteLine("Nombre," + txtMozoDelDia.Text);
                        archivo.WriteLine("Importe," + txtImporteMozoDelDia.Text);
                    }

                    // Notificar al usuario que la exportación fue exitosa.
                    MessageBox.Show(
                        $"Archivo exportado correctamente:\n\n{dialogo.FileName}",
                        "Exportación exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(
                        $"Error al guardar el archivo:\n\n{ex.Message}",
                        "Error de exportación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // =========================================================================
        // CIERRE DE LA APLICACIÓN
        // =========================================================================

        /// <summary>
        /// Cierra la aplicación con confirmación del usuario.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Preguntar confirmación.
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea salir?",
                "Confirmar cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario confirma, cerrar la aplicación.
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // =========================================================================
        // MÉTODOS AUXILIARES
        // =========================================================================

        /// <summary>
        /// Limpia todos los campos de resultados.
        /// </summary>
        private void LimpiarResultados()
        {
            txtMozoDelDia.Clear();
            txtImporteMozoDelDia.Clear();
            txtTotalComidas.Clear();
            txtTotalBebSinAlc.Clear();
            txtTotalBebConAlc.Clear();
            txtTotalPostres.Clear();
            txtGranTotal.Clear();
        }
    }
}
