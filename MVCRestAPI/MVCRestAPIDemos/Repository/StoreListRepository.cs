using MVCRestAPIDemos.Models;

namespace MVCRestAPIDemos.Repository
{
    public class StoreListRepository : IStoreListRepository
    {
        public List<Store> list = new List<Store>();

        public void Add(Store store)
        {
            list.Add(store);
        }
        public List<Store> GetAll()
        {
            return list;
        }
        public void Delete(int id)
        {

            var find = list.Where(x => x.Id == id).FirstOrDefault();
            if (find != null)
            {
                list.Remove(find);
            }
        }
        public void Update(int id, Store store)
        {
            var find = list.Where(x => x.Id == id).FirstOrDefault();
            if (find != null)
            {
                find.Name = store.Name;
                find.Location = store.Location;
            }

        }
    }
}
