using System.Drawing.Imaging;

using Emgu.CV;

namespace BasicImageProcessing.ImageProcessingServices;

internal class ConvolutionMatrix
{
    public int TopLeft { get; set; } = 0;
    public int TopMiddle { get; set; } = 0;
    public int TopRight { get; set; } = 0;

    public int MiddleLeft { get; set; } = 0;
    public int Pixel { get; set; } = 1;
    public int MiddleRight { get; set; } = 0;

    public int BottomLeft { get; set; } = 0;
    public int BottomMiddle { get; set; } = 0;
    public int BottomRight { get; set; } = 0;

    public int Factor { get; set; } = 1;
    public int Offset { get; set; } = 0;

    public ConvolutionMatrix() {}

    public ConvolutionMatrix(int val)
    {
        TopLeft = TopMiddle = TopRight =
        MiddleLeft = Pixel = MiddleRight =
        BottomLeft = BottomMiddle = BottomRight =
        val;
    }

    public void SetAll(int val)
    {
        TopLeft = TopMiddle = TopRight = 
        MiddleLeft = Pixel = MiddleRight =
        BottomLeft = BottomMiddle = BottomRight = 
        val;
    }

    public static bool Convolution3x3(Bitmap bitmap, ConvolutionMatrix matrix)
    {
        // Avoid divide by zero errors
        if (0 == matrix.Factor) return false;

        Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

        // GDI+ still lies to us - the return format is BGR, NOT RGB.
        BitmapData bitmapOriginalData = bitmap.LockBits(
            new Rectangle(0, 0, bitmap.Width, bitmap.Height), 
            ImageLockMode.ReadWrite, 
            PixelFormat.Format24bppRgb
        );
        BitmapData bitmapCopyData = bitmapCopy.LockBits(
            new Rectangle(0, 0, bitmapCopy.Width, bitmapCopy.Height), 
            ImageLockMode.ReadWrite, 
            PixelFormat.Format24bppRgb
        );

        int stride = bitmapOriginalData.Stride;
        int stride2 = stride * 2;
        IntPtr Scan0 = bitmapOriginalData.Scan0;
        IntPtr SrcScan0 = bitmapCopyData.Scan0;

        unsafe
        {
            byte* p = (byte*)(void*)Scan0;
            byte* pSrc = (byte*)(void*)SrcScan0;

            int nOffset = stride - bitmap.Width * 3;
            int nWidth = bitmap.Width - 2;
            int nHeight = bitmap.Height - 2;

            int nPixel;

            for (int y = 0; y < nHeight; ++y)
            {
                for (int x = 0; x < nWidth; ++x)
                {
                    nPixel = (
                        (
                            (
                                (pSrc[2] * matrix.TopLeft) + (pSrc[5] * matrix.TopMiddle) + (pSrc[8] * matrix.TopRight) +
                                (pSrc[2 + stride] * matrix.MiddleLeft) + (pSrc[5 + stride] * matrix.Pixel) + (pSrc[8 + stride] * matrix.MiddleRight) +
                                (pSrc[2 + stride2] * matrix.BottomLeft) + (pSrc[5 + stride2] * matrix.BottomMiddle) + (pSrc[8 + stride2] * matrix.BottomRight)
                            ) / matrix.Factor
                        ) + matrix.Offset
                    );

                    if (nPixel < 0) nPixel = 0;
                    if (nPixel > 255) nPixel = 255;

                    p[5 + stride] = (byte)nPixel;

                    nPixel = (
                        (
                            (
                                (pSrc[1] * matrix.TopLeft) + (pSrc[4] * matrix.TopMiddle) + (pSrc[7] * matrix.TopRight) +
                                (pSrc[1 + stride] * matrix.MiddleLeft) + (pSrc[4 + stride] * matrix.Pixel) + (pSrc[7 + stride] * matrix.MiddleRight) +
                                (pSrc[1 + stride2] * matrix.BottomLeft) + (pSrc[4 + stride2] * matrix.BottomMiddle) + (pSrc[7 + stride2] * matrix.BottomRight)
                            ) / matrix.Factor
                        ) + matrix.Offset
                    );

                    if (nPixel < 0) nPixel = 0;
                    if (nPixel > 255) nPixel = 255;

                    p[4 + stride] = (byte)nPixel;

                    nPixel = (
                        (
                            (
                                (pSrc[0] * matrix.TopLeft) + (pSrc[3] * matrix.TopMiddle) + (pSrc[6] * matrix.TopRight) +
                                (pSrc[0 + stride] * matrix.MiddleLeft) + (pSrc[3 + stride] * matrix.Pixel) + (pSrc[6 + stride] * matrix.MiddleRight) +
                                (pSrc[0 + stride2] * matrix.BottomLeft) + (pSrc[3 + stride2] * matrix.BottomMiddle) + (pSrc[6 + stride2] * matrix.BottomRight)
                            ) / matrix.Factor
                        ) + matrix.Offset
                    );

                    if (nPixel < 0) nPixel = 0;
                    if (nPixel > 255) nPixel = 255;

                    p[3 + stride] = (byte)nPixel;

                    p += 3;
                    pSrc += 3;
                }
                p += nOffset;
                pSrc += nOffset;
            }
        }
        bitmap.UnlockBits(bitmapOriginalData);
        bitmapCopy.UnlockBits(bitmapCopyData);

        return true;
    }


