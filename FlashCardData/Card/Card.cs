using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public abstract partial class Card : Component
    {
        public enum CardTypeEnum { NumberProblem, FloatingPointProblem, FractionProblem, MultipleChoice, QandA, Unknown };

        private Deck _deck = null;
        private Guid _id = Guid.Empty;
        private Guid? _categoryId = null;

        public Card()
        {
            InitializeComponent();
        }

        public Card(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public Card(IContainer container, Deck deck, XmlElement cardElement)
        {
            container.Add(this, cardElement.Attributes["ID"].InnerText);

            InitializeComponent();

            this.Load(deck, cardElement);
        }

        public Card(Deck deck, XmlElement cardElement)
        {
            InitializeComponent();

            this.Load(deck, cardElement);
        }

        private void Load(Deck deck, XmlElement cardElement)
        {
            if (cardElement == null)
                throw new ArgumentNullException();

            this._deck = deck;
            this._id = new Guid(cardElement.Attributes["ID"].InnerText);
            if (cardElement.Attributes["CategoryID"] == null)
                this._categoryId = null;
            else
                this._categoryId = new Guid(cardElement.Attributes["CategoryID"].InnerText);
        }

        public abstract void SetPromptText(RichTextBox richTextBox);

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Guid ID
        {
            get
            {
                return this._id;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Guid? CategoryID
        {
            get
            {
                return this._categoryId;
            }
            set
            {
                this._categoryId = value;
            }
        }
    }
}
