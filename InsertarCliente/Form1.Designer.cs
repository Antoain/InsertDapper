namespace InsertarCliente
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtboxCatName = new System.Windows.Forms.TextBox();
            this.txtboxDescripccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvObtenerTodos = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtBObtnerID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.btnObtenerID = new System.Windows.Forms.Button();
            this.txtboxCatID = new System.Windows.Forms.TextBox();
            this.IDS = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(583, 347);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(169, 23);
            this.btnInsertar.TabIndex = 27;
            this.btnInsertar.Text = "Insertacion de Categoria";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtboxCatName
            // 
            this.txtboxCatName.Location = new System.Drawing.Point(652, 259);
            this.txtboxCatName.Name = "txtboxCatName";
            this.txtboxCatName.Size = new System.Drawing.Size(100, 22);
            this.txtboxCatName.TabIndex = 25;
            // 
            // txtboxDescripccion
            // 
            this.txtboxDescripccion.Location = new System.Drawing.Point(652, 287);
            this.txtboxDescripccion.Name = "txtboxDescripccion";
            this.txtboxDescripccion.Size = new System.Drawing.Size(100, 22);
            this.txtboxDescripccion.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Descripccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Company Name";
            // 
            // dgvObtenerTodos
            // 
            this.dgvObtenerTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObtenerTodos.Location = new System.Drawing.Point(66, 40);
            this.dgvObtenerTodos.Name = "dgvObtenerTodos";
            this.dgvObtenerTodos.RowHeadersWidth = 51;
            this.dgvObtenerTodos.RowTemplate.Height = 24;
            this.dgvObtenerTodos.Size = new System.Drawing.Size(470, 150);
            this.dgvObtenerTodos.TabIndex = 28;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(66, 196);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(183, 23);
            this.btnObtenerTodos.TabIndex = 29;
            this.btnObtenerTodos.Text = "Obtener Categoria";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(595, 376);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(169, 23);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizacin de Categoria";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtBObtnerID
            // 
            this.txtBObtnerID.Location = new System.Drawing.Point(240, 270);
            this.txtBObtnerID.Name = "txtBObtnerID";
            this.txtBObtnerID.Size = new System.Drawing.Size(100, 22);
            this.txtBObtnerID.TabIndex = 31;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(172, 276);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 16);
            this.ID.TabIndex = 32;
            this.ID.Text = "ID";
            // 
            // btnObtenerID
            // 
            this.btnObtenerID.Location = new System.Drawing.Point(175, 313);
            this.btnObtenerID.Name = "btnObtenerID";
            this.btnObtenerID.Size = new System.Drawing.Size(183, 23);
            this.btnObtenerID.TabIndex = 33;
            this.btnObtenerID.Text = "Obtener Categoria";
            this.btnObtenerID.UseVisualStyleBackColor = true;
            this.btnObtenerID.Click += new System.EventHandler(this.btnObtenerID_Click);
            // 
            // txtboxCatID
            // 
            this.txtboxCatID.Location = new System.Drawing.Point(652, 237);
            this.txtboxCatID.Name = "txtboxCatID";
            this.txtboxCatID.Size = new System.Drawing.Size(100, 22);
            this.txtboxCatID.TabIndex = 34;
            // 
            // IDS
            // 
            this.IDS.AutoSize = true;
            this.IDS.Location = new System.Drawing.Point(573, 240);
            this.IDS.Name = "IDS";
            this.IDS.Size = new System.Drawing.Size(56, 16);
            this.IDS.TabIndex = 35;
            this.IDS.Text = "CategID";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(576, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(169, 23);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminacion de Categoria";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.IDS);
            this.Controls.Add(this.txtboxCatID);
            this.Controls.Add(this.btnObtenerID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtBObtnerID);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvObtenerTodos);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtboxCatName);
            this.Controls.Add(this.txtboxDescripccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtboxCatName;
        private System.Windows.Forms.TextBox txtboxDescripccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvObtenerTodos;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtBObtnerID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button btnObtenerID;
        private System.Windows.Forms.TextBox txtboxCatID;
        private System.Windows.Forms.Label IDS;
        private System.Windows.Forms.Button btnEliminar;
    }
}

