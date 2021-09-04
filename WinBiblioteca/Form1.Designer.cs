namespace WinBiblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpAutor = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cboPaises = new System.Windows.Forms.ComboBox();
            this.tlpAutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAutor
            // 
            this.tlpAutor.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpAutor.ColumnCount = 2;
            this.tlpAutor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAutor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAutor.Controls.Add(this.btnConfirmar, 0, 4);
            this.tlpAutor.Controls.Add(this.txtNombre, 1, 1);
            this.tlpAutor.Controls.Add(this.lblApellido, 0, 0);
            this.tlpAutor.Controls.Add(this.lblNombre, 0, 1);
            this.tlpAutor.Controls.Add(this.lblFechaNacimiento, 0, 2);
            this.tlpAutor.Controls.Add(this.lblNacionalidad, 0, 3);
            this.tlpAutor.Controls.Add(this.txtApellido, 1, 0);
            this.tlpAutor.Controls.Add(this.dtpFechaNacimiento, 1, 2);
            this.tlpAutor.Controls.Add(this.btnCerrar, 1, 4);
            this.tlpAutor.Controls.Add(this.cboPaises, 1, 3);
            this.tlpAutor.Location = new System.Drawing.Point(18, 15);
            this.tlpAutor.Margin = new System.Windows.Forms.Padding(4);
            this.tlpAutor.Name = "tlpAutor";
            this.tlpAutor.RowCount = 5;
            this.tlpAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.1165F));
            this.tlpAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.63107F));
            this.tlpAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.71845F));
            this.tlpAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.14563F));
            this.tlpAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.1165F));
            this.tlpAutor.Size = new System.Drawing.Size(588, 507);
            this.tlpAutor.TabIndex = 0;
            this.tlpAutor.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnConfirmar.Location = new System.Drawing.Point(7, 404);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(281, 96);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(299, 147);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(166, 46);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(122, 16);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Ingrese Apellido";
            this.lblApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(225, 150);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(133, 246);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(155, 16);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(187, 340);
            this.lblNacionalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(101, 16);
            this.lblNacionalidad.TabIndex = 3;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Location = new System.Drawing.Point(299, 43);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(222, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(299, 243);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(222, 22);
            this.dtpFechaNacimiento.TabIndex = 8;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrar.ForeColor = System.Drawing.Color.Silver;
            this.btnCerrar.Location = new System.Drawing.Point(299, 404);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(282, 96);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // cboPaises
            // 
            this.cboPaises.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaises.FormattingEnabled = true;
            this.cboPaises.Items.AddRange(new object[] {
            "Argentina",
            "Uruguay",
            "Chile",
            "Peru",
            "Colombia"});
            this.cboPaises.Location = new System.Drawing.Point(298, 338);
            this.cboPaises.Name = "cboPaises";
            this.cboPaises.Size = new System.Drawing.Size(223, 24);
            this.cboPaises.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 527);
            this.Controls.Add(this.tlpAutor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpAutor.ResumeLayout(false);
            this.tlpAutor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAutor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboPaises;
    }
}

