
namespace TPWinForm_equipo_O
{
    partial class FormaInicio
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
            this.labelCampo = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.dataGridViewArticuloBD = new System.Windows.Forms.DataGridView();
            this.buttonEliminarArticulo = new System.Windows.Forms.Button();
            this.buttonModificiarArticulo = new System.Windows.Forms.Button();
            this.buttonAgregarArticulo = new System.Windows.Forms.Button();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticuloBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(12, 12);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(56, 17);
            this.labelCampo.TabIndex = 6;
            this.labelCampo.Text = "Campo:";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(74, 9);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(139, 24);
            this.comboBoxCampo.TabIndex = 9;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::TPWinForm_equipo_O.Properties.Resources.iconoLupa;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscar.Location = new System.Drawing.Point(574, 6);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(37, 29);
            this.buttonBuscar.TabIndex = 14;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(286, 9);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(139, 24);
            this.comboBoxCriterio.TabIndex = 13;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(431, 10);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(125, 22);
            this.textBoxFiltro.TabIndex = 12;
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(223, 13);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(57, 17);
            this.labelCriterio.TabIndex = 11;
            this.labelCriterio.Text = "Criterio:";
            // 
            // dataGridViewArticuloBD
            // 
            this.dataGridViewArticuloBD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArticuloBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticuloBD.Location = new System.Drawing.Point(15, 57);
            this.dataGridViewArticuloBD.Name = "dataGridViewArticuloBD";
            this.dataGridViewArticuloBD.RowHeadersWidth = 51;
            this.dataGridViewArticuloBD.RowTemplate.Height = 24;
            this.dataGridViewArticuloBD.Size = new System.Drawing.Size(961, 244);
            this.dataGridViewArticuloBD.TabIndex = 15;
            this.dataGridViewArticuloBD.SelectionChanged += new System.EventHandler(this.dataGridViewArticuloBD_SelectionChanged);
            // 
            // buttonEliminarArticulo
            // 
            this.buttonEliminarArticulo.Location = new System.Drawing.Point(48, 399);
            this.buttonEliminarArticulo.Name = "buttonEliminarArticulo";
            this.buttonEliminarArticulo.Size = new System.Drawing.Size(165, 40);
            this.buttonEliminarArticulo.TabIndex = 19;
            this.buttonEliminarArticulo.Text = "Eliminar Articulo";
            this.buttonEliminarArticulo.UseVisualStyleBackColor = true;
            this.buttonEliminarArticulo.Click += new System.EventHandler(this.buttonEliminarArticulo_Click);
            // 
            // buttonModificiarArticulo
            // 
            this.buttonModificiarArticulo.Location = new System.Drawing.Point(48, 353);
            this.buttonModificiarArticulo.Name = "buttonModificiarArticulo";
            this.buttonModificiarArticulo.Size = new System.Drawing.Size(165, 40);
            this.buttonModificiarArticulo.TabIndex = 18;
            this.buttonModificiarArticulo.Text = "Modificar Articulo";
            this.buttonModificiarArticulo.UseVisualStyleBackColor = true;
            this.buttonModificiarArticulo.Click += new System.EventHandler(this.buttonModificiarArticulo_Click);
            // 
            // buttonAgregarArticulo
            // 
            this.buttonAgregarArticulo.Location = new System.Drawing.Point(48, 307);
            this.buttonAgregarArticulo.Name = "buttonAgregarArticulo";
            this.buttonAgregarArticulo.Size = new System.Drawing.Size(165, 40);
            this.buttonAgregarArticulo.TabIndex = 17;
            this.buttonAgregarArticulo.Text = "Agregar Articulo";
            this.buttonAgregarArticulo.UseVisualStyleBackColor = true;
            this.buttonAgregarArticulo.Click += new System.EventHandler(this.buttonAgregarArticulo_Click);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(493, 323);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(483, 237);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArticulo.TabIndex = 16;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // FormaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 610);
            this.Controls.Add(this.buttonEliminarArticulo);
            this.Controls.Add(this.buttonModificiarArticulo);
            this.Controls.Add(this.buttonAgregarArticulo);
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.dataGridViewArticuloBD);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.labelCampo);
            this.Name = "FormaInicio";
            this.Text = "Administracion de Articulos";
            this.Load += new System.EventHandler(this.FormaInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticuloBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.DataGridView dataGridViewArticuloBD;
        private System.Windows.Forms.Button buttonEliminarArticulo;
        private System.Windows.Forms.Button buttonModificiarArticulo;
        private System.Windows.Forms.Button buttonAgregarArticulo;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
    }
}

