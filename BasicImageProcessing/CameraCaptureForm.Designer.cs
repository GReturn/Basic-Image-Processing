namespace BasicImageProcessing
{
    partial class CameraCaptureForm
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
            components = new System.ComponentModel.Container();
            pictureBoxCameraDisplay = new PictureBox();
            menuStrip1 = new MenuStrip();
            goBackToolStripMenuItem = new ToolStripMenuItem();
            buttonCapture = new Button();
            timerCamera = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCameraDisplay).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCameraDisplay
            // 
            pictureBoxCameraDisplay.Location = new Point(18, 38);
            pictureBoxCameraDisplay.Name = "pictureBoxCameraDisplay";
            pictureBoxCameraDisplay.Size = new Size(356, 361);
            pictureBoxCameraDisplay.TabIndex = 0;
            pictureBoxCameraDisplay.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { goBackToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(391, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // goBackToolStripMenuItem
            // 
            goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            goBackToolStripMenuItem.Size = new Size(62, 20);
            goBackToolStripMenuItem.Text = "Go Back";
            goBackToolStripMenuItem.Click += goBackToolStripMenuItem_Click;
            // 
            // buttonCapture
            // 
            buttonCapture.Location = new Point(135, 432);
            buttonCapture.Name = "buttonCapture";
            buttonCapture.Size = new Size(120, 65);
            buttonCapture.TabIndex = 2;
            buttonCapture.Text = "Capture";
            buttonCapture.UseVisualStyleBackColor = true;
            buttonCapture.Click += buttonCapture_Click;
            // 
            // CameraCaptureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 525);
            Controls.Add(buttonCapture);
            Controls.Add(pictureBoxCameraDisplay);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CameraCaptureForm";
            Text = "CameraCaptureForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCameraDisplay).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCameraDisplay;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem goBackToolStripMenuItem;
        private Button buttonCapture;
        private System.Windows.Forms.Timer timerCamera;
    }
}