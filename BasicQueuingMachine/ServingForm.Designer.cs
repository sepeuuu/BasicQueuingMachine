namespace BasicQueuingMachine
{
    partial class ServingForm
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
            lblStatus = new Label();
            lblServing = new Label();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(27, 32);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(158, 30);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "* Now Serving";
            // 
            // lblServing
            // 
            lblServing.AutoSize = true;
            lblServing.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblServing.Location = new Point(74, 62);
            lblServing.Name = "lblServing";
            lblServing.Size = new Size(0, 65);
            lblServing.TabIndex = 9;
            // 
            // ServingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 163);
            Controls.Add(lblServing);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServingForm";
            Text = "ServingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        public Label lblServing;
    }
}