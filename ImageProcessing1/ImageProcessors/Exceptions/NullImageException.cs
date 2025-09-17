namespace ImageProcessing1.ImageProcessors.Exceptions;

internal class NullImageException : Exception
{
    public NullImageException() { }
    public NullImageException(string message) : base(message) { }
}
