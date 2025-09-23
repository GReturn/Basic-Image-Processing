using BasicImageProcessing.ImageProcessingServices.Exceptions;

namespace BasicImageProcessing.ImageProcessingServices;

internal class SubtractImageProcessingService
{
    public Image ProcessImages(Image imageBackground, Image imageSubject)
    {
        if (imageBackground == null || imageSubject == null) throw new NullImageException("One or both input images are empty.");
        if (imageBackground.Size != imageSubject.Size) throw new ImageProcessingException("Input images must be of the same dimensions.");
        
        Bitmap originalImageSubject = new(imageSubject);
        Bitmap originalImageBackground = new(imageBackground);
        Bitmap processedImage = new(originalImageBackground.Width, originalImageBackground.Height);
        
        Color green = Color.FromArgb(0, 255, 0);
        int greyGreen = (green.R + green.G + green.B) / 3;
        int threshold = 30;

        try
        {
            for (int x = 0; x < originalImageSubject.Width; x++)
            {
                for (int y = 0; y < originalImageSubject.Height; y++)
                {
                    var pixelColorSubject = originalImageSubject.GetPixel(x, y);
                    var pixelColorBackground = originalImageBackground.GetPixel(x, y);

                    var averageColorSubject = (pixelColorSubject.R + pixelColorSubject.G + pixelColorSubject.B) / 3;
                    int subtractionValue = Math.Abs(averageColorSubject - greyGreen);
                    if (subtractionValue < threshold 
                        && pixelColorSubject.G > pixelColorSubject.R 
                        && pixelColorSubject.G > pixelColorSubject.B
                    )
                    {
                        processedImage.SetPixel(x, y, pixelColorBackground);
                    }
                    else
                    {
                        processedImage.SetPixel(x, y, pixelColorSubject);
                    }
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
