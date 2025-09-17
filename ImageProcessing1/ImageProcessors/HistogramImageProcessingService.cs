using System.Collections;

using ImageProcessing1.ImageProcessors.Exceptions;

namespace ImageProcessing1.ImageProcessors;

internal class HistogramImageProcessingService : IImageProcessingService
{
    /*
     *  The easiest way of doing this is by representing 
     *  an image into a 2D space where x is the degree of 
     *  image intensity and y as the magnitude of the intensity
     */

    public Image ProcessImage(Image image)
    {
        if (image == null) throw new NullImageException("Input image is empty.");

        Bitmap originalImage = new(image);
        Bitmap processedImage = new(originalImage.Width, originalImage.Height);

        try
        {
            // Step 1 Convert the image to grayscale.
            GreyscaleImageProcessingService greyscaleProcessor = new();
            Bitmap grayImage = new((Bitmap)greyscaleProcessor.ProcessImage(originalImage));

            // Step 2 Use an array to count up pixels of same levels
            int[] intensityCounts = CountIntensity(grayImage);

            // Step 3 Plot the values of the array on a bitmap graph
            processedImage = PlotHistogram(intensityCounts, originalImage.Width, originalImage.Height);

            return processedImage;
        }
        catch (Exception)
        {
            throw new ImageProcessingException("An error occurred during image processing.");
        }
    }

    private static int[] CountIntensity(Bitmap grayImage)
    {
        int[] intensityCounts = new int[256];
        for (int y = 0; y < grayImage.Height; y++)
        {
            for (int x = 0; x < grayImage.Width; x++)
            {
                var pixelColor = grayImage.GetPixel(x, y);
                intensityCounts[pixelColor.R]++;
            }
        }
        return intensityCounts;
    }

    private static Bitmap PlotHistogram(int[] intensityCounts, int width, int height)
    {
        Bitmap histogramImage = new(width, height);
        using (Graphics g = Graphics.FromImage(histogramImage))
        {
            g.Clear(Color.White);
            int maxCount = intensityCounts.Max();
            for (int x = 0; x < width; x++)
            {
                int intensityLevel = (int)((x / (float)width) * 255);
                int barHeight = (int)((intensityCounts[intensityLevel] / (float)maxCount) * height);
                g.DrawLine(Pens.Black, x, height, x, height - barHeight);
            }
        }
        return histogramImage;
    }
}