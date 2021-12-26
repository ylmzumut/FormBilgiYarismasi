namespace Yazılım_yarisma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxSoru = new System.Windows.Forms.TextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonbasla = new System.Windows.Forms.Button();
            this.lbldogru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSoru
            // 
            this.textBoxSoru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSoru.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxSoru.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoru.Location = new System.Drawing.Point(216, 28);
            this.textBoxSoru.Multiline = true;
            this.textBoxSoru.Name = "textBoxSoru";
            this.textBoxSoru.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSoru.Size = new System.Drawing.Size(545, 196);
            this.textBoxSoru.TabIndex = 0;
            this.textBoxSoru.Text = "Bilgi Yarışmasına Hoşgeldiniz";
            this.textBoxSoru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSoru.UseWaitCursor = true;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.LightCyan;
            this.buttonA.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonA.Location = new System.Drawing.Point(216, 254);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(253, 89);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.LightCyan;
            this.buttonC.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonC.Location = new System.Drawing.Point(216, 373);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(253, 89);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.LightCyan;
            this.buttonB.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonB.Location = new System.Drawing.Point(508, 254);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(253, 89);
            this.buttonB.TabIndex = 3;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.LightCyan;
            this.buttonD.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonD.Location = new System.Drawing.Point(508, 373);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(253, 89);
            this.buttonD.TabIndex = 4;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonbasla
            // 
            this.buttonbasla.BackColor = System.Drawing.Color.Gold;
            this.buttonbasla.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonbasla.FlatAppearance.BorderSize = 0;
            this.buttonbasla.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonbasla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonbasla.Location = new System.Drawing.Point(791, 205);
            this.buttonbasla.Name = "buttonbasla";
            this.buttonbasla.Size = new System.Drawing.Size(169, 92);
            this.buttonbasla.TabIndex = 5;
            this.buttonbasla.Text = "Başla";
            this.buttonbasla.UseVisualStyleBackColor = false;
            this.buttonbasla.Click += new System.EventHandler(this.buttonbasla_Click);
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Location = new System.Drawing.Point(840, 79);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(59, 17);
            this.lbldogru.TabIndex = 6;
            this.lbldogru.Text = "lbldogru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(988, 505);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.buttonbasla);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.textBoxSoru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSoru;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonbasla;
        private System.Windows.Forms.Label lbldogru;
    }
}

