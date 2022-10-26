using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver.Core.Configuration;

namespace DAL
{
    public class MongoHelper
    {
        protected static MongoClient _client;
        protected static MongoHelper _helper;
        protected IMongoDatabase database;

        public MongoHelper()
        { _client = new MongoClient("mongodb+srv://gg3:gg3@cluster0.mhym582.mongodb.net/?retryWrites=true&w=majority"); database = _client.GetDatabase("NoSqlProjectDatabase"); }


        public static MongoHelper getInstance()
        {
            if (_helper == null)
                _helper = new MongoHelper();
            return _helper;
        }

        public List<DatabaseModel> getAllDbs()
        {
            List<DatabaseModel> dbs = new List<DatabaseModel>();
            foreach (BsonDocument db in _client.ListDatabases().ToList())
                dbs.Add(BsonSerializer.Deserialize<DatabaseModel>(db));
            return dbs;
        }

        protected List<BsonDocument> GetListOfDocuments(string collection)
        {
            var Collection = database.GetCollection<BsonDocument>(collection);
            var filter = Builders<BsonDocument>.Filter.Empty;
            var Documents = Collection.Find(filter).ToList();

            return Documents;
        }

        protected List<BsonDocument> GetListOfFilteredDocuments(string collection, string searchValue, int atribute)
        {
            var Collection = database.GetCollection<BsonDocument>(collection);
            var filter = Builders<BsonDocument>.Filter.Eq(searchValue, atribute);
            var Documents = Collection.Find(filter).ToList();

            return Documents;
        }
    }
}
