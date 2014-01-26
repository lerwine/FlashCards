using System;
using System.ComponentModel;
using System.Xml;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public partial class FloatingPointProblemCard : Card
    {
        private double _answer = 0.0;
        private string _problem = null;
    
        public FloatingPointProblemCard()
            : base()
        {
        }

        public FloatingPointProblemCard(IContainer container)
            : base(container)
        {
        }

        public FloatingPointProblemCard(Deck deck, XmlElement contentElement)
            : base(deck, contentElement.ParentNode as XmlElement)
        {
            this.Load(contentElement);
        }

        public FloatingPointProblemCard(IContainer container, Deck deck, XmlElement contentElement)
            : base(container, deck, contentElement.ParentNode as XmlElement)
        {
            this.Load(contentElement);
        }

        public string Problem
        {
            get
            {
                return this._problem;
            }
            set
            {
                this._problem = value;
            }
        }

        public double Answer
        {
            get
            {
                return this._answer;
            }
            set
            {
                this._answer = value;
            }
        }

        private void Load(XmlElement contentElement)
        {
            double? answer;

            this.Problem = Utility.GetXmlNodeText(contentElement, null);
            if ((answer = Utility.GetXmlNodeDouble(contentElement, "@Answer")).HasValue)
                this.Answer = answer.Value;
            else
                this.Answer = 0.0;
        }

        public override void SetPromptText(System.Windows.Forms.RichTextBox richTextBox)
        {
            richTextBox.Rtf = this.Problem;
        }
    }
}
