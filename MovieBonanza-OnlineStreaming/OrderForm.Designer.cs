namespace MovieBonanza_OnlineStreaming
{
    partial class OrderForm
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
            this.GroupBoxMovieSelected = new System.Windows.Forms.GroupBox();
            this.PictureBoxOrderForm = new System.Windows.Forms.PictureBox();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GroupBoxYourOrder = new System.Windows.Forms.GroupBox();
            this.CheckBoxDVD = new System.Windows.Forms.CheckBox();
            this.LabelGrandTotal = new System.Windows.Forms.Label();
            this.LabelSalesTax = new System.Windows.Forms.Label();
            this.LabelDVD = new System.Windows.Forms.Label();
            this.LabelSubTotal = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TextBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.TextBoxSalesTax = new System.Windows.Forms.TextBox();
            this.TextBoxSubTotal = new System.Windows.Forms.TextBox();
            this.TextBoxDVD = new System.Windows.Forms.TextBox();
            this.TextBoxCost = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonStream = new System.Windows.Forms.Button();
            this.MenuStripOrderForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxMovieSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOrderForm)).BeginInit();
            this.GroupBoxYourOrder.SuspendLayout();
            this.MenuStripOrderForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxMovieSelected
            // 
            this.GroupBoxMovieSelected.Controls.Add(this.PictureBoxOrderForm);
            this.GroupBoxMovieSelected.Controls.Add(this.LabelGenre);
            this.GroupBoxMovieSelected.Controls.Add(this.LabelTitle);
            this.GroupBoxMovieSelected.Controls.Add(this.textBox3);
            this.GroupBoxMovieSelected.Controls.Add(this.textBox1);
            this.GroupBoxMovieSelected.Location = new System.Drawing.Point(12, 24);
            this.GroupBoxMovieSelected.Name = "GroupBoxMovieSelected";
            this.GroupBoxMovieSelected.Size = new System.Drawing.Size(276, 384);
            this.GroupBoxMovieSelected.TabIndex = 0;
            this.GroupBoxMovieSelected.TabStop = false;
            this.GroupBoxMovieSelected.Text = "Movie Selected";
            // 
            // PictureBoxOrderForm
            // 
            this.PictureBoxOrderForm.Location = new System.Drawing.Point(20, 154);
            this.PictureBoxOrderForm.Name = "PictureBoxOrderForm";
            this.PictureBoxOrderForm.Size = new System.Drawing.Size(230, 217);
            this.PictureBoxOrderForm.TabIndex = 5;
            this.PictureBoxOrderForm.TabStop = false;
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Location = new System.Drawing.Point(16, 87);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(54, 20);
            this.LabelGenre.TabIndex = 4;
            this.LabelGenre.Text = "Genre";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(16, 29);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(38, 20);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "Title";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(20, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(230, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(20, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(230, 26);
            this.textBox1.TabIndex = 0;
            // 
            // GroupBoxYourOrder
            // 
            this.GroupBoxYourOrder.Controls.Add(this.CheckBoxDVD);
            this.GroupBoxYourOrder.Controls.Add(this.LabelGrandTotal);
            this.GroupBoxYourOrder.Controls.Add(this.LabelSalesTax);
            this.GroupBoxYourOrder.Controls.Add(this.LabelDVD);
            this.GroupBoxYourOrder.Controls.Add(this.LabelSubTotal);
            this.GroupBoxYourOrder.Controls.Add(this.LabelCost);
            this.GroupBoxYourOrder.Controls.Add(this.textBox8);
            this.GroupBoxYourOrder.Controls.Add(this.TextBoxGrandTotal);
            this.GroupBoxYourOrder.Controls.Add(this.TextBoxSalesTax);
            this.GroupBoxYourOrder.Controls.Add(this.TextBoxSubTotal);
            this.GroupBoxYourOrder.Controls.Add(this.TextBoxDVD);
            this.GroupBoxYourOrder.Controls.Add(this.TextBoxCost);
            this.GroupBoxYourOrder.Location = new System.Drawing.Point(310, 24);
            this.GroupBoxYourOrder.Name = "GroupBoxYourOrder";
            this.GroupBoxYourOrder.Size = new System.Drawing.Size(268, 288);
            this.GroupBoxYourOrder.TabIndex = 1;
            this.GroupBoxYourOrder.TabStop = false;
            this.GroupBoxYourOrder.Text = "Your Order";
            // 
            // CheckBoxDVD
            // 
            this.CheckBoxDVD.AutoSize = true;
            this.CheckBoxDVD.Location = new System.Drawing.Point(6, 258);
            this.CheckBoxDVD.Name = "CheckBoxDVD";
            this.CheckBoxDVD.Size = new System.Drawing.Size(175, 24);
            this.CheckBoxDVD.TabIndex = 11;
            this.CheckBoxDVD.Text = "Order the DVD (10$)";
            this.CheckBoxDVD.UseVisualStyleBackColor = true;
            this.CheckBoxDVD.CheckedChanged += new System.EventHandler(this.CheckBoxDVD_CheckedChanged);
            // 
            // LabelGrandTotal
            // 
            this.LabelGrandTotal.AutoSize = true;
            this.LabelGrandTotal.Location = new System.Drawing.Point(54, 219);
            this.LabelGrandTotal.Name = "LabelGrandTotal";
            this.LabelGrandTotal.Size = new System.Drawing.Size(93, 20);
            this.LabelGrandTotal.TabIndex = 10;
            this.LabelGrandTotal.Text = "Grand Total";
            // 
            // LabelSalesTax
            // 
            this.LabelSalesTax.AutoSize = true;
            this.LabelSalesTax.Location = new System.Drawing.Point(27, 184);
            this.LabelSalesTax.Name = "LabelSalesTax";
            this.LabelSalesTax.Size = new System.Drawing.Size(120, 20);
            this.LabelSalesTax.TabIndex = 9;
            this.LabelSalesTax.Text = "Sales Tax(13%)";
            // 
            // LabelDVD
            // 
            this.LabelDVD.AutoSize = true;
            this.LabelDVD.Location = new System.Drawing.Point(103, 87);
            this.LabelDVD.Name = "LabelDVD";
            this.LabelDVD.Size = new System.Drawing.Size(44, 20);
            this.LabelDVD.TabIndex = 8;
            this.LabelDVD.Text = "DVD";
            this.LabelDVD.Visible = false;
            // 
            // LabelSubTotal
            // 
            this.LabelSubTotal.AutoSize = true;
            this.LabelSubTotal.Location = new System.Drawing.Point(77, 116);
            this.LabelSubTotal.Name = "LabelSubTotal";
            this.LabelSubTotal.Size = new System.Drawing.Size(73, 20);
            this.LabelSubTotal.TabIndex = 7;
            this.LabelSubTotal.Text = "SubTotal";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(105, 52);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(42, 20);
            this.LabelCost.TabIndex = 6;
            this.LabelCost.Text = "Cost";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Black;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(153, 158);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 10);
            this.textBox8.TabIndex = 5;
            // 
            // TextBoxGrandTotal
            // 
            this.TextBoxGrandTotal.BackColor = System.Drawing.Color.White;
            this.TextBoxGrandTotal.Location = new System.Drawing.Point(153, 216);
            this.TextBoxGrandTotal.Name = "TextBoxGrandTotal";
            this.TextBoxGrandTotal.ReadOnly = true;
            this.TextBoxGrandTotal.Size = new System.Drawing.Size(100, 26);
            this.TextBoxGrandTotal.TabIndex = 4;
            // 
            // TextBoxSalesTax
            // 
            this.TextBoxSalesTax.BackColor = System.Drawing.Color.White;
            this.TextBoxSalesTax.Location = new System.Drawing.Point(153, 184);
            this.TextBoxSalesTax.Name = "TextBoxSalesTax";
            this.TextBoxSalesTax.ReadOnly = true;
            this.TextBoxSalesTax.Size = new System.Drawing.Size(100, 26);
            this.TextBoxSalesTax.TabIndex = 3;
            // 
            // TextBoxSubTotal
            // 
            this.TextBoxSubTotal.BackColor = System.Drawing.Color.White;
            this.TextBoxSubTotal.Location = new System.Drawing.Point(153, 116);
            this.TextBoxSubTotal.Name = "TextBoxSubTotal";
            this.TextBoxSubTotal.ReadOnly = true;
            this.TextBoxSubTotal.Size = new System.Drawing.Size(100, 26);
            this.TextBoxSubTotal.TabIndex = 2;
            // 
            // TextBoxDVD
            // 
            this.TextBoxDVD.BackColor = System.Drawing.Color.White;
            this.TextBoxDVD.Location = new System.Drawing.Point(153, 84);
            this.TextBoxDVD.Name = "TextBoxDVD";
            this.TextBoxDVD.ReadOnly = true;
            this.TextBoxDVD.Size = new System.Drawing.Size(100, 26);
            this.TextBoxDVD.TabIndex = 1;
            this.TextBoxDVD.Text = "10.0$";
            this.TextBoxDVD.Visible = false;
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.BackColor = System.Drawing.Color.White;
            this.TextBoxCost.Location = new System.Drawing.Point(153, 52);
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.ReadOnly = true;
            this.TextBoxCost.Size = new System.Drawing.Size(100, 26);
            this.TextBoxCost.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(426, 366);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(79, 29);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(310, 366);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(79, 29);
            this.ButtonBack.TabIndex = 3;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonStream
            // 
            this.ButtonStream.Location = new System.Drawing.Point(511, 366);
            this.ButtonStream.Name = "ButtonStream";
            this.ButtonStream.Size = new System.Drawing.Size(79, 29);
            this.ButtonStream.TabIndex = 4;
            this.ButtonStream.Text = "Stream";
            this.ButtonStream.UseVisualStyleBackColor = true;
            this.ButtonStream.Click += new System.EventHandler(this.ButtonStream_Click);
            // 
            // MenuStripOrderForm
            // 
            this.MenuStripOrderForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStripOrderForm.Location = new System.Drawing.Point(0, 0);
            this.MenuStripOrderForm.Name = "MenuStripOrderForm";
            this.MenuStripOrderForm.Size = new System.Drawing.Size(602, 24);
            this.MenuStripOrderForm.TabIndex = 5;
            this.MenuStripOrderForm.Text = "Order Form";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripCancel,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuStripCancel
            // 
            this.MenuStripCancel.Name = "MenuStripCancel";
            this.MenuStripCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MenuStripCancel.Size = new System.Drawing.Size(151, 22);
            this.MenuStripCancel.Text = "Print";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.streamToolStripMenuItem.Text = "Stream";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.ButtonStream_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 420);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonStream);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.GroupBoxYourOrder);
            this.Controls.Add(this.GroupBoxMovieSelected);
            this.Controls.Add(this.MenuStripOrderForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuStripOrderForm;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.GroupBoxMovieSelected.ResumeLayout(false);
            this.GroupBoxMovieSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOrderForm)).EndInit();
            this.GroupBoxYourOrder.ResumeLayout(false);
            this.GroupBoxYourOrder.PerformLayout();
            this.MenuStripOrderForm.ResumeLayout(false);
            this.MenuStripOrderForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxMovieSelected;
        private System.Windows.Forms.PictureBox PictureBoxOrderForm;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox GroupBoxYourOrder;
        private System.Windows.Forms.CheckBox CheckBoxDVD;
        private System.Windows.Forms.Label LabelGrandTotal;
        private System.Windows.Forms.Label LabelSalesTax;
        private System.Windows.Forms.Label LabelDVD;
        private System.Windows.Forms.Label LabelSubTotal;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox TextBoxGrandTotal;
        private System.Windows.Forms.TextBox TextBoxSalesTax;
        private System.Windows.Forms.TextBox TextBoxSubTotal;
        private System.Windows.Forms.TextBox TextBoxDVD;
        private System.Windows.Forms.TextBox TextBoxCost;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonStream;
        private System.Windows.Forms.MenuStrip MenuStripOrderForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStripCancel;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}