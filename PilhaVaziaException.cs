using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class PilhaVaziaException : Exception
    {
        //No parameter constructor
        public PilhaVaziaException() : base() { }
        //Constructor with message property definition
        public PilhaVaziaException(string erro) : base(erro) { }
        //Constructor with message and InnerException properties definition
        public PilhaVaziaException(string erro, Exception inner) : base(erro, inner) { }

        //Constructor for serialization
        protected PilhaVaziaException(System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

    }
}
