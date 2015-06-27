namespace happnFBidExtractor
{
    partial class happnFBidExtractor
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
            this.rtbInputText = new System.Windows.Forms.RichTextBox();
            this.rtbOutputText = new System.Windows.Forms.RichTextBox();
            this.btnExtractor = new System.Windows.Forms.Button();
            this.rtbOutputTextNames = new System.Windows.Forms.RichTextBox();
            this.rtbFinalOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbInputText
            // 
            this.rtbInputText.Location = new System.Drawing.Point(12, 29);
            this.rtbInputText.Name = "rtbInputText";
            this.rtbInputText.Size = new System.Drawing.Size(461, 394);
            this.rtbInputText.TabIndex = 0;
            this.rtbInputText.Text = "";
            // 
            // rtbOutputText
            // 
            this.rtbOutputText.Location = new System.Drawing.Point(630, 29);
            this.rtbOutputText.Name = "rtbOutputText";
            this.rtbOutputText.Size = new System.Drawing.Size(214, 201);
            this.rtbOutputText.TabIndex = 1;
            this.rtbOutputText.Text = "";
            // 
            // btnExtractor
            // 
            this.btnExtractor.Location = new System.Drawing.Point(498, 193);
            this.btnExtractor.Name = "btnExtractor";
            this.btnExtractor.Size = new System.Drawing.Size(105, 71);
            this.btnExtractor.TabIndex = 2;
            this.btnExtractor.Text = "Extract !";
            this.btnExtractor.UseVisualStyleBackColor = true;
            this.btnExtractor.Click += new System.EventHandler(this.btnExtractor_Click);
            // 
            // rtbOutputTextNames
            // 
            this.rtbOutputTextNames.Location = new System.Drawing.Point(859, 29);
            this.rtbOutputTextNames.Name = "rtbOutputTextNames";
            this.rtbOutputTextNames.Size = new System.Drawing.Size(214, 201);
            this.rtbOutputTextNames.TabIndex = 3;
            this.rtbOutputTextNames.Text = "";
            // 
            // rtbFinalOutput
            // 
            this.rtbFinalOutput.Location = new System.Drawing.Point(630, 236);
            this.rtbFinalOutput.Name = "rtbFinalOutput";
            this.rtbFinalOutput.Size = new System.Drawing.Size(443, 201);
            this.rtbFinalOutput.TabIndex = 4;
            this.rtbFinalOutput.Text = "";
            // 
            // happnFBidExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 435);
            this.Controls.Add(this.rtbFinalOutput);
            this.Controls.Add(this.rtbOutputTextNames);
            this.Controls.Add(this.btnExtractor);
            this.Controls.Add(this.rtbOutputText);
            this.Controls.Add(this.rtbInputText);
            this.Name = "happnFBidExtractor";
            this.Text = "Happn Facebook ID Extractor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInputText;
        private System.Windows.Forms.RichTextBox rtbOutputText;
        private System.Windows.Forms.Button btnExtractor;
        private System.Windows.Forms.RichTextBox rtbOutputTextNames;
        private System.Windows.Forms.RichTextBox rtbFinalOutput;
    }
}

