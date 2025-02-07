namespace Calculadora
{
    partial class Hsitorico_Calculadora
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
            label1 = new Label();
            label2 = new Label();
            rtbHistorico = new RichTextBox();
            btnLimparHistorico = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Historico";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-57, 29);
            label2.Name = "label2";
            label2.Size = new Size(453, 20);
            label2.TabIndex = 1;
            label2.Text = "--------------------------------------------------------------------------";
            // 
            // rtbHistorico
            // 
            rtbHistorico.Location = new Point(12, 52);
            rtbHistorico.Name = "rtbHistorico";
            rtbHistorico.Size = new Size(286, 328);
            rtbHistorico.TabIndex = 2;
            rtbHistorico.Text = "";
            rtbHistorico.TextChanged += rtbHistorico_TextChanged;
            // 
            // btnLimparHistorico
            // 
            btnLimparHistorico.Location = new Point(163, 5);
            btnLimparHistorico.Name = "btnLimparHistorico";
            btnLimparHistorico.Size = new Size(94, 29);
            btnLimparHistorico.TabIndex = 3;
            btnLimparHistorico.Text = "Limpar";
            btnLimparHistorico.UseVisualStyleBackColor = true;
            btnLimparHistorico.Click += btnLimparHistorico_Click;
            // 
            // Hsitorico_Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 392);
            Controls.Add(btnLimparHistorico);
            Controls.Add(rtbHistorico);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(328, 439);
            MinimumSize = new Size(328, 439);
            Name = "Hsitorico_Calculadora";
            Text = "Hsitorico_Calculadora";
            Load += Hsitorico_Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox rtbHistorico;
        private Button btnLimparHistorico;
    }
}