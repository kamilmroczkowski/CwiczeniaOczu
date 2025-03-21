
namespace Cwieczenie1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownTime1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTime2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownTotalTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelTime = new System.Windows.Forms.Label();
            this.rbLiteryCyfry = new System.Windows.Forms.RadioButton();
            this.rbLitery = new System.Windows.Forms.RadioButton();
            this.rbCyfry = new System.Windows.Forms.RadioButton();
            this.rbRysunki = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbSylaby = new System.Windows.Forms.RadioButton();
            this.rb3Lw = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Location = new System.Drawing.Point(172, 12);
            this.numericUpDownFontSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(68, 26);
            this.numericUpDownFontSize.TabIndex = 0;
            this.numericUpDownFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numericUpDownFontSize.Leave += new System.EventHandler(this.numericUpDownFontSize_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wielkość czcionki:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(246, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Czas wyświetlania:";
            // 
            // numericUpDownTime1
            // 
            this.numericUpDownTime1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownTime1.Location = new System.Drawing.Point(410, 12);
            this.numericUpDownTime1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTime1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownTime1.Name = "numericUpDownTime1";
            this.numericUpDownTime1.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownTime1.TabIndex = 3;
            this.numericUpDownTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTime1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownTime1.Leave += new System.EventHandler(this.numericUpDownTime1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(516, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Czas zniknięcia:";
            // 
            // numericUpDownTime2
            // 
            this.numericUpDownTime2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownTime2.Location = new System.Drawing.Point(660, 12);
            this.numericUpDownTime2.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numericUpDownTime2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownTime2.Name = "numericUpDownTime2";
            this.numericUpDownTime2.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownTime2.TabIndex = 6;
            this.numericUpDownTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTime2.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownTime2.Leave += new System.EventHandler(this.numericUpDownTime2_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(766, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Czałkowity czas testu:";
            // 
            // numericUpDownTotalTime
            // 
            this.numericUpDownTotalTime.Location = new System.Drawing.Point(959, 12);
            this.numericUpDownTotalTime.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownTotalTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTotalTime.Name = "numericUpDownTotalTime";
            this.numericUpDownTotalTime.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownTotalTime.TabIndex = 9;
            this.numericUpDownTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTotalTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownTotalTime.Leave += new System.EventHandler(this.numericUpDownTotalTime_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1025, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "s";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1030, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelText
            // 
            this.labelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelText.Location = new System.Drawing.Point(12, 79);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(1030, 483);
            this.labelText.TabIndex = 12;
            this.labelText.Text = "Naciśnij start";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime.Location = new System.Drawing.Point(959, 46);
            this.labelTime.Margin = new System.Windows.Forms.Padding(5);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(81, 28);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "T";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbLiteryCyfry
            // 
            this.rbLiteryCyfry.AutoSize = true;
            this.rbLiteryCyfry.Location = new System.Drawing.Point(16, 48);
            this.rbLiteryCyfry.Name = "rbLiteryCyfry";
            this.rbLiteryCyfry.Size = new System.Drawing.Size(102, 24);
            this.rbLiteryCyfry.TabIndex = 14;
            this.rbLiteryCyfry.TabStop = true;
            this.rbLiteryCyfry.Text = "litery i cyfry";
            this.rbLiteryCyfry.UseVisualStyleBackColor = true;
            this.rbLiteryCyfry.CheckedChanged += new System.EventHandler(this.rbLiteryCyfry_CheckedChanged);
            // 
            // rbLitery
            // 
            this.rbLitery.AutoSize = true;
            this.rbLitery.Location = new System.Drawing.Point(124, 48);
            this.rbLitery.Name = "rbLitery";
            this.rbLitery.Size = new System.Drawing.Size(59, 24);
            this.rbLitery.TabIndex = 15;
            this.rbLitery.TabStop = true;
            this.rbLitery.Text = "litery";
            this.rbLitery.UseVisualStyleBackColor = true;
            this.rbLitery.CheckedChanged += new System.EventHandler(this.rbLitery_CheckedChanged);
            // 
            // rbCyfry
            // 
            this.rbCyfry.AutoSize = true;
            this.rbCyfry.Location = new System.Drawing.Point(189, 48);
            this.rbCyfry.Name = "rbCyfry";
            this.rbCyfry.Size = new System.Drawing.Size(59, 24);
            this.rbCyfry.TabIndex = 16;
            this.rbCyfry.TabStop = true;
            this.rbCyfry.Text = "cyfry";
            this.rbCyfry.UseVisualStyleBackColor = true;
            this.rbCyfry.CheckedChanged += new System.EventHandler(this.rbCyfry_CheckedChanged);
            // 
            // rbRysunki
            // 
            this.rbRysunki.AutoSize = true;
            this.rbRysunki.Location = new System.Drawing.Point(254, 48);
            this.rbRysunki.Name = "rbRysunki";
            this.rbRysunki.Size = new System.Drawing.Size(76, 24);
            this.rbRysunki.TabIndex = 17;
            this.rbRysunki.TabStop = true;
            this.rbRysunki.Text = "rysunki";
            this.rbRysunki.UseVisualStyleBackColor = true;
            this.rbRysunki.CheckedChanged += new System.EventHandler(this.rbRysunki_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1030, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // rbSylaby
            // 
            this.rbSylaby.AutoSize = true;
            this.rbSylaby.Location = new System.Drawing.Point(336, 48);
            this.rbSylaby.Name = "rbSylaby";
            this.rbSylaby.Size = new System.Drawing.Size(70, 24);
            this.rbSylaby.TabIndex = 19;
            this.rbSylaby.TabStop = true;
            this.rbSylaby.Text = "sylaby";
            this.rbSylaby.UseVisualStyleBackColor = true;
            this.rbSylaby.CheckedChanged += new System.EventHandler(this.rbSylaby_CheckedChanged);
            // 
            // rb3Lw
            // 
            this.rb3Lw.AutoSize = true;
            this.rb3Lw.Location = new System.Drawing.Point(418, 48);
            this.rb3Lw.Name = "rb3Lw";
            this.rb3Lw.Size = new System.Drawing.Size(145, 24);
            this.rb3Lw.TabIndex = 20;
            this.rb3Lw.TabStop = true;
            this.rb3Lw.Text = "3 literowe wyrazy";
            this.rb3Lw.UseVisualStyleBackColor = true;
            this.rb3Lw.CheckedChanged += new System.EventHandler(this.rb3Lw_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 616);
            this.Controls.Add(this.rb3Lw);
            this.Controls.Add(this.rbSylaby);
            this.Controls.Add(this.rbRysunki);
            this.Controls.Add(this.rbCyfry);
            this.Controls.Add(this.rbLitery);
            this.Controls.Add(this.rbLiteryCyfry);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownTotalTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownTime2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownTime1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownFontSize);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1070, 655);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ćwieczenie 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownTime1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownTime2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.RadioButton rbLiteryCyfry;
        private System.Windows.Forms.RadioButton rbLitery;
        private System.Windows.Forms.RadioButton rbCyfry;
        private System.Windows.Forms.RadioButton rbRysunki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbSylaby;
        private System.Windows.Forms.RadioButton rb3Lw;
    }
}

