using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Erwine.Leonard.Thomas.WindowsFormsControls
{
    public partial class RoundedTextBox : UserControl
    {
        private bool _showCardFront = true;
        private bool _showCardBack = true;
        private uint _cornerPercentage = 10;
        private Color _cardFrontBorderColor = Color.DarkGray;
        private Color _cardBackBorderColor = Color.Honeydew;
        private Color _cardFrontForeColor = Color.Black;
        private Color _cardBackForeColor = Color.MistyRose;
        private Color _cardFrontBackColor = Color.White;
        private Color _cardBackBackColor = Color.ForestGreen;
        private HatchStyle _cardBackHatchStyle = HatchStyle.Plaid;
        private int _cardBorderWidth = 1;

        [Bindable(false)]
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(true)]
        [DisplayName("Show Card Front")]
        [Description("Show Card Front")]
        public bool ShowCardFront
        {
            get
            {
                return this._showCardFront;
            }
            set
            {
                this._showCardFront = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(true)]
        [DisplayName("Show Card Back")]
        [Description("Show Card Back")]
        public bool ShowCardBack
        {
            get
            {
                return this._showCardBack;
            }
            set
            {
                this._showCardBack = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(5)]
        [DisplayName("Card Corner Percentage")]
        [Description("Percentage of card edge taken up by corners")]
        public uint CornerPercentage
        {
            get
            {
                return this._cornerPercentage;
            }
            set
            {
                this._cornerPercentage = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(3)]
        [DisplayName("Card Border Width")]
        [Description("Card Border Width")]
        public int CardBorderWidth
        {
            get
            {
                return this._cardBorderWidth;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                this._cardBorderWidth = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [Category("Card Front")]
        [DefaultValue("Honeydew")]
        [DisplayName("Border Color")]
        [Description("Card Front Border Color")]
        public Color CardFrontBorderColor
        {
            get
            {
                return this._cardFrontBorderColor;
            }
            set
            {
                this._cardFrontBorderColor = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [Category("Card Backing")]
        [DefaultValue("Honeydew")]
        [DisplayName("Border Color")]
        [Description("Card Backing Border Color")]
        public Color CardBackBorderColor
        {
            get
            {
                return this._cardBackBorderColor;
            }
            set
            {
                this._cardBackBorderColor = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [Category("Card Front")]
        [DefaultValue("MistyRose")]
        [DisplayName("Foreground Color")]
        [Description("Card Front Foreground Color")]
        public Color CardFrontForeColor
        {
            get
            {
                return this._cardFrontForeColor;
            }
            set
            {
                this._cardFrontForeColor = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [Category("Card Backing")]
        [DefaultValue("MistyRose")]
        [DisplayName("Foreground Color")]
        [Description("Card Backing Foreground Color")]
        public Color CardBackForeColor
        {
            get
            {
                return this._cardBackForeColor;
            }
            set
            {
                this._cardBackForeColor = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [Category("Card Front")]
        [DefaultValue("ForestGreen")]
        [DisplayName("Background Color")]
        [Description("Card Front Background Color")]
        public Color CardFrontBackColor
        {
            get
            {
                return this._cardFrontBackColor;
            }
            set
            {
                this._cardFrontBackColor = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [Category("Card Backing")]
        [DefaultValue("ForestGreen")]
        [DisplayName("Background Color")]
        [Description("Card Backing Background Color")]
        public Color CardBackBackColor
        {
            get
            {
                return this._cardBackBackColor;
            }
            set
            {
                this._cardBackBackColor = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [Category("Card Backing")]
        [DefaultValue("Plaid")]
        [DisplayName("Hatch Style")]
        [Description("Card Backing Hatch Style")]
        public HatchStyle CardBackHatchStyle
        {
            get
            {
                return this._cardBackHatchStyle;
            }
            set
            {
                this._cardBackHatchStyle = value;
                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Rtf
        {
            get
            {
                return this.richTextBox1.Rtf;
            }
            set
            {
                this.richTextBox1.Rtf = value;
            }
        }

        public override string Text
        {
            get
            {
                return this.richTextBox1.Text;
            }
            set
            {
                this.richTextBox1.Text = value;
            }
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            if (this.DesignMode)
                this.Refresh();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.DesignMode)
                this.Refresh();
        }

        public RoundedTextBox()
        {
            InitializeComponent();
        }

        private void RoundedTextBox_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap;
            int cornerMargin;

            bitmap = new Bitmap(Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.ClientSize.Width) / 2.0)) - this.Padding.Left - this.Padding.Right - (this.CardBorderWidth * 8),
                this.ClientSize.Height - (this.CardBorderWidth * 8) - this.Padding.Top - this.Padding.Bottom);
            DrawCardBack(bitmap);
            cornerMargin = Convert.ToInt32(Convert.ToSingle(bitmap.Width + bitmap.Height) / 2.0F *
                Convert.ToSingle(this.CornerPercentage) / 100.0F);

            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            if (this.ShowCardBack)
            {
                for (int i = 0; i < 4; i++)
                    e.Graphics.DrawImageUnscaled(bitmap, this.Padding.Left + (i * (this.CardBorderWidth * 2)),
                        this.Padding.Top + (i * (this.CardBorderWidth * 2)));

                this.richTextBox1.Visible = true;
                this.richTextBox1.ForeColor = this.CardBackForeColor;
                this.richTextBox1.BackColor = this.CardBackBackColor;
                this.richTextBox1.Location = new Point(this.Padding.Left + (3 * (this.CardBorderWidth * 2)) + cornerMargin, this.Padding.Top + (3 * (this.CardBorderWidth * 2)) + cornerMargin);
                this.richTextBox1.Size = new Size(bitmap.Width - (cornerMargin * 2), bitmap.Height - (cornerMargin * 2));
            }
            else
            {
                e.Graphics.DrawImageUnscaled(bitmap, this.Padding.Left,
                    this.Padding.Top + (this.ClientSize.Height - bitmap.Height - this.Padding.Top - this.Padding.Bottom) / 2);

                this.richTextBox1.Visible = false;
            }

            this.DrawCardFront(bitmap);

            if (this.ShowCardFront)
            {
                for (int i = 0; i < 4; i++)
                    e.Graphics.DrawImageUnscaled(bitmap, this.ClientSize.Width - bitmap.Width - this.Padding.Right - (i * (this.CardBorderWidth * 2)), 
                        this.Padding.Top + (i * (this.CardBorderWidth * 2)));

                this.richTextBox2.Visible = true;
                this.richTextBox2.ForeColor = this.CardFrontForeColor;
                this.richTextBox2.BackColor = this.CardFrontBackColor;
                this.richTextBox2.Location = new Point((this.ClientSize.Width - bitmap.Width - this.Padding.Right - (3 * (this.CardBorderWidth * 2))) + cornerMargin,
                        (this.Padding.Top + (3 * (this.CardBorderWidth * 2))) + cornerMargin);
                this.richTextBox2.Size = new Size(bitmap.Width - (cornerMargin * 2), bitmap.Height - (cornerMargin * 2));
            }
            else
            {
                e.Graphics.DrawImageUnscaled(bitmap, this.ClientSize.Width - bitmap.Width - this.Padding.Right,
                    this.Padding.Top + (this.ClientSize.Height - bitmap.Height - this.Padding.Top - this.Padding.Bottom) / 2);

                this.richTextBox2.Visible = false;
            }
        }

        private void DrawCardFront(Bitmap bitmap)
        {
            Graphics graphics, hqGraphics;
            SizeF cornerBounds;
            GraphicsPath path;
            float bitMapWidth;
            float bitMapHeight;
            float cardBackBorderWidth;
            Bitmap hqBitmap;

            graphics = Graphics.FromImage(bitmap);

            cornerBounds = new SizeF();
            cornerBounds.Width = Convert.ToSingle(bitmap.Width + bitmap.Height) / 2.0F *
                Convert.ToSingle(this.CornerPercentage) / 100.0F;
            cornerBounds.Height = cornerBounds.Width;
            bitMapWidth = Convert.ToSingle(bitmap.Width);
            bitMapHeight = Convert.ToSingle(bitmap.Height);
            cardBackBorderWidth = Convert.ToSingle(this.CardBorderWidth) * 1.25F;

            path = new GraphicsPath();

            path.AddArc(new RectangleF(new PointF(bitMapWidth - cardBackBorderWidth - cornerBounds.Width,
                bitMapHeight - cardBackBorderWidth - cornerBounds.Height), cornerBounds), 0.0F, 90.0F);
            path.AddLine(
                new PointF(bitMapWidth - cardBackBorderWidth - (cornerBounds.Width / 2), bitMapHeight - cardBackBorderWidth),
                new PointF(cardBackBorderWidth + (cornerBounds.Width / 2), bitMapHeight - cardBackBorderWidth));
            path.AddArc(new RectangleF(
                new PointF(cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - cornerBounds.Height),
                cornerBounds), 90.0F, 90.0F);
            path.AddLine(
                new PointF(cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - (cornerBounds.Height / 2)),
                new PointF(cardBackBorderWidth, cardBackBorderWidth + (cornerBounds.Height / 2)));
            path.AddArc(new RectangleF(
                new PointF(cardBackBorderWidth, cardBackBorderWidth), cornerBounds), 180.0F, 90.0F);
            path.AddLine(
                new PointF(cardBackBorderWidth + (cornerBounds.Width / 2), cardBackBorderWidth),
                new PointF(bitMapWidth - cardBackBorderWidth - (cornerBounds.Width / 2), cardBackBorderWidth));
            path.AddArc(new RectangleF(
                new PointF(bitMapWidth - cardBackBorderWidth - cornerBounds.Width, cardBackBorderWidth), cornerBounds),
                270.0F, 90.0F);
            path.AddLine(
                new PointF(bitMapWidth - cardBackBorderWidth, cardBackBorderWidth + (cornerBounds.Height / 2)),
                new PointF(bitMapWidth - cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - (cornerBounds.Height / 2)));
            path.CloseFigure();

            graphics.FillPath(new SolidBrush(this.CardFrontBackColor), path);

            hqBitmap = new Bitmap(bitmap.Width * 4, bitmap.Height * 4);
            hqGraphics = Graphics.FromImage(hqBitmap);

            path = new GraphicsPath();

            bitMapWidth = Convert.ToSingle(bitmap.Width * 4);
            bitMapHeight = Convert.ToSingle(bitmap.Height * 4);
            cardBackBorderWidth = Convert.ToSingle(this.CardBorderWidth * 4);
            cornerBounds.Width = cornerBounds.Width * 4.0F;
            cornerBounds.Height = cornerBounds.Width;

            path.AddArc(new RectangleF(new PointF(bitMapWidth - cardBackBorderWidth - cornerBounds.Width,
                bitMapHeight - cardBackBorderWidth - cornerBounds.Height), cornerBounds), 0.0F, 90.0F);
            path.AddLine(
                new PointF(bitMapWidth - cardBackBorderWidth - (cornerBounds.Width / 2), bitMapHeight - cardBackBorderWidth),
                new PointF(cardBackBorderWidth + (cornerBounds.Width / 2), bitMapHeight - cardBackBorderWidth));
            path.AddArc(new RectangleF(
                new PointF(cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - cornerBounds.Height),
                cornerBounds), 90.0F, 90.0F);
            path.AddLine(
                new PointF(cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - (cornerBounds.Height / 2)),
                new PointF(cardBackBorderWidth, cardBackBorderWidth + (cornerBounds.Height / 2)));
            path.AddArc(new RectangleF(
                new PointF(cardBackBorderWidth, cardBackBorderWidth), cornerBounds), 180.0F, 90.0F);
            path.AddLine(
                new PointF(cardBackBorderWidth + (cornerBounds.Width / 2), cardBackBorderWidth),
                new PointF(bitMapWidth - cardBackBorderWidth - (cornerBounds.Width / 2), cardBackBorderWidth));
            path.AddArc(new RectangleF(
                new PointF(bitMapWidth - cardBackBorderWidth - cornerBounds.Width, cardBackBorderWidth), cornerBounds),
                270.0F, 90.0F);
            path.AddLine(
                new PointF(bitMapWidth - cardBackBorderWidth, cardBackBorderWidth + (cornerBounds.Height / 2)),
                new PointF(bitMapWidth - cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - (cornerBounds.Height / 2)));
            path.CloseFigure();

            hqGraphics.DrawPath(new Pen(this.CardFrontBorderColor, cardBackBorderWidth), path);

            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.DrawImage(hqBitmap, 0, 0, bitmap.Width, bitmap.Height);
            
            if (this.ShowCardFront)
                return;

            graphics.DrawLine(new Pen(this.CardFrontBorderColor, 1.0F),
                new PointF(cornerBounds.Width / 4.0F, cornerBounds.Height / 4.0F),
                new PointF(bitmap.Width - (cornerBounds.Width / 4.0F), bitmap.Height - (cornerBounds.Height / 4.0F)));

            graphics.DrawLine(new Pen(this.CardFrontBorderColor, 1.0F),
                new PointF(bitmap.Width - (cornerBounds.Width / 4.0F), cornerBounds.Height / 4.0F),
                new PointF(cornerBounds.Width / 4.0F, bitmap.Height - (cornerBounds.Height / 4.0F)));
        }

        private void DrawCardBack(Bitmap bitmap)
        {
            Graphics graphics, hqGraphics;
            SizeF cornerBounds;
            GraphicsPath path;
            float bitMapWidth;
            float bitMapHeight;
            float cardBackBorderWidth;
            Bitmap hqBitmap;

            graphics = Graphics.FromImage(bitmap);

            cornerBounds = new SizeF();
            cornerBounds.Width = Convert.ToSingle(bitmap.Width + bitmap.Height) / 2.0F *
                Convert.ToSingle(this.CornerPercentage) / 100.0F;
            cornerBounds.Height = cornerBounds.Width;
            bitMapWidth = Convert.ToSingle(bitmap.Width);
            bitMapHeight = Convert.ToSingle(bitmap.Height);
            cardBackBorderWidth = Convert.ToSingle(this.CardBorderWidth) * 1.25F;

            path = new GraphicsPath();

            path.AddArc(new RectangleF(new PointF(bitMapWidth - cardBackBorderWidth - cornerBounds.Width,
                bitMapHeight - cardBackBorderWidth - cornerBounds.Height), cornerBounds), 0.0F, 90.0F);
            path.AddLine(
                new PointF(bitMapWidth - cardBackBorderWidth - (cornerBounds.Width / 2), bitMapHeight - cardBackBorderWidth),
                new PointF(cardBackBorderWidth + (cornerBounds.Width / 2), bitMapHeight - cardBackBorderWidth));
            path.AddArc(new RectangleF(
                new PointF(cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - cornerBounds.Height),
                cornerBounds), 90.0F, 90.0F);
            path.AddLine(
                new PointF(cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - (cornerBounds.Height / 2)),
                new PointF(cardBackBorderWidth, cardBackBorderWidth + (cornerBounds.Height / 2)));
            path.AddArc(new RectangleF(
                new PointF(cardBackBorderWidth, cardBackBorderWidth), cornerBounds), 180.0F, 90.0F);
            path.AddLine(
                new PointF(cardBackBorderWidth + (cornerBounds.Width / 2), cardBackBorderWidth),
                new PointF(bitMapWidth - cardBackBorderWidth - (cornerBounds.Width / 2), cardBackBorderWidth));
            path.AddArc(new RectangleF(
                new PointF(bitMapWidth - cardBackBorderWidth - cornerBounds.Width, cardBackBorderWidth), cornerBounds),
                270.0F, 90.0F);
            path.AddLine(
                new PointF(bitMapWidth - cardBackBorderWidth, cardBackBorderWidth + (cornerBounds.Height / 2)),
                new PointF(bitMapWidth - cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - (cornerBounds.Height / 2)));
            path.CloseFigure();

            graphics.FillPath(new HatchBrush(this.CardBackHatchStyle, this.CardBackForeColor, this.CardBackBackColor), path);

            hqBitmap = new Bitmap(bitmap.Width * 4, bitmap.Height * 4);
            hqGraphics = Graphics.FromImage(hqBitmap);

            path = new GraphicsPath();

            bitMapWidth = Convert.ToSingle(bitmap.Width * 4);
            bitMapHeight = Convert.ToSingle(bitmap.Height * 4);
            cardBackBorderWidth = Convert.ToSingle(this.CardBorderWidth * 4);
            cornerBounds.Width = cornerBounds.Width * 4.0F;
            cornerBounds.Height = cornerBounds.Width;

            path.AddArc(new RectangleF(new PointF(bitMapWidth - cardBackBorderWidth - cornerBounds.Width,
                bitMapHeight - cardBackBorderWidth - cornerBounds.Height), cornerBounds), 0.0F, 90.0F);
            path.AddLine(
                new PointF(bitMapWidth - cardBackBorderWidth - (cornerBounds.Width / 2), bitMapHeight - cardBackBorderWidth),
                new PointF(cardBackBorderWidth + (cornerBounds.Width / 2), bitMapHeight - cardBackBorderWidth));
            path.AddArc(new RectangleF(
                new PointF(cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - cornerBounds.Height),
                cornerBounds), 90.0F, 90.0F);
            path.AddLine(
                new PointF(cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - (cornerBounds.Height / 2)),
                new PointF(cardBackBorderWidth, cardBackBorderWidth + (cornerBounds.Height / 2)));
            path.AddArc(new RectangleF(
                new PointF(cardBackBorderWidth, cardBackBorderWidth), cornerBounds), 180.0F, 90.0F);
            path.AddLine(
                new PointF(cardBackBorderWidth + (cornerBounds.Width / 2), cardBackBorderWidth),
                new PointF(bitMapWidth - cardBackBorderWidth - (cornerBounds.Width / 2), cardBackBorderWidth));
            path.AddArc(new RectangleF(
                new PointF(bitMapWidth - cardBackBorderWidth - cornerBounds.Width, cardBackBorderWidth), cornerBounds),
                270.0F, 90.0F);
            path.AddLine(
                new PointF(bitMapWidth - cardBackBorderWidth, cardBackBorderWidth + (cornerBounds.Height / 2)),
                new PointF(bitMapWidth - cardBackBorderWidth, bitMapHeight - cardBackBorderWidth - (cornerBounds.Height / 2)));
            path.CloseFigure();

            hqGraphics.DrawPath(new Pen(this.CardBackBorderColor, cardBackBorderWidth), path);

            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.DrawImage(hqBitmap, 0, 0, bitmap.Width, bitmap.Height);

            if (this.ShowCardBack)
                return;

            graphics.DrawLine(new Pen(this.CardFrontBorderColor, 2.0F),
                new PointF(cornerBounds.Width / 4.0F, cornerBounds.Height / 4.0F),
                new PointF(bitmap.Width - (cornerBounds.Width / 4.0F), bitmap.Height - (cornerBounds.Height / 4.0F)));

            graphics.DrawLine(new Pen(this.CardBackBorderColor, 2.0F),
                new PointF(bitmap.Width - (cornerBounds.Width / 4.0F), cornerBounds.Height / 4.0F),
                new PointF(cornerBounds.Width / 4.0F, bitmap.Height - (cornerBounds.Height / 4.0F)));
        }
    }
}
