using System;
using System.IO;
using System.ComponentModel;
using System.Xml;
using System.Collections;
using System.Reflection;
using System.Xml.Schema;
using System.Collections.Generic;
using System.Drawing;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    [ToolboxItem(true)]
    [Serializable()]
    public partial class Deck : Component
    {
        public EventHandler OnDeckChanged;

        private FileInfo _deckFile = null;
        private bool _hasChanges = false;
        private BindingList<Card> _cards;
        private BindingList<Category> _categories;

        public BindingList<Card> Cards
        {
            get
            {
                return this._cards;
            }
        }

        public BindingList<Category> Categories
        {
            get
            {
                return this._categories;
            }
        }

        public Deck()
        {
            InitializeComponent();
        }

        public Deck(IContainer container)
        {
            container.Add(this);
            
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLoaded
        {
            get
            {
                return (this._deckFile != null);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool HasChanges
        {
            get
            {
                return this._hasChanges;
            }
        }

        public void Load(Deck deck)
        {
            this.LoadXml(deck._deckFile.FullName, deck.GetXmlData());
        }

        private string GetXmlData()
        {
            throw new NotImplementedException();
        }

        public void LoadXml(string path, string XmlData)
        {
            XmlDocument doc;
            Assembly assembly;
            XmlReaderSettings settings;
            XmlReader reader;
            XmlSchemaSet schemaSet;

            doc = new XmlDocument();

            assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream("Erwine.Leonard.Thomas.Flash_Cards.Data.Deck.xsd"))
            {
                settings = new XmlReaderSettings();
                settings.CloseInput = true;
                reader = XmlTextReader.Create(stream, settings);
                schemaSet = new XmlSchemaSet();
                schemaSet.Add(Properties.Settings.Default.DeckNamespace, reader);
                reader.Close();
            }

            using (StringReader sr = new StringReader(XmlData))
            {
                settings = new XmlReaderSettings();
                settings.CloseInput = true;
                settings.Schemas = schemaSet;
                settings.ValidationType = ValidationType.Schema;
                reader = XmlTextReader.Create(sr, settings);
                doc.Load(reader);
                reader.Close();
            }

            this.Load(path, doc);
        }

        public void Load(string path, XmlDocument doc)
        {
            XmlNamespaceManager nsmgr;
            XmlElement contentElement;
            Card card;

            if (path == null)
                throw new ArgumentNullException();

            if (path == String.Empty)
                throw new ArgumentException();

            this._deckFile = new FileInfo(path);

            nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("fcd", Properties.Settings.Default.DeckNamespace);

            this._categories = new BindingList<Category>();
            foreach (XmlElement element in doc.SelectNodes("/fcd:Deck/fcd:Categories/fcd:Category", nsmgr))
                this._categories.Add(new Category(this, element));

            this._cards = new BindingList<Card>();
            foreach (XmlElement element in doc.SelectNodes("/fcd:Deck/fcd:Cards/fcd:Card", nsmgr))
            {
                if ((contentElement = element.SelectSingleNode("fcd:QandA", nsmgr) as XmlElement) != null)
                {
                    this._cards.Add(new QandACard(this, contentElement));
                    continue;
                }

                if ((contentElement = element.SelectSingleNode("fcd:MultipleChoice", nsmgr) as XmlElement) != null)
                {
                    this._cards.Add(new MultipleChoiceCard(this, contentElement));
                    continue;
                }

                if ((contentElement = element.SelectSingleNode("fcd:NumberProblem", nsmgr) as XmlElement) != null)
                {
                    this._cards.Add(new NumberProblemCard(this, contentElement));
                    continue;
                }

                if ((contentElement = element.SelectSingleNode("fcd:FloatingPointProblem", nsmgr) as XmlElement) != null)
                {
                    this._cards.Add(new FloatingPointProblemCard(this, contentElement));
                    continue;
                }

                if ((contentElement = element.SelectSingleNode("fcd:FractionProblem", nsmgr) as XmlElement) != null)
                    this._cards.Add(new FractionProblemCard(this, contentElement));
            }
        }

        public void Load(string path)
        {
            XmlDocument doc;
            Assembly assembly;
            XmlReaderSettings settings;
            XmlReader reader;
            XmlSchemaSet schemaSet;

            if (path == null)
                throw new ArgumentNullException();

            if (path == String.Empty)
                throw new ArgumentException();

            this._deckFile = new FileInfo(path);
            doc = new XmlDocument();
            if (!this._deckFile.Exists)
            {
                doc.AppendChild(doc.CreateElement("Deck", Properties.Settings.Default.DeckNamespace));
                doc.DocumentElement.Attributes.Append(doc.CreateAttribute("ID"));
                doc.DocumentElement.Attributes["ID"].InnerText = System.Xml.XmlConvert.ToString(Guid.NewGuid());
                doc.DocumentElement.Attributes.Append(doc.CreateAttribute("Title"));
                doc.DocumentElement.Attributes["Title"].InnerText = String.Empty;
                doc.DocumentElement.AppendChild(doc.CreateElement("Categories", Properties.Settings.Default.DeckNamespace));
                doc.DocumentElement.AppendChild(doc.CreateElement("Cards", Properties.Settings.Default.DeckNamespace));
                this._cards = new BindingList<Card>();
                this._hasChanges = true;
                return;
            }

            assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream("Erwine.Leonard.Thomas.Flash_Cards.Data.Deck.xsd"))
            {
                settings = new XmlReaderSettings();
                settings.CloseInput = true;
                reader = XmlTextReader.Create(stream, settings);
                schemaSet = new XmlSchemaSet();
                schemaSet.Add(Properties.Settings.Default.DeckNamespace, reader);
                reader.Close();
            }

            using (FileStream fs = this._deckFile.OpenRead())
            {
                settings = new XmlReaderSettings();
                settings.CloseInput = true;
                settings.Schemas = schemaSet;
                settings.ValidationType = ValidationType.Schema;
                reader = XmlTextReader.Create(fs, settings);
                doc.Load(reader);
                reader.Close();
            }

            this.Load(path, doc);
        }

        public void Unload()
        {
            this._deckFile = null;
            this._hasChanges = false;
            this._cards = null;
            this._categories = null;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DeckPath
        {
            get
            {
                if (this._deckFile == null)
                    throw new DeckNotLoadedException();

                return this._deckFile.FullName;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Guid ID
        {
            get
            {
                if (this._deckFile == null)
                    throw new DeckNotLoadedException();

                throw new NotImplementedException();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title
        {
            get
            {
                if (this._deckFile == null)
                    throw new DeckNotLoadedException();

                throw new NotImplementedException();
            }
            set
            {
                if (this._deckFile == null)
                    throw new DeckNotLoadedException();

                if (value == null)
                    throw new ArgumentNullException();

                if (value == String.Empty)
                    throw new ArgumentException();

                throw new NotImplementedException();
            }
        }
    }
}
