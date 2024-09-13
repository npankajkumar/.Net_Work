using MVCRestAPIDemos.Models;

namespace MVCRestAPIDemos.Repository
{
    public interface IStoreListRepository
    {
        void Add(Store store);
        void Delete(int id);
        List<Store> GetAll();
        void Update(int id, Store store);
    }
}