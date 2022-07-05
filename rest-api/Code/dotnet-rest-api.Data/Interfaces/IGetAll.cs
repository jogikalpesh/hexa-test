using System.Collections.Generic;

namespace dotnet-rest-api.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
