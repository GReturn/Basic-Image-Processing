using BasicImageProcessing.ImageProcessingServices.Exceptions;
using BasicImageProcessing.ImageProcessingServices.Interfaces;

namespace BasicImageProcessing.ImageProcessingServices;

internal class GreyscaleImageProcessingService : IImageProcessingService
{
    public Image ProcessImage(Image image)
    {
        if (image == null) throw new NullImageException("Input image is empty.");

        Bitmap originalImage = new(image);
        Bitmap processedImage = new(originalImage.Width, originalImage.Height);

        try
        {
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    var pixelColor = originalImage.GetPixel(x, y);
                    var averageColor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    processedImage.SetPixel(x, y, Color.FromArgb(averageColor, averageColor, averageColor));
                }
            }
            return processedImage;
        }
        catch (Exception)
        {
            throw new ImageProcessingException("An error occurred during image processing.");
        }
    }
}