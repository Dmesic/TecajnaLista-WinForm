namespace TecajnaLista
{
    partial class FormGlavna
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
            this.dohvatiButton = new System.Windows.Forms.Button();
            this.TecajeviDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TecajeviDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dohvatiButton
            // 
            this.dohvatiButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dohvatiButton.Location = new System.Drawing.Point(234, 12);
            this.dohvatiButton.Name = "dohvatiButton";
            this.dohvatiButton.Size = new System.Drawing.Size(317, 49);
            this.dohvatiButton.TabIndex = 0;
            this.dohvatiButton.Text = "Dohvati nove tečajeve";
            this.dohvatiButton.UseVisualStyleBackColor = true;
            this.dohvatiButton.Click += new System.EventHandler(this.dohvatiButton_Click);
            // 
            // TecajeviDataGridView
            // 
            this.TecajeviDataGridView.AllowUserToAddRows = false;
            this.TecajeviDataGridView.AllowUserToDeleteRows = false;
            this.TecajeviDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TecajeviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TecajeviDataGridView.Location = new System.Drawing.Point(12, 79);
            this.TecajeviDataGridView.MultiSelect = false;
            this.TecajeviDataGridView.Name = "TecajeviDataGridView";
            this.TecajeviDataGridView.ReadOnly = true;
            this.TecajeviDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TecajeviDataGridView.Size = new System.Drawing.Size(760, 470);
            this.TecajeviDataGridView.TabIndex = 1;
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TecajeviDataGridView);
            this.Controls.Add(this.dohvatiButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tecajna Lista";
            this.Load += new System.EventHandler(this.FormGlavna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TecajeviDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dohvatiButton;
        private System.Windows.Forms.DataGridView TecajeviDataGridView;
    }
}

