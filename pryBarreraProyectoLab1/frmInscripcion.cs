using System.Globalization;
using System.Text;

namespace pryBarreraProyectoLab1
{
    // Formulario principal de inscripción de socios del gimnasio.
    public partial class frmInscripcion : Form
    {
        // Estructura solicitada por la guía para representar una inscripción.
        public struct SOCIO
        {
            public string Nombre;
            public int Edad;
            public string Categoria;
            public string Plan;
            public string Horario;
            public int Meses;
            public string FormaPago;
            public decimal Total;
            public decimal ValorCuota;
        }

        // Constantes de precios y reglas de negocio.
        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO_MENSUAL = 3000m;
        private const int EDAD_MINIMA = 14;
        private const decimal DESCUENTO_MENOR = 0.25m;
        private const decimal DESCUENTO_ADULTO_MAYOR = 0.30m;
        private const decimal DESCUENTO_ESTUDIANTE = 0.15m;
        private const decimal SIN_DESCUENTO = 0.0m;
        private const decimal DESCUENTO_EFECTIVO = -0.10m;
        private const decimal RECARGO_TRES_CUOTAS = 0.10m;
        private const decimal RECARGO_SEIS_CUOTAS = 0.20m;

        // La lista conserva los registros mientras la aplicación está abierta.
        private readonly List<SOCIO> socios = new();

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void frmInscripcion_Load(object? sender, EventArgs e)
        {
            EstadoInicial();
        }

        // Restablece todos los controles a su estado de inicio.
        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Clear();
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            rbtTarjeta.Checked = false;
            cboCuotas.SelectedIndex = 0;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        // Solo permite dígitos y la tecla Retroceso en edad y meses.
        private void CamposNumericos_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        // Convierte cada carácter escrito en el nombre a mayúscula.
        private void txtNombre_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        // El cálculo solo se habilita cuando los tres datos obligatorios tienen contenido.
        private void CamposObligatorios_TextChanged(object? sender, EventArgs e)
        {
            btnCalcular.Enabled = !string.IsNullOrWhiteSpace(txtNombre.Text)
                && !string.IsNullOrWhiteSpace(txtEdad.Text)
                && !string.IsNullOrWhiteSpace(txtMeses.Text);
        }

        // Las cuotas solo aplican cuando la forma de pago seleccionada es tarjeta.
        private void FormaPago_CheckedChanged(object? sender, EventArgs e)
        {
            cboCuotas.Enabled = rbtTarjeta.Checked;
        }

