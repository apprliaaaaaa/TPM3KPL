namespace TPM3KPL
{
    partial class Form1
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
            txtinput = new TextBox();
            btnSubmit = new Button();
            label1 = new Label();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // txtinput
            // 
            txtinput.BackColor = SystemColors.Info;
            txtinput.Location = new Point(169, 121);
            txtinput.Name = "txtinput";
            txtinput.Size = new Size(182, 23);
            txtinput.TabIndex = 0;
            txtinput.Text = "INPUT";
            txtinput.SizeChanged += label2_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(255, 224, 192);
            btnSubmit.Location = new Point(375, 117);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(157, 29);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 171);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.BackColor = Color.FromArgb(255, 224, 192);
            lblOutput.Location = new Point(169, 171);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(51, 15);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "OUTPUT";
            lblOutput.AutoSizeChanged += label2_Click;
            lblOutput.Click += Form1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(txtinput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtinput;
        private Button btnSubmit;
        private Label label1;
        private Label lblOutput;
    }
}
