using System.Drawing.Drawing2D;

namespace BasicImageProcessing.ImageProcessingServices;

internal class ResizeImageProcessingService
{
    public static Image Process(Image image, int width, int height)
    {
        var newImage = new Bitmap(width, height);
        using (Graphics g = Graphics.FromImage(newImage))
        {
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, width, height);
        }
        return newImage;
    }
}
