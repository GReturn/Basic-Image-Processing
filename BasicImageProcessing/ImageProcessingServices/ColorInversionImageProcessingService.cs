using BasicImageProcessing.ImageProcessingServices.Exceptions;
using BasicImageProcessing.ImageProcessingServices.Interfaces;

namespace BasicImageProcessing.ImageProcessingServices;

internal class ColorInversionImageProcessingService : IImageProcessingService
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
                    processedImage.SetPixel(
                        x, 
                        y, 
                        Color.FromArgb(
                            pixelColor.A, 
                            Math.Clamp(255 - pixelColor.R, 0, 255),
                            Math.Clamp(255 - pixelColor.G, 0, 255),
                            Math.Clamp(255 - pixelColor.B, 0, 255)
                        )
                    );
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