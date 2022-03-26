using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using SparkPlug.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Services
{
    public class FeedbackService
    {
        private MongoClient mongoClient;
        private IDatabaseSettings _settings;
        public FeedbackService(IDatabaseSettings settings)
        {
            mongoClient = new MongoClient(settings.ConnectionString);
        }

        public void InsertData(Feedback data)
        {
            var _data = ConnectToCustomerTable(data.DomainName, data.FormName);
            _data.InsertOne(data);
        }

        private IMongoCollection<Feedback> ConnectToCustomerTable(string domainName, string formName)
        {
            var db = mongoClient.GetDatabase(domainName);
            var data = db.GetCollection<Feedback>(formName);

            return data;
        }

    }
}
