namespace BasicImageProcessing
{
    partial class ImageSubtractionForm
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
            pictureBoxImageSubject = new PictureBox();
            pictureBoxImageBackground = new PictureBox();
            pictureBoxImageResult = new PictureBox();
            menuStrip1 = new MenuStrip();
            goBackToolStripMenuItem = new ToolStripMenuItem();
            buttonLoadImage = new Button();
            buttonLoadBackground = new Button();
            buttonApplySubtraction = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageResult).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxImageA
            // 
            pictureBoxImageSubject.BackColor = SystemColors.ActiveCaption;
            pictureBoxImageSubject.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImageSubject.Location = new Point(12, 22);
            pictureBoxImageSubject.Name = "pictureBoxImageA";
            pictureBoxImageSubject.Size = new Size(333, 333);
            pictureBoxImageSubject.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImageSubject.TabIndex = 0;
            pictureBoxImageSubject.TabStop = false;
            // 
            // pictureBoxImageB
            // 
            pictureBoxImageBackground.BackColor = SystemColors.ActiveBorder;
            pictureBoxImageBackground.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImageBackground.Location = new Point(372, 22);
            pictureBoxImageBackground.Name = "pictureBoxImageB";
            pictureBoxImageBackground.Size = new Size(323, 333);
            pictureBoxImageBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImageBackground.TabIndex = 1;
            pictureBoxImageBackground.TabStop = false;
            // 
            // pictureBoxImageC
            // 
            pictureBoxImageResult.BackColor = SystemColors.ScrollBar;
            pictureBoxImageResult.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImageResult.Location = new Point(722, 22);
            pictureBoxImageResult.Name = "pictureBoxImageC";
            pictureBoxImageResult.Size = new Size(333, 333);
            pictureBoxImageResult.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImageResult.TabIndex = 2;
            pictureBoxImageResult.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { goBackToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1064, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // goBackToolStripMenuItem
            // 
            goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            goBackToolStripMenuItem.Size = new Size(62, 20);
            goBackToolStripMenuItem.Text = "Go Back";
            goBackToolStripMenuItem.Click += goBackToolStripMenuItem_Click;
            // 
            // buttonLoadImage
            // 
            buttonLoadImage.Location = new Point(95, 378);
            buttonLoadImage.Name = "buttonLoadImage";
            buttonLoadImage.Size = new Size(136, 41);
            buttonLoadImage.TabIndex = 4;
            buttonLoadImage.Text = "Load Image";
            buttonLoadImage.UseVisualStyleBackColor = true;
            buttonLoadImage.Click += buttonLoadImage_Click;
            // 
            // buttonLoadBackground
            // 
            buttonLoadBackground.Location = new Point(460, 377);
            buttonLoadBackground.Name = "buttonLoadBackground";
            buttonLoadBackground.Size = new Size(141, 43);
            buttonLoadBackground.TabIndex = 5;
            buttonLoadBackground.Text = "Load Background";
            buttonLoadBackground.UseVisualStyleBackColor = true;
            buttonLoadBackground.Click += buttonLoadBackground_Click;
            // 
            // buttonApplySubtraction
            // 
            buttonApplySubtraction.Location = new Point(831, 378);
            buttonApplySubtraction.Name = "buttonApplySubtraction";
            buttonApplySubtraction.Size = new Size(132, 41);
            buttonApplySubtraction.TabIndex = 6;
            buttonApplySubtraction.Text = "Apply Subtraction";
            buttonApplySubtraction.UseVisualStyleBackColor = true;
            buttonApplySubtraction.Click += buttonApplySubtraction_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // ImageSubtractionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 438);
            Controls.Add(buttonApplySubtraction);
            Controls.Add(buttonLoadBackground);
            Controls.Add(buttonLoadImage);
            Controls.Add(pictureBoxImageResult);
            Controls.Add(pictureBoxImageBackground);
            Controls.Add(pictureBoxImageSubject);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ImageSubtractionForm";
            Text = "Image Subtraction";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageResult).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImageSubject;
        private PictureBox pictureBoxImageBackground;
        private PictureBox pictureBoxImageResult;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem goBackToolStripMenuItem;
        private Button buttonLoadImage;
        private Button buttonLoadBackground;
        private Button buttonApplySubtraction;
        private OpenFileDialog openFileDialog;
    }
}