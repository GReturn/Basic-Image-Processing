using BasicImageProcessing.ImageProcessingServices;

using WebCamLib;

namespace BasicImageProcessing;

public partial class CameraCaptureForm : Form
{
    private Form parentForm;
    private PictureBox captureOutput;
    private Device? device;
    public CameraCaptureForm(Form parentForm, ref PictureBox pictureBoxImageSubject)
    {
        InitializeComponent();
        this.parentForm = parentForm;
        captureOutput = pictureBoxImageSubject;

        Device[] devices = DeviceManager.GetAllDevices();
        if (devices.Length == 0)
        {
            MessageBox.Show("No camera devices found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        string deviceList = string.Join(", ", devices.Select(d => d.Name));
        device = devices[0];
        if(device is null)
        {
            MessageBox.Show("Error initializing camera.",  "Error",  MessageBoxButtons.OK,  MessageBoxIcon.Error);
            return;
        }

        device.ShowWindow(pictureBoxCameraDisplay);
        pictureBoxCameraDisplay.Refresh();
    }

    private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void buttonCapture_Click(object sender, EventArgs e)
    {
        if (device is null) return;
        device.Sendmessage();
        var capturedImage = Clipboard.GetImage();

        pictureBoxCameraDisplay.Image = capturedImage;
        if (pictureBoxCameraDisplay.Image != null)
        {

            captureOutput.Image = (Image)pictureBoxCameraDisplay.Image.Clone();
        }
        else
        {
            MessageBox.Show(
                "No image captured from camera.", 
                "Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );
        }
    }
}
