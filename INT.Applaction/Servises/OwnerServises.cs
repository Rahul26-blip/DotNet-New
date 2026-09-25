using INT.Applaction.Iservises;
using INT.Domain.Entity;
using INT.Infrastucher.IRepository;


namespace INT.Applaction.Servises
{
    public class OwnerServises : IOwnerServises
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerServises(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public void AddOwner(Owner owner)
        {
            _ownerRepository.AddOwner(owner);
        }
        public void Update(Owner owner)
        {
            _ownerRepository.Update(owner);
        }
        public List<Owner> GetAll()
        {
            return _ownerRepository.GetAll();
        }
        public Owner GetById(int id)
        {
            return _ownerRepository.GetById(id);
        }
        public void Delete(int id)
        {
            _ownerRepository.Delete(id);
        }


    }
}
