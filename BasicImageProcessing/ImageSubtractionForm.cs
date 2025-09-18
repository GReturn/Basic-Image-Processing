using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BasicImageProcessing.ImageProcessingServices;
using BasicImageProcessing.ImageProcessingServices.Exceptions;
using BasicImageProcessing.ImageProcessingServices.Interfaces;

namespace BasicImageProcessing
{
    public partial class ImageSubtractionForm : Form
    {
        private MainForm mainForm;
        public ImageSubtractionForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.Show();
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
            }
        }

        private void buttonApplySubtraction_Click(object sender, EventArgs e)
        {
            //try
            //{
                SubtractImageProcessingService service = new();
                var processedImage = service.ProcessImages(pictureBoxImageBackground.Image, pictureBoxImageSubject.Image);
                pictureBoxImageResult.Image = processedImage;
            //}
            //catch (Exception ex)
            //when (ex is NullImageException || ex is ImageProcessingException || ex is not null)
            //{
            //    MessageBox.Show(
            //        ex.Message,
            //        "Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error
            //    );
            //    return;
            //}
        }
    }
}
