namespace Hekzawind_Prototip
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
            txtNuten = new TextBox();
            txtPole = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtNuten
            // 
            txtNuten.Location = new Point(227, 137);
            txtNuten.Name = "txtNuten";
            txtNuten.Size = new Size(125, 27);
            txtNuten.TabIndex = 0;
            txtNuten.TextChanged += txtNuten_TextChanged;
            // 
            // txtPole
            // 
            txtPole.Location = new Point(412, 138);
            txtPole.Name = "txtPole";
            txtPole.Size = new Size(125, 27);
            txtPole.TabIndex = 1;
            txtPole.TextChanged += txtPole_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(331, 203);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(349, 281);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(173, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "Sonuç burada görünecek";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtPole);
            Controls.Add(txtNuten);
            Name = "Form1";
            Text = "Hekzawind";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNuten;
        private System.Windows.Forms.TextBox txtPole;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}
