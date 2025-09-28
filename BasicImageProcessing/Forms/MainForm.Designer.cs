namespace BasicImageProcessing;

partial class MainForm
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
        menuStrip = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        addImageToolStripMenuItem = new ToolStripMenuItem();
        captureCameraPhotoToolStripMenuItem = new ToolStripMenuItem();
        saveProcessedImageToolStripMenuItem = new ToolStripMenuItem();
        clearImagePlaceholdersToolStripMenuItem = new ToolStripMenuItem();
        advancedImageProcessingToolStripMenuItem = new ToolStripMenuItem();
        imageSubtractionToolStripMenuItem = new ToolStripMenuItem();
        openFileDialog = new OpenFileDialog();
        pictureBoxOriginalImage = new PictureBox();
        labelControls = new Label();
        panel1 = new Panel();
        groupBoxConvolutionMatrix = new GroupBox();
        labelWeight = new Label();
        textBoxWeight = new TextBox();
        groupBoxAdvancedEmboss = new GroupBox();
        buttonVerticalOnly = new Button();
        buttonHorizontalOnly = new Button();
        buttonLossy = new Button();
        buttonAllDirections = new Button();
        buttonHorizontalVertical = new Button();
        buttonEmboss = new Button();
        buttonMeanRemoval = new Button();
        buttonSharpen = new Button();
        buttonGaussianBlur = new Button();
        buttonSmoothing = new Button();
        groupBoxContrast = new GroupBox();
        trackBarContrast = new TrackBar();
        groupBoxBrightness = new GroupBox();
        trackBarBrightness = new TrackBar();
        groupBoxBasicImageProcessing = new GroupBox();
        buttonSepia = new Button();
        buttonHistogram = new Button();
        buttonColorInversion = new Button();
        buttonGreyscale = new Button();
        buttonCopyImage = new Button();
        pictureBoxProcessedImage = new PictureBox();
        labelImageA = new Label();
        labelImageB = new Label();
        saveFileDialog = new SaveFileDialog();
        menuStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalImage).BeginInit();
        panel1.SuspendLayout();
        groupBoxConvolutionMatrix.SuspendLayout();
        groupBoxAdvancedEmboss.SuspendLayout();
        groupBoxContrast.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)trackBarContrast).BeginInit();
        groupBoxBrightness.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)trackBarBrightness).BeginInit();
        groupBoxBasicImageProcessing.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxProcessedImage).BeginInit();
        SuspendLayout();
        // 
        // menuStrip
        // 
        menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, advancedImageProcessingToolStripMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(1163, 24);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addImageToolStripMenuItem, captureCameraPhotoToolStripMenuItem, saveProcessedImageToolStripMenuItem, clearImagePlaceholdersToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(61, 20);
        fileToolStripMenuItem.Text = "Options";
        // 
        // addImageToolStripMenuItem
        // 
        addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
        addImageToolStripMenuItem.Size = new Size(207, 22);
        addImageToolStripMenuItem.Text = "Add Image";
        addImageToolStripMenuItem.Click += addImageToolStripMenuItem_Click;
        // 
        // captureCameraPhotoToolStripMenuItem
        // 
        captureCameraPhotoToolStripMenuItem.Name = "captureCameraPhotoToolStripMenuItem";
        captureCameraPhotoToolStripMenuItem.Size = new Size(207, 22);
        captureCameraPhotoToolStripMenuItem.Text = "Add Image - Use Camera";
        captureCameraPhotoToolStripMenuItem.Click += captureCameraPhotoToolStripMenuItem_Click;
        // 
        // saveProcessedImageToolStripMenuItem
        // 
        saveProcessedImageToolStripMenuItem.Name = "saveProcessedImageToolStripMenuItem";
        saveProcessedImageToolStripMenuItem.Size = new Size(207, 22);
        saveProcessedImageToolStripMenuItem.Text = "Save Processed Image";
        saveProcessedImageToolStripMenuItem.Click += saveProcessedImageToolStripMenuItem_Click;
        // 
        // clearImagePlaceholdersToolStripMenuItem
        // 
        clearImagePlaceholdersToolStripMenuItem.Name = "clearImagePlaceholdersToolStripMenuItem";
        clearImagePlaceholdersToolStripMenuItem.Size = new Size(207, 22);
        clearImagePlaceholdersToolStripMenuItem.Text = "Clear Image Placeholders";
        clearImagePlaceholdersToolStripMenuItem.Click += clearImagePlaceholdersToolStripMenuItem_Click;
        // 
        // advancedImageProcessingToolStripMenuItem
        // 
        advancedImageProcessingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageSubtractionToolStripMenuItem });
        advancedImageProcessingToolStripMenuItem.Name = "advancedImageProcessingToolStripMenuItem";
        advancedImageProcessingToolStripMenuItem.Size = new Size(168, 20);
        advancedImageProcessingToolStripMenuItem.Text = "Advanced Image Processing";
        // 
        // imageSubtractionToolStripMenuItem
        // 
        imageSubtractionToolStripMenuItem.Name = "imageSubtractionToolStripMenuItem";
        imageSubtractionToolStripMenuItem.Size = new Size(180, 22);
        imageSubtractionToolStripMenuItem.Text = "Image Subtraction";
        imageSubtractionToolStripMenuItem.Click += imageSubtractionToolStripMenuItem_Click;
        // 
        // openFileDialog
        // 
        openFileDialog.FileName = "openFileDialog1";
        // 
        // pictureBoxOriginalImage
        // 
        pictureBoxOriginalImage.BackColor = SystemColors.ActiveCaption;
        pictureBoxOriginalImage.Location = new Point(98, 51);
        pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
        pictureBoxOriginalImage.Size = new Size(410, 432);
        pictureBoxOriginalImage.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxOriginalImage.TabIndex = 1;
        pictureBoxOriginalImage.TabStop = false;
        // 
        // labelControls
        // 
        labelControls.Dock = DockStyle.Top;
        labelControls.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelControls.Location = new Point(0, 0);
        labelControls.Name = "labelControls";
        labelControls.Size = new Size(1163, 23);
        labelControls.TabIndex = 0;
        labelControls.Text = "Control Panel";
        labelControls.TextAlign = ContentAlignment.TopCenter;
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.Control;
        panel1.Controls.Add(groupBoxConvolutionMatrix);
        panel1.Controls.Add(groupBoxContrast);
        panel1.Controls.Add(groupBoxBrightness);
        panel1.Controls.Add(groupBoxBasicImageProcessing);
        panel1.Controls.Add(labelControls);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 489);
        panel1.Name = "panel1";
        panel1.Size = new Size(1163, 232);
        panel1.TabIndex = 3;
        // 
        // groupBoxConvolutionMatrix
        // 
        groupBoxConvolutionMatrix.Controls.Add(labelWeight);
        groupBoxConvolutionMatrix.Controls.Add(textBoxWeight);
        groupBoxConvolutionMatrix.Controls.Add(groupBoxAdvancedEmboss);
        groupBoxConvolutionMatrix.Controls.Add(buttonEmboss);
        groupBoxConvolutionMatrix.Controls.Add(buttonMeanRemoval);
        groupBoxConvolutionMatrix.Controls.Add(buttonSharpen);
        groupBoxConvolutionMatrix.Controls.Add(buttonGaussianBlur);
        groupBoxConvolutionMatrix.Controls.Add(buttonSmoothing);
        groupBoxConvolutionMatrix.Location = new Point(219, 29);
        groupBoxConvolutionMatrix.Name = "groupBoxConvolutionMatrix";
        groupBoxConvolutionMatrix.Size = new Size(529, 173);
        groupBoxConvolutionMatrix.TabIndex = 8;
        groupBoxConvolutionMatrix.TabStop = false;
        groupBoxConvolutionMatrix.Text = "Convolution Matrix";
        // 
        // labelWeight
        // 
        labelWeight.AutoSize = true;
        labelWeight.Location = new Point(361, 22);
        labelWeight.Name = "labelWeight";
        labelWeight.Size = new Size(48, 15);
        labelWeight.TabIndex = 7;
        labelWeight.Text = "Weight:";
        // 
        // textBoxWeight
        // 
        textBoxWeight.Location = new Point(413, 19);
        textBoxWeight.Name = "textBoxWeight";
        textBoxWeight.Size = new Size(100, 23);
        textBoxWeight.TabIndex = 6;
        // 
        // groupBoxAdvancedEmboss
        // 
        groupBoxAdvancedEmboss.Controls.Add(buttonVerticalOnly);
        groupBoxAdvancedEmboss.Controls.Add(buttonHorizontalOnly);
        groupBoxAdvancedEmboss.Controls.Add(buttonLossy);
        groupBoxAdvancedEmboss.Controls.Add(buttonAllDirections);
        groupBoxAdvancedEmboss.Controls.Add(buttonHorizontalVertical);
        groupBoxAdvancedEmboss.Location = new Point(197, 51);
        groupBoxAdvancedEmboss.Name = "groupBoxAdvancedEmboss";
        groupBoxAdvancedEmboss.Size = new Size(326, 116);
        groupBoxAdvancedEmboss.TabIndex = 5;
        groupBoxAdvancedEmboss.TabStop = false;
        groupBoxAdvancedEmboss.Text = "Advanced Emboss";
        // 
        // buttonVerticalOnly
        // 
        buttonVerticalOnly.Location = new Point(164, 58);
        buttonVerticalOnly.Name = "buttonVerticalOnly";
        buttonVerticalOnly.Size = new Size(152, 23);
        buttonVerticalOnly.TabIndex = 4;
        buttonVerticalOnly.Text = "Vertical Only";
        buttonVerticalOnly.UseVisualStyleBackColor = true;
        buttonVerticalOnly.Click += buttonVerticalOnly_Click;
        // 
        // buttonHorizontalOnly
        // 
        buttonHorizontalOnly.Location = new Point(164, 29);
        buttonHorizontalOnly.Name = "buttonHorizontalOnly";
        buttonHorizontalOnly.Size = new Size(152, 23);
        buttonHorizontalOnly.TabIndex = 3;
        buttonHorizontalOnly.Text = "Horizontal Only";
        buttonHorizontalOnly.UseVisualStyleBackColor = true;
        buttonHorizontalOnly.Click += buttonHorizontalOnly_Click;
        // 
        // buttonLossy
        // 
        buttonLossy.Location = new Point(6, 87);
        buttonLossy.Name = "buttonLossy";
        buttonLossy.Size = new Size(152, 23);
        buttonLossy.TabIndex = 2;
        buttonLossy.Text = "Lossy";
        buttonLossy.UseVisualStyleBackColor = true;
        buttonLossy.Click += buttonLossy_Click;
        // 
        // buttonAllDirections
        // 
        buttonAllDirections.Location = new Point(6, 58);
        buttonAllDirections.Name = "buttonAllDirections";
        buttonAllDirections.Size = new Size(152, 23);
        buttonAllDirections.TabIndex = 1;
        buttonAllDirections.Text = "All Directions";
        buttonAllDirections.UseVisualStyleBackColor = true;
        buttonAllDirections.Click += buttonAllDirections_Click;
        // 
        // buttonHorizontalVertical
        // 
        buttonHorizontalVertical.Location = new Point(6, 29);
        buttonHorizontalVertical.Name = "buttonHorizontalVertical";
        buttonHorizontalVertical.Size = new Size(152, 23);
        buttonHorizontalVertical.TabIndex = 0;
        buttonHorizontalVertical.Text = "Horizontal + Vertical";
        buttonHorizontalVertical.UseVisualStyleBackColor = true;
        buttonHorizontalVertical.Click += buttonHorizontalVertical_Click;
        // 
        // buttonEmboss
        // 
        buttonEmboss.Location = new Point(6, 138);
        buttonEmboss.Name = "buttonEmboss";
        buttonEmboss.Size = new Size(185, 23);
        buttonEmboss.TabIndex = 4;
        buttonEmboss.Text = "Emboss";
        buttonEmboss.UseVisualStyleBackColor = true;
        buttonEmboss.Click += buttonEmboss_Click;
        // 
        // buttonMeanRemoval
        // 
        buttonMeanRemoval.Location = new Point(6, 109);
        buttonMeanRemoval.Name = "buttonMeanRemoval";
        buttonMeanRemoval.Size = new Size(185, 23);
        buttonMeanRemoval.TabIndex = 3;
        buttonMeanRemoval.Text = "Mean Removal";
        buttonMeanRemoval.UseVisualStyleBackColor = true;
        buttonMeanRemoval.Click += buttonMeanRemoval_Click;
        // 
        // buttonSharpen
        // 
        buttonSharpen.Location = new Point(6, 80);
        buttonSharpen.Name = "buttonSharpen";
        buttonSharpen.Size = new Size(185, 23);
        buttonSharpen.TabIndex = 2;
        buttonSharpen.Text = "Sharpen";
        buttonSharpen.UseVisualStyleBackColor = true;
        buttonSharpen.Click += buttonSharpen_Click;
        // 
        // buttonGaussianBlur
        // 
        buttonGaussianBlur.Location = new Point(6, 51);
        buttonGaussianBlur.Name = "buttonGaussianBlur";
        buttonGaussianBlur.Size = new Size(185, 23);
        buttonGaussianBlur.TabIndex = 1;
        buttonGaussianBlur.Text = "Gaussian Blur";
        buttonGaussianBlur.UseVisualStyleBackColor = true;
        buttonGaussianBlur.Click += buttonGaussianBlur_Click;
        // 
        // buttonSmoothing
        // 
        buttonSmoothing.Location = new Point(6, 22);
        buttonSmoothing.Name = "buttonSmoothing";
        buttonSmoothing.Size = new Size(185, 23);
        buttonSmoothing.TabIndex = 0;
        buttonSmoothing.Text = "Smoothing";
        buttonSmoothing.UseVisualStyleBackColor = true;
        buttonSmoothing.Click += buttonSmoothing_Click;
        // 
        // groupBoxContrast
        // 
        groupBoxContrast.Controls.Add(trackBarContrast);
        groupBoxContrast.Location = new Point(845, 120);
        groupBoxContrast.Name = "groupBoxContrast";
        groupBoxContrast.Size = new Size(300, 82);
        groupBoxContrast.TabIndex = 7;
        groupBoxContrast.TabStop = false;
        groupBoxContrast.Text = "Contrast";
        // 
        // trackBarContrast
        // 
        trackBarContrast.Location = new Point(6, 22);
        trackBarContrast.Maximum = 50;
        trackBarContrast.Minimum = -50;
        trackBarContrast.Name = "trackBarContrast";
        trackBarContrast.Size = new Size(288, 45);
        trackBarContrast.TabIndex = 0;
        trackBarContrast.Scroll += trackBarContrast_Scroll;
        // 
        // groupBoxBrightness
        // 
        groupBoxBrightness.Controls.Add(trackBarBrightness);
        groupBoxBrightness.Location = new Point(851, 26);
        groupBoxBrightness.Name = "groupBoxBrightness";
        groupBoxBrightness.Size = new Size(300, 74);
        groupBoxBrightness.TabIndex = 6;
        groupBoxBrightness.TabStop = false;
        groupBoxBrightness.Text = "Brightness";
        // 
        // trackBarBrightness
        // 
        trackBarBrightness.Location = new Point(6, 22);
        trackBarBrightness.Maximum = 100;
        trackBarBrightness.Name = "trackBarBrightness";
        trackBarBrightness.Size = new Size(288, 45);
        trackBarBrightness.TabIndex = 5;
        trackBarBrightness.Value = 100;
        trackBarBrightness.Scroll += trackBarBrightness_Scroll;
        // 
        // groupBoxBasicImageProcessing
        // 
        groupBoxBasicImageProcessing.Controls.Add(buttonSepia);
        groupBoxBasicImageProcessing.Controls.Add(buttonHistogram);
        groupBoxBasicImageProcessing.Controls.Add(buttonColorInversion);
        groupBoxBasicImageProcessing.Controls.Add(buttonGreyscale);
        groupBoxBasicImageProcessing.Controls.Add(buttonCopyImage);
        groupBoxBasicImageProcessing.Location = new Point(12, 26);
        groupBoxBasicImageProcessing.Name = "groupBoxBasicImageProcessing";
        groupBoxBasicImageProcessing.Size = new Size(201, 176);
        groupBoxBasicImageProcessing.TabIndex = 4;
        groupBoxBasicImageProcessing.TabStop = false;
        groupBoxBasicImageProcessing.Text = "Basic Image Processing";
        // 
        // buttonSepia
        // 
        buttonSepia.Location = new Point(6, 138);
        buttonSepia.Name = "buttonSepia";
        buttonSepia.Size = new Size(174, 23);
        buttonSepia.TabIndex = 3;
        buttonSepia.Text = "Sepia";
        buttonSepia.UseVisualStyleBackColor = true;
        buttonSepia.Click += buttonSepia_Click;
        // 
        // buttonHistogram
        // 
        buttonHistogram.Location = new Point(6, 109);
        buttonHistogram.Name = "buttonHistogram";
        buttonHistogram.Size = new Size(174, 23);
        buttonHistogram.TabIndex = 2;
        buttonHistogram.Text = "Histogram";
        buttonHistogram.UseVisualStyleBackColor = true;
        buttonHistogram.Click += buttonHistogram_Click;
        // 
        // buttonColorInversion
        // 
        buttonColorInversion.Location = new Point(6, 80);
        buttonColorInversion.Name = "buttonColorInversion";
        buttonColorInversion.Size = new Size(174, 23);
        buttonColorInversion.TabIndex = 1;
        buttonColorInversion.Text = "Invert Colors";
        buttonColorInversion.UseVisualStyleBackColor = true;
        buttonColorInversion.Click += buttonColorInversion_Click;
        // 
        // buttonGreyscale
        // 
        buttonGreyscale.Location = new Point(6, 51);
        buttonGreyscale.Name = "buttonGreyscale";
        buttonGreyscale.Size = new Size(174, 23);
        buttonGreyscale.TabIndex = 0;
        buttonGreyscale.Text = "Greyscale";
        buttonGreyscale.UseVisualStyleBackColor = true;
        buttonGreyscale.Click += buttonGreyscale_Click;
        // 
        // buttonCopyImage
        // 
        buttonCopyImage.Location = new Point(6, 22);
        buttonCopyImage.Name = "buttonCopyImage";
        buttonCopyImage.Size = new Size(174, 23);
        buttonCopyImage.TabIndex = 0;
        buttonCopyImage.Text = "Copy Image";
        buttonCopyImage.UseVisualStyleBackColor = true;
        buttonCopyImage.Click += buttonCopyImage_Click;
        // 
        // pictureBoxProcessedImage
        // 
        pictureBoxProcessedImage.BackColor = SystemColors.ActiveBorder;
        pictureBoxProcessedImage.Location = new Point(667, 51);
        pictureBoxProcessedImage.Name = "pictureBoxProcessedImage";
        pictureBoxProcessedImage.Size = new Size(410, 432);
        pictureBoxProcessedImage.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxProcessedImage.TabIndex = 4;
        pictureBoxProcessedImage.TabStop = false;
        // 
        // labelImageA
        // 
        labelImageA.AutoSize = true;
        labelImageA.Location = new Point(98, 33);
        labelImageA.Name = "labelImageA";
        labelImageA.Size = new Size(51, 15);
        labelImageA.TabIndex = 5;
        labelImageA.Text = "Image A";
        // 
        // labelImageB
        // 
        labelImageB.AutoSize = true;
        labelImageB.Location = new Point(667, 33);
        labelImageB.Name = "labelImageB";
        labelImageB.Size = new Size(50, 15);
        labelImageB.TabIndex = 6;
        labelImageB.Text = "Image B";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1163, 721);
        Controls.Add(labelImageB);
        Controls.Add(labelImageA);
        Controls.Add(pictureBoxProcessedImage);
        Controls.Add(panel1);
        Controls.Add(pictureBoxOriginalImage);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        Name = "MainForm";
        Text = "Basic Image Processing by Rafael Mendoza";
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalImage).EndInit();
        panel1.ResumeLayout(false);
        groupBoxConvolutionMatrix.ResumeLayout(false);
        groupBoxConvolutionMatrix.PerformLayout();
        groupBoxAdvancedEmboss.ResumeLayout(false);
        groupBoxContrast.ResumeLayout(false);
        groupBoxContrast.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)trackBarContrast).EndInit();
        groupBoxBrightness.ResumeLayout(false);
        groupBoxBrightness.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)trackBarBrightness).EndInit();
        groupBoxBasicImageProcessing.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBoxProcessedImage).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem addImageToolStripMenuItem;
    private ToolStripMenuItem saveProcessedImageToolStripMenuItem;
    private ToolStripMenuItem imageProcessingToolStripMenuItem;
    private ToolStripMenuItem copyToolStripMenuItem;
    private ToolStripMenuItem greyscaleToolStripMenuItem;
    private ToolStripMenuItem invertColorsToolStripMenuItem;
    private ToolStripMenuItem histogramToolStripMenuItem;
    private ToolStripMenuItem sepiaToolStripMenuItem;
    private OpenFileDialog openFileDialog;
    private PictureBox pictureBoxOriginalImage;
    private Label labelControls;
    private Panel panel1;
    private GroupBox groupBoxBasicImageProcessing;
    private Button buttonCopyImage;
    private PictureBox pictureBoxProcessedImage;
    private Label labelImageA;
    private Label labelImageB;
    private Button buttonGreyscale;
    private Button buttonSepia;
    private Button buttonHistogram;
    private Button buttonColorInversion;
    private SaveFileDialog saveFileDialog;
    private ToolStripMenuItem clearImagePlaceholdersToolStripMenuItem;
    private GroupBox groupBoxBrightness;
    private TrackBar trackBarBrightness;
    private GroupBox groupBoxContrast;
    private TrackBar trackBarContrast;
    private ToolStripMenuItem advancedImageProcessingToolStripMenuItem;
    private ToolStripMenuItem imageSubtractionToolStripMenuItem;
    private ToolStripMenuItem captureCameraPhotoToolStripMenuItem;
    private GroupBox groupBoxConvolutionMatrix;
    private Button buttonSharpen;
    private Button buttonGaussianBlur;
    private Button buttonSmoothing;
    private GroupBox groupBoxAdvancedEmboss;
    private Button buttonAllDirections;
    private Button buttonHorizontalVertical;
    private Button buttonEmboss;
    private Button buttonMeanRemoval;
    private Button buttonVerticalOnly;
    private Button buttonHorizontalOnly;
    private Button buttonLossy;
    private Label labelWeight;
    private TextBox textBoxWeight;
}
