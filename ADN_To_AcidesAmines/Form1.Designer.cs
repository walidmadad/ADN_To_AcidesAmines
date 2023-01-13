namespace ADN_To_AcidesAmines
{
    partial class ADN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADN));
            this.adn1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.arn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.convert_adn = new System.Windows.Forms.Button();
            this.convert_arn = new System.Windows.Forms.Button();
            this.convertir_acides = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.adn_ntr = new System.Windows.Forms.TextBox();
            this.adn_tr = new System.Windows.Forms.TextBox();
            this.arn_m = new System.Windows.Forms.TextBox();
            this.acides = new System.Windows.Forms.TextBox();
            this.erreur_adn_tr = new System.Windows.Forms.Label();
            this.erreur_adn_ntr = new System.Windows.Forms.Label();
            this.erreur_arn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adn1
            // 
            this.adn1.AutoSize = true;
            this.adn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adn1.Location = new System.Drawing.Point(13, 36);
            this.adn1.Name = "adn1";
            this.adn1.Size = new System.Drawing.Size(58, 22);
            this.adn1.TabIndex = 0;
            this.adn1.Text = "ADN :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADN :";
            // 
            // arn
            // 
            this.arn.AutoSize = true;
            this.arn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arn.Location = new System.Drawing.Point(13, 265);
            this.arn.Name = "arn";
            this.arn.Size = new System.Drawing.Size(72, 22);
            this.arn.TabIndex = 2;
            this.arn.Text = "ARNm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Non-Transcrit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transcrit";
            // 
            // convert_adn
            // 
            this.convert_adn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convert_adn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_adn.Location = new System.Drawing.Point(121, 96);
            this.convert_adn.Name = "convert_adn";
            this.convert_adn.Size = new System.Drawing.Size(300, 40);
            this.convert_adn.TabIndex = 5;
            this.convert_adn.Text = "Convert To ADN-Transcrit";
            this.convert_adn.UseVisualStyleBackColor = false;
            this.convert_adn.Click += new System.EventHandler(this.convert_adn_Click);
            // 
            // convert_arn
            // 
            this.convert_arn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_arn.Location = new System.Drawing.Point(176, 215);
            this.convert_arn.Name = "convert_arn";
            this.convert_arn.Size = new System.Drawing.Size(180, 40);
            this.convert_arn.TabIndex = 6;
            this.convert_arn.Text = "Convert To ARNm";
            this.convert_arn.UseVisualStyleBackColor = true;
            this.convert_arn.Click += new System.EventHandler(this.convert_arn_Click);
            // 
            // convertir_acides
            // 
            this.convertir_acides.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertir_acides.Location = new System.Drawing.Point(121, 333);
            this.convertir_acides.Name = "convertir_acides";
            this.convertir_acides.Size = new System.Drawing.Size(300, 40);
            this.convertir_acides.TabIndex = 7;
            this.convertir_acides.Text = "Séquence des acides aminés";
            this.convertir_acides.UseVisualStyleBackColor = true;
            this.convertir_acides.Click += new System.EventHandler(this.convert_acides_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(195, 452);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(150, 40);
            this.reset.TabIndex = 8;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // adn_ntr
            // 
            this.adn_ntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adn_ntr.Location = new System.Drawing.Point(92, 33);
            this.adn_ntr.Name = "adn_ntr";
            this.adn_ntr.Size = new System.Drawing.Size(350, 28);
            this.adn_ntr.TabIndex = 9;
            // 
            // adn_tr
            // 
            this.adn_tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adn_tr.Location = new System.Drawing.Point(92, 157);
            this.adn_tr.Name = "adn_tr";
            this.adn_tr.Size = new System.Drawing.Size(350, 28);
            this.adn_tr.TabIndex = 10;
            // 
            // arn_m
            // 
            this.arn_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arn_m.Location = new System.Drawing.Point(92, 262);
            this.arn_m.Name = "arn_m";
            this.arn_m.Size = new System.Drawing.Size(350, 28);
            this.arn_m.TabIndex = 11;
            // 
            // acides
            // 
            this.acides.Enabled = false;
            this.acides.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acides.Location = new System.Drawing.Point(27, 404);
            this.acides.Name = "acides";
            this.acides.Size = new System.Drawing.Size(464, 28);
            this.acides.TabIndex = 12;
            // 
            // erreur_adn_tr
            // 
            this.erreur_adn_tr.AutoSize = true;
            this.erreur_adn_tr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.erreur_adn_tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreur_adn_tr.ForeColor = System.Drawing.Color.White;
            this.erreur_adn_tr.Location = new System.Drawing.Point(104, 193);
            this.erreur_adn_tr.Name = "erreur_adn_tr";
            this.erreur_adn_tr.Size = new System.Drawing.Size(0, 18);
            this.erreur_adn_tr.TabIndex = 13;
            this.erreur_adn_tr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // erreur_adn_ntr
            // 
            this.erreur_adn_ntr.AutoSize = true;
            this.erreur_adn_ntr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.erreur_adn_ntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreur_adn_ntr.ForeColor = System.Drawing.Color.White;
            this.erreur_adn_ntr.Location = new System.Drawing.Point(104, 70);
            this.erreur_adn_ntr.Name = "erreur_adn_ntr";
            this.erreur_adn_ntr.Size = new System.Drawing.Size(0, 18);
            this.erreur_adn_ntr.TabIndex = 14;
            this.erreur_adn_ntr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // erreur_arn
            // 
            this.erreur_arn.AutoSize = true;
            this.erreur_arn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.erreur_arn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreur_arn.ForeColor = System.Drawing.Color.White;
            this.erreur_arn.Location = new System.Drawing.Point(104, 304);
            this.erreur_arn.Name = "erreur_arn";
            this.erreur_arn.Size = new System.Drawing.Size(0, 18);
            this.erreur_arn.TabIndex = 15;
            this.erreur_arn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ADN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADN_To_AcidesAmines.Properties.Resources.adn;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.erreur_arn);
            this.Controls.Add(this.erreur_adn_ntr);
            this.Controls.Add(this.erreur_adn_tr);
            this.Controls.Add(this.acides);
            this.Controls.Add(this.arn_m);
            this.Controls.Add(this.adn_tr);
            this.Controls.Add(this.adn_ntr);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.convertir_acides);
            this.Controls.Add(this.convert_arn);
            this.Controls.Add(this.convert_adn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADN";
            this.Text = "ADN_To_AcidesAminés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label arn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button convert_adn;
        private System.Windows.Forms.Button convert_arn;
        private System.Windows.Forms.Button convertir_acides;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox adn_ntr;
        private System.Windows.Forms.TextBox adn_tr;
        private System.Windows.Forms.TextBox arn_m;
        private System.Windows.Forms.TextBox acides;
        private System.Windows.Forms.Label erreur_adn_tr;
        private System.Windows.Forms.Label erreur_adn_ntr;
        private System.Windows.Forms.Label erreur_arn;
    }

}

