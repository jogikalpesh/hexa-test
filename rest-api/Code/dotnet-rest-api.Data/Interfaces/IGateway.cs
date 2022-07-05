using MongoDB.Driver;

namespace dotnet-rest-api.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
