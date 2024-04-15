namespace Examen.Servicios
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarServicios = new System.Windows.Forms.Button();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstPaquetes = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mtxId = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkJardineria = new System.Windows.Forms.CheckBox();
            this.chkLimpiezaC = new System.Windows.Forms.CheckBox();
            this.chkLavadoA = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCantidadHrs = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadHrs)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "telecable.PNG");
            this.imageList.Images.SetKeyName(1, "tigo.PNG");
            this.imageList.Images.SetKeyName(2, "cabletica.PNG");
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Solo XML | *.xml";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(499, 606);
            this.webBrowser.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer.Panel1.Controls.Add(this.btnCotizar);
            this.splitContainer.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.webBrowser);
            this.splitContainer.Size = new System.Drawing.Size(1091, 606);
            this.splitContainer.SplitterDistance = 588;
            this.splitContainer.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrarServicios);
            this.groupBox1.Controls.Add(this.cmbServicios);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvDatos);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 235);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // btnMostrarServicios
            // 
            this.btnMostrarServicios.Location = new System.Drawing.Point(401, 13);
            this.btnMostrarServicios.Name = "btnMostrarServicios";
            this.btnMostrarServicios.Size = new System.Drawing.Size(131, 49);
            this.btnMostrarServicios.TabIndex = 16;
            this.btnMostrarServicios.Text = "Mostrar Opciones";
            this.btnMostrarServicios.UseVisualStyleBackColor = true;
            this.btnMostrarServicios.Click += new System.EventHandler(this.btnMostrarServicios_Click);
            // 
            // cmbServicios
            // 
            this.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(131, 24);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(264, 28);
            this.cmbServicios.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo Servicio";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(23, 68);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(509, 155);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(6, 556);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(547, 32);
            this.btnCotizar.TabIndex = 3;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstPaquetes);
            this.groupBox4.Location = new System.Drawing.Point(303, 401);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 140);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paquetes";
            // 
            // lstPaquetes
            // 
            this.lstPaquetes.DisplayMember = "Descripcion";
            this.lstPaquetes.FormattingEnabled = true;
            this.lstPaquetes.ItemHeight = 20;
            this.lstPaquetes.Location = new System.Drawing.Point(14, 21);
            this.lstPaquetes.Name = "lstPaquetes";
            this.lstPaquetes.ScrollAlwaysVisible = true;
            this.lstPaquetes.Size = new System.Drawing.Size(221, 104);
            this.lstPaquetes.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudCantidadHrs);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.mtxId);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 133);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(392, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // mtxId
            // 
            this.mtxId.Location = new System.Drawing.Point(141, 22);
            this.mtxId.Mask = "0-0000-0000";
            this.mtxId.Name = "mtxId";
            this.mtxId.Size = new System.Drawing.Size(392, 26);
            this.mtxId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkJardineria);
            this.groupBox2.Controls.Add(this.chkLimpiezaC);
            this.groupBox2.Controls.Add(this.chkLavadoA);
            this.groupBox2.Location = new System.Drawing.Point(7, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionales";
            // 
            // chkJardineria
            // 
            this.chkJardineria.AutoSize = true;
            this.chkJardineria.Location = new System.Drawing.Point(52, 72);
            this.chkJardineria.Name = "chkJardineria";
            this.chkJardineria.Size = new System.Drawing.Size(105, 24);
            this.chkJardineria.TabIndex = 3;
            this.chkJardineria.Text = "Jardineria";
            this.chkJardineria.UseVisualStyleBackColor = true;
            // 
            // chkLimpiezaC
            // 
            this.chkLimpiezaC.AutoSize = true;
            this.chkLimpiezaC.Location = new System.Drawing.Point(52, 24);
            this.chkLimpiezaC.Name = "chkLimpiezaC";
            this.chkLimpiezaC.Size = new System.Drawing.Size(161, 24);
            this.chkLimpiezaC.TabIndex = 0;
            this.chkLimpiezaC.Text = "Limpieza Canoas";
            this.chkLimpiezaC.UseVisualStyleBackColor = true;
            // 
            // chkLavadoA
            // 
            this.chkLavadoA.AutoSize = true;
            this.chkLavadoA.Location = new System.Drawing.Point(52, 47);
            this.chkLavadoA.Name = "chkLavadoA";
            this.chkLavadoA.Size = new System.Drawing.Size(143, 24);
            this.chkLavadoA.TabIndex = 2;
            this.chkLavadoA.Text = "Lavado Aceras";
            this.chkLavadoA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horas";
            // 
            // nudCantidadHrs
            // 
            this.nudCantidadHrs.Location = new System.Drawing.Point(141, 97);
            this.nudCantidadHrs.Name = "nudCantidadHrs";
            this.nudCantidadHrs.Size = new System.Drawing.Size(120, 26);
            this.nudCantidadHrs.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 606);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante:";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadHrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstPaquetes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mtxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkLimpiezaC;
        private System.Windows.Forms.CheckBox chkLavadoA;
        private System.Windows.Forms.CheckBox chkJardineria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrarServicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCantidadHrs;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

