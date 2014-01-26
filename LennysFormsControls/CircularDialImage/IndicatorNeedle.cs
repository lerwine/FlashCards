using System;
using System.Drawing;

namespace Erwine.Leonard.Thomas.WindowsFormsControls
{
    public partial class CircularDialImage
    {
        public struct IndicatorNeedle
        {
            private float _angle;
            private int _width, _length;
            private Color _color;

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

            public Color Color
            {
                get
                {
                    return this._color;
                }
                set
                {
                    this._color = value;
                }
            }

            public IndicatorNeedle(float angle, int length)
                : this(angle, length, 1) { }

            public IndicatorNeedle(float angle, int length, int width)
                : this(angle, length, width, Color.Black) { }

            public IndicatorNeedle(float angle, int length, int width, Color color)
            {
                this._color = color;
                this._angle = angle;
                this._length = length;
                this._width = width;
            }
        }
    }
}