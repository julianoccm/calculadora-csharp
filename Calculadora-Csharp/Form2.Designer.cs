namespace Calculadora_Csharp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.historico = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historico";
            // 
            // historico
            // 
            this.historico.BackColor = System.Drawing.Color.DarkGray;
            this.historico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historico.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.historico.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Bold);
            this.historico.ForeColor = System.Drawing.Color.Gray;
            this.historico.Location = new System.Drawing.Point(15, 49);
            this.historico.Multiline = true;
            this.historico.Name = "historico";
            this.historico.ReadOnly = true;
            this.historico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.historico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historico.Size = new System.Drawing.Size(240, 400);
            this.historico.TabIndex = 22;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::Calculadora_Csharp.Properties.Resources.cancel_24px;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(217, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 26);
            this.closeButton.TabIndex = 23;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(255, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.historico);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Historico de contas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox historico;
        private System.Windows.Forms.Button closeButton;
    }
}