        // Ejecuta las validaciones y el cálculo exigido por la guía.
        private void btnCalcular_Click(object? sender, EventArgs e)
        {
            // Se utilizan int.Parse y los filtros de teclado garantizan datos numéricos.
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show($"La edad mínima para inscribirse es {EDAD_MINIMA} años.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Switch con string: obtiene el precio mensual del plan elegido.
            decimal precioPlan = cboPlan.Text switch
            {
                "Musculación" => PRECIO_MUSCULACION,
                "Funcional" => PRECIO_FUNCIONAL,
                "Natación" => PRECIO_NATACION,
                _ => 0m
            };

            // Switch con int: convierte el índice del turno en un horario legible.
            string horario = cboTurno.SelectedIndex switch
            {
                0 => "7 a 12 h",
                1 => "14 a 18 h",
                2 => "18 a 23 h",
                _ => "Sin horario"
            };

            decimal precioMensual = precioPlan;
            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO_MENSUAL;
            decimal subtotal = precioMensual * meses;

            // If anidado: solo se aplica una categoría de descuento.
            decimal porcentajeDescuento;
            if (edad < 18)
                porcentajeDescuento = DESCUENTO_MENOR;
            else
                if (edad >= 65)
                    porcentajeDescuento = DESCUENTO_ADULTO_MAYOR;
                else
                    if (chkEstudiante.Checked)
                        porcentajeDescuento = DESCUENTO_ESTUDIANTE;
                    else
                        porcentajeDescuento = SIN_DESCUENTO;

            decimal total = subtotal * (1m - porcentajeDescuento);

            // Forma de pago: efectivo descuenta; tarjeta aplica recargo según cuotas.
            int cuotas = 1;
            if (rbtEfectivo.Checked)
            {
                total *= 1m + DESCUENTO_EFECTIVO;
            }
            else
            {
                cuotas = int.Parse(cboCuotas.Text);
                if (cuotas == 3)
                    total *= 1m + RECARGO_TRES_CUOTAS;
                else if (cuotas == 6)
                    total *= 1m + RECARGO_SEIS_CUOTAS;
            }

            total = Math.Round(total, 2, MidpointRounding.AwayFromZero);

            // Tres usos explícitos del operador ternario solicitados.
            string categoria = edad < 18 ? "Menor" : "Mayor";
            string formaPago = rbtEfectivo.Checked ? "Efectivo" : $"Tarjeta ({cuotas} cuotas)";
            decimal valorCuota = rbtEfectivo.Checked ? total : (total / cuotas);

            SOCIO socio = new()
            {
                Nombre = txtNombre.Text.Trim(),
                Edad = edad,
                Categoria = categoria,
                Plan = cboPlan.Text,
                Horario = horario,
                Meses = meses,
                FormaPago = formaPago,
                Total = total,
                ValorCuota = Math.Round(valorCuota, 2, MidpointRounding.AwayFromZero)
            };

            socios.Add(socio);

            MessageBox.Show($"Socio registrado correctamente.\n\nTotal: {socio.Total:C2}\nValor de cuota: {socio.ValorCuota:C2}",
                "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EstadoInicial();
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            EstadoInicial();
        }

        // Muestra todos los registros en una ventana secundaria con una grilla.
        private void btnConsultar_Click(object? sender, EventArgs e)
        {
            if (socios.Count == 0)
            {
                MessageBox.Show("Todavía no hay socios registrados.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using Form ventana = new()
            {
                Text = "Socios registrados",
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(1150, 450),
                MinimumSize = new Size(900, 300)
            };

            DataGridView grilla = new()
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                DataSource = socios.Select((socio, indice) => new
                {
                    Índice = indice + 1,
                    socio.Nombre,
                    socio.Edad,
                    socio.Categoria,
                    socio.Plan,
                    Turno = socio.Horario,
                    socio.Meses,
                    socio.FormaPago,
                    Cuota = socio.ValorCuota.ToString("C2"),
                    Total = socio.Total.ToString("C2")
                }).ToList()
            };

            ventana.Controls.Add(grilla);
            ventana.ShowDialog(this);
        }

        // Exporta la colección a CSV UTF-8, que puede abrirse directamente con Excel.
        private void btnExportarExcel_Click(object? sender, EventArgs e)
        {
            if (socios.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using SaveFileDialog dialogo = new()
            {
                Title = "Guardar registros de socios",
                Filter = "Archivo CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*",
                FileName = "socios_gimnasio.csv",
                AddExtension = true,
                DefaultExt = "csv"
            };

            if (dialogo.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using StreamWriter archivo = new(dialogo.FileName, false, new UTF8Encoding(true));
                archivo.WriteLine("Índice;Nombre;Edad;Categoría;Plan;Horario;Meses;Forma de pago;Valor cuota;Total");

                for (int indice = 0; indice < socios.Count; indice++)
                {
                    SOCIO socio = socios[indice];
                    archivo.WriteLine(string.Join(";",
                        indice + 1,
                        Csv(socio.Nombre),
                        socio.Edad,
                        Csv(socio.Categoria),
                        Csv(socio.Plan),
                        Csv(socio.Horario),
                        socio.Meses,
                        Csv(socio.FormaPago),
                        socio.ValorCuota.ToString("0.00", CultureInfo.InvariantCulture),
                        socio.Total.ToString("0.00", CultureInfo.InvariantCulture)));
                }

                MessageBox.Show("Los registros se exportaron correctamente.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"No fue posible guardar el archivo: {ex.Message}", "Error de exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Encierra textos con separadores para preservar el formato CSV.
        private static string Csv(string texto) => $"\"{texto.Replace("\"", "\"\"")}\"";
    }
}
