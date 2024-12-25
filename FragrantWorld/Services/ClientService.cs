using FragrantWorld.Database;
using FragrantWorld.Interface;
using FragrantWorld.modeles;


namespace FragrantWorld.Services
{
    public class ClientService : IClientService
    {
        private readonly AppDbContext _context;

        public ClientService(AppDbContext context)
        {
            _context = context;
        }
        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }
    }
}
