
namespace praktikumw7
{
    partial class FormQuiz
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
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.labelKalimat = new System.Windows.Forms.Label();
            this.labelHuruf = new System.Windows.Forms.Label();
            this.textBoxHuruf1 = new System.Windows.Forms.TextBox();
            this.labelHasil = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHuruf2 = new System.Windows.Forms.TextBox();
            this.labelHasilAkhir = new System.Windows.Forms.Label();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Location = new System.Drawing.Point(243, 43);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(337, 31);
            this.textBoxKalimat.TabIndex = 0;
            this.textBoxKalimat.TextChanged += new System.EventHandler(this.textBoxKalimat_TextChanged);
            // 
            // labelKalimat
            // 
            this.labelKalimat.AutoSize = true;
            this.labelKalimat.Location = new System.Drawing.Point(60, 46);
            this.labelKalimat.Name = "labelKalimat";
            this.labelKalimat.Size = new System.Drawing.Size(155, 25);
            this.labelKalimat.TabIndex = 1;
            this.labelKalimat.Text = "Masukkan Kalimat";
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(60, 102);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(142, 25);
            this.labelHuruf.TabIndex = 1;
            this.labelHuruf.Text = "Masukkan Huruf";
            // 
            // textBoxHuruf1
            // 
            this.textBoxHuruf1.Location = new System.Drawing.Point(243, 102);
            this.textBoxHuruf1.Name = "textBoxHuruf1";
            this.textBoxHuruf1.Size = new System.Drawing.Size(110, 31);
            this.textBoxHuruf1.TabIndex = 0;
            this.textBoxHuruf1.TextChanged += new System.EventHandler(this.textBoxHuruf1_TextChanged);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(60, 219);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(54, 25);
            this.labelHasil.TabIndex = 1;
            this.labelHasil.Text = "Hasil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Menjadi";
            // 
            // textBoxHuruf2
            // 
            this.textBoxHuruf2.Location = new System.Drawing.Point(470, 102);
            this.textBoxHuruf2.Name = "textBoxHuruf2";
            this.textBoxHuruf2.Size = new System.Drawing.Size(110, 31);
            this.textBoxHuruf2.TabIndex = 0;
            // 
            // labelHasilAkhir
            // 
            this.labelHasilAkhir.AutoSize = true;
            this.labelHasilAkhir.Location = new System.Drawing.Point(243, 219);
            this.labelHasilAkhir.Name = "labelHasilAkhir";
            this.labelHasilAkhir.Size = new System.Drawing.Size(0, 25);
            this.labelHasilAkhir.TabIndex = 1;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(243, 157);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(337, 39);
            this.buttonKonversi.TabIndex = 2;
            this.buttonKonversi.Text = "Konversi!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 307);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelHasilAkhir);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.textBoxHuruf2);
            this.Controls.Add(this.textBoxHuruf1);
            this.Controls.Add(this.labelKalimat);
            this.Controls.Add(this.textBoxKalimat);
            this.Name = "FormQuiz";
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKalimat;
        private System.Windows.Forms.Label labelKalimat;
        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.TextBox textBoxHuruf1;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHuruf2;
        private System.Windows.Forms.Label labelHasilAkhir;
        private System.Windows.Forms.Button buttonKonversi;
    }
}

