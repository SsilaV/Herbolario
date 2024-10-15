
namespace HerbolarioViolero
{
    partial class FormEditar
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
            this.txtAtributo2 = new System.Windows.Forms.TextBox();
            this.lblAtributo2 = new System.Windows.Forms.Label();
            this.txtAtributo1 = new System.Windows.Forms.TextBox();
            this.lblAtributo1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.rbtnAlimentacion = new System.Windows.Forms.RadioButton();
            this.rbtnEcologico = new System.Windows.Forms.RadioButton();
            this.rbtnCorporal = new System.Windows.Forms.RadioButton();
            this.rbtnDeporte = new System.Windows.Forms.RadioButton();
            this.rbtnIntolerancia = new System.Windows.Forms.RadioButton();
            this.rbtnSuplemento = new System.Windows.Forms.RadioButton();
            this.rbtnAdelgazante = new System.Windows.Forms.RadioButton();
            this.lblCasaComercial = new System.Windows.Forms.Label();
            this.comboBoxCasas = new System.Windows.Forms.ComboBox();
            this.txtIdEditar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listBoxEditar = new System.Windows.Forms.ListBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.groupBoxProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAtributo2
            // 
            this.txtAtributo2.Location = new System.Drawing.Point(110, 384);
            this.txtAtributo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAtributo2.Name = "txtAtributo2";
            this.txtAtributo2.Size = new System.Drawing.Size(306, 20);
            this.txtAtributo2.TabIndex = 31;
            this.txtAtributo2.Visible = false;
            // 
            // lblAtributo2
            // 
            this.lblAtributo2.Location = new System.Drawing.Point(26, 387);
            this.lblAtributo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtributo2.Name = "lblAtributo2";
            this.lblAtributo2.Size = new System.Drawing.Size(76, 14);
            this.lblAtributo2.TabIndex = 32;
            this.lblAtributo2.Text = "Atributo 2";
            this.lblAtributo2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAtributo2.Visible = false;
            // 
            // txtAtributo1
            // 
            this.txtAtributo1.Location = new System.Drawing.Point(110, 362);
            this.txtAtributo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAtributo1.Name = "txtAtributo1";
            this.txtAtributo1.Size = new System.Drawing.Size(306, 20);
            this.txtAtributo1.TabIndex = 27;
            this.txtAtributo1.Visible = false;
            // 
            // lblAtributo1
            // 
            this.lblAtributo1.Location = new System.Drawing.Point(26, 364);
            this.lblAtributo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtributo1.Name = "lblAtributo1";
            this.lblAtributo1.Size = new System.Drawing.Size(76, 14);
            this.lblAtributo1.TabIndex = 28;
            this.lblAtributo1.Text = "Atributo 1";
            this.lblAtributo1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAtributo1.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(358, 429);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(56, 27);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.rbtnAlimentacion);
            this.groupBoxProducto.Controls.Add(this.rbtnEcologico);
            this.groupBoxProducto.Controls.Add(this.rbtnCorporal);
            this.groupBoxProducto.Controls.Add(this.rbtnDeporte);
            this.groupBoxProducto.Controls.Add(this.rbtnIntolerancia);
            this.groupBoxProducto.Controls.Add(this.rbtnSuplemento);
            this.groupBoxProducto.Controls.Add(this.rbtnAdelgazante);
            this.groupBoxProducto.Location = new System.Drawing.Point(24, 189);
            this.groupBoxProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProducto.Size = new System.Drawing.Size(390, 148);
            this.groupBoxProducto.TabIndex = 25;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Tipo de producto";
            this.groupBoxProducto.Visible = false;
            // 
            // rbtnAlimentacion
            // 
            this.rbtnAlimentacion.AutoSize = true;
            this.rbtnAlimentacion.Checked = true;
            this.rbtnAlimentacion.Location = new System.Drawing.Point(17, 28);
            this.rbtnAlimentacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnAlimentacion.Name = "rbtnAlimentacion";
            this.rbtnAlimentacion.Size = new System.Drawing.Size(85, 17);
            this.rbtnAlimentacion.TabIndex = 5;
            this.rbtnAlimentacion.TabStop = true;
            this.rbtnAlimentacion.Text = "Alimentación";
            this.rbtnAlimentacion.UseVisualStyleBackColor = true;
            // 
            // rbtnEcologico
            // 
            this.rbtnEcologico.AutoSize = true;
            this.rbtnEcologico.Location = new System.Drawing.Point(104, 28);
            this.rbtnEcologico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnEcologico.Name = "rbtnEcologico";
            this.rbtnEcologico.Size = new System.Drawing.Size(72, 17);
            this.rbtnEcologico.TabIndex = 6;
            this.rbtnEcologico.Text = "Ecológico";
            this.rbtnEcologico.UseVisualStyleBackColor = true;
            // 
            // rbtnCorporal
            // 
            this.rbtnCorporal.AutoSize = true;
            this.rbtnCorporal.Location = new System.Drawing.Point(17, 75);
            this.rbtnCorporal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnCorporal.Name = "rbtnCorporal";
            this.rbtnCorporal.Size = new System.Drawing.Size(64, 17);
            this.rbtnCorporal.TabIndex = 9;
            this.rbtnCorporal.TabStop = true;
            this.rbtnCorporal.Text = "Corporal";
            this.rbtnCorporal.UseVisualStyleBackColor = true;
            // 
            // rbtnDeporte
            // 
            this.rbtnDeporte.AutoSize = true;
            this.rbtnDeporte.Location = new System.Drawing.Point(17, 97);
            this.rbtnDeporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnDeporte.Name = "rbtnDeporte";
            this.rbtnDeporte.Size = new System.Drawing.Size(63, 17);
            this.rbtnDeporte.TabIndex = 10;
            this.rbtnDeporte.TabStop = true;
            this.rbtnDeporte.Text = "Deporte";
            this.rbtnDeporte.UseVisualStyleBackColor = true;
            // 
            // rbtnIntolerancia
            // 
            this.rbtnIntolerancia.AutoSize = true;
            this.rbtnIntolerancia.Location = new System.Drawing.Point(262, 28);
            this.rbtnIntolerancia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnIntolerancia.Name = "rbtnIntolerancia";
            this.rbtnIntolerancia.Size = new System.Drawing.Size(80, 17);
            this.rbtnIntolerancia.TabIndex = 8;
            this.rbtnIntolerancia.Text = "Intolerencia";
            this.rbtnIntolerancia.UseVisualStyleBackColor = true;
            // 
            // rbtnSuplemento
            // 
            this.rbtnSuplemento.AutoSize = true;
            this.rbtnSuplemento.Location = new System.Drawing.Point(17, 119);
            this.rbtnSuplemento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnSuplemento.Name = "rbtnSuplemento";
            this.rbtnSuplemento.Size = new System.Drawing.Size(81, 17);
            this.rbtnSuplemento.TabIndex = 11;
            this.rbtnSuplemento.TabStop = true;
            this.rbtnSuplemento.Text = "Suplemento";
            this.rbtnSuplemento.UseVisualStyleBackColor = true;
            // 
            // rbtnAdelgazante
            // 
            this.rbtnAdelgazante.AutoSize = true;
            this.rbtnAdelgazante.Location = new System.Drawing.Point(176, 28);
            this.rbtnAdelgazante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnAdelgazante.Name = "rbtnAdelgazante";
            this.rbtnAdelgazante.Size = new System.Drawing.Size(84, 17);
            this.rbtnAdelgazante.TabIndex = 7;
            this.rbtnAdelgazante.Text = "Adelgazante";
            this.rbtnAdelgazante.UseVisualStyleBackColor = true;
            // 
            // lblCasaComercial
            // 
            this.lblCasaComercial.AutoSize = true;
            this.lblCasaComercial.Location = new System.Drawing.Point(23, 146);
            this.lblCasaComercial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCasaComercial.Name = "lblCasaComercial";
            this.lblCasaComercial.Size = new System.Drawing.Size(80, 13);
            this.lblCasaComercial.TabIndex = 26;
            this.lblCasaComercial.Text = "Casa Comercial";
            this.lblCasaComercial.Visible = false;
            // 
            // comboBoxCasas
            // 
            this.comboBoxCasas.FormattingEnabled = true;
            this.comboBoxCasas.Location = new System.Drawing.Point(116, 144);
            this.comboBoxCasas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCasas.Name = "comboBoxCasas";
            this.comboBoxCasas.Size = new System.Drawing.Size(300, 21);
            this.comboBoxCasas.TabIndex = 24;
            this.comboBoxCasas.Visible = false;
            // 
            // txtIdEditar
            // 
            this.txtIdEditar.Location = new System.Drawing.Point(116, 24);
            this.txtIdEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdEditar.Name = "txtIdEditar";
            this.txtIdEditar.Size = new System.Drawing.Size(52, 20);
            this.txtIdEditar.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 48);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 20);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(116, 73);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 62);
            this.txtDescripcion.TabIndex = 23;
            this.txtDescripcion.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(41, 73);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 50);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(88, 27);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Id";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(174, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 23);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // listBoxEditar
            // 
            this.listBoxEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEditar.FormattingEnabled = true;
            this.listBoxEditar.Location = new System.Drawing.Point(442, 27);
            this.listBoxEditar.Name = "listBoxEditar";
            this.listBoxEditar.Size = new System.Drawing.Size(625, 407);
            this.listBoxEditar.TabIndex = 34;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(230, 413);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(106, 42);
            this.buttonEditar.TabIndex = 35;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 461);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.listBoxEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtAtributo2);
            this.Controls.Add(this.lblAtributo2);
            this.Controls.Add(this.txtAtributo1);
            this.Controls.Add(this.lblAtributo1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.lblCasaComercial);
            this.Controls.Add(this.comboBoxCasas);
            this.Controls.Add(this.txtIdEditar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditar";
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAtributo2;
        private System.Windows.Forms.Label lblAtributo2;
        private System.Windows.Forms.TextBox txtAtributo1;
        private System.Windows.Forms.Label lblAtributo1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.RadioButton rbtnCorporal;
        private System.Windows.Forms.RadioButton rbtnAlimentacion;
        private System.Windows.Forms.RadioButton rbtnEcologico;
        private System.Windows.Forms.RadioButton rbtnIntolerancia;
        private System.Windows.Forms.RadioButton rbtnAdelgazante;
        private System.Windows.Forms.RadioButton rbtnDeporte;
        private System.Windows.Forms.RadioButton rbtnSuplemento;
        private System.Windows.Forms.Label lblCasaComercial;
        private System.Windows.Forms.ComboBox comboBoxCasas;
        private System.Windows.Forms.TextBox txtIdEditar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox listBoxEditar;
        private System.Windows.Forms.Button buttonEditar;
    }
}