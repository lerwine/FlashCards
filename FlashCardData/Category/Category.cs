using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public partial class Category : Component
    {
        public Category()
        {
            InitializeComponent();
        }

        public Category(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        internal Category(Deck deck, System.Xml.XmlElement element)
        {
            throw new NotImplementedException();
        }
    }
}
