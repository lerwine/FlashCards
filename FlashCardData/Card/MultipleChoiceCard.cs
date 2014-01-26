using System;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;
using System.Drawing;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public partial class MultipleChoiceCard : Card
    {
        private Erwine.Leonard.Thomas.Flash_Cards.Data.MultipleChoiceItem[] _choices = null;
        private string _question = null;
    
        public MultipleChoiceCard()
            : base()
        {
        }

        public MultipleChoiceCard(IContainer container)
            : base(container)
        {
        }

        public MultipleChoiceCard(Deck deck, XmlElement contentElement)
            : base(deck, contentElement.ParentNode as XmlElement)
        {
            this.Load(contentElement);
        }

        public MultipleChoiceCard(IContainer container, Deck deck, XmlElement contentElement)
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

        public Erwine.Leonard.Thomas.Flash_Cards.Data.MultipleChoiceItem[] Choices
        {
            get
            {
                return this._choices;
            }
        }

        private void Load(XmlElement contentElement)
        {
            List<MultipleChoiceItem> items;
            XmlNamespaceManager nsmgr;

            this.Question = Utility.GetXmlNodeText(contentElement, "Question");

            items = new List<MultipleChoiceItem>();
            nsmgr = new XmlNamespaceManager(contentElement.OwnerDocument.NameTable);
            nsmgr.AddNamespace("fcd", Properties.Settings.Default.DeckNamespace);

            foreach (XmlElement element in contentElement.SelectNodes("fcd:Choices/fcd:Choice"))
                items.Add(new MultipleChoiceItem(element));

            this._choices = items.ToArray();
        }

        public override void SetPromptText(System.Windows.Forms.RichTextBox richTextBox)
        {
            int cursor;

            richTextBox.Rtf = this.Question;
            richTextBox.AppendText("\r\n");
            for (int i = 0; i < this._choices.Length; i++)
            {
                cursor = richTextBox.TextLength;
                richTextBox.AppendText(String.Format("\r\n{0}: ", i + 1));
                richTextBox.SelectionStart = cursor;
                richTextBox.SelectionLength = richTextBox.TextLength - cursor;
                richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font, FontStyle.Bold);

                cursor = richTextBox.TextLength;
                richTextBox.AppendText(this._choices[i].Value);
                richTextBox.SelectionStart = cursor;
                richTextBox.SelectionLength = richTextBox.TextLength - cursor;
                richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font, FontStyle.Regular);
            }
            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = 0;
        }
    }
}
