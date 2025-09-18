using BasicImageProcessing.ImageProcessingServices.Exceptions;
using BasicImageProcessing.ImageProcessingServices.Interfaces;

namespace BasicImageProcessing.ImageProcessingServices;

internal class SepiaImageProcessingService : IImageProcessingService
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

                    // Linear transformation of the color space to achieve the sepia effect.
                    // The constants are defined in this old MSFT article from Jan 2005.
                    // By Stephen Toub:
                    // https://learn.microsoft.com/en-us/archive/msdn-magazine/2005/january/net-matters-sepia-tone-stringlogicalcomparer-and-more
                    int newRed = (int)(0.393 * pixelColor.R + 0.769 * pixelColor.G + 0.189 * pixelColor.B);
                    int newGreen = (int)(0.349 * pixelColor.R + 0.686 * pixelColor.G + 0.168 * pixelColor.B);
                    int newBlue = (int)(0.272 * pixelColor.R + 0.534 * pixelColor.G + 0.131 * pixelColor.B);

                    processedImage.SetPixel(
                        x,
                        y,
                        Color.FromArgb(
                            pixelColor.A,
                            Math.Clamp(newRed, 0, 255),
                            Math.Clamp(newGreen, 0, 255),
                            Math.Clamp(newBlue, 0, 255)
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