namespace DigiSalud
{
    partial class FormularioPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GbDatosBasicos = new System.Windows.Forms.GroupBox();
            this.LblSalario = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.MaskedTextBox();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.LblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.RdbFemenino = new System.Windows.Forms.RadioButton();
            this.RdbMasculino = new System.Windows.Forms.RadioButton();
            this.LblCotizante = new System.Windows.Forms.Label();
            this.ChkCotizante = new System.Windows.Forms.CheckBox();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblSegundoApellido = new System.Windows.Forms.Label();
            this.LblPrimerApellido = new System.Windows.Forms.Label();
            this.LblSegundoNombre = new System.Windows.Forms.Label();
            this.LblPrimerNombre = new System.Windows.Forms.Label();
            this.TxtSegundoApellido = new System.Windows.Forms.TextBox();
            this.TxtPrimerApellido = new System.Windows.Forms.TextBox();
            this.TxtPrimerNombre = new System.Windows.Forms.TextBox();
            this.TxtSegundoNombre = new System.Windows.Forms.TextBox();
            this.DtpFechaFacimiento = new System.Windows.Forms.DateTimePicker();
            this.TabDatosAdicionales = new System.Windows.Forms.TabControl();
            this.TabDireccion = new System.Windows.Forms.TabPage();
            this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.CboCiudad = new System.Windows.Forms.ComboBox();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.CboDepartamento = new System.Windows.Forms.ComboBox();
            this.LblDepartamento = new System.Windows.Forms.Label();
            this.TabAntecedentes = new System.Windows.Forms.TabPage();
            this.BtnRemoverAntecedente = new System.Windows.Forms.Button();
            this.BtnAdicionarAntecedente = new System.Windows.Forms.Button();
            this.LstAntecedentesSeleccionados = new System.Windows.Forms.ListBox();
            this.LstAntecedentes = new System.Windows.Forms.ListBox();
            this.ContextMenuPaciente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEdad = new System.Windows.Forms.Button();
            this.ErpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolTipMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.GbDatosBasicos.SuspendLayout();
            this.TabDatosAdicionales.SuspendLayout();
            this.TabDireccion.SuspendLayout();
            this.TabAntecedentes.SuspendLayout();
            this.ContextMenuPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErpMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDatosBasicos
            // 
            this.GbDatosBasicos.Controls.Add(this.LblSalario);
            this.GbDatosBasicos.Controls.Add(this.TxtSalario);
            this.GbDatosBasicos.Controls.Add(this.CboTipoDocumento);
            this.GbDatosBasicos.Controls.Add(this.LblTipoDocumento);
            this.GbDatosBasicos.Controls.Add(this.lblNumeroDocumento);
            this.GbDatosBasicos.Controls.Add(this.TxtNumeroDocumento);
            this.GbDatosBasicos.Controls.Add(this.lblSexo);
            this.GbDatosBasicos.Controls.Add(this.RdbFemenino);
            this.GbDatosBasicos.Controls.Add(this.RdbMasculino);
            this.GbDatosBasicos.Controls.Add(this.LblCotizante);
            this.GbDatosBasicos.Controls.Add(this.ChkCotizante);
            this.GbDatosBasicos.Controls.Add(this.LblFechaNacimiento);
            this.GbDatosBasicos.Controls.Add(this.LblSegundoApellido);
            this.GbDatosBasicos.Controls.Add(this.LblPrimerApellido);
            this.GbDatosBasicos.Controls.Add(this.LblSegundoNombre);
            this.GbDatosBasicos.Controls.Add(this.LblPrimerNombre);
            this.GbDatosBasicos.Controls.Add(this.TxtSegundoApellido);
            this.GbDatosBasicos.Controls.Add(this.TxtPrimerApellido);
            this.GbDatosBasicos.Controls.Add(this.TxtPrimerNombre);
            this.GbDatosBasicos.Controls.Add(this.TxtSegundoNombre);
            this.GbDatosBasicos.Controls.Add(this.DtpFechaFacimiento);
            this.GbDatosBasicos.Location = new System.Drawing.Point(30, 43);
            this.GbDatosBasicos.Name = "GbDatosBasicos";
            this.GbDatosBasicos.Size = new System.Drawing.Size(740, 247);
            this.GbDatosBasicos.TabIndex = 0;
            this.GbDatosBasicos.TabStop = false;
            this.GbDatosBasicos.Text = "Datos Básicos";
            // 
            // LblSalario
            // 
            this.LblSalario.AutoSize = true;
            this.LblSalario.Location = new System.Drawing.Point(404, 204);
            this.LblSalario.Name = "LblSalario";
            this.LblSalario.Size = new System.Drawing.Size(39, 13);
            this.LblSalario.TabIndex = 20;
            this.LblSalario.Text = "Salario";
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(527, 204);
            this.TxtSalario.Mask = "$999.999.999";
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(200, 20);
            this.TxtSalario.TabIndex = 19;
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Items.AddRange(new object[] {
            "Cédula de Ciudadanía",
            "Tarje de Identidad"});
            this.CboTipoDocumento.Location = new System.Drawing.Point(171, 31);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(200, 21);
            this.CboTipoDocumento.TabIndex = 1;
            // 
            // LblTipoDocumento
            // 
            this.LblTipoDocumento.AutoSize = true;
            this.LblTipoDocumento.Location = new System.Drawing.Point(38, 31);
            this.LblTipoDocumento.Name = "LblTipoDocumento";
            this.LblTipoDocumento.Size = new System.Drawing.Size(101, 13);
            this.LblTipoDocumento.TabIndex = 0;
            this.LblTipoDocumento.Text = "Tipo de Documento";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(404, 39);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(117, 13);
            this.lblNumeroDocumento.TabIndex = 2;
            this.lblNumeroDocumento.Text = "Número de Documento";
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(527, 39);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(200, 20);
            this.TxtNumeroDocumento.TabIndex = 3;
            this.TxtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroDocumento_KeyPress);
            this.TxtNumeroDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumeroDocumento_Validating);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(38, 211);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 16;
            this.lblSexo.Text = "Sexo";
            // 
            // RdbFemenino
            // 
            this.RdbFemenino.AutoSize = true;
            this.RdbFemenino.Location = new System.Drawing.Point(283, 211);
            this.RdbFemenino.Name = "RdbFemenino";
            this.RdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.RdbFemenino.TabIndex = 18;
            this.RdbFemenino.TabStop = true;
            this.RdbFemenino.Text = "Femenino";
            this.RdbFemenino.UseVisualStyleBackColor = true;
            // 
            // RdbMasculino
            // 
            this.RdbMasculino.AutoSize = true;
            this.RdbMasculino.Location = new System.Drawing.Point(171, 211);
            this.RdbMasculino.Name = "RdbMasculino";
            this.RdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.RdbMasculino.TabIndex = 17;
            this.RdbMasculino.TabStop = true;
            this.RdbMasculino.Text = "Masculino";
            this.RdbMasculino.UseVisualStyleBackColor = true;
            // 
            // LblCotizante
            // 
            this.LblCotizante.AutoSize = true;
            this.LblCotizante.Location = new System.Drawing.Point(404, 169);
            this.LblCotizante.Name = "LblCotizante";
            this.LblCotizante.Size = new System.Drawing.Size(51, 13);
            this.LblCotizante.TabIndex = 14;
            this.LblCotizante.Text = "Cotizante";
            // 
            // ChkCotizante
            // 
            this.ChkCotizante.AutoSize = true;
            this.ChkCotizante.Location = new System.Drawing.Point(527, 169);
            this.ChkCotizante.Name = "ChkCotizante";
            this.ChkCotizante.Size = new System.Drawing.Size(15, 14);
            this.ChkCotizante.TabIndex = 15;
            this.ChkCotizante.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChkCotizante.UseVisualStyleBackColor = true;
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(38, 162);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.LblFechaNacimiento.TabIndex = 12;
            this.LblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // LblSegundoApellido
            // 
            this.LblSegundoApellido.AutoSize = true;
            this.LblSegundoApellido.Location = new System.Drawing.Point(404, 127);
            this.LblSegundoApellido.Name = "LblSegundoApellido";
            this.LblSegundoApellido.Size = new System.Drawing.Size(90, 13);
            this.LblSegundoApellido.TabIndex = 10;
            this.LblSegundoApellido.Text = "Segundo Apellido";
            // 
            // LblPrimerApellido
            // 
            this.LblPrimerApellido.AutoSize = true;
            this.LblPrimerApellido.Location = new System.Drawing.Point(38, 120);
            this.LblPrimerApellido.Name = "LblPrimerApellido";
            this.LblPrimerApellido.Size = new System.Drawing.Size(76, 13);
            this.LblPrimerApellido.TabIndex = 8;
            this.LblPrimerApellido.Text = "Primer Apellido";
            // 
            // LblSegundoNombre
            // 
            this.LblSegundoNombre.AutoSize = true;
            this.LblSegundoNombre.Location = new System.Drawing.Point(404, 84);
            this.LblSegundoNombre.Name = "LblSegundoNombre";
            this.LblSegundoNombre.Size = new System.Drawing.Size(90, 13);
            this.LblSegundoNombre.TabIndex = 6;
            this.LblSegundoNombre.Text = "Segundo Nombre";
            // 
            // LblPrimerNombre
            // 
            this.LblPrimerNombre.AutoSize = true;
            this.LblPrimerNombre.Location = new System.Drawing.Point(38, 77);
            this.LblPrimerNombre.Name = "LblPrimerNombre";
            this.LblPrimerNombre.Size = new System.Drawing.Size(76, 13);
            this.LblPrimerNombre.TabIndex = 4;
            this.LblPrimerNombre.Text = "Primer Nombre";
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.Location = new System.Drawing.Point(527, 127);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(200, 20);
            this.TxtSegundoApellido.TabIndex = 11;
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.Location = new System.Drawing.Point(171, 120);
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(200, 20);
            this.TxtPrimerApellido.TabIndex = 9;
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.Location = new System.Drawing.Point(171, 77);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtPrimerNombre.TabIndex = 5;
            this.TxtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrimerNombre_KeyPress);
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Location = new System.Drawing.Point(527, 81);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtSegundoNombre.TabIndex = 7;
            // 
            // DtpFechaFacimiento
            // 
            this.DtpFechaFacimiento.Location = new System.Drawing.Point(171, 162);
            this.DtpFechaFacimiento.Name = "DtpFechaFacimiento";
            this.DtpFechaFacimiento.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaFacimiento.TabIndex = 13;
            this.ToolTipMensaje.SetToolTip(this.DtpFechaFacimiento, "La fecha de nacimiento no debe ser mayor a la fecha actual");
            this.DtpFechaFacimiento.Leave += new System.EventHandler(this.DtpFechaFacimiento_Leave);
            // 
            // TabDatosAdicionales
            // 
            this.TabDatosAdicionales.Controls.Add(this.TabDireccion);
            this.TabDatosAdicionales.Controls.Add(this.TabAntecedentes);
            this.TabDatosAdicionales.Location = new System.Drawing.Point(34, 309);
            this.TabDatosAdicionales.Name = "TabDatosAdicionales";
            this.TabDatosAdicionales.SelectedIndex = 0;
            this.TabDatosAdicionales.Size = new System.Drawing.Size(740, 217);
            this.TabDatosAdicionales.TabIndex = 6;
            // 
            // TabDireccion
            // 
            this.TabDireccion.Controls.Add(this.TxtTelefono);
            this.TabDireccion.Controls.Add(this.LblDireccion);
            this.TabDireccion.Controls.Add(this.LblTelefono);
            this.TabDireccion.Controls.Add(this.TxtDireccion);
            this.TabDireccion.Controls.Add(this.CboCiudad);
            this.TabDireccion.Controls.Add(this.LblCiudad);
            this.TabDireccion.Controls.Add(this.CboDepartamento);
            this.TabDireccion.Controls.Add(this.LblDepartamento);
            this.TabDireccion.Location = new System.Drawing.Point(4, 22);
            this.TabDireccion.Name = "TabDireccion";
            this.TabDireccion.Padding = new System.Windows.Forms.Padding(3);
            this.TabDireccion.Size = new System.Drawing.Size(732, 191);
            this.TabDireccion.TabIndex = 0;
            this.TabDireccion.Text = "Dirección";
            this.TabDireccion.UseVisualStyleBackColor = true;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(163, 73);
            this.TxtTelefono.Mask = "(999)000-0000";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(200, 20);
            this.TxtTelefono.TabIndex = 12;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(386, 76);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 10;
            this.LblDireccion.Text = "Dirección";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(30, 69);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 8;
            this.LblTelefono.Text = "Teléfono";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(519, 73);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(200, 20);
            this.TxtDireccion.TabIndex = 11;
            // 
            // CboCiudad
            // 
            this.CboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCiudad.FormattingEnabled = true;
            this.CboCiudad.Items.AddRange(new object[] {
            "Bello",
            "La Estrella",
            "Medellín",
            "Sabaneta"});
            this.CboCiudad.Location = new System.Drawing.Point(519, 26);
            this.CboCiudad.Name = "CboCiudad";
            this.CboCiudad.Size = new System.Drawing.Size(200, 21);
            this.CboCiudad.Sorted = true;
            this.CboCiudad.TabIndex = 5;
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Location = new System.Drawing.Point(386, 26);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(40, 13);
            this.LblCiudad.TabIndex = 4;
            this.LblCiudad.Text = "Ciudad";
            // 
            // CboDepartamento
            // 
            this.CboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDepartamento.FormattingEnabled = true;
            this.CboDepartamento.Items.AddRange(new object[] {
            "Antioquia",
            "Córdoba"});
            this.CboDepartamento.Location = new System.Drawing.Point(163, 26);
            this.CboDepartamento.Name = "CboDepartamento";
            this.CboDepartamento.Size = new System.Drawing.Size(200, 21);
            this.CboDepartamento.Sorted = true;
            this.CboDepartamento.TabIndex = 3;
            // 
            // LblDepartamento
            // 
            this.LblDepartamento.AutoSize = true;
            this.LblDepartamento.Location = new System.Drawing.Point(30, 26);
            this.LblDepartamento.Name = "LblDepartamento";
            this.LblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.LblDepartamento.TabIndex = 2;
            this.LblDepartamento.Text = "Departamento";
            // 
            // TabAntecedentes
            // 
            this.TabAntecedentes.Controls.Add(this.BtnRemoverAntecedente);
            this.TabAntecedentes.Controls.Add(this.BtnAdicionarAntecedente);
            this.TabAntecedentes.Controls.Add(this.LstAntecedentesSeleccionados);
            this.TabAntecedentes.Controls.Add(this.LstAntecedentes);
            this.TabAntecedentes.Location = new System.Drawing.Point(4, 22);
            this.TabAntecedentes.Name = "TabAntecedentes";
            this.TabAntecedentes.Padding = new System.Windows.Forms.Padding(3);
            this.TabAntecedentes.Size = new System.Drawing.Size(732, 191);
            this.TabAntecedentes.TabIndex = 1;
            this.TabAntecedentes.Text = "Antecedentes";
            this.TabAntecedentes.UseVisualStyleBackColor = true;
            // 
            // BtnRemoverAntecedente
            // 
            this.BtnRemoverAntecedente.Location = new System.Drawing.Point(327, 91);
            this.BtnRemoverAntecedente.Name = "BtnRemoverAntecedente";
            this.BtnRemoverAntecedente.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverAntecedente.TabIndex = 9;
            this.BtnRemoverAntecedente.Text = "<-";
            this.BtnRemoverAntecedente.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionarAntecedente
            // 
            this.BtnAdicionarAntecedente.Location = new System.Drawing.Point(327, 62);
            this.BtnAdicionarAntecedente.Name = "BtnAdicionarAntecedente";
            this.BtnAdicionarAntecedente.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionarAntecedente.TabIndex = 8;
            this.BtnAdicionarAntecedente.Text = "->";
            this.BtnAdicionarAntecedente.UseVisualStyleBackColor = true;
            // 
            // LstAntecedentesSeleccionados
            // 
            this.LstAntecedentesSeleccionados.FormattingEnabled = true;
            this.LstAntecedentesSeleccionados.Items.AddRange(new object[] {
            "Anemia",
            "Artritis",
            "Asma"});
            this.LstAntecedentesSeleccionados.Location = new System.Drawing.Point(421, 39);
            this.LstAntecedentesSeleccionados.Name = "LstAntecedentesSeleccionados";
            this.LstAntecedentesSeleccionados.ScrollAlwaysVisible = true;
            this.LstAntecedentesSeleccionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LstAntecedentesSeleccionados.Size = new System.Drawing.Size(287, 95);
            this.LstAntecedentesSeleccionados.TabIndex = 10;
            // 
            // LstAntecedentes
            // 
            this.LstAntecedentes.FormattingEnabled = true;
            this.LstAntecedentes.Items.AddRange(new object[] {
            "Hipertensión",
            "Diabetes"});
            this.LstAntecedentes.Location = new System.Drawing.Point(25, 39);
            this.LstAntecedentes.Name = "LstAntecedentes";
            this.LstAntecedentes.ScrollAlwaysVisible = true;
            this.LstAntecedentes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LstAntecedentes.Size = new System.Drawing.Size(287, 95);
            this.LstAntecedentes.TabIndex = 7;
            // 
            // ContextMenuPaciente
            // 
            this.ContextMenuPaciente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.ContextMenuPaciente.Name = "ContextMenuPaciente";
            this.ContextMenuPaciente.Size = new System.Drawing.Size(121, 48);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // BtnEdad
            // 
            this.BtnEdad.Location = new System.Drawing.Point(695, 532);
            this.BtnEdad.Name = "BtnEdad";
            this.BtnEdad.Size = new System.Drawing.Size(75, 23);
            this.BtnEdad.TabIndex = 19;
            this.BtnEdad.Text = "Edad";
            this.BtnEdad.UseVisualStyleBackColor = true;
            this.BtnEdad.Click += new System.EventHandler(this.BtnEdad_Click);
            // 
            // ErpMensaje
            // 
            this.ErpMensaje.ContainerControl = this;
            // 
            // FormularioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.ContextMenuStrip = this.ContextMenuPaciente;
            this.Controls.Add(this.BtnEdad);
            this.Controls.Add(this.TabDatosAdicionales);
            this.Controls.Add(this.GbDatosBasicos);
            this.Name = "FormularioPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.FormularioPaciente_Load);
            this.GbDatosBasicos.ResumeLayout(false);
            this.GbDatosBasicos.PerformLayout();
            this.TabDatosAdicionales.ResumeLayout(false);
            this.TabDireccion.ResumeLayout(false);
            this.TabDireccion.PerformLayout();
            this.TabAntecedentes.ResumeLayout(false);
            this.ContextMenuPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErpMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbDatosBasicos;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.Label LblTipoDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton RdbFemenino;
        private System.Windows.Forms.RadioButton RdbMasculino;
        private System.Windows.Forms.Label LblCotizante;
        private System.Windows.Forms.CheckBox ChkCotizante;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblSegundoApellido;
        private System.Windows.Forms.Label LblPrimerApellido;
        private System.Windows.Forms.Label LblSegundoNombre;
        private System.Windows.Forms.Label LblPrimerNombre;
        private System.Windows.Forms.TextBox TxtSegundoApellido;
        private System.Windows.Forms.TextBox TxtPrimerApellido;
        private System.Windows.Forms.TextBox TxtPrimerNombre;
        private System.Windows.Forms.TextBox TxtSegundoNombre;
        private System.Windows.Forms.DateTimePicker DtpFechaFacimiento;
        private System.Windows.Forms.TabControl TabDatosAdicionales;
        private System.Windows.Forms.TabPage TabDireccion;
        private System.Windows.Forms.ComboBox CboCiudad;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.ComboBox CboDepartamento;
        private System.Windows.Forms.Label LblDepartamento;
        private System.Windows.Forms.TabPage TabAntecedentes;
        private System.Windows.Forms.Button BtnRemoverAntecedente;
        private System.Windows.Forms.Button BtnAdicionarAntecedente;
        private System.Windows.Forms.ListBox LstAntecedentesSeleccionados;
        private System.Windows.Forms.ListBox LstAntecedentes;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.ContextMenuStrip ContextMenuPaciente;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.Button BtnEdad;
        private System.Windows.Forms.ErrorProvider ErpMensaje;
        private System.Windows.Forms.ToolTip ToolTipMensaje;
        private System.Windows.Forms.MaskedTextBox TxtTelefono;
        private System.Windows.Forms.Label LblSalario;
        private System.Windows.Forms.MaskedTextBox TxtSalario;
    }
}