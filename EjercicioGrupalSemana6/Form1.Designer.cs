partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button buttonEjecutar;
    private System.Windows.Forms.Button buttonLimpiar;
    private System.Windows.Forms.DataGridView dataGridView1;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.buttonEjecutar = new System.Windows.Forms.Button();
        this.buttonLimpiar = new System.Windows.Forms.Button();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();

        // el boton ejecutar
        this.buttonEjecutar.BackColor = System.Drawing.Color.Pink;
        this.buttonEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        this.buttonEjecutar.Location = new System.Drawing.Point(340, 12);
        this.buttonEjecutar.Name = "buttonEjecutar";
        this.buttonEjecutar.Size = new System.Drawing.Size(150, 38);
        this.buttonEjecutar.TabIndex = 0;
        this.buttonEjecutar.Text = "Ejecutar!";
        this.buttonEjecutar.UseVisualStyleBackColor = false;
        this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click);

        // BotonLimpiar por implementar
        this.buttonLimpiar.BackColor = System.Drawing.Color.Pink;
        this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        this.buttonLimpiar.Location = new System.Drawing.Point(44, 12);
        this.buttonLimpiar.Name = "buttonLimpiar";
        this.buttonLimpiar.Size = new System.Drawing.Size(150, 38);
        this.buttonLimpiar.TabIndex = 1;
        this.buttonLimpiar.Text = "Limpiar!";
        this.buttonLimpiar.UseVisualStyleBackColor = false;
        this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);

        // el dataGrid
        this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new System.Drawing.Point(44, 78);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.Size = new System.Drawing.Size(446, 172);
        this.dataGridView1.TabIndex = 2;

        // formulario1
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(523, 262);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.buttonLimpiar);
        this.Controls.Add(this.buttonEjecutar);
        this.Name = "Form1";
        this.Text = "Analizando Números Primos";
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);
    }
}
