
namespace WinFormsAppEjercicio06
{
    partial class frmCompraDolares
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cotizacionTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.datosDataGridView = new System.Windows.Forms.DataGridView();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.otraCompraButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de dólares:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(257, 38);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 23);
            this.cantidadTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese la cotización del dólar oficial:";
            // 
            // cotizacionTextBox
            // 
            this.cotizacionTextBox.Location = new System.Drawing.Point(257, 76);
            this.cotizacionTextBox.Name = "cotizacionTextBox";
            this.cotizacionTextBox.Size = new System.Drawing.Size(100, 23);
            this.cotizacionTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Image = global::WinFormsAppEjercicio06.Properties.Resources.ok_36px;
            this.okButton.Location = new System.Drawing.Point(50, 130);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 70);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Image = global::WinFormsAppEjercicio06.Properties.Resources.cancel_36px;
            this.cancelarButton.Location = new System.Drawing.Point(262, 130);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(95, 70);
            this.cancelarButton.TabIndex = 3;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // datosDataGridView
            // 
            this.datosDataGridView.AllowUserToAddRows = false;
            this.datosDataGridView.AllowUserToDeleteRows = false;
            this.datosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDescripcion,
            this.colImporte});
            this.datosDataGridView.Location = new System.Drawing.Point(50, 246);
            this.datosDataGridView.Name = "datosDataGridView";
            this.datosDataGridView.ReadOnly = true;
            this.datosDataGridView.RowTemplate.Height = 25;
            this.datosDataGridView.Size = new System.Drawing.Size(307, 150);
            this.datosDataGridView.TabIndex = 6;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colImporte
            // 
            this.colImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImporte.DefaultCellStyle = dataGridViewCellStyle1;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // otraCompraButton
            // 
            this.otraCompraButton.Image = global::WinFormsAppEjercicio06.Properties.Resources.money_20px;
            this.otraCompraButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.otraCompraButton.Location = new System.Drawing.Point(249, 401);
            this.otraCompraButton.Name = "otraCompraButton";
            this.otraCompraButton.Size = new System.Drawing.Size(107, 37);
            this.otraCompraButton.TabIndex = 7;
            this.otraCompraButton.Text = "Otra Compra";
            this.otraCompraButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.otraCompraButton.UseVisualStyleBackColor = true;
            this.otraCompraButton.Click += new System.EventHandler(this.otraCompraButton_Click);
            // 
            // frmCompraDolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.otraCompraButton);
            this.Controls.Add(this.datosDataGridView);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cotizacionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 489);
            this.Name = "frmCompraDolares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Divisas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCompraDolares_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.datosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cotizacionTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.DataGridView datosDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Button otraCompraButton;
    }
}

