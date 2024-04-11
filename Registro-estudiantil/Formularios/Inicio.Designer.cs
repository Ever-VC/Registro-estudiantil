namespace Registro_estudiantil.Formularios
{
    partial class Inicio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            gbInfoPersonal = new GroupBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDui = new TextBox();
            lblNombre = new Label();
            txtDireccion = new TextBox();
            lblDui = new Label();
            txtEdad = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDireccion = new Label();
            txtNombre = new TextBox();
            lblEdad = new Label();
            gbInfoAcademica = new GroupBox();
            txtPromedioIngles = new TextBox();
            lblPromedioIngles = new Label();
            txtPromedioCiencias = new TextBox();
            lblPromedioLenguaje = new Label();
            txtPromedioSociales = new TextBox();
            lblPromedioCiencias = new Label();
            txtPromedioMatematica = new TextBox();
            lblPromedioMatematica = new Label();
            txtPromedioLenguaje = new TextBox();
            lblPromedioSociales = new Label();
            btnGuardar = new Button();
            lblTitutloRegistro = new Label();
            lblTituloListado = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnInscribir = new Button();
            dgvAspirantes = new DataGridView();
            lblIdSeleccionado = new Label();
            errpValidar = new ErrorProvider(components);
            gbInfoPersonal.SuspendLayout();
            gbInfoAcademica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAspirantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errpValidar).BeginInit();
            SuspendLayout();
            // 
            // gbInfoPersonal
            // 
            gbInfoPersonal.Controls.Add(txtTelefono);
            gbInfoPersonal.Controls.Add(lblTelefono);
            gbInfoPersonal.Controls.Add(txtDui);
            gbInfoPersonal.Controls.Add(lblNombre);
            gbInfoPersonal.Controls.Add(txtDireccion);
            gbInfoPersonal.Controls.Add(lblDui);
            gbInfoPersonal.Controls.Add(txtEdad);
            gbInfoPersonal.Controls.Add(lblApellido);
            gbInfoPersonal.Controls.Add(txtApellido);
            gbInfoPersonal.Controls.Add(lblDireccion);
            gbInfoPersonal.Controls.Add(txtNombre);
            gbInfoPersonal.Controls.Add(lblEdad);
            gbInfoPersonal.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbInfoPersonal.ForeColor = Color.White;
            gbInfoPersonal.Location = new Point(68, 82);
            gbInfoPersonal.Name = "gbInfoPersonal";
            gbInfoPersonal.Size = new Size(246, 225);
            gbInfoPersonal.TabIndex = 0;
            gbInfoPersonal.TabStop = false;
            gbInfoPersonal.Text = "INFORMACIÓN PERSONAL";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 9F);
            txtTelefono.Location = new Point(112, 183);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 22);
            txtTelefono.TabIndex = 6;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Century Gothic", 9F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(26, 188);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(69, 17);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "TELÉFONO:";
            // 
            // txtDui
            // 
            txtDui.Font = new Font("Century Gothic", 9F);
            txtDui.Location = new Point(112, 155);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(100, 22);
            txtDui.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 9F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(34, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Century Gothic", 9F);
            txtDireccion.Location = new Point(112, 127);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 22);
            txtDireccion.TabIndex = 4;
            txtDireccion.KeyPress += txtDireccion_KeyPress;
            // 
            // lblDui
            // 
            lblDui.AutoSize = true;
            lblDui.Font = new Font("Century Gothic", 9F);
            lblDui.ForeColor = Color.White;
            lblDui.Location = new Point(64, 160);
            lblDui.Name = "lblDui";
            lblDui.Size = new Size(31, 17);
            lblDui.TabIndex = 1;
            lblDui.Text = "DUI:";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Century Gothic", 9F);
            txtEdad.Location = new Point(112, 99);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 22);
            txtEdad.TabIndex = 3;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Century Gothic", 9F);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(30, 76);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 17);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "APELLIDO:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Century Gothic", 9F);
            txtApellido.Location = new Point(112, 71);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 22);
            txtApellido.TabIndex = 2;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Century Gothic", 9F);
            lblDireccion.ForeColor = Color.White;
            lblDireccion.Location = new Point(22, 132);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(76, 17);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "DIRECCIÓN:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 9F);
            txtNombre.Location = new Point(112, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 22);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Century Gothic", 9F);
            lblEdad.ForeColor = Color.White;
            lblEdad.Location = new Point(53, 104);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(44, 17);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "EDAD:";
            // 
            // gbInfoAcademica
            // 
            gbInfoAcademica.Controls.Add(txtPromedioIngles);
            gbInfoAcademica.Controls.Add(lblPromedioIngles);
            gbInfoAcademica.Controls.Add(txtPromedioCiencias);
            gbInfoAcademica.Controls.Add(lblPromedioLenguaje);
            gbInfoAcademica.Controls.Add(txtPromedioSociales);
            gbInfoAcademica.Controls.Add(lblPromedioCiencias);
            gbInfoAcademica.Controls.Add(txtPromedioMatematica);
            gbInfoAcademica.Controls.Add(lblPromedioMatematica);
            gbInfoAcademica.Controls.Add(txtPromedioLenguaje);
            gbInfoAcademica.Controls.Add(lblPromedioSociales);
            gbInfoAcademica.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbInfoAcademica.ForeColor = Color.White;
            gbInfoAcademica.Location = new Point(68, 313);
            gbInfoAcademica.Name = "gbInfoAcademica";
            gbInfoAcademica.Size = new Size(246, 227);
            gbInfoAcademica.TabIndex = 1;
            gbInfoAcademica.TabStop = false;
            gbInfoAcademica.Text = "INFORMACIÓN ACADÉMICA";
            // 
            // txtPromedioIngles
            // 
            txtPromedioIngles.Font = new Font("Century Gothic", 9F);
            txtPromedioIngles.Location = new Point(186, 175);
            txtPromedioIngles.Name = "txtPromedioIngles";
            txtPromedioIngles.Size = new Size(42, 22);
            txtPromedioIngles.TabIndex = 6;
            txtPromedioIngles.KeyPress += txtPromedioIngles_KeyPress;
            // 
            // lblPromedioIngles
            // 
            lblPromedioIngles.AutoSize = true;
            lblPromedioIngles.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPromedioIngles.ForeColor = Color.White;
            lblPromedioIngles.Location = new Point(47, 180);
            lblPromedioIngles.Name = "lblPromedioIngles";
            lblPromedioIngles.Size = new Size(124, 17);
            lblPromedioIngles.TabIndex = 2;
            lblPromedioIngles.Text = "Promedio de Inglés:";
            // 
            // txtPromedioCiencias
            // 
            txtPromedioCiencias.Font = new Font("Century Gothic", 9F);
            txtPromedioCiencias.Location = new Point(186, 142);
            txtPromedioCiencias.Name = "txtPromedioCiencias";
            txtPromedioCiencias.Size = new Size(42, 22);
            txtPromedioCiencias.TabIndex = 5;
            txtPromedioCiencias.KeyPress += txtPromedioCiencias_KeyPress;
            // 
            // lblPromedioLenguaje
            // 
            lblPromedioLenguaje.AutoSize = true;
            lblPromedioLenguaje.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPromedioLenguaje.ForeColor = Color.White;
            lblPromedioLenguaje.Location = new Point(26, 48);
            lblPromedioLenguaje.Name = "lblPromedioLenguaje";
            lblPromedioLenguaje.Size = new Size(145, 17);
            lblPromedioLenguaje.TabIndex = 2;
            lblPromedioLenguaje.Text = "Promedio de Lenguaje:";
            // 
            // txtPromedioSociales
            // 
            txtPromedioSociales.Font = new Font("Century Gothic", 9F);
            txtPromedioSociales.Location = new Point(186, 109);
            txtPromedioSociales.Name = "txtPromedioSociales";
            txtPromedioSociales.Size = new Size(42, 22);
            txtPromedioSociales.TabIndex = 4;
            txtPromedioSociales.KeyPress += txtPromedioSociales_KeyPress;
            // 
            // lblPromedioCiencias
            // 
            lblPromedioCiencias.AutoSize = true;
            lblPromedioCiencias.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPromedioCiencias.ForeColor = Color.White;
            lblPromedioCiencias.Location = new Point(30, 147);
            lblPromedioCiencias.Name = "lblPromedioCiencias";
            lblPromedioCiencias.Size = new Size(141, 17);
            lblPromedioCiencias.TabIndex = 2;
            lblPromedioCiencias.Text = "Promedio de Ciencias:";
            // 
            // txtPromedioMatematica
            // 
            txtPromedioMatematica.Font = new Font("Century Gothic", 9F);
            txtPromedioMatematica.Location = new Point(186, 76);
            txtPromedioMatematica.Name = "txtPromedioMatematica";
            txtPromedioMatematica.Size = new Size(42, 22);
            txtPromedioMatematica.TabIndex = 3;
            txtPromedioMatematica.KeyPress += txtPromedioMatematica_KeyPress;
            // 
            // lblPromedioMatematica
            // 
            lblPromedioMatematica.AutoSize = true;
            lblPromedioMatematica.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPromedioMatematica.ForeColor = Color.White;
            lblPromedioMatematica.Location = new Point(6, 81);
            lblPromedioMatematica.Name = "lblPromedioMatematica";
            lblPromedioMatematica.Size = new Size(165, 17);
            lblPromedioMatematica.TabIndex = 2;
            lblPromedioMatematica.Text = "Promedio de Matemática:";
            // 
            // txtPromedioLenguaje
            // 
            txtPromedioLenguaje.Font = new Font("Century Gothic", 9F);
            txtPromedioLenguaje.Location = new Point(186, 43);
            txtPromedioLenguaje.Name = "txtPromedioLenguaje";
            txtPromedioLenguaje.Size = new Size(42, 22);
            txtPromedioLenguaje.TabIndex = 2;
            txtPromedioLenguaje.KeyPress += txtPromedioLenguaje_KeyPress;
            // 
            // lblPromedioSociales
            // 
            lblPromedioSociales.AutoSize = true;
            lblPromedioSociales.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPromedioSociales.ForeColor = Color.White;
            lblPromedioSociales.Location = new Point(31, 114);
            lblPromedioSociales.Name = "lblPromedioSociales";
            lblPromedioSociales.Size = new Size(140, 17);
            lblPromedioSociales.TabIndex = 2;
            lblPromedioSociales.Text = "Promedio de Sociales:";
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(166, 546);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(148, 36);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "REGISTRAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblTitutloRegistro
            // 
            lblTitutloRegistro.AutoSize = true;
            lblTitutloRegistro.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitutloRegistro.ForeColor = SystemColors.Window;
            lblTitutloRegistro.Location = new Point(68, 33);
            lblTitutloRegistro.Name = "lblTitutloRegistro";
            lblTitutloRegistro.Size = new Size(267, 25);
            lblTitutloRegistro.TabIndex = 3;
            lblTitutloRegistro.Text = "REGISTRO DE ASPIRANTES";
            // 
            // lblTituloListado
            // 
            lblTituloListado.AutoSize = true;
            lblTituloListado.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloListado.ForeColor = Color.White;
            lblTituloListado.Location = new Point(643, 33);
            lblTituloListado.Name = "lblTituloListado";
            lblTituloListado.Size = new Size(254, 25);
            lblTituloListado.TabIndex = 3;
            lblTituloListado.Text = "LISTADO DE ASPIRANTES";
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 9F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(1039, 546);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 35);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "    ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.Green;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 9F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(927, 546);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 35);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "   ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.Cursor = Cursors.Hand;
            btnInscribir.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnInscribir.FlatStyle = FlatStyle.Flat;
            btnInscribir.Font = new Font("Century Gothic", 9F);
            btnInscribir.ForeColor = Color.White;
            btnInscribir.Image = (Image)resources.GetObject("btnInscribir.Image");
            btnInscribir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInscribir.Location = new Point(815, 546);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(106, 35);
            btnInscribir.TabIndex = 7;
            btnInscribir.Text = "    INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // dgvAspirantes
            // 
            dgvAspirantes.AllowUserToAddRows = false;
            dgvAspirantes.AllowUserToDeleteRows = false;
            dgvAspirantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAspirantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAspirantes.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvAspirantes.BorderStyle = BorderStyle.None;
            dgvAspirantes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAspirantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAspirantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAspirantes.EnableHeadersVisualStyles = false;
            dgvAspirantes.GridColor = Color.SteelBlue;
            dgvAspirantes.Location = new Point(362, 91);
            dgvAspirantes.Name = "dgvAspirantes";
            dgvAspirantes.ReadOnly = true;
            dgvAspirantes.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvAspirantes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvAspirantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAspirantes.Size = new Size(783, 449);
            dgvAspirantes.TabIndex = 8;
            dgvAspirantes.CellClick += dgvAspirantes_CellClick;
            // 
            // lblIdSeleccionado
            // 
            lblIdSeleccionado.AutoSize = true;
            lblIdSeleccionado.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblIdSeleccionado.ForeColor = Color.White;
            lblIdSeleccionado.Location = new Point(1018, 72);
            lblIdSeleccionado.Name = "lblIdSeleccionado";
            lblIdSeleccionado.Size = new Size(127, 16);
            lblIdSeleccionado.TabIndex = 9;
            lblIdSeleccionado.Text = "ID SELECCIONADO";
            lblIdSeleccionado.Visible = false;
            // 
            // errpValidar
            // 
            errpValidar.ContainerControl = this;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 41, 78);
            ClientSize = new Size(1207, 692);
            Controls.Add(lblIdSeleccionado);
            Controls.Add(dgvAspirantes);
            Controls.Add(btnInscribir);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(lblTituloListado);
            Controls.Add(lblTitutloRegistro);
            Controls.Add(btnGuardar);
            Controls.Add(gbInfoAcademica);
            Controls.Add(gbInfoPersonal);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            gbInfoPersonal.ResumeLayout(false);
            gbInfoPersonal.PerformLayout();
            gbInfoAcademica.ResumeLayout(false);
            gbInfoAcademica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAspirantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errpValidar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbInfoPersonal;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblDireccion;
        private Label lblDui;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private TextBox txtDui;
        private TextBox txtDireccion;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private GroupBox gbInfoAcademica;
        private Label lblPromedioIngles;
        private Label lblPromedioLenguaje;
        private Label lblPromedioCiencias;
        private TextBox txtPromedioMatematica;
        private Label lblPromedioMatematica;
        private TextBox txtPromedioLenguaje;
        private Label lblPromedioSociales;
        private TextBox txtPromedioSociales;
        private TextBox txtPromedioCiencias;
        private TextBox txtPromedioIngles;
        private Button btnGuardar;
        private Label lblTitutloRegistro;
        private Label lblTituloListado;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnInscribir;
        private DataGridView dgvAspirantes;
        private Label lblIdSeleccionado;
        private ErrorProvider errpValidar;
    }
}