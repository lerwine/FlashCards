using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Drawing2D;

namespace Erwine.Leonard.Thomas.WindowsFormsControls
{
    public partial class CircularDialImage
    {
        public enum FillTypeEnum { SolidColor, HatchFill, TextureFill, LinearGradient }

        private int _diameter;
        private List<IndicatorNeedle> _indicators;
        private List<MeasurementRange> _measurementRanges;
        private List<MeasurementTickMark> _tickMarks;
        
        public int Diameter
        {
            get
            {
                return this._diameter;
            }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException();

                this._diameter = value;
            }
        }

        public List<IndicatorNeedle> Indicators
        {
            get
            {
                return this._indicators;
            }
        }

        public List<MeasurementTickMark> TickMarks
        {
            get
            {
                return this._tickMarks;
            }
        }

        public CircularDialImage()
            : this(250) { }

        public CircularDialImage(int diameter)
            : this(diameter, null, null, null) { }

        public CircularDialImage(int diameter, IEnumerable<IndicatorNeedle> indicators,
            IEnumerable<MeasurementRange> measurementRanges, IEnumerable<MeasurementTickMark> tickMarks)
        {
            if (diameter < 1)
                throw new ArgumentOutOfRangeException("diameter");

            this._diameter = diameter;

            if (indicators == null)
                this._indicators = new List<IndicatorNeedle>();
            else
                this._indicators = new List<IndicatorNeedle>(indicators);

            if (measurementRanges == null)
                this._measurementRanges = new List<MeasurementRange>();
            else
                this._measurementRanges = new List<MeasurementRange>(measurementRanges);

            if (tickMarks == null)
                this._tickMarks = new List<MeasurementTickMark>();
            else
                this._tickMarks = new List<MeasurementTickMark>(tickMarks);
        }

        public Image GetTextureImage(Color borderColor, int borderWidth, Image image, WrapMode wrapMode, Color backgroundColor)
        {
            Bitmap normalResBitmap;
            Graphics graphics;

            normalResBitmap = new Bitmap(this.Diameter, this.Diameter);

            graphics = Graphics.FromImage(normalResBitmap);

            graphics.FillEllipse(new SolidBrush(backgroundColor), 0, 0, this.Diameter - 1, this.Diameter - 1);
            graphics.FillEllipse(new TextureBrush(this.GetReducedImage(image, backgroundColor), wrapMode), 0, 0, this.Diameter - 1, this.Diameter - 1);

            this.OverlayBorderAndMarks(graphics, borderColor, borderWidth);

            return normalResBitmap;
        }

        public Image GetLinearGradientImage(Color borderColor, int borderWidth, Point point1, Point point2, Color color1, Color color2)
        {
            Bitmap normalResBitmap;
            Graphics graphics;

            normalResBitmap = new Bitmap(this.Diameter, this.Diameter);

            graphics = Graphics.FromImage(normalResBitmap);

            graphics.FillEllipse(new LinearGradientBrush(point1, point2, color1, color2), 0, 0, this.Diameter - 1, this.Diameter - 1);

            this.OverlayBorderAndMarks(graphics, borderColor, borderWidth);

            return normalResBitmap;
        }

        public Image GetHatchedImage(Color borderColor, int borderWidth, Color backgroundColor, Color foregroundColor, HatchStyle hatchStyle)
        {
            Bitmap normalResBitmap;
            Graphics graphics;

            normalResBitmap = new Bitmap(this.Diameter, this.Diameter);

            graphics = Graphics.FromImage(normalResBitmap);

            graphics.FillEllipse(new HatchBrush(hatchStyle, foregroundColor, backgroundColor), 0, 0, this.Diameter - 1, this.Diameter - 1);

            this.OverlayBorderAndMarks(graphics, borderColor, borderWidth);

            return normalResBitmap;
        }

