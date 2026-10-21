using System.Drawing;
using System.Windows.Forms;

namespace pryBarreraSP4
{
    partial class frmBarLaMilanga
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo = null;
        private System.Windows.Forms.Label lblSubtitulo = null;
        private System.Windows.Forms.Label lblFecha = null;
        private System.Windows.Forms.DataGridView dgvVentas = null;
        private System.Windows.Forms.Button btnValidar = null;
        private System.Windows.Forms.Button btnMozoDelDia = null;
        private System.Windows.Forms.Label lblMozoDelDia = null;
        private System.Windows.Forms.TextBox txtMozoDelDia = null;
        private System.Windows.Forms.Label lblImporteMozoDelDia = null;
        private System.Windows.Forms.TextBox txtImporteMozoDelDia = null;
        private System.Windows.Forms.Button btnTotales = null;
        private System.Windows.Forms.Label lblTotalComidas = null;
        private System.Windows.Forms.TextBox txtTotalComidas = null;
        private System.Windows.Forms.Label lblTotalBebSinAlc = null;
        private System.Windows.Forms.TextBox txtTotalBebSinAlc = null;
        private System.Windows.Forms.Label lblTotalBebConAlc = null;
        private System.Windows.Forms.TextBox txtTotalBebConAlc = null;
        private System.Windows.Forms.Label lblTotalPostres = null;
        private System.Windows.Forms.TextBox txtTotalPostres = null;
        private System.Windows.Forms.Label lblGranTotal = null;
        private System.Windows.Forms.TextBox txtGranTotal = null;
        private System.Windows.Forms.Button btnExportarExcel = null;
        private System.Windows.Forms.Button btnCerrar = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnMozoDelDia = new System.Windows.Forms.Button();
            this.lblMozoDelDia = new System.Windows.Forms.Label();
            this.txtMozoDelDia = new System.Windows.Forms.TextBox();
            this.lblImporteMozoDelDia = new System.Windows.Forms.Label();
            this.txtImporteMozoDelDia = new System.Windows.Forms.TextBox();
            this.btnTotales = new System.Windows.Forms.Button();
            this.lblTotalComidas = new System.Windows.Forms.Label();
            this.txtTotalComidas = new System.Windows.Forms.TextBox();
            this.lblTotalBebSinAlc = new System.Windows.Forms.Label();
            this.txtTotalBebSinAlc = new System.Windows.Forms.TextBox();
            this.lblTotalBebConAlc = new System.Windows.Forms.Label();
            this.txtTotalBebConAlc = new System.Windows.Forms.TextBox();
            this.lblTotalPostres = new System.Windows.Forms.Label();
            this.txtTotalPostres = new System.Windows.Forms.TextBox();
            this.lblGranTotal = new System.Windows.Forms.Label();
            this.txtGranTotal = new System.Windows.Forms.TextBox();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblTitulo.Location = new System.Drawing.Point(19, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(244, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bar La Milanga";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(23, 52);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(245, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Control de Ventas Diarias por Mozo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblFecha.Location = new System.Drawing.Point(700, 29);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha: ";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(36)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVentas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.Location = new System.Drawing.Point(23, 87);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVentas.RowHeadersWidth = 120;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVentas.Size = new System.Drawing.Size(548, 179);
            this.dgvVentas.TabIndex = 0;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnValidar.ForeColor = System.Drawing.Color.Black;
            this.btnValidar.Location = new System.Drawing.Point(23, 283);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(163, 40);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "✔ Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnMozoDelDia
            // 
            this.btnMozoDelDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnMozoDelDia.FlatAppearance.BorderSize = 0;
            this.btnMozoDelDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMozoDelDia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMozoDelDia.ForeColor = System.Drawing.Color.White;
            this.btnMozoDelDia.Location = new System.Drawing.Point(23, 352);
            this.btnMozoDelDia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMozoDelDia.Name = "btnMozoDelDia";
            this.btnMozoDelDia.Size = new System.Drawing.Size(163, 40);
            this.btnMozoDelDia.TabIndex = 2;
            this.btnMozoDelDia.Text = "🏆 Mozo del Día";
            this.btnMozoDelDia.UseVisualStyleBackColor = false;
            this.btnMozoDelDia.Click += new System.EventHandler(this.btnMozoDelDia_Click);
            // 
            // lblMozoDelDia
            // 
            this.lblMozoDelDia.AutoSize = true;
            this.lblMozoDelDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblMozoDelDia.Location = new System.Drawing.Point(198, 363);
            this.lblMozoDelDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMozoDelDia.Name = "lblMozoDelDia";
            this.lblMozoDelDia.Size = new System.Drawing.Size(54, 15);
            this.lblMozoDelDia.TabIndex = 3;
            this.lblMozoDelDia.Text = "Nombre:";
            // 
            // txtMozoDelDia
            // 
            this.txtMozoDelDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.txtMozoDelDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMozoDelDia.ForeColor = System.Drawing.Color.White;
            this.txtMozoDelDia.Location = new System.Drawing.Point(268, 360);
            this.txtMozoDelDia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMozoDelDia.Name = "txtMozoDelDia";
            this.txtMozoDelDia.ReadOnly = true;
            this.txtMozoDelDia.Size = new System.Drawing.Size(140, 23);
            this.txtMozoDelDia.TabIndex = 3;
            // 
            // lblImporteMozoDelDia
            // 
            this.lblImporteMozoDelDia.AutoSize = true;
            this.lblImporteMozoDelDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblImporteMozoDelDia.Location = new System.Drawing.Point(420, 363);
            this.lblImporteMozoDelDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporteMozoDelDia.Name = "lblImporteMozoDelDia";
            this.lblImporteMozoDelDia.Size = new System.Drawing.Size(52, 15);
            this.lblImporteMozoDelDia.TabIndex = 4;
            this.lblImporteMozoDelDia.Text = "Importe:";
            // 
            // txtImporteMozoDelDia
            // 
            this.txtImporteMozoDelDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.txtImporteMozoDelDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImporteMozoDelDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.txtImporteMozoDelDia.Location = new System.Drawing.Point(490, 360);
            this.txtImporteMozoDelDia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtImporteMozoDelDia.Name = "txtImporteMozoDelDia";
            this.txtImporteMozoDelDia.ReadOnly = true;
            this.txtImporteMozoDelDia.Size = new System.Drawing.Size(81, 23);
            this.txtImporteMozoDelDia.TabIndex = 4;
            // 
            // btnTotales
            // 
            this.btnTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnTotales.FlatAppearance.BorderSize = 0;
            this.btnTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTotales.ForeColor = System.Drawing.Color.White;
            this.btnTotales.Location = new System.Drawing.Point(23, 415);
            this.btnTotales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(163, 40);
            this.btnTotales.TabIndex = 5;
            this.btnTotales.Text = "📊 Calcular Totales";
            this.btnTotales.UseVisualStyleBackColor = false;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // lblTotalComidas
            // 
            this.lblTotalComidas.AutoSize = true;
            this.lblTotalComidas.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalComidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblTotalComidas.Location = new System.Drawing.Point(198, 427);
            this.lblTotalComidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalComidas.Name = "lblTotalComidas";
            this.lblTotalComidas.Size = new System.Drawing.Size(51, 13);
            this.lblTotalComidas.TabIndex = 6;
            this.lblTotalComidas.Text = "Comidas";
            // 
            // txtTotalComidas
            // 
            this.txtTotalComidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.txtTotalComidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalComidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.txtTotalComidas.Location = new System.Drawing.Point(198, 448);
            this.txtTotalComidas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalComidas.Name = "txtTotalComidas";
            this.txtTotalComidas.ReadOnly = true;
            this.txtTotalComidas.Size = new System.Drawing.Size(76, 23);
            this.txtTotalComidas.TabIndex = 6;
            this.txtTotalComidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalBebSinAlc
            // 
            this.lblTotalBebSinAlc.AutoSize = true;
            this.lblTotalBebSinAlc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalBebSinAlc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblTotalBebSinAlc.Location = new System.Drawing.Point(286, 427);
            this.lblTotalBebSinAlc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBebSinAlc.Name = "lblTotalBebSinAlc";
            this.lblTotalBebSinAlc.Size = new System.Drawing.Size(74, 13);
            this.lblTotalBebSinAlc.TabIndex = 7;
            this.lblTotalBebSinAlc.Text = "Bebidas s/alc";
            // 
            // txtTotalBebSinAlc
            // 
            this.txtTotalBebSinAlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.txtTotalBebSinAlc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBebSinAlc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.txtTotalBebSinAlc.Location = new System.Drawing.Point(286, 448);
            this.txtTotalBebSinAlc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalBebSinAlc.Name = "txtTotalBebSinAlc";
            this.txtTotalBebSinAlc.ReadOnly = true;
            this.txtTotalBebSinAlc.Size = new System.Drawing.Size(76, 23);
            this.txtTotalBebSinAlc.TabIndex = 7;
            this.txtTotalBebSinAlc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalBebConAlc
            // 
            this.lblTotalBebConAlc.AutoSize = true;
            this.lblTotalBebConAlc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalBebConAlc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblTotalBebConAlc.Location = new System.Drawing.Point(373, 427);
            this.lblTotalBebConAlc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBebConAlc.Name = "lblTotalBebConAlc";
            this.lblTotalBebConAlc.Size = new System.Drawing.Size(74, 13);
            this.lblTotalBebConAlc.TabIndex = 8;
            this.lblTotalBebConAlc.Text = "Bebidas c/alc";
            // 
            // txtTotalBebConAlc
            // 
            this.txtTotalBebConAlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.txtTotalBebConAlc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBebConAlc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.txtTotalBebConAlc.Location = new System.Drawing.Point(373, 448);
            this.txtTotalBebConAlc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalBebConAlc.Name = "txtTotalBebConAlc";
            this.txtTotalBebConAlc.ReadOnly = true;
            this.txtTotalBebConAlc.Size = new System.Drawing.Size(76, 23);
            this.txtTotalBebConAlc.TabIndex = 8;
            this.txtTotalBebConAlc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPostres
            // 
            this.lblTotalPostres.AutoSize = true;
            this.lblTotalPostres.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalPostres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblTotalPostres.Location = new System.Drawing.Point(461, 427);
            this.lblTotalPostres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPostres.Name = "lblTotalPostres";
            this.lblTotalPostres.Size = new System.Drawing.Size(44, 13);
            this.lblTotalPostres.TabIndex = 9;
            this.lblTotalPostres.Text = "Postres";
            // 
            // txtTotalPostres
            // 
            this.txtTotalPostres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.txtTotalPostres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPostres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.txtTotalPostres.Location = new System.Drawing.Point(461, 448);
            this.txtTotalPostres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalPostres.Name = "txtTotalPostres";
            this.txtTotalPostres.ReadOnly = true;
            this.txtTotalPostres.Size = new System.Drawing.Size(76, 23);
            this.txtTotalPostres.TabIndex = 9;
            this.txtTotalPostres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGranTotal
            // 
            this.lblGranTotal.AutoSize = true;
            this.lblGranTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGranTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblGranTotal.Location = new System.Drawing.Point(198, 490);
            this.lblGranTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGranTotal.Name = "lblGranTotal";
            this.lblGranTotal.Size = new System.Drawing.Size(80, 15);
            this.lblGranTotal.TabIndex = 10;
            this.lblGranTotal.Text = "GRAN TOTAL";
            // 
            // txtGranTotal
            // 
            this.txtGranTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.txtGranTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGranTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtGranTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.txtGranTotal.Location = new System.Drawing.Point(198, 511);
            this.txtGranTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGranTotal.Name = "txtGranTotal";
            this.txtGranTotal.ReadOnly = true;
            this.txtGranTotal.Size = new System.Drawing.Size(338, 27);
            this.txtGranTotal.TabIndex = 10;
            this.txtGranTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnExportarExcel.FlatAppearance.BorderSize = 0;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Location = new System.Drawing.Point(23, 565);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(222, 40);
            this.btnExportarExcel.TabIndex = 11;
            this.btnExportarExcel.Text = "📥 Exportar Reporte";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(262, 565);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(309, 40);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar Aplicación";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmBarLaMilanga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(595, 629);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnMozoDelDia);
            this.Controls.Add(this.lblMozoDelDia);
            this.Controls.Add(this.txtMozoDelDia);
            this.Controls.Add(this.lblImporteMozoDelDia);
            this.Controls.Add(this.txtImporteMozoDelDia);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.lblTotalComidas);
            this.Controls.Add(this.txtTotalComidas);
            this.Controls.Add(this.lblTotalBebSinAlc);
            this.Controls.Add(this.txtTotalBebSinAlc);
            this.Controls.Add(this.lblTotalBebConAlc);
            this.Controls.Add(this.txtTotalBebConAlc);
            this.Controls.Add(this.lblTotalPostres);
            this.Controls.Add(this.txtTotalPostres);
            this.Controls.Add(this.lblGranTotal);
            this.Controls.Add(this.txtGranTotal);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmBarLaMilanga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar La Milanga - Control de Ventas";
            this.Load += new System.EventHandler(this.frmBarLaMilanga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
