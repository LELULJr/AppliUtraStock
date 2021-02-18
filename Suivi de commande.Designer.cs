
namespace AppliUtraStock
{
    partial class SuiviDeCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuiviDeCommande));
            this.Num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.Retour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Num
            // 
            this.Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num.Location = new System.Drawing.Point(229, 81);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(290, 22);
            this.Num.TabIndex = 0;
            this.Num.Text = "Numéro de suivi";
            this.Num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "veuillez renseigner le numéro de suivi de votre commande : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Valider
            // 
            this.Valider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Valider.Location = new System.Drawing.Point(301, 130);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(148, 28);
            this.Valider.TabIndex = 2;
            this.Valider.Text = "valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Retour
            // 
            this.Retour.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Retour.Location = new System.Drawing.Point(301, 392);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(148, 23);
            this.Retour.TabIndex = 3;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "suivi de commande";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "historique de commandes";
            // 
            // SuiviDeCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num);
            this.Name = "SuiviDeCommande";
            this.Text = "suivi de commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}