namespace AccesoDeDatos
{
    partial class frmCustomers
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
            label2 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnCrear = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvCustomers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 1;
            label2.Text = "FirstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 121);
            label3.Name = "label3";
            label3.Size = new Size(119, 32);
            label3.TabIndex = 2;
            label3.Text = "LastName";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(188, 36);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(276, 39);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(188, 114);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(276, 39);
            txtLastName.TabIndex = 5;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(503, 65);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(201, 88);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(735, 65);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(201, 88);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(953, 65);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(201, 88);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(21, 177);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 82;
            dgvCustomers.Size = new Size(1133, 424);
            dgvCustomers.TabIndex = 11;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 631);
            Controls.Add(dgvCustomers);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmCustomers";
            Text = "frmCustomers";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnCrear;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvCustomers;
    }
}