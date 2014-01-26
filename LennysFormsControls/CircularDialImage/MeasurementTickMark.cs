using System;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace Erwine.Leonard.Thomas.WindowsFormsControls
{
    public partial class CircularDialImage
    {
        public struct MeasurementTickMark
        {
            private float _angle;
            private int _width, _length;
            private Color _tickMarkColor, _fontColor;
            private string _text;
            private Font _font;
            private HorizontalAlign _textAlign;
            private bool _innerOrientation;

            public float Angle
            {
                get
                {
                    return this._angle;
                }
                set
                {
                    if (this._angle < 0.0F || this._angle >= 360.0F)
                        throw new ArgumentOutOfRangeException();

                    this._angle = value;
                }
            }

            public int Width
            {
                get
                {
                    return this._width;
                }
                set
                {
                    if (this._width < 1)
                        throw new ArgumentOutOfRangeException();

                    this._width = value;
                }
            }

            public int Length
            {
                get
                {
                    return this._length;
                }
                set
                {
                    if (this._length < 1)
                        throw new ArgumentOutOfRangeException();

                    this._length = value;
                }
            }

            public Color TickMarkColor
            {
                get
                {
                    return this._tickMarkColor;
                }
                set
                {
                    this._tickMarkColor = value;
                }
            }

            public HorizontalAlign TextAlign
            {
                get
                {
                    return this._textAlign;
                }
                set
                {
                    this._textAlign = value;
                }
            }

            public string Text
            {
                get
                {
                    return this._text;
                }
                set
                {
                    this._text = value;
                }
            }

            public Color FontColor
            {
                get
                {
                    return this._fontColor;
                }
                set
                {
                    this._fontColor = value;
                }
            }

            public Font Font
            {
                get
                {
                    return this._font;
                }
                set
                {
                    this._font = value;
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

            public MeasurementTickMark(float angle, int length)
                : this(angle, length, false) { }

            public MeasurementTickMark(float angle, int length, bool innerOrientation)
                : this(angle, length, 1, innerOrientation) { }

            public MeasurementTickMark(float angle, int length, int width)
                : this(angle, length, width, false) { }

            public MeasurementTickMark(float angle, int length, int width, bool innerOrientation)
                : this(angle, length, width, Color.Black, false) { }

            public MeasurementTickMark(float angle, int length, int width, Color color)
                : this(angle, length, width, color, false) { }

            public MeasurementTickMark(float angle, int length, int width, Color color, bool innerOrientation)
                : this(angle, length, width, color, null, new Font(FontFamily.GenericSansSerif, 8.25F, GraphicsUnit.Point), 
                innerOrientation) { }

            public MeasurementTickMark(float angle, int length, int width, Color color, string text, Font font)
                : this(angle, length, width, color, text, font, false) { }

            public MeasurementTickMark(float angle, int length, int width, Color color, string text, Font font, bool innerOrientation)
                : this(angle, length, width, color, text, font, color, innerOrientation) { }

            public MeasurementTickMark(float angle, int length, int width, Color tickMarkColor, string text, Font font, Color fontColor)
                : this(angle, length, width, tickMarkColor, text, font, fontColor, false) { }

            public MeasurementTickMark(float angle, int length, int width, Color tickMarkColor, string text, Font font, Color fontColor, 
                    bool innerOrientation)
                : this(angle, length, width, tickMarkColor, text, font, fontColor, HorizontalAlign.Center, innerOrientation) { }

            public MeasurementTickMark(float angle, int length, int width, Color tickMarkColor, string text, Font font, Color fontColor,
                HorizontalAlign textAlign)
                : this(angle, length, width, tickMarkColor, text, font, fontColor, textAlign, false) { }

            public MeasurementTickMark(float angle, int length, int width, Color tickMarkColor, string text, Font font, Color fontColor,
                HorizontalAlign textAlign, bool innerOrientation)
            {
                this._tickMarkColor = tickMarkColor;
                this._angle = angle;
                this._length = length;
                this._width = width;
                this._fontColor = fontColor;
                this._textAlign = textAlign;
                this._innerOrientation = innerOrientation;
                this._font = font;
                this._text = text;
            }
        }
    }
}