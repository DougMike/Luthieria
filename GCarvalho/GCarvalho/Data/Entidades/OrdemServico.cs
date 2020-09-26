using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCarvalho.Data.Entidades
{
    public class OrdemServico
    {
        public int idOrdemServico { get; set; }
        public virtual Instrumento Instrumento { get; set; }

    }
}
