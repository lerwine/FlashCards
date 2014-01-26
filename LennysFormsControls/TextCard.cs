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
    public partial class TextCard : UserControl
    {
        public enum FillTypeEnum { SolidColor, HatchFill, TextureFill, VerticalGradient, HorizontalGradient, DiagonalGradientUlLr, DiagonalGradientUrLl }

        private int _cournerPercentage = 15, _borderWidth;
        private FillTypeEnum _fillType = FillTypeEnum.SolidColor;
        public Color _backColor1 = Color.White, _backColor2 = Color.Gray, _borderColor = Color.DarkGray;
        private Image _texture = null;
        private HatchStyle _hatchStyle = HatchStyle.Cross;
        private WrapMode _wrapMode = WrapMode.Tile;
        private int _cardsShownBehind = 0;
        
        [Bindable(false)]
        [Browsable(true)]
        [DisplayName("Corner Rounding Percentage")]
        [Description("Percentage to round corner")]
        [DefaultValue(15)]
        [Category("Card Style")]
        public int CornerPercentage
        {
            get
            {
                return this._cournerPercentage;
            }
            set
            {
                if (this._cournerPercentage < 0)
                    throw new ArgumentOutOfRangeException();

                this._cournerPercentage = value;

                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [DisplayName("Background Fill Type")]
        [Description("Method used as background fill")]
        [DefaultValue(FillTypeEnum.SolidColor)]
        [Category("Card Style")]
        public FillTypeEnum FillType
        {
            get
            {
                return this._fillType;
            }
            set
            {
                this._fillType = value;

                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [DisplayName("Background color")]
        [Description("Text background color for card")]
        [DefaultValue("White")]
        [Category("Card Style")]
        public Color BackColor1
        {
            get
            {
                return this._backColor1;
            }
            set
            {
                this._backColor1 = value;
                this.richTextBox1.BackColor = value;

                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [DisplayName("Alternate Background color")]
        [Description("Alternate background color for hatch fill")]
        [DefaultValue("Gray")]
        [Category("Card Style")]
        public Color BackColor2
        {
            get
            {
                return this._backColor2;
            }
            set
            {
                this._backColor2 = value;

                if (this.DesignMode && (this.FillType != FillTypeEnum.SolidColor && this.FillType == FillTypeEnum.TextureFill))
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [DisplayName("Border color")]
        [Description("Card border color")]
        [DefaultValue("DarkGray")]
        [Category("Card Style")]
        public Color CardBorderColor
        {
            get
            {
                return this._borderColor;
            }
            set
            {
                this._borderColor = value;

                if (this.DesignMode && this.CardBorderWidth > 0)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [DisplayName("Border width")]
        [Description("Card border width")]
        [DefaultValue(1)]
        [Category("Card Style")]
        public int CardBorderWidth
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

                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [DisplayName("Background Texture Image")]
        [Description("Card Background Image")]
        [Category("Card Style")]
        public Image Texture
        {
            get
            {
                return this._texture;
            }
            set
            {
                this._texture = value;

                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [DisplayName("Background Texture Wrap Mode")]
        [Description("Card Background Image Wrap Mode")]
        [DefaultValue("Tile")]
        [Category("Card Style")]
        public WrapMode WrapMode
        {
            get
            {
                return this._wrapMode;
            }
            set
            {
                this._wrapMode = value;

                if (this.DesignMode && this.Texture != null)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [DisplayName("Background Hatch Style")]
        [Description("Hatch Style for background fill")]
        [DefaultValue("Cross")]
        [Category("Card Style")]
        public HatchStyle HatchStyle
        {
            get
            {
                return this._hatchStyle;
            }
            set
            {
                this._hatchStyle = value;

                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Bindable(false)]
        [Browsable(true)]
        [DisplayName("Cards Shown Behind")]
        [Description("Cards to show behind top card for \"stack\" appearance")]
        [DefaultValue(0)]
        [Category("Card Style")]
        public int CardsShownBehind
        {
            get
            {
                return this._cardsShownBehind;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                this._cardsShownBehind = value;

                if (this.DesignMode)
                    this.Refresh();
            }
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;

                this.richTextBox1.ForeColor = value;

                if (this.DesignMode)
                    this.Refresh();
            }
        }

        [Browsable(false)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RichTextBox RichTextBox
        {
            get
            {
                return this.richTextBox1;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                this.richTextBox1.Font = value;
            }
        }
        public int GetActualCardWidth()
        {
            return this.ClientSize.Width - (this.CardsShownBehind * (this.CardBorderWidth * 2));
        }

        public int GetActualCardHeight()
        {
            return this.ClientSize.Height - (this.CardsShownBehind * (this.CardBorderWidth * 2));
        }

        public TextCard()
        {
            InitializeComponent();
        }

        private void TextCard_Paint(object sender, PaintEventArgs e)
        {
            int width, height;
            RoundedSquare square;
            FillTypeEnum fillType;
            Image cardImage;
            int backBorderWidth;

            width = this.GetActualCardWidth();
            height = this.GetActualCardHeight();

            if ((fillType = this.FillType) == FillTypeEnum.TextureFill && this.Texture == null)
                fillType = FillTypeEnum.SolidColor;

            square = new RoundedSquare(width, height, this.CornerPercentage);

            switch (fillType)
            {
                case FillTypeEnum.HatchFill:
                    cardImage = square.GetHatchedImage(this.CardBorderColor, this.CardBorderWidth, this.BackColor1, this.BackColor2, this.HatchStyle);
                    break;
                case FillTypeEnum.DiagonalGradientUlLr:
                    cardImage = square.GetLinearGradientImage(this.CardBorderColor, this.CardBorderWidth,
                        new Point(0, 0), new Point(width - 1, height - 1), this.BackColor1, this.BackColor2);
                    break;
                case FillTypeEnum.DiagonalGradientUrLl:
                    cardImage = square.GetLinearGradientImage(this.CardBorderColor, this.CardBorderWidth,
                        new Point(width - 1, 0), new Point(0, height - 1), this.BackColor1, this.BackColor2);
                    break;
                case FillTypeEnum.HorizontalGradient:
                    cardImage = square.GetLinearGradientImage(this.CardBorderColor, this.CardBorderWidth,
                        new Point(0, 0), new Point(width - 1, 0), this.BackColor1, this.BackColor2);
                    break;
                case FillTypeEnum.VerticalGradient:
                    cardImage = square.GetLinearGradientImage(this.CardBorderColor, this.CardBorderWidth,
                        new Point(0, 0), new Point(0, height - 1), this.BackColor1, this.BackColor2);
                    break;
                case FillTypeEnum.TextureFill:
                    cardImage = square.GetTextureImage(this.CardBorderColor, this.CardBorderWidth, this.Texture, this.WrapMode, this.BackColor1);
                    break;
                default:
                    cardImage = square.GetSolidImage(this.CardBorderColor, this.CardBorderWidth, this.BackColor1);
                    break;
            }

            if ((backBorderWidth = this.CardBorderWidth) < 1)
                backBorderWidth = 1;

            for (int i = 0; i < this.CardsShownBehind; i++)
                e.Graphics.DrawImage(cardImage, new Point(i * backBorderWidth * 2, i * backBorderWidth * 2));

            e.Graphics.DrawImage(cardImage, new Point(this.CardsShownBehind * backBorderWidth * 2, this.CardsShownBehind * backBorderWidth * 2));

            if (String.IsNullOrEmpty(this.richTextBox1.Text))
            {
                this.richTextBox1.Visible = false;
                return;
            }

            this.richTextBox1.Visible = true;
            this.richTextBox1.Location = new Point((this.CardsShownBehind * backBorderWidth * 2) + square.GetPadding(),
                (this.CardsShownBehind * backBorderWidth * 2) + square.GetPadding());
            this.richTextBox1.Width = square.GetInnerWidth();
            this.richTextBox1.Height = square.GetInnerHeight();
            this.richTextBox1.BackColor = this.BackColor1;
            this.richTextBox1.ForeColor = this.ForeColor;
        }
    }
}
