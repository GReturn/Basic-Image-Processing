using BasicImageProcessing.ImageProcessingServices;
using BasicImageProcessing.ImageProcessingServices.Exceptions;
using BasicImageProcessing.ImageProcessingServices.Interfaces;

namespace BasicImageProcessing
{
    public partial class MainForm : Form
    {
        IImageProcessingService? _imageProcessingService;
        IAdjustImageService? _adjustImageService;

        public MainForm()
        {
            InitializeComponent();
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select an image file";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(openFileDialog.FileName);
                pictureBoxOriginalImage.Image = image;
            }
        }

        private void saveProcessedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxProcessedImage.Image == null)
            {
                MessageBox.Show("No processed image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            saveFileDialog.Title = "Save Processed Image";
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|All Files|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var format = System.Drawing.Imaging.ImageFormat.Png;
                switch (Path.GetExtension(saveFileDialog.FileName).ToLower())
                {
                    case ".jpg":
                    case ".jpeg":
                    case ".png":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                }
                pictureBoxProcessedImage.Image.Save(saveFileDialog.FileName, format);
            }
        }

        #region Control Panel Buttons

        private void buttonCopyImage_Click(object sender, EventArgs e)
        {
            try
            {
                _imageProcessingService = new CopyImageProcessingService();
                var processedImage = _imageProcessingService.ProcessImage(pictureBoxOriginalImage.Image);
                pictureBoxProcessedImage.Image = processedImage;
            }
            catch (Exception ex)
            when (ex is NullImageException || ex is ImageProcessingException || ex is not null)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void buttonGreyscale_Click(object sender, EventArgs e)
        {
            try
            {
                _imageProcessingService = new GreyscaleImageProcessingService();
                var processedImage = _imageProcessingService.ProcessImage(pictureBoxOriginalImage.Image);
                pictureBoxProcessedImage.Image = processedImage;
            }
            catch (Exception ex)
            when (ex is NullImageException || ex is ImageProcessingException || ex is not null)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void buttonColorInversion_Click(object sender, EventArgs e)
        {
            try
            {
                _imageProcessingService = new ColorInversionImageProcessingService();
                var processedImage = _imageProcessingService.ProcessImage(pictureBoxOriginalImage.Image);
                pictureBoxProcessedImage.Image = processedImage;
            }
            catch (Exception ex)
            when (ex is NullImageException || ex is ImageProcessingException || ex is not null)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            try
            {
                _imageProcessingService = new HistogramImageProcessingService();
                var processedImage = _imageProcessingService.ProcessImage(pictureBoxOriginalImage.Image);
                pictureBoxProcessedImage.Image = processedImage;
            }
            catch (Exception ex)
            when (ex is NullImageException || ex is ImageProcessingException || ex is not null)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void buttonSepia_Click(object sender, EventArgs e)
        {
            try
            {
                _imageProcessingService = new SepiaImageProcessingService();
                var processedImage = _imageProcessingService.ProcessImage(pictureBoxOriginalImage.Image);
                pictureBoxProcessedImage.Image = processedImage;
            }
            catch (Exception ex)
            when (ex is NullImageException || ex is ImageProcessingException || ex is not null)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            try
            {
                _adjustImageService = new AdjustBrightnessImageService();
                var processedImage = _adjustImageService.Adjust(pictureBoxOriginalImage.Image, trackBarBrightness.Value);
                pictureBoxProcessedImage.Image = processedImage;
            }
            catch (Exception ex)
            when (ex is NullImageException || ex is ImageProcessingException || ex is not null)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            try
            {
                _adjustImageService = new AdjustContrastImageService();
                var processedImage = _adjustImageService.Adjust(pictureBoxOriginalImage.Image, trackBarContrast.Value);
                pictureBoxProcessedImage.Image = processedImage;
            }
            catch (Exception ex)
            when (ex is NullImageException || ex is ImageProcessingException || ex is not null)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        #endregion

        private void clearImagePlaceholdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxOriginalImage.Image = null;
            pictureBoxProcessedImage.Image = null;
        }

        private void imageSubtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imageSubtractionForm = new ImageSubtractionForm(this);
            imageSubtractionForm.Show();
            Hide();
        }

        private void captureCameraPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CameraCaptureForm cameraCaptureForm = new CameraCaptureForm(this, ref pictureBoxOriginalImage);
            cameraCaptureForm.ShowDialog();
        }
    }
}
