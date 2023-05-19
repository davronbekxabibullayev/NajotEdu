namespace NajotEdu.Application.Abstraction
{
    public interface ICRUDService<T, V, C, U>
    {
        Task<V> GetById(int id);
        Task<IEnumerable<V>> GetAll();
        Task<string> Create(C createModel);
        Task<int> Update(U updateModel);
        Task<int> Delete(int id);
    }
}