        public Image GetSolidImage(Color borderColor, int borderWidth, Color backgroundColor)
        {
            Bitmap normalResBitmap;
            Graphics graphics;

            normalResBitmap = new Bitmap(this.Diameter, this.Diameter);

            graphics = Graphics.FromImage(normalResBitmap);
            graphics.Clear(Color.White);

            graphics.FillEllipse(new SolidBrush(backgroundColor), 0, 0, this.Diameter - 1, this.Diameter - 1);

            this.OverlayBorderAndMarks(graphics, borderColor, borderWidth);

            return normalResBitmap;
        }

        private Image GetReducedImage(Image image, Color backgroundColor)
        {
            Graphics graphics;
            Bitmap reductionBitmap;
            int reducedDiameter;

            if (image.Width <= this.Diameter && image.Height <= this.Diameter)
                return image;

            reductionBitmap = new Bitmap(this.Diameter, this.Diameter);

            reducedDiameter = Convert.ToInt32(Math.Floor(Convert.ToDouble(image.Width) / (Convert.ToDouble(image.Height) / Convert.ToDouble(this.Diameter))));

            graphics = Graphics.FromImage(reductionBitmap);
            graphics.Clear(backgroundColor);

            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.DrawImage(image, new Rectangle((this.Diameter - reducedDiameter) / 2, (this.Diameter - reducedDiameter) / 2, reducedDiameter - 1, reducedDiameter - 1));

            return reductionBitmap;
        }

        private void OverlayBorderAndMarks(Graphics graphics, Color borderColor, int borderWidth)
        {
            Bitmap largeImage, fontImage;
            Graphics largeGraphics, fontGraphics;
            Matrix angleMatrix;
            Point[] points;
            SizeF size;

            largeImage = new Bitmap(this.Diameter * 4, this.Diameter * 4);
            largeGraphics = Graphics.FromImage(largeImage);

            graphics.DrawImage(largeImage, 0, 0, this.Diameter - 1, this.Diameter - 1);
            
            if (this.TickMarks != null)
            {
                foreach (MeasurementTickMark tm in this.TickMarks)
                {
                    angleMatrix = new Matrix(largeGraphics.Transform.Elements[0], largeGraphics.Transform.Elements[1], 
                        largeGraphics.Transform.Elements[2], largeGraphics.Transform.Elements[3], largeGraphics.Transform.Elements[4], 
                        largeGraphics.Transform.Elements[5]);
                    angleMatrix.RotateAt(tm.Angle, new PointF(Convert.ToSingle(this.Diameter * 2), Convert.ToSingle(this.Diameter * 2)));
                    size = largeGraphics.MeasureString(tm.Text, new Font(tm.Font.FontFamily, tm.Font.Size * 4.0F, tm.Font.Style));
                    points = new Point[] { new Point((this.Diameter * 2) - 4, 0), new Point((this.Diameter * 2) - 4, tm.Length * 4) };
                    angleMatrix.TransformPoints(points);
                    largeGraphics.DrawLine(new Pen(tm.TickMarkColor, tm.Width), points[0], points[1]);

                    if (String.IsNullOrEmpty(tm.Text))
                        continue;

                    fontImage = new Bitmap(Convert.ToInt32(Math.Ceiling(Convert.ToDouble(size.Width))), 
                        Convert.ToInt32(Math.Ceiling(Convert.ToDouble(size.Height))));
                    fontGraphics = Graphics.FromImage(fontImage);
                    fontGraphics.DrawString(tm.Text, new Font(tm.Font.FontFamily, tm.Font.Size * 4.0F, tm.Font.Style),
                        new SolidBrush(tm.FontColor), new PointF(0.0F, 0.0F));

                    points = new Point[] { new Point(this.Diameter * 2 - Convert.ToInt32(size.Width / 2.0F) - 4, 
                        (tm.Length * 4) + Convert.ToInt32(size.Height)) };
                    angleMatrix.TransformPoints(points);
                    largeGraphics.DrawImage(fontImage, points[0]); 
                }
            }

            graphics.DrawImage(largeImage, new Rectangle(0, 0, this.Diameter, this.Diameter));
        }
    }
}
