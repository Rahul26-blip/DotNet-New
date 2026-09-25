using INT.Domain.Entity;
using INT.Infrastucher.Context;
using INT.Infrastucher.IRepository;

namespace INT.Infrastucher.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly AppDbCntext _context;


        public OwnerRepository(AppDbCntext context)
        {
            _context = context;
        }

        public void AddOwner(Owner owner)
        {

            owner.IsActive = true;

            _context.Owner.Add(owner);

            _context.SaveChanges();
        }

        public void Update(Owner owner)
        {
            var existingOwner = _context.Owner.FirstOrDefault(x => x.OwnerId == owner.OwnerId);

            _context.Owner.Update(existingOwner);
            _context.SaveChanges();
        }
        public Owner GetById(int id)
        {
            return _context.Owner.FirstOrDefault(x => x.OwnerId == id);
        }

        public List<Owner> GetAll()
        {
            return _context.Owner.ToList();
        }
        public void Delete(int id)
        {
            var owner = _context.Owner .FirstOrDefault(x => x.OwnerId == id);

            _context.Owner.Remove(owner);

            _context.SaveChanges();

        }
    }
}
