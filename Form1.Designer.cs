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
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.imgSaber = new System.Windows.Forms.PictureBox();
            this.grpSaberColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSaber)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSaberColor
            // 
            this.grpSaberColor.Controls.Add(this.radioBlue);
            this.grpSaberColor.Controls.Add(this.radGreen);
            this.grpSaberColor.Controls.Add(this.radRed);
            this.grpSaberColor.Location = new System.Drawing.Point(12, 12);
            this.grpSaberColor.Name = "grpSaberColor";
            this.grpSaberColor.Size = new System.Drawing.Size(200, 100);
            this.grpSaberColor.TabIndex = 0;
            this.grpSaberColor.TabStop = false;
            this.grpSaberColor.Text = "Choose a Lightsaber color";
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(7, 20);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRedCheck);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(7, 43);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreenCheck);
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(7, 66);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(46, 17);
            this.radioBlue.TabIndex = 2;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            this.radioBlue.CheckedChanged += new System.EventHandler(this.radBlueCheck);
            // 
            // imgSaber
            // 
            this.imgSaber.Location = new System.Drawing.Point(218, 12);
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
            this.Controls.Add(this.imgSaber);
            this.Controls.Add(this.grpSaberColor);
            this.Name = "Form1";
            this.Text = "why is et even alled a raido buttom";
            this.grpSaberColor.ResumeLayout(false);
            this.grpSaberColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSaber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSaberColor;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.PictureBox imgSaber;
    }
}

