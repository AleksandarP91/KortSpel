namespace KortSpel
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
            this.Sort = new System.Windows.Forms.Button();
            this.Mix = new System.Windows.Forms.Button();
            this.card = new System.Windows.Forms.PictureBox();
            this.deck = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deck)).BeginInit();
            this.SuspendLayout();
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(147, 285);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 23);
            this.Sort.TabIndex = 1;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Mix
            // 
            this.Mix.Location = new System.Drawing.Point(321, 285);
            this.Mix.Name = "Mix";
            this.Mix.Size = new System.Drawing.Size(75, 23);
            this.Mix.TabIndex = 2;
            this.Mix.Text = "Mix";
            this.Mix.UseVisualStyleBackColor = true;
            this.Mix.Click += new System.EventHandler(this.Mix_Click);
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(527, 49);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(178, 180);
            this.card.TabIndex = 4;
            this.card.TabStop = false;
            // 
            // deck
            // 
            this.deck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deck.Image = ((System.Drawing.Image)(resources.GetObject("deck.Image")));
            this.deck.Location = new System.Drawing.Point(147, 49);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(249, 180);
            this.deck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deck.TabIndex = 3;
            this.deck.TabStop = false;
            this.deck.Click += new System.EventHandler(this.deck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click to Draw a Card!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(912, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.card);
            this.Controls.Add(this.deck);
            this.Controls.Add(this.Mix);
            this.Controls.Add(this.Sort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button Mix;
        private System.Windows.Forms.PictureBox deck;
        private System.Windows.Forms.PictureBox card;
        private System.Windows.Forms.Label label1;
    }
}

