namespace Pokedex
{
    partial class Pokedex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokedex));
            ResultsWindow = new ListBox();
            SearchBox = new TextBox();
            pictureBox1 = new PictureBox();
            Clear = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ResultsWindow
            // 
            ResultsWindow.FormattingEnabled = true;
            ResultsWindow.ItemHeight = 50;
            ResultsWindow.Location = new Point(723, 41);
            ResultsWindow.Margin = new Padding(5);
            ResultsWindow.Name = "ResultsWindow";
            ResultsWindow.Size = new Size(613, 554);
            ResultsWindow.TabIndex = 3;
            ResultsWindow.DoubleClick += ResultsWindow_DoubleClick;
            // 
            // SearchBox
            // 
            SearchBox.BorderStyle = BorderStyle.None;
            SearchBox.Location = new Point(102, 41);
            SearchBox.Margin = new Padding(5);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(557, 50);
            SearchBox.TabIndex = 4;
            SearchBox.Text = "  Search";
            SearchBox.Click += SearchBox_Click;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 41);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Clear
            // 
            Clear.AutoSize = true;
            Clear.BackColor = Color.White;
            Clear.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Location = new Point(610, 41);
            Clear.Margin = new Padding(5, 0, 5, 0);
            Clear.Name = "Clear";
            Clear.Size = new Size(43, 51);
            Clear.TabIndex = 6;
            Clear.Text = "x";
            Clear.TextAlign = ContentAlignment.MiddleCenter;
            Clear.Click += clear_Click;
            // 
            // Pokedex
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 140);
            Controls.Add(Clear);
            Controls.Add(pictureBox1);
            Controls.Add(SearchBox);
            Controls.Add(ResultsWindow);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Pokedex";
            Text = "Pokedex";
            Load += Pokedex_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox ResultsWindow;
        private TextBox SearchBox;
        private PictureBox pictureBox1;
        private Label Clear;
    }
}
