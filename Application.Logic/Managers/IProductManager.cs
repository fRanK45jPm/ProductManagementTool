namespace Application.Logic.Managers
{
    using System.Collections.Generic;
    using Application.Data.Entities;
    using Application.Logic.Managers.Candidates;

    public interface IProductManager
    {
        Product Add(NewProductCandidate candidate);

        Product GetById(int id);

        Product Update(EditProductCandidate candidate);

        IEnumerable<Product> GetAll();

        int Delete(int projectId);
    }
}