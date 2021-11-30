
namespace ProjetMemoire
{
    partial class frmExerciceMem
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExercices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExercices
            // 
            this.btnExercices.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercices.Location = new System.Drawing.Point(51, 67);
            this.btnExercices.Name = "btnExercices";
            this.btnExercices.Size = new System.Drawing.Size(334, 210);
            this.btnExercices.TabIndex = 0;
            this.btnExercices.Text = "Exercices donnés en mémoire";
            this.btnExercices.UseVisualStyleBackColor = true;
            this.btnExercices.Click += new System.EventHandler(this.btnExercices_Click);
            // 
            // frmExerciceMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 334);
            this.Controls.Add(this.btnExercices);
            this.Name = "frmExerciceMem";
            this.Text = "frmExerciceMem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExercices;
    }
}

