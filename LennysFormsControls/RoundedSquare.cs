using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Erwine.Leonard.Thomas.WindowsFormsControls
{
    public class RoundedSquare
    {
        private int _width, _height, _cornerRoundPercentage;

        public RoundedSquare()
            : this(200, 300) { }

        public RoundedSquare(int width, int height)
            : this(width, height, 15) { }

        public RoundedSquare(int width, int height, int cornerRoundingPercentage)
        {
            this.Width = width;
            this.Height = height;
            this.CornerRoundingPercentage = cornerRoundingPercentage;
        }

        public int Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }

        public int Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }

        public int CornerRoundingPercentage
        {
            get
            {
                return this._cornerRoundPercentage;
            }
            set
            {
                this._cornerRoundPercentage = value;
            }
        }

        public int GetPadding()
        {
            return Convert.ToInt32(Math.Ceiling((Convert.ToDouble(this.Width + this.Height) / 2.0) * (Convert.ToDouble(this.CornerRoundingPercentage) / 100.0)));
        }

        public int GetInnerHeight()
        {
            return this.Height - (this.GetPadding() * 2);
        }

        public int GetInnerWidth()
        {
            return this.Width - (this.GetPadding() * 2);
        }

        private Image GetReducedImage(Image image, Color backgroundColor)
        {
            Graphics graphics;
            Bitmap reductionBitmap;
            double reductionPercentage;
            int reducedWidth, reducedHeight;

            if (image.Width <= this.Width && image.Height <= this.Height)
                return image;

            reductionBitmap = new Bitmap(this.Width, this.Height);

            if (Convert.ToDouble(image.Width) / Convert.ToDouble(this.Width) > Convert.ToDouble(image.Height) / Convert.ToDouble(this.Height))
                reductionPercentage = Convert.ToDouble(image.Width) / Convert.ToDouble(this.Width);
            else
                reductionPercentage = Convert.ToDouble(image.Height) / Convert.ToDouble(this.Height);

            reducedWidth = Convert.ToInt32(Math.Floor(Convert.ToDouble(image.Width) / reductionPercentage));
            reducedHeight = Convert.ToInt32(Math.Floor(Convert.ToDouble(image.Height) / reductionPercentage));

            graphics = Graphics.FromImage(reductionBitmap);
            graphics.Clear(backgroundColor);

            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.DrawImage(image, new Rectangle((this.Width - reducedWidth) / 2, (this.Height - reducedHeight) / 2, reducedWidth, reducedHeight));

            return reductionBitmap;
        }

        public Image GetTextureImage(Color borderColor, int borderWidth, Image image, WrapMode wrapMode, Color backgroundColor)
        {
            Bitmap normalResBitmap;
            Graphics graphics;

            normalResBitmap = new Bitmap(this.Width, this.Height);

            graphics = Graphics.FromImage(normalResBitmap);
            graphics.FillPath(new TextureBrush(this.GetReducedImage(image, backgroundColor), wrapMode), this.GetPathForFill(borderWidth));

            this.OverlayBorder(graphics, borderColor, borderWidth);

            return normalResBitmap;
        }

        public Image GetLinearGradientImage(Color borderColor, int borderWidth, Point point1, Point point2, Color color1, Color color2)
        {
            Bitmap normalResBitmap;
            Graphics normalGraphics;

            normalResBitmap = new Bitmap(this.Width, this.Height);

            normalGraphics = Graphics.FromImage(normalResBitmap);

            normalGraphics.FillPath(new LinearGradientBrush(point1, point2, color1, color2), this.GetPathForFill(borderWidth));

            this.OverlayBorder(normalGraphics, borderColor, borderWidth);

            return normalResBitmap;
        }

        public Image GetHatchedImage(Color borderColor, int borderWidth, Color backgroundColor, Color foregroundColor, HatchStyle hatchStyle)
        {
            Bitmap normalResBitmap;
            Graphics normalGraphics;

            normalResBitmap = new Bitmap(this.Width, this.Height);

            normalGraphics = Graphics.FromImage(normalResBitmap);

            normalGraphics.FillPath(new HatchBrush(hatchStyle, foregroundColor, backgroundColor), this.GetPathForFill(borderWidth));

            this.OverlayBorder(normalGraphics, borderColor, borderWidth);

            return normalResBitmap;
        }

        public Image GetSolidImage(Color borderColor, int borderWidth, Color backgroundColor)
        {
            Bitmap normalResBitmap;
            Graphics normalGraphics;

            normalResBitmap = new Bitmap(this.Width, this.Height);

            normalGraphics = Graphics.FromImage(normalResBitmap);
            
            normalGraphics.FillPath(new SolidBrush(backgroundColor), this.GetPathForFill(borderWidth));

            this.OverlayBorder(normalGraphics, borderColor, borderWidth);

            return normalResBitmap;
        }

        private GraphicsPath GetPathForFill(int borderWidth)
        {
            GraphicsPath path;
            int borderOffset, halfPadding, innerWidth, innerHeight, padding;

            innerWidth = this.Width - 1;
            innerHeight = this.Height - 1;
            padding = this.GetPadding();

            borderOffset = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(borderWidth) / 2.0));
            halfPadding = Convert.ToInt32(Math.Floor(Convert.ToDouble(padding) / 2.0));

            path = new GraphicsPath();
            path.AddArc(new Rectangle(innerWidth - borderOffset - padding, innerHeight - borderOffset - padding,
                padding, padding), 0.0F, 90.0F);
            path.AddLine(
                new Point(innerWidth - borderOffset - halfPadding, innerHeight - borderOffset),
                new Point(borderOffset + halfPadding, innerHeight - borderOffset));
            path.AddArc(new Rectangle(borderOffset, innerHeight - borderOffset - padding, padding, padding),
                90.0F, 90.0F);
            path.AddLine(
                new Point(borderOffset, innerHeight - borderOffset - halfPadding),
                new Point(borderOffset, borderOffset + halfPadding));
            path.AddArc(new Rectangle(borderOffset, borderOffset, padding, padding), 180.0F, 90.0F);
            path.AddLine(
                new Point(borderOffset + halfPadding, borderOffset),
                new Point(innerWidth - halfPadding - borderOffset, borderOffset));
            path.AddArc(new Rectangle(innerWidth - padding - borderOffset, borderOffset, padding, padding),
                270.0F, 90.0F);
            path.AddLine(
                new Point(innerWidth - borderOffset, borderOffset + halfPadding),
                new Point(innerWidth - borderOffset, innerHeight - borderOffset - halfPadding));

            path.CloseFigure();
            return path;
        }

        private void OverlayBorder(Graphics normalGraphics, Color borderColor, int borderWidth)
        {
            Bitmap hiResBitMap;
            Graphics hiResGraphics;
            GraphicsPath path;
            int borderOffset, halfPadding, innerWidth, innerHeight, padding;

            if (borderWidth < 1)
                return;

            innerWidth = (this.Width - 1) * 4;
            innerHeight = (this.Height - 1) * 4;
            padding = this.GetPadding() * 4;
            halfPadding = Convert.ToInt32(Math.Floor(Convert.ToDouble(padding) / 2.0));
            borderOffset = borderWidth * 2;

            hiResBitMap = new Bitmap(this.Width * 4, this.Height * 4);


            path = new GraphicsPath();
            path.AddArc(new Rectangle(innerWidth - borderOffset - padding, innerHeight - borderOffset - padding,
                padding, padding), 0.0F, 90.0F);
            path.AddLine(
                new Point(innerWidth - borderOffset - halfPadding, innerHeight - borderOffset),
                new Point(borderOffset + halfPadding, innerHeight - borderOffset));
            path.AddArc(new Rectangle(borderOffset, innerHeight - borderOffset - padding, padding, padding),
                90.0F, 90.0F);
            path.AddLine(
                new Point(borderOffset, innerHeight - borderOffset - halfPadding),
                new Point(borderOffset, borderOffset + halfPadding));
            path.AddArc(new Rectangle(borderOffset, borderOffset, padding, padding), 180.0F, 90.0F);
            path.AddLine(
                new Point(borderOffset + halfPadding, borderOffset),
                new Point(innerWidth - halfPadding - borderOffset, borderOffset));
            path.AddArc(new Rectangle(innerWidth - padding - borderOffset, borderOffset, padding, padding),
                270.0F, 90.0F);
            path.AddLine(
                new Point(innerWidth - borderOffset, borderOffset + halfPadding),
                new Point(innerWidth - borderOffset, innerHeight - borderOffset - halfPadding));

            path.CloseFigure();

            hiResGraphics = Graphics.FromImage(hiResBitMap);
            hiResGraphics.Clear(Color.Transparent);

            hiResGraphics.DrawPath(new Pen(borderColor, Convert.ToSingle(borderWidth * 4)), path);

            normalGraphics.CompositingQuality = CompositingQuality.HighQuality;
            normalGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            normalGraphics.SmoothingMode = SmoothingMode.HighQuality;

            normalGraphics.DrawImage(hiResBitMap, 0, 0, this.Width, this.Height);
        }
    }
}
