namespace pryBarreraProyectoLab1
{
    partial class frmInscripcion
    {
        private System.ComponentModel.IContainer? components = null;
        private Label lblTitulo = null!;
        private Label lblSubtitulo = null!;
        private Label lblNombre = null!;
        private Label lblEdad = null!;
        private Label lblMeses = null!;
        private Label lblPlan = null!;
        private Label lblTurno = null!;
        private Label lblCuotas = null!;
        private TextBox txtNombre = null!;
        private TextBox txtEdad = null!;
        private TextBox txtMeses = null!;
        private ComboBox cboPlan = null!;
        private ComboBox cboTurno = null!;
        private ComboBox cboCuotas = null!;
        private CheckBox chkEstudiante = null!;
        private CheckBox chkCasillero = null!;
        private GroupBox grpPago = null!;
        private RadioButton rbtEfectivo = null!;
        private RadioButton rbtTarjeta = null!;
        private Button btnCalcular = null!;
        private Button btnLimpiar = null!;
        private Button btnConsultar = null!;
        private Button btnExportarExcel = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblNombre = new Label();
            lblEdad = new Label();
            lblMeses = new Label();
            lblPlan = new Label();
            lblTurno = new Label();
            lblCuotas = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtMeses = new TextBox();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            cboCuotas = new ComboBox();
            chkEstudiante = new CheckBox();
            chkCasillero = new CheckBox();
            grpPago = new GroupBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnConsultar = new Button();
            btnExportarExcel = new Button();
            grpPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(28, 63, 104);
            lblTitulo.Location = new Point(35, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(515, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gimnasio Siglo — Inscripción de socios";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(92, 108, 125);
            lblSubtitulo.Location = new Point(39, 62);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(305, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Completá los datos del socio para calcular su inscripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(45, 55, 72);
            lblNombre.Location = new Point(40, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(112, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre completo:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEdad.ForeColor = Color.FromArgb(45, 55, 72);
            lblEdad.Location = new Point(40, 125);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMeses.ForeColor = Color.FromArgb(45, 55, 72);
            lblMeses.Location = new Point(280, 125);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(45, 15);
            lblMeses.TabIndex = 4;
            lblMeses.Text = "Meses:";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPlan.ForeColor = Color.FromArgb(45, 55, 72);
            lblPlan.Location = new Point(40, 165);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(33, 15);
            lblPlan.TabIndex = 5;
            lblPlan.Text = "Plan:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTurno.ForeColor = Color.FromArgb(45, 55, 72);
            lblTurno.Location = new Point(40, 205);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(42, 15);
            lblTurno.TabIndex = 6;
            lblTurno.Text = "Turno:";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCuotas.ForeColor = Color.FromArgb(45, 55, 72);
            lblCuotas.Location = new Point(400, 310);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(47, 15);
            lblCuotas.TabIndex = 8;
            lblCuotas.Text = "Cuotas:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(165, 82);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(350, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += CamposObligatorios_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.White;
            txtEdad.BorderStyle = BorderStyle.FixedSingle;
            txtEdad.Location = new Point(165, 122);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(80, 23);
            txtEdad.TabIndex = 1;
            txtEdad.TextChanged += CamposObligatorios_TextChanged;
            txtEdad.KeyPress += CamposNumericos_KeyPress;
            // 
            // txtMeses
            // 
            txtMeses.BackColor = Color.White;
            txtMeses.BorderStyle = BorderStyle.FixedSingle;
            txtMeses.Location = new Point(345, 122);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(80, 23);
            txtMeses.TabIndex = 2;
            txtMeses.TextChanged += CamposObligatorios_TextChanged;
            txtMeses.KeyPress += CamposNumericos_KeyPress;
            // 
            // cboPlan
            // 
            cboPlan.BackColor = Color.White;
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(165, 162);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(200, 23);
            cboPlan.TabIndex = 3;
            // 
            // cboTurno
            // 
            cboTurno.BackColor = Color.White;
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(165, 202);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(200, 23);
            cboTurno.TabIndex = 4;
            // 
            // cboCuotas
            // 
            cboCuotas.BackColor = Color.White;
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(465, 307);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(80, 23);
            cboCuotas.TabIndex = 8;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Font = new Font("Segoe UI", 9F);
            chkEstudiante.ForeColor = Color.FromArgb(45, 55, 72);
            chkEstudiante.Location = new Point(40, 250);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(95, 19);
            chkEstudiante.TabIndex = 5;
            chkEstudiante.Text = "Es estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Font = new Font("Segoe UI", 9F);
            chkCasillero.ForeColor = Color.FromArgb(45, 55, 72);
            chkCasillero.Location = new Point(200, 250);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(189, 19);
            chkCasillero.TabIndex = 6;
            chkCasillero.Text = "Solicita casillero (+$3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // grpPago
            // 
            grpPago.Controls.Add(rbtEfectivo);
            grpPago.Controls.Add(rbtTarjeta);
            grpPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPago.ForeColor = Color.FromArgb(28, 63, 104);
            grpPago.Location = new Point(40, 290);
            grpPago.Name = "grpPago";
            grpPago.Size = new Size(354, 70);
            grpPago.TabIndex = 7;
            grpPago.TabStop = false;
            grpPago.Text = "Forma de pago";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Font = new Font("Segoe UI", 9F);
            rbtEfectivo.ForeColor = Color.FromArgb(45, 55, 72);
            rbtEfectivo.Location = new Point(15, 32);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(158, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.Text = "Efectivo (10% descuento)";
            rbtEfectivo.CheckedChanged += FormaPago_CheckedChanged;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Font = new Font("Segoe UI", 9F);
            rbtTarjeta.ForeColor = Color.FromArgb(45, 55, 72);
            rbtTarjeta.Location = new Point(245, 32);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.CheckedChanged += FormaPago_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(32, 132, 91);
            btnCalcular.Enabled = false;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(40, 400);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 38);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(235, 239, 244);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(45, 55, 72);
            btnLimpiar.Location = new Point(175, 400);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 38);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(28, 63, 104);
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(310, 400);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(125, 38);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = Color.FromArgb(44, 142, 84);
            btnExportarExcel.FlatAppearance.BorderSize = 0;
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportarExcel.ForeColor = Color.White;
            btnExportarExcel.Location = new Point(445, 400);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(140, 38);
            btnExportarExcel.TabIndex = 12;
            btnExportarExcel.Text = "Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = true;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(625, 465);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(txtEdad);
            Controls.Add(lblMeses);
            Controls.Add(txtMeses);
            Controls.Add(lblPlan);
            Controls.Add(cboPlan);
            Controls.Add(lblTurno);
            Controls.Add(cboTurno);
            Controls.Add(chkEstudiante);
            Controls.Add(chkCasillero);
            Controls.Add(grpPago);
            Controls.Add(lblCuotas);
            Controls.Add(cboCuotas);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(btnConsultar);
            Controls.Add(btnExportarExcel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción de socios";
            Load += frmInscripcion_Load;
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
