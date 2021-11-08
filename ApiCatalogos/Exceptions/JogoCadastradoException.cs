using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogos.Exceptions
{
    public class JogoCadastradoException : Exception
    {
        public JogoCadastradoException()
            : base ("Este jogo já está cadastrado") { }
    }
}
