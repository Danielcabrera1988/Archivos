namespace Archivos
{
    partial class Archivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archivos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxExt = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtBoxRuta = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTamRelative = new System.Windows.Forms.Label();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Directorios = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxRelativo = new System.Windows.Forms.ListBox();
            this.listBoxTam = new System.Windows.Forms.ListBox();
            this.listBoxNombre = new System.Windows.Forms.ListBox();
            this.listBoxDir = new System.Windows.Forms.ListBox();
            this.labelTamaños = new System.Windows.Forms.Label();
            this.lblTamTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantArch = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.sFD = new System.Windows.Forms.SaveFileDialog();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnExplorar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbBoxExt, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMostrar, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 396);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 35);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnExplorar
            // 
            this.btnExplorar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExplorar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorar.Location = new System.Drawing.Point(3, 3);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(143, 29);
            this.btnExplorar.TabIndex = 0;
            this.btnExplorar.Text = "Explorar";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Extención";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxExt
            // 
            this.cmbBoxExt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBoxExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxExt.FormattingEnabled = true;
            this.cmbBoxExt.Items.AddRange(new object[] {
            "pdf",
            "doc",
            "docx",
            "pptx",
            "ppt",
            "xlsx",
            "jpg",
            "bpm",
            "png",
            "sln",
            "exe",
            "*"});
            this.cmbBoxExt.Location = new System.Drawing.Point(301, 3);
            this.cmbBoxExt.Name = "cmbBoxExt";
            this.cmbBoxExt.Size = new System.Drawing.Size(143, 26);
            this.cmbBoxExt.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(450, 3);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(146, 29);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // txtBoxRuta
            // 
            this.txtBoxRuta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRuta.Location = new System.Drawing.Point(0, 374);
            this.txtBoxRuta.Name = "txtBoxRuta";
            this.txtBoxRuta.Size = new System.Drawing.Size(599, 22);
            this.txtBoxRuta.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.lblTamRelative, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTamaño, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Directorios, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(599, 22);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblTamRelative
            // 
            this.lblTamRelative.AutoSize = true;
            this.lblTamRelative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTamRelative.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamRelative.Location = new System.Drawing.Point(450, 0);
            this.lblTamRelative.Name = "lblTamRelative";
            this.lblTamRelative.Size = new System.Drawing.Size(146, 22);
            this.lblTamRelative.TabIndex = 4;
            this.lblTamRelative.Text = "Relativo %";
            this.lblTamRelative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTamaño.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamaño.Location = new System.Drawing.Point(301, 0);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(143, 22);
            this.lblTamaño.TabIndex = 1;
            this.lblTamaño.Text = "Tamaño KB";
            this.lblTamaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(152, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(143, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Directorios
            // 
            this.Directorios.AutoSize = true;
            this.Directorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Directorios.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directorios.Location = new System.Drawing.Point(3, 0);
            this.Directorios.Name = "Directorios";
            this.Directorios.Size = new System.Drawing.Size(143, 22);
            this.Directorios.TabIndex = 5;
            this.Directorios.Text = "Directorios";
            this.Directorios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.listBoxRelativo, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.listBoxTam, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.listBoxNombre, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.listBoxDir, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(599, 263);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // listBoxRelativo
            // 
            this.listBoxRelativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRelativo.FormattingEnabled = true;
            this.listBoxRelativo.Location = new System.Drawing.Point(450, 3);
            this.listBoxRelativo.Name = "listBoxRelativo";
            this.listBoxRelativo.Size = new System.Drawing.Size(146, 257);
            this.listBoxRelativo.TabIndex = 4;
            // 
            // listBoxTam
            // 
            this.listBoxTam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTam.FormattingEnabled = true;
            this.listBoxTam.Location = new System.Drawing.Point(301, 3);
            this.listBoxTam.Name = "listBoxTam";
            this.listBoxTam.Size = new System.Drawing.Size(143, 257);
            this.listBoxTam.TabIndex = 1;
            // 
            // listBoxNombre
            // 
            this.listBoxNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNombre.FormattingEnabled = true;
            this.listBoxNombre.Location = new System.Drawing.Point(152, 3);
            this.listBoxNombre.Name = "listBoxNombre";
            this.listBoxNombre.Size = new System.Drawing.Size(143, 257);
            this.listBoxNombre.TabIndex = 0;
            // 
            // listBoxDir
            // 
            this.listBoxDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDir.FormattingEnabled = true;
            this.listBoxDir.Location = new System.Drawing.Point(3, 3);
            this.listBoxDir.Name = "listBoxDir";
            this.listBoxDir.Size = new System.Drawing.Size(143, 257);
            this.listBoxDir.TabIndex = 5;
            // 
            // labelTamaños
            // 
            this.labelTamaños.AutoSize = true;
            this.labelTamaños.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamaños.Location = new System.Drawing.Point(3, 311);
            this.labelTamaños.Name = "labelTamaños";
            this.labelTamaños.Size = new System.Drawing.Size(307, 18);
            this.labelTamaños.TabIndex = 7;
            this.labelTamaños.Text = "Tamaño total de archivos encontrados en KB:";
            this.labelTamaños.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTamTotal
            // 
            this.lblTamTotal.AutoSize = true;
            this.lblTamTotal.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamTotal.Location = new System.Drawing.Point(321, 311);
            this.lblTamTotal.Name = "lblTamTotal";
            this.lblTamTotal.Size = new System.Drawing.Size(0, 18);
            this.lblTamTotal.TabIndex = 8;
            this.lblTamTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad de archivos encontrados:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantArch
            // 
            this.lblCantArch.AutoSize = true;
            this.lblCantArch.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantArch.Location = new System.Drawing.Point(245, 288);
            this.lblCantArch.Name = "lblCantArch";
            this.lblCantArch.Size = new System.Drawing.Size(0, 18);
            this.lblCantArch.TabIndex = 10;
            this.lblCantArch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(401, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(195, 29);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnOpen, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnLimpiar, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 339);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(599, 35);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(202, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(193, 29);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            // 
            // Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 431);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.lblCantArch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTamTotal);
            this.Controls.Add(this.labelTamaños);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.txtBoxRuta);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Archivos";
            this.Text = "Buscador de Archivos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.TextBox txtBoxRuta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTamRelative;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox listBoxTam;
        private System.Windows.Forms.ListBox listBoxNombre;
        private System.Windows.Forms.ListBox listBoxRelativo;
        private System.Windows.Forms.Label labelTamaños;
        private System.Windows.Forms.Label lblTamTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantArch;
        private System.Windows.Forms.ComboBox cmbBoxExt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Directorios;
        private System.Windows.Forms.ListBox listBoxDir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.SaveFileDialog sFD;
        private System.Windows.Forms.OpenFileDialog oFD;
    }
}

