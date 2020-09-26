using GCarvalho.Data.Entidades;

namespace GCarvalho.Data
{
    public class Instrumento
    {
        public int TipoInstrumento { get; set; }

        public virtual OrdemServico OrdemServico{ get; set; }
    }
}