    public static bool Smooth(Bitmap bitmap, int weight = 1)
    {
        ConvolutionMatrix matrix = new(1)
        {
            Pixel = weight,
            Factor = weight + 8
        };
        return Convolution3x3(bitmap, matrix);
    }

    public static bool GaussianBlur(Bitmap bitmap, int weight = 4) {
        ConvolutionMatrix matrix = new(1)
        {
            Pixel = weight,
            TopMiddle = 2,
            MiddleLeft = 2,
            MiddleRight = 2,
            BottomMiddle = 2,
            Factor = weight + 12
        };
        return Convolution3x3(bitmap, matrix);
    }

    public static bool Sharpen(Bitmap bitmap, int weight = 11)
    {
        ConvolutionMatrix matrix = new(0)
        {
            Pixel = weight,
            TopMiddle =  -2,
            MiddleLeft = -2,
            MiddleRight = -2,
            BottomMiddle = -2,
            Factor = weight - 8
        };
        return Convolution3x3(bitmap, matrix);
    }

    public static bool MeanRemoval(Bitmap bitmap, int weight = 9)
    {
        ConvolutionMatrix matrix = new(-1)
        {
            Pixel = weight,
            Factor = weight - 8
        };
        return Convolution3x3(bitmap, matrix);
    }

    public static bool EmbossLaplacian(Bitmap bitmap, int weight = 4)
    {
        ConvolutionMatrix matrix = new(-1)
        {
            Pixel = weight,
            TopMiddle = 0,
            MiddleLeft = 0,
            MiddleRight = 0,
            BottomMiddle = 0,
            Factor = 1,
            Offset = 127
        };
        return Convolution3x3(bitmap, matrix);
    }

    public static bool EmbossLaplacianHorizontalVertical(Bitmap bitmap, int weight = 4)
    {
        ConvolutionMatrix matrix = new(0)
        {
            Pixel = weight,
            TopMiddle = -1,
            MiddleLeft = -1,
            MiddleRight = -1,
            BottomMiddle = -1,
            Factor = 1,
            Offset = 127
        };
        return Convolution3x3(bitmap, matrix);
    }

    public static bool EmbossLaplacianAllDirections(Bitmap bitmap, int weight = 8)
    {
        ConvolutionMatrix matrix = new(-1)
        {
            Pixel = weight,
            Factor = 1,
            Offset = 127
        };
        return Convolution3x3(bitmap, matrix);
    }

    public static bool EmbossLaplacianLossy(Bitmap bitmap, int weight = 4)
    {
        ConvolutionMatrix matrix = new(-2)
        {
            Pixel = weight,
            TopLeft = 1,
            TopRight = 1,
            BottomMiddle = 1,
            Factor = 1,
            Offset = 127
        };
        return Convolution3x3(bitmap, matrix);
    }

    public static bool EmbossLaplacianHorizontalOnly(Bitmap bitmap, int weight = 2)
    {
        ConvolutionMatrix matrix = new(0)
        {
            Pixel = weight,
            MiddleLeft = -1,
            MiddleRight = -1,
            Factor = 1,
            Offset = 127
        };
        return Convolution3x3(bitmap, matrix);
    }

    public static bool EmbossLaplacianVerticalOnly(Bitmap bitmap, int weight = 0)
    {
        ConvolutionMatrix matrix = new(0)
        {
            Pixel = weight,
            TopMiddle = -1,
            BottomMiddle = 1,
            Factor = 1,
            Offset = 127
        };
        return Convolution3x3(bitmap, matrix);
    }
}
