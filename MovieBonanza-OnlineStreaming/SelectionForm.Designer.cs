namespace MovieBonanza_OnlineStreaming
{
    partial class SelectionForm
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
            this.ListBoxMovies = new System.Windows.Forms.ListBox();
            this.LabelMovies = new System.Windows.Forms.Label();
            this.GroupBoxSelection = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.GroupBoxSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxMovies
            // 
            this.ListBoxMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxMovies.FormattingEnabled = true;
            this.ListBoxMovies.ItemHeight = 20;
            this.ListBoxMovies.Location = new System.Drawing.Point(13, 72);
            this.ListBoxMovies.Name = "ListBoxMovies";
            this.ListBoxMovies.Size = new System.Drawing.Size(184, 284);
            this.ListBoxMovies.TabIndex = 0;
            // 
            // LabelMovies
            // 
            this.LabelMovies.AutoSize = true;
            this.LabelMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMovies.Location = new System.Drawing.Point(33, 49);
            this.LabelMovies.Name = "LabelMovies";
            this.LabelMovies.Size = new System.Drawing.Size(129, 20);
            this.LabelMovies.TabIndex = 1;
            this.LabelMovies.Text = "Current Movies";
            // 
            // GroupBoxSelection
            // 
            this.GroupBoxSelection.Controls.Add(this.LabelCost);
            this.GroupBoxSelection.Controls.Add(this.LabelGenre);
            this.GroupBoxSelection.Controls.Add(this.LabelTitle);
            this.GroupBoxSelection.Controls.Add(this.textBox3);
            this.GroupBoxSelection.Controls.Add(this.pictureBox1);
            this.GroupBoxSelection.Controls.Add(this.textBox2);
            this.GroupBoxSelection.Controls.Add(this.textBox1);
            this.GroupBoxSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSelection.Location = new System.Drawing.Point(228, 72);
            this.GroupBoxSelection.Name = "GroupBoxSelection";
            this.GroupBoxSelection.Size = new System.Drawing.Size(538, 190);
            this.GroupBoxSelection.TabIndex = 2;
            this.GroupBoxSelection.TabStop = false;
            this.GroupBoxSelection.Text = "Your Selection";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(216, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(308, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(216, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(168, 26);
            this.textBox2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 148);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(413, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(111, 26);
            this.textBox3.TabIndex = 7;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(224, 31);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(43, 20);
            this.LabelTitle.TabIndex = 8;
            this.LabelTitle.Text = "Title";
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Location = new System.Drawing.Point(224, 109);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(59, 20);
            this.LabelGenre.TabIndex = 9;
            this.LabelGenre.Text = "Genre";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(437, 109);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(46, 20);
            this.LabelCost.TabIndex = 10;
            this.LabelCost.Text = "Cost";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBoxSelection);
            this.Controls.Add(this.LabelMovies);
            this.Controls.Add(this.ListBoxMovies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectionForm";
            this.Text = "Movie Bonanza";
            this.GroupBoxSelection.ResumeLayout(false);
            this.GroupBoxSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxMovies;
        private System.Windows.Forms.Label LabelMovies;
        private System.Windows.Forms.GroupBox GroupBoxSelection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

