namespace BasicImageProcessing.ImageProcessingServices.Interfaces;

internal interface IAdjustImageService
{
    Image Adjust(Image image, float units);
}
