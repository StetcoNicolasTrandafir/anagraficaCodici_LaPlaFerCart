namespace sistemaPerRoxy
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            lblRis = new Label();
            lblError = new Label();
            txtCode = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 57);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Codice:";
            // 
            // lblRis
            // 
            lblRis.AutoSize = true;
            lblRis.Location = new Point(29, 137);
            lblRis.Name = "lblRis";
            lblRis.Size = new Size(0, 20);
            lblRis.TabIndex = 2;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(60, 9);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 3;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(306, 54);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(142, 27);
            txtCode.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(473, 52);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Cerca";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 510);
            Controls.Add(button1);
            Controls.Add(txtCode);
            Controls.Add(lblError);
            Controls.Add(lblRis);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "LaPlaFerCart";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label lblRis;
        private Label lblError;
        private TextBox txtCode;
        private Button button1;
    }
}
