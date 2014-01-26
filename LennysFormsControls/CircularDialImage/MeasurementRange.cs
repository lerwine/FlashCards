using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Erwine.Leonard.Thomas.WindowsFormsControls
{
    public partial class CircularDialImage
    {
        public struct MeasurementRange
        {
            private float _rangeStart, _rangeEnd;
            private int _borderWidth, _height;
            private Color _backColor1, _backColor2, _borderColor;
            private Image _texture;
            private HatchStyle _hatchStyle;
            private FillTypeEnum _fillType;
            private Point _point1;
            private Point _point2;
            private WrapMode _wrapMode;
            private bool _innerOrientation;

            public float RangeStart
            {
                get
                {
                    return this._rangeStart;
                }
                set
                {
                    
                    if (value < 0.0F || value >= 360.0F)
                        throw new ArgumentOutOfRangeException();

                    this._rangeStart = value;
                }
            }

            public float RangeEnd
            {
                get
                {
                    return this._rangeEnd;
                }
                set
                {
                    if (value < 0.0F || value >= 360.0F)
                        throw new ArgumentOutOfRangeException();

                    this._rangeEnd = value;
                }
            }

            public int BorderWidth
            {
                get
                {
                    return this._borderWidth;
                }
                set
                {
                    if (value < 0)
                        throw new ArgumentOutOfRangeException();

                    this._borderWidth = value;
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
                    if (value < 0)
                        throw new ArgumentOutOfRangeException();

                    this._height = value;
                }
            }

            public Color BackColor1
            {
                get
                {
                    return this._backColor1;
                }
            }

            public Color BackColor2
            {
                get
                {
                    return this._backColor2;
                }
            }

            public Color BorderColor
            {
                get
                {
                    return this._borderColor;
                }
                set
                {
                    this._borderColor = value;
                }
            }

            public FillTypeEnum FillType
            {
                get
                {
                    return this._fillType;
                }
            }

            public Image Texture
            {
                get
                {
                    return this._texture;
                }
            }

            public HatchStyle HatchStyle
            {
                get
                {
                    return this._hatchStyle;
                }
            }

            public Point Point1
            {
                get
                {
                    return this._point1;
                }
            }

            public Point Point2
            {
                get
                {
                    return this._point2;
                }
            }

            public WrapMode WrapMode
            {
                get
                {
                    return this._wrapMode;
                }
            }

            public bool InnerOrientation
            {
                get
                {
                    return this._innerOrientation;
                }
                set
                {
                    this._innerOrientation = value;
                }
            }

            private MeasurementRange(float rangeStart, float rangeEnd, int height, int borderWidth, Color borderColor, bool innerOrientation)
            {
                if (rangeStart < 0.0F || rangeStart >= 360.0F)
                    throw new ArgumentOutOfRangeException("rangeStart");

                if (rangeEnd < 0.0F || rangeEnd >= 360.0F)
                    throw new ArgumentOutOfRangeException("rangeEnd");

                if (borderWidth < 0)
                    throw new ArgumentOutOfRangeException("borderWidth");

                if (height < 0)
                    throw new ArgumentOutOfRangeException("height");

                this._rangeStart = rangeStart;
                this._rangeEnd = rangeEnd;
                this._borderWidth = borderWidth;
                this._borderColor = borderColor;
                this._height = height;
                this._backColor1 = Color.White;
                this._backColor2 = Color.Gray;
                this._texture = null;
                this._hatchStyle = HatchStyle.Percent50;
                this._fillType = FillTypeEnum.SolidColor;
                this._point1 = new Point();
                this._point2 = new Point();
                this._wrapMode = WrapMode.Tile;
                this._innerOrientation = innerOrientation;
            }

            public MeasurementRange(float rangeStart, float rangeEnd, int borderWidth, int height)
                : this(rangeStart, rangeEnd, height, borderWidth, false) { }

            public MeasurementRange(float rangeStart, float rangeEnd, int borderWidth, int height, bool innerOrientation)
                : this(rangeStart, rangeEnd, height, borderWidth, Color.Black, innerOrientation)
            {
                this.SetSolidFill(Color.White);
            }

            public MeasurementRange(float rangeStart, float rangeEnd, int borderWidth, int height, Color borderColor, Color backColor)
                : this(rangeStart, rangeEnd, height, borderWidth, borderColor, false) { }

            public MeasurementRange(float rangeStart, float rangeEnd, int borderWidth, int height, Color borderColor, Color backColor, 
                bool innerOrientation)
                : this(rangeStart, rangeEnd, height, borderWidth, borderColor, innerOrientation)
            {
                this.SetSolidFill(backColor);
            }

            public MeasurementRange(float rangeStart, float rangeEnd, int borderWidth, int height, Color borderColor, Color backColor,
                Image image, WrapMode wrapMode)
                : this(rangeStart, rangeEnd, height, borderWidth, borderColor, false) { }

            public MeasurementRange(float rangeStart, float rangeEnd, int borderWidth, int height, Color borderColor, Color backColor,
                Image image, WrapMode wrapMode, bool innerOrientation)
                : this(rangeStart, rangeEnd, height, borderWidth, borderColor, innerOrientation)
            {
                this.SetTextureFill(backColor, image, wrapMode);
            }

            public MeasurementRange(float rangeStart, float rangeEnd, int borderWidth, int height, Color borderColor, Color backColor1,
                Color backColor2, HatchStyle hatchStyle)
                : this(rangeStart, rangeEnd, height, borderWidth, borderColor, false) { }

            public MeasurementRange(float rangeStart, float rangeEnd, int borderWidth, int height, Color borderColor, Color backColor1,
                Color backColor2, HatchStyle hatchStyle, bool innerOrientation)
                : this(rangeStart, rangeEnd, height, borderWidth, borderColor, innerOrientation)
            {
                this.SetHatchFill(backColor1, backColor2, hatchStyle);
            }

            public MeasurementRange(float rangeStart, float rangeEnd, int borderWidth, int height, Color borderColor, Color backColor1,
                Color backColor2, Point point1, Point point2)
                : this(rangeStart, rangeEnd, height, borderWidth, borderColor, false) { }

            public MeasurementRange(float rangeStart, float rangeEnd, int borderWidth, int height, Color borderColor, Color backColor1,
                Color backColor2, Point point1, Point point2, bool innerOrientation)
                : this(rangeStart, rangeEnd, height, borderWidth, borderColor, innerOrientation)
            {
                this.SetLinearGradientFill(backColor1, backColor2, point1, point2);
            }

            public void SetSolidFill(Color backColor)
            {
                this._fillType = FillTypeEnum.SolidColor;
                this._backColor1 = backColor;
            }

            public void SetLinearGradientFill(Color backColor1, Color backColor2, Point point1, Point point2)
            {
                this._fillType = FillTypeEnum.LinearGradient;
                this._backColor1 = backColor1;
                this._backColor2 = backColor2;
                this._point1 = point1;
                this._point2 = point2;
            }

            public void SetHatchFill(Color backColor1, Color backColor2, HatchStyle hatchStyle)
            {
                this._fillType = FillTypeEnum.HatchFill;
                this._backColor1 = backColor1;
                this._backColor2 = backColor2;
                this._hatchStyle = hatchStyle;
            }

            public void SetTextureFill(Color backColor, Image image, WrapMode wrapMode)
            {
                this._fillType = FillTypeEnum.TextureFill;
                this._backColor1 = backColor;
                this._texture = image;
                this._wrapMode = wrapMode;
            }
        }
    }
}