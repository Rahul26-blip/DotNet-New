using INT.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace INT.Applaction.Iservises
{
    public interface IOwnerServises
    {
        void AddOwner(Owner owner);
        void Update(Owner owner);
        List<Owner> GetAll();
        Owner GetById(int id);
        void Delete(int id);
    }
}
