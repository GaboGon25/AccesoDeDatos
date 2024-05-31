namespace AccesoDeDatos
{
    partial class frmCreditRisks
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
            dgvCreditRisks = new DataGridView();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtCustomerId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCreditRisks).BeginInit();
            SuspendLayout();
            // 
            // dgvCreditRisks
            // 
            dgvCreditRisks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreditRisks.Location = new Point(12, 420);
            dgvCreditRisks.Name = "dgvCreditRisks";
            dgvCreditRisks.RowHeadersWidth = 82;
            dgvCreditRisks.Size = new Size(934, 424);
            dgvCreditRisks.TabIndex = 23;
            dgvCreditRisks.SelectionChanged += dgvCreditRisks_SelectionChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(634, 299);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(201, 88);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(634, 173);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(201, 88);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(634, 24);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(201, 88);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "CREAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(227, 166);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(276, 39);
            txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(227, 45);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(276, 39);
            txtFirstName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 173);
            label3.Name = "label3";
            label3.Size = new Size(119, 32);
            label3.TabIndex = 14;
            label3.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 52);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 13;
            label2.Text = "FirstName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 299);
            label4.Name = "label4";
            label4.Size = new Size(137, 32);
            label4.TabIndex = 24;
            label4.Text = "CustomerId";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(227, 292);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(276, 39);
            txtCustomerId.TabIndex = 25;
            // 
            // frmCreditRisks
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 910);
            Controls.Add(txtCustomerId);
            Controls.Add(label4);
            Controls.Add(dgvCreditRisks);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmCreditRisks";
            Text = "frmCreditRisks";
            ((System.ComponentModel.ISupportInitialize)dgvCreditRisks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCreditRisks;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtCustomerId;
    }
}