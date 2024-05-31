namespace AccesoDeDatos
{
    partial class frmPrincipalEF
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
            btnCustomers = new Button();
            btnCreditRisks = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(97, 171);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(301, 160);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "CRUD DE CUSTOMERS";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnCreditRisks
            // 
            btnCreditRisks.Location = new Point(494, 171);
            btnCreditRisks.Name = "btnCreditRisks";
            btnCreditRisks.Size = new Size(301, 160);
            btnCreditRisks.TabIndex = 1;
            btnCreditRisks.Text = "CRUD DE CREDIT_RISKS";
            btnCreditRisks.UseVisualStyleBackColor = true;
            btnCreditRisks.Click += btnCreditRisks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 76);
            label1.Name = "label1";
            label1.Size = new Size(480, 32);
            label1.TabIndex = 2;
            label1.Text = "EJERCICIO 2-USANDO ENTITY FRAMEWORK";
            // 
            // frmPrincipalEF
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 595);
            Controls.Add(label1);
            Controls.Add(btnCreditRisks);
            Controls.Add(btnCustomers);
            Name = "frmPrincipalEF";
            Text = "frmPrincipalEF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCustomers;
        private Button btnCreditRisks;
        private Label label1;
    }
}