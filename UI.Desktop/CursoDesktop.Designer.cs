namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tlCurso = new System.Windows.Forms.TableLayoutPanel();
            this.cboIdMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.txtAnioCalendario = new System.Windows.Forms.TextBox();
            this.cboIdComision = new System.Windows.Forms.ComboBox();
            this.tlCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlCurso
            // 
            this.tlCurso.ColumnCount = 2;
            this.tlCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.32472F));
            this.tlCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.67528F));
            this.tlCurso.Controls.Add(this.cboIdMateria, 1, 2);
            this.tlCurso.Controls.Add(this.label1, 0, 0);
            this.tlCurso.Controls.Add(this.label6, 0, 5);
            this.tlCurso.Controls.Add(this.label5, 0, 4);
            this.tlCurso.Controls.Add(this.label4, 0, 3);
            this.tlCurso.Controls.Add(this.label3, 0, 2);
            this.tlCurso.Controls.Add(this.label2, 0, 1);
            this.tlCurso.Controls.Add(this.btnAceptar, 0, 6);
            this.tlCurso.Controls.Add(this.btnCancelar, 1, 6);
            this.tlCurso.Controls.Add(this.txtID, 1, 0);
            this.tlCurso.Controls.Add(this.txtDesc, 1, 3);
            this.tlCurso.Controls.Add(this.txtCupo, 1, 4);
            this.tlCurso.Controls.Add(this.txtAnioCalendario, 1, 5);
            this.tlCurso.Controls.Add(this.cboIdComision, 1, 1);
            this.tlCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlCurso.Location = new System.Drawing.Point(0, 0);
            this.tlCurso.Name = "tlCurso";
            this.tlCurso.RowCount = 7;
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.79657F));
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84068F));
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84068F));
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84068F));
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84068F));
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84068F));
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCurso.Size = new System.Drawing.Size(542, 213);
            this.tlCurso.TabIndex = 0;
            // 
            // cboIdMateria
            // 
            this.cboIdMateria.FormattingEnabled = true;
            this.cboIdMateria.Location = new System.Drawing.Point(123, 59);
            this.cboIdMateria.Name = "cboIdMateria";
            this.cboIdMateria.Size = new System.Drawing.Size(121, 24);
            this.cboIdMateria.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Año Calendario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID comision";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(3, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(123, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Location = new System.Drawing.Point(123, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(415, 23);
            this.txtID.TabIndex = 8;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(123, 88);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(415, 23);
            this.txtDesc.TabIndex = 9;
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(123, 117);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(415, 23);
            this.txtCupo.TabIndex = 10;
            // 
            // txtAnioCalendario
            // 
            this.txtAnioCalendario.Location = new System.Drawing.Point(123, 146);
            this.txtAnioCalendario.Name = "txtAnioCalendario";
            this.txtAnioCalendario.Size = new System.Drawing.Size(415, 23);
            this.txtAnioCalendario.TabIndex = 11;
            // 
            // cboIdComision
            // 
            this.cboIdComision.FormattingEnabled = true;
            this.cboIdComision.Location = new System.Drawing.Point(123, 30);
            this.cboIdComision.Name = "cboIdComision";
            this.cboIdComision.Size = new System.Drawing.Size(121, 24);
            this.cboIdComision.TabIndex = 12;
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 213);
            this.Controls.Add(this.tlCurso);
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.tlCurso.ResumeLayout(false);
            this.tlCurso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboIdMateria;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.TextBox txtAnioCalendario;
        private System.Windows.Forms.ComboBox cboIdComision;
    }
}