using System;
using System.ComponentModel;
using System.Xml;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public partial class QandACard : Card
    {
        private string _question = null;
        private string _answer = null;
    
        public QandACard()
            : base()
        {
        }

        public QandACard(IContainer container)
            : base(container)
        {
        }

        public QandACard(Deck deck, XmlElement contentElement)
            : base(deck, contentElement.ParentNode as XmlElement)
        {
            this.Load(contentElement);
        }

        public QandACard(IContainer container, Deck deck, XmlElement contentElement)
            : base(container, deck, contentElement.ParentNode as XmlElement)
        {
            this.Load(contentElement);
        }

        public string Question
        {
            get
            {
                return this._question;
            }
            set
            {
                this._question = value;
            }
        }

        public string Answer
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
            this.Question = Utility.GetXmlNodeText(contentElement, "Question");
            this.Answer = Utility.GetXmlNodeText(contentElement, "Answer");
        }

        public override void SetPromptText(System.Windows.Forms.RichTextBox richTextBox)
        {
            richTextBox.Rtf = this.Question;
        }
    }
}
