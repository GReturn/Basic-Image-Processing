using BasicImageProcessing.ImageProcessingServices.Exceptions;
using BasicImageProcessing.ImageProcessingServices.Interfaces;

namespace BasicImageProcessing.ImageProcessingServices;

internal class AdjustBrightnessImageService : IAdjustImageService
{
    public Image Adjust(Image image, float units)
    {
        if (image == null) throw new NullImageException("Input image is empty.");
        if (units < 0.0f || units > 100.0f) throw new ImageProcessingException("Units must be between 0 and 100.");

        units /= 100.0f;
        Bitmap originalImage = new(image);
        Bitmap adjustedImage = new(originalImage.Width, originalImage.Height);
        
        try
        {
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    var pixelColor = originalImage.GetPixel(x, y);
                    int r = Math.Clamp((int)(pixelColor.R + (units * 255)), 0, 255);
                    int g = Math.Clamp((int)(pixelColor.G + (units * 255)), 0, 255);
                    int b = Math.Clamp((int)(pixelColor.B + (units * 255)), 0, 255);
                    adjustedImage.SetPixel(x, y, Color.FromArgb(pixelColor.A, r, g, b));
                }
            }
            return adjustedImage;
        }
        catch (Exception)
        {
            throw new ImageProcessingException("An error occurred during brightness adjustment.");
        }
    }
}
