namespace dotnet-rest-api.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
