namespace administrador_alumnos
{
    partial class formAlumnos
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
            this.dgvALUMNOS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNOTA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAÑO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnBORRAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.picFOTO = new System.Windows.Forms.PictureBox();
            this.btnADJUNTAR = new System.Windows.Forms.Button();
            this.txtESCUELA = new System.Windows.Forms.TextBox();
            this.txtMATERIA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvALUMNOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFOTO)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvALUMNOS
            // 
            this.dgvALUMNOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvALUMNOS.Location = new System.Drawing.Point(28, 232);
            this.dgvALUMNOS.Name = "dgvALUMNOS";
            this.dgvALUMNOS.Size = new System.Drawing.Size(563, 146);
            this.dgvALUMNOS.TabIndex = 0;
            this.dgvALUMNOS.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MATERIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOTA";
            // 
            // txtNOTA
            // 
            this.txtNOTA.Location = new System.Drawing.Point(395, 118);
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(196, 20);
            this.txtNOTA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "APELLIDO";
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.Location = new System.Drawing.Point(395, 79);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(196, 20);
            this.txtAPELLIDO.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOMBRE";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(193, 79);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(196, 20);
            this.txtNOMBRE.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "AÑO";
            // 
            // txtAÑO
            // 
            this.txtAÑO.Location = new System.Drawing.Point(395, 40);
            this.txtAÑO.Name = "txtAÑO";
            this.txtAÑO.Size = new System.Drawing.Size(196, 20);
            this.txtAÑO.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ESCUELA";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(516, 203);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.btnCANCELAR.TabIndex = 15;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnBORRAR
            // 
            this.btnBORRAR.Location = new System.Drawing.Point(435, 203);
            this.btnBORRAR.Name = "btnBORRAR";
            this.btnBORRAR.Size = new System.Drawing.Size(75, 23);
            this.btnBORRAR.TabIndex = 16;
            this.btnBORRAR.Text = "BORRAR";
            this.btnBORRAR.UseVisualStyleBackColor = true;
            this.btnBORRAR.Click += new System.EventHandler(this.btnBORRAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(354, 203);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.btnMODIFICAR.TabIndex = 17;
            this.btnMODIFICAR.Text = "MODIFICAR";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(273, 203);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.btnAGREGAR.TabIndex = 18;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // picFOTO
            // 
            this.picFOTO.Location = new System.Drawing.Point(28, 40);
            this.picFOTO.Name = "picFOTO";
            this.picFOTO.Size = new System.Drawing.Size(147, 128);
            this.picFOTO.TabIndex = 19;
            this.picFOTO.TabStop = false;
            // 
            // btnADJUNTAR
            // 
            this.btnADJUNTAR.Location = new System.Drawing.Point(28, 174);
            this.btnADJUNTAR.Name = "btnADJUNTAR";
            this.btnADJUNTAR.Size = new System.Drawing.Size(147, 23);
            this.btnADJUNTAR.TabIndex = 20;
            this.btnADJUNTAR.Text = "ADJUNTAR";
            this.btnADJUNTAR.UseVisualStyleBackColor = true;
            this.btnADJUNTAR.Click += new System.EventHandler(this.btnADJUNTAR_Click);
            // 
            // txtESCUELA
            // 
            this.txtESCUELA.Location = new System.Drawing.Point(193, 40);
            this.txtESCUELA.Name = "txtESCUELA";
            this.txtESCUELA.Size = new System.Drawing.Size(196, 20);
            this.txtESCUELA.TabIndex = 21;
            // 
            // txtMATERIA
            // 
            this.txtMATERIA.Location = new System.Drawing.Point(193, 118);
            this.txtMATERIA.Name = "txtMATERIA";
            this.txtMATERIA.Size = new System.Drawing.Size(196, 20);
            this.txtMATERIA.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(299, 159);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 20);
            this.txtID.TabIndex = 23;
            // 
            // formAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 398);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtMATERIA);
            this.Controls.Add(this.txtESCUELA);
            this.Controls.Add(this.btnADJUNTAR);
            this.Controls.Add(this.picFOTO);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnBORRAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAÑO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAPELLIDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNOTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvALUMNOS);
            this.Name = "formAlumnos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvALUMNOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFOTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvALUMNOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNOTA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPELLIDO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAÑO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnBORRAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.PictureBox picFOTO;
        private System.Windows.Forms.Button btnADJUNTAR;
        private System.Windows.Forms.TextBox txtESCUELA;
        private System.Windows.Forms.TextBox txtMATERIA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
    }
}

