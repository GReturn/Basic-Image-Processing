
using BasicImageProcessing.ImageProcessingServices.Exceptions;
using BasicImageProcessing.ImageProcessingServices.Interfaces;

namespace BasicImageProcessing.ImageProcessingServices;

internal class AdjustContrastImageService : IAdjustImageService
{
    public Image Adjust(Image image, float units)
    {
        if (image == null) throw new NullImageException("Input image is empty.");
        if (units < -50.0f || units > 50.0f) throw new ImageProcessingException("Units must be between -1.0 and 1.0.");

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
                    float factor = (259 * (units * 255 + 255)) / (255 * (259 - units * 255));
                    int r = Math.Clamp((int)(factor * (pixelColor.R - 128) + 128), 0, 255);
                    int g = Math.Clamp((int)(factor * (pixelColor.G - 128) + 128), 0, 255);
                    int b = Math.Clamp((int)(factor * (pixelColor.B - 128) + 128), 0, 255);
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
