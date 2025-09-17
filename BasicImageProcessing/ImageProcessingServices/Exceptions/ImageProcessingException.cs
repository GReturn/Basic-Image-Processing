namespace BasicImageProcessing.ImageProcessingServices.Exceptions;

internal class ImageProcessingException : Exception
{
    public ImageProcessingException() { }
    public ImageProcessingException(string message) : base(message) { }
}
