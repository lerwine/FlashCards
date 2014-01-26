using System;
using System.ComponentModel;
using System.Xml;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public partial class NumberProblemCard : Card
    {
        private long _numberAnswer = 0;
        private string _problem = null;
        private long? _remainderAnswer = null;
    
        public NumberProblemCard()
            : base()
        {
        }

        public NumberProblemCard(IContainer container)
            : base(container)
        {
        }

        public NumberProblemCard(Deck deck, XmlElement contentElement)
            : base(deck, contentElement.ParentNode as XmlElement)
        {
            this.Load(contentElement);
        }

        public NumberProblemCard(IContainer container, Deck deck, XmlElement contentElement)
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

        public long NumberAnswer
        {
            get
            {
                return this._numberAnswer;
            }
            set
            {
                this._numberAnswer = value;
            }
        }

        public long? RemainderAnswer
        {
            get
            {
                return this._remainderAnswer;
            }
            set
            {
                this._remainderAnswer = value;
            }
        }

        private void Load(XmlElement contentElement)
        {
            long? value;

            this.Problem = Utility.GetXmlNodeText(contentElement, null);
            if ((value = Utility.GetXmlNodeLong(contentElement, "@NumberAnswer")).HasValue)
                this.NumberAnswer = value.Value;
            else
                this.NumberAnswer = 0;
            this.RemainderAnswer = Utility.GetXmlNodeLong(contentElement, "@RemainderAnswer");
        }

        public override void SetPromptText(System.Windows.Forms.RichTextBox richTextBox)
        {
            richTextBox.Rtf = this.Problem;
        }
    }
}
