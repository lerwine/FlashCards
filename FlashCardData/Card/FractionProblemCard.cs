using System;
using System.ComponentModel;
using System.Xml;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public partial class FractionProblemCard : Card
    {
        private string _problem = null;
        private int _numeratorAnswer = 0;
        private int _denominatorAnswer = 0;
    
        public FractionProblemCard()
            : base()
        {
        }

        public FractionProblemCard(IContainer container)
            : base(container)
        {
        }

        public FractionProblemCard(Deck deck, XmlElement contentElement)
            : base(deck, contentElement.ParentNode as XmlElement)
        {
            this.Load(contentElement);
        }

        public FractionProblemCard(IContainer container, Deck deck, XmlElement contentElement)
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

        public int NumeratorAnswer
        {
            get
            {
                return this._numeratorAnswer;
            }
            set
            {
                this._numeratorAnswer = value;
            }
        }

        public int DenominatorAnswer
        {
            get
            {
                return this._denominatorAnswer;
            }
            set
            {
                this._denominatorAnswer = value;
            }
        }

        private void Load(XmlElement contentElement)
        {
            int? value;
            this.Problem = Utility.GetXmlNodeText(contentElement, null);

            if ((value = Utility.GetXmlNodeInteger(contentElement, "@NumeratorAnswer")).HasValue)
                this.NumeratorAnswer = value.Value;
            else
                this.NumeratorAnswer = 0;
            if ((value = Utility.GetXmlNodeInteger(contentElement, "@DenominatorAnswer")).HasValue)
                this.DenominatorAnswer = value.Value;
            else
                this.DenominatorAnswer = 1;
        }

        public override void SetPromptText(System.Windows.Forms.RichTextBox richTextBox)
        {
            richTextBox.Rtf = this.Problem;
        }
    }
}
