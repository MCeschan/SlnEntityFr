namespace WindowsEFEscuela
{
    partial class frmAlumno
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
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.GridAlumnos = new System.Windows.Forms.DataGridView();
            this.btnTraerUno = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(528, 98);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(113, 23);
            this.btnTraerTodos.TabIndex = 0;
            this.btnTraerTodos.Text = "Traer todos";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // GridAlumnos
            // 
            this.GridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAlumnos.Location = new System.Drawing.Point(182, 195);
            this.GridAlumnos.Name = "GridAlumnos";
            this.GridAlumnos.RowHeadersWidth = 51;
            this.GridAlumnos.RowTemplate.Height = 24;
            this.GridAlumnos.Size = new System.Drawing.Size(240, 150);
            this.GridAlumnos.TabIndex = 1;
            // 
            // btnTraerUno
            // 
            this.btnTraerUno.Location = new System.Drawing.Point(528, 152);
            this.btnTraerUno.Name = "btnTraerUno";
            this.btnTraerUno.Size = new System.Drawing.Size(113, 23);
            this.btnTraerUno.TabIndex = 2;
            this.btnTraerUno.Text = "Traer uno";
            this.btnTraerUno.UseVisualStyleBackColor = true;
            this.btnTraerUno.Click += new System.EventHandler(this.btnTraerUno_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(528, 195);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(142, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insertar un alumno";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(528, 239);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(528, 302);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnTraerUno);
            this.Controls.Add(this.GridAlumnos);
            this.Controls.Add(this.btnTraerTodos);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.GridAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.DataGridView GridAlumnos;
        private System.Windows.Forms.Button btnTraerUno;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}