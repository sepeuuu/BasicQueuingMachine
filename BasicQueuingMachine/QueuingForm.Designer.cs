namespace BasicQueuingMachine
{
    partial class QueuingForm
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
            btnCashier = new Button();
            lblQueue = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(194, 33);
            label2.Name = "label2";
            label2.Size = new Size(206, 32);
            label2.TabIndex = 6;
            label2.Text = "Position in Queue";
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCashier.Location = new Point(25, 33);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(145, 96);
            btnCashier.TabIndex = 4;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblQueue.Location = new Point(187, 65);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(220, 65);
            lblQueue.TabIndex = 8;
            lblQueue.Text = "P - 10001";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(25, 132);
            label3.Name = "label3";
            label3.Size = new Size(138, 17);
            label3.TabIndex = 9;
            label3.Text = "*Click to get a number";
            label3.Click += label3_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 178);
            Controls.Add(label3);
            Controls.Add(lblQueue);
            Controls.Add(label2);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "QueuingForm";
            Load += QueuingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button btnCashier;
        private Label lblQueue;
        private Label label3;
    }
}