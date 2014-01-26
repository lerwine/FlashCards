using System;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public partial class Card
    {
        [ToolboxItem(false)]
        public class CardNotLoadedException : Exception
        {
            public CardNotLoadedException() : base() { }

            public CardNotLoadedException(string message) : base(message) { }

            public CardNotLoadedException(string message, Exception innerException) : base(message, innerException) { }

            public CardNotLoadedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        }
    }
}
