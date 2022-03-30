namespace APINetMongo.Service
{
    public interface IPeopleService
    {
        List<People> Get();
        People Get(String id);
        People Create(People people);
        void Update(String id, People people);
        void Remove(String id);
    }
}