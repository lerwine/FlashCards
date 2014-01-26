using System;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public partial class Deck
    {
        [ToolboxItem(false)]
        public class DeckNotLoadedException : Exception
        {
            public DeckNotLoadedException() : base() { }

            public DeckNotLoadedException(string message) : base(message) { }

            public DeckNotLoadedException(string message, Exception innerException) : base(message, innerException) { }

            public DeckNotLoadedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        }
    }
}
