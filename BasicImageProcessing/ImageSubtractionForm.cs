using System.Windows.Forms;

using BasicImageProcessing.ImageProcessingServices;
using BasicImageProcessing.ImageProcessingServices.Exceptions;

using WebCamLib;

namespace BasicImageProcessing;

public partial class ImageSubtractionForm : Form
{
    private MainForm mainForm;
    public ImageSubtractionForm(MainForm mainForm)
    {
        InitializeComponent();
        this.mainForm = mainForm;
    }

    private void GoBack()
    {
        mainForm.Show();
    }

    private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
    {
        GoBack();
        Close();
    }

    private void buttonLoadImage_Click(object sender, EventArgs e)
    {
        openFileDialog.Title = "Select an image file";
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            var image = Image.FromFile(openFileDialog.FileName);
            pictureBoxImageSubject.Image = image;
            labelImage1.Text = $"Image 1: {image.Width}x{image.Height}px";
        }
    }

    private void buttonLoadBackground_Click(object sender, EventArgs e)
    {
        openFileDialog.Title = "Select an image file";
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            var image = Image.FromFile(openFileDialog.FileName);
            pictureBoxImageBackground.Image = image;
            labelImage2.Text = $"Image 2: {image.Width}x{image.Height}px";
        }
    }

    private void buttonApplySubtraction_Click(object sender, EventArgs e)
    {
        try
        {
            SubtractImageProcessingService service = new();
            var processedImage = service.ProcessImages(pictureBoxImageBackground.Image, pictureBoxImageSubject.Image);
            pictureBoxImageResult.Image = processedImage;
            labelImage3.Text = $"Result Image: {processedImage.Width}x{processedImage.Height}px";
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

    private void buttonUseCamera_Click(object sender, EventArgs e)
    {
        CameraCaptureForm cameraCaptureForm = new CameraCaptureForm(this, ref pictureBoxImageSubject);
        cameraCaptureForm.ShowDialog();
        labelImage1.Text = $"Image 1: {pictureBoxImageSubject.Image?.Width ?? 0}x{pictureBoxImageSubject.Image?.Height ?? 0}px";
    }


    private void saveProcessedImageToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (pictureBoxImageResult.Image == null)
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
            pictureBoxImageResult.Image.Save(saveFileDialog.FileName, format);
        }
    }

    private void ImageSubtractionForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        GoBack();
    }
}
