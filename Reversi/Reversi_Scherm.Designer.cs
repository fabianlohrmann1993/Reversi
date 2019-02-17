namespace Reversi
{
    partial class reversi_scherm
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
            this.nieuw_spel = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.panel_speelveld = new System.Windows.Forms.Panel();
            this.panel_score = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.label_Nrood = new System.Windows.Forms.Label();
            this.label_Nblauw = new System.Windows.Forms.Label();
            this.panel_score.SuspendLayout();
            this.SuspendLayout();
            // 
            // nieuw_spel
            // 
            this.nieuw_spel.Location = new System.Drawing.Point(542, 74);
            this.nieuw_spel.Name = "nieuw_spel";
            this.nieuw_spel.Size = new System.Drawing.Size(177, 32);
            this.nieuw_spel.TabIndex = 0;
            this.nieuw_spel.Text = "Nieuw Spel";
            this.nieuw_spel.UseVisualStyleBackColor = true;
            this.nieuw_spel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nieuw_spel_MouseClick);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(542, 126);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(177, 35);
            this.help.TabIndex = 1;
            this.help.Text = "Ik heb hulp nodig!";
            this.help.UseVisualStyleBackColor = true;
            this.help.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_MouseClick);
            // 
            // panel_speelveld
            // 
            this.panel_speelveld.Location = new System.Drawing.Point(57, 74);
            this.panel_speelveld.Name = "panel_speelveld";
            this.panel_speelveld.Size = new System.Drawing.Size(401, 401);
            this.panel_speelveld.TabIndex = 2;
            this.panel_speelveld.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_speelveld_Paint);
            this.panel_speelveld.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_speelveld_MouseClick);
            // 
            // panel_score
            // 
            this.panel_score.Controls.Add(this.label_Nblauw);
            this.panel_score.Controls.Add(this.label_Nrood);
            this.panel_score.Controls.Add(this.label_status);
            this.panel_score.Location = new System.Drawing.Point(542, 196);
            this.panel_score.Name = "panel_score";
            this.panel_score.Size = new System.Drawing.Size(177, 279);
            this.panel_score.TabIndex = 3;
            this.panel_score.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_score_Paint);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(57, 25);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(46, 17);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "label1";
            // 
            // label_Nrood
            // 
            this.label_Nrood.AutoSize = true;
            this.label_Nrood.Location = new System.Drawing.Point(80, 113);
            this.label_Nrood.Name = "label_Nrood";
            this.label_Nrood.Size = new System.Drawing.Size(46, 17);
            this.label_Nrood.TabIndex = 1;
            this.label_Nrood.Text = "label1";
            // 
            // label_Nblauw
            // 
            this.label_Nblauw.AutoSize = true;
            this.label_Nblauw.Location = new System.Drawing.Point(80, 172);
            this.label_Nblauw.Name = "label_Nblauw";
            this.label_Nblauw.Size = new System.Drawing.Size(46, 17);
            this.label_Nblauw.TabIndex = 2;
            this.label_Nblauw.Text = "label1";
            // 
            // reversi_scherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 539);
            this.Controls.Add(this.panel_score);
            this.Controls.Add(this.panel_speelveld);
            this.Controls.Add(this.help);
            this.Controls.Add(this.nieuw_spel);
            this.Name = "reversi_scherm";
            this.Text = "Form1";
            this.panel_score.ResumeLayout(false);
            this.panel_score.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nieuw_spel;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Panel panel_speelveld;
        private System.Windows.Forms.Panel panel_score;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_Nrood;
        private System.Windows.Forms.Label label_Nblauw;
    }
}