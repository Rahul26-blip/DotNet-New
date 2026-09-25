using INT.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace INT.Infrastucher.IRepository
{
    public interface IOwnerRepository
    {
        
        List<Owner> GetAll();
        Owner GetById(int id);
        void AddOwner(Owner owner);
        void Update(Owner owner);
        void Delete(int id);

    }
}
