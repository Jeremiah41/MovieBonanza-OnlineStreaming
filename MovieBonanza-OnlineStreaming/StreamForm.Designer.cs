namespace MovieBonanza_OnlineStreaming
{
    partial class StreamForm
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
            this.LabelThankYou = new System.Windows.Forms.Label();
            this.LabelCreditCard = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelYourMovie = new System.Windows.Forms.Label();
            this.LabelMovieMessage = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelThankYou
            // 
            this.LabelThankYou.AutoSize = true;
            this.LabelThankYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThankYou.Location = new System.Drawing.Point(12, 30);
            this.LabelThankYou.Name = "LabelThankYou";
            this.LabelThankYou.Size = new System.Drawing.Size(447, 25);
            this.LabelThankYou.TabIndex = 0;
            this.LabelThankYou.Text = "Thanks you for choosing Movie Bonanza!";
            // 
            // LabelCreditCard
            // 
            this.LabelCreditCard.AutoSize = true;
            this.LabelCreditCard.Location = new System.Drawing.Point(13, 88);
            this.LabelCreditCard.Name = "LabelCreditCard";
            this.LabelCreditCard.Size = new System.Drawing.Size(233, 20);
            this.LabelCreditCard.TabIndex = 1;
            this.LabelCreditCard.Text = "Your credit card will be charged:";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(266, 88);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(0, 20);
            this.LabelCost.TabIndex = 2;
            // 
            // LabelYourMovie
            // 
            this.LabelYourMovie.AutoSize = true;
            this.LabelYourMovie.Location = new System.Drawing.Point(50, 170);
            this.LabelYourMovie.Name = "LabelYourMovie";
            this.LabelYourMovie.Size = new System.Drawing.Size(0, 20);
            this.LabelYourMovie.TabIndex = 3;
            // 
            // LabelMovieMessage
            // 
            this.LabelMovieMessage.AutoSize = true;
            this.LabelMovieMessage.Location = new System.Drawing.Point(206, 170);
            this.LabelMovieMessage.Name = "LabelMovieMessage";
            this.LabelMovieMessage.Size = new System.Drawing.Size(196, 20);
            this.LabelMovieMessage.TabIndex = 4;
            this.LabelMovieMessage.Text = "will begin streaming shortly";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(171, 202);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(95, 34);
            this.ButtonOk.TabIndex = 5;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 248);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.LabelMovieMessage);
            this.Controls.Add(this.LabelYourMovie);
            this.Controls.Add(this.LabelCost);
            this.Controls.Add(this.LabelCreditCard);
            this.Controls.Add(this.LabelThankYou);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelThankYou;
        private System.Windows.Forms.Label LabelCreditCard;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelYourMovie;
        private System.Windows.Forms.Label LabelMovieMessage;
        private System.Windows.Forms.Button ButtonOk;
    }
}