namespace BasicImageProcessing.ImageProcessingServices.Exceptions;

internal class NullImageException : Exception
{
    public NullImageException() { }
    public NullImageException(string message) : base(message) { }
}
