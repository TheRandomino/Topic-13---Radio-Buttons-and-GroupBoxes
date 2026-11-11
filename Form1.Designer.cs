namespace Topic_13___Radio_Buttons_and_GroupBoxes
{
    partial class Form1
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
            this.grpSaberColor = new System.Windows.Forms.GroupBox();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grpShip = new System.Windows.Forms.GroupBox();
            this.radTitanic = new System.Windows.Forms.RadioButton();
            this.radMilleniumFalcon = new System.Windows.Forms.RadioButton();
            this.radEnterprise = new System.Windows.Forms.RadioButton();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgSaber = new System.Windows.Forms.PictureBox();
            this.grpSaberColor.SuspendLayout();
            this.grpShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSaber)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSaberColor
            // 
            this.grpSaberColor.Controls.Add(this.radioBlue);
            this.grpSaberColor.Controls.Add(this.radGreen);
            this.grpSaberColor.Controls.Add(this.radRed);
            this.grpSaberColor.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaberColor.Location = new System.Drawing.Point(12, 12);
            this.grpSaberColor.Name = "grpSaberColor";
            this.grpSaberColor.Size = new System.Drawing.Size(126, 100);
            this.grpSaberColor.TabIndex = 0;
            this.grpSaberColor.TabStop = false;
            this.grpSaberColor.Text = "Choose a Saber color";
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(7, 66);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(58, 25);
            this.radioBlue.TabIndex = 2;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            this.radioBlue.CheckedChanged += new System.EventHandler(this.radBlueCheck);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(7, 43);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(67, 25);
            this.radGreen.TabIndex = 1;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreenCheck);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(7, 20);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(54, 25);
            this.radRed.TabIndex = 0;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRedCheck);
            // 
            // grpShip
            // 
            this.grpShip.Controls.Add(this.radTitanic);
            this.grpShip.Controls.Add(this.radMilleniumFalcon);
            this.grpShip.Controls.Add(this.radEnterprise);
            this.grpShip.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShip.Location = new System.Drawing.Point(12, 118);
            this.grpShip.Name = "grpShip";
            this.grpShip.Size = new System.Drawing.Size(225, 100);
            this.grpShip.TabIndex = 3;
            this.grpShip.TabStop = false;
            this.grpShip.Text = "What is the name of this ship?";
            // 
            // radTitanic
            // 
            this.radTitanic.AutoSize = true;
            this.radTitanic.Location = new System.Drawing.Point(7, 66);
            this.radTitanic.Name = "radTitanic";
            this.radTitanic.Size = new System.Drawing.Size(70, 25);
            this.radTitanic.TabIndex = 2;
            this.radTitanic.Text = "Titanic";
            this.radTitanic.UseVisualStyleBackColor = true;
            // 
            // radMilleniumFalcon
            // 
            this.radMilleniumFalcon.AutoSize = true;
            this.radMilleniumFalcon.Location = new System.Drawing.Point(7, 43);
            this.radMilleniumFalcon.Name = "radMilleniumFalcon";
            this.radMilleniumFalcon.Size = new System.Drawing.Size(127, 25);
            this.radMilleniumFalcon.TabIndex = 1;
            this.radMilleniumFalcon.Text = "Millenium Falcon";
            this.radMilleniumFalcon.UseVisualStyleBackColor = true;
            // 
            // radEnterprise
            // 
            this.radEnterprise.AutoSize = true;
            this.radEnterprise.Location = new System.Drawing.Point(7, 20);
            this.radEnterprise.Name = "radEnterprise";
            this.radEnterprise.Size = new System.Drawing.Size(122, 25);
            this.radEnterprise.TabIndex = 0;
            this.radEnterprise.Text = "The Enterprise";
            this.radEnterprise.UseVisualStyleBackColor = true;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(12, 225);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(225, 28);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Submit Answer";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(8, 256);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(59, 21);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Answer:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Topic_13___Radio_Buttons_and_GroupBoxes.Properties.Resources.enterprise;
            this.pictureBox1.Location = new System.Drawing.Point(244, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // imgSaber
            // 
            this.imgSaber.Location = new System.Drawing.Point(144, 12);
            this.imgSaber.Name = "imgSaber";
            this.imgSaber.Size = new System.Drawing.Size(346, 100);
            this.imgSaber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSaber.TabIndex = 1;
            this.imgSaber.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpShip);
            this.Controls.Add(this.imgSaber);
            this.Controls.Add(this.grpSaberColor);
            this.Name = "Form1";
            this.Text = "why is et even alled a raido buttom";
            this.grpSaberColor.ResumeLayout(false);
            this.grpSaberColor.PerformLayout();
            this.grpShip.ResumeLayout(false);
            this.grpShip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSaber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSaberColor;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.PictureBox imgSaber;
        private System.Windows.Forms.GroupBox grpShip;
        private System.Windows.Forms.RadioButton radTitanic;
        private System.Windows.Forms.RadioButton radMilleniumFalcon;
        private System.Windows.Forms.RadioButton radEnterprise;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblAnswer;
    }
}

