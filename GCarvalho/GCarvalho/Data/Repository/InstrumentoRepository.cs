using GCarvalho.Data.Conf;

namespace GCarvalho.Data.Repository
{
    public class InstrumentoRepository : BaseRepository<Instrumento>, IInsturmentoRepository
    {
        public InstrumentoRepository(LuthieriaContext _context) : base(_context)
        {

        }
    }
}
