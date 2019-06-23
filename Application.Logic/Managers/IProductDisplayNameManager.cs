namespace Application.Logic.Managers
{
    using Application.Data.Entities;
    using Application.Logic.Managers.Candidates;

    public interface IProductDisplayNameManager
    {
        ProductDisplayName AddNew(NewProductDisplayNameCandidate candidate);

        ProductDisplayName GetById(int id);

        ProductDisplayName UpdateById(EditProductDisplayNameCandidate candidate);

        int DeleteById(int id);
    }
}
