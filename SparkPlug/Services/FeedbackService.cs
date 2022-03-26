using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using SparkPlug.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SparkPlug.Services
{
    public class FeedbackService
    {
        private MongoClient mongoClient;
        public FeedbackService(IDatabaseSettings settings)
        {
            mongoClient = new MongoClient(settings.ConnectionString);
        }

        public void InsertData(Feedback feedback)
        {
            var _data = ConnectToCustomerTable(feedback.DomainName, feedback.FormName);
            _data.InsertOne(feedback);
        }

        private IMongoCollection<Feedback> ConnectToCustomerTable(string domainName, string formName)
        {
            var db = mongoClient.GetDatabase(domainName);
            var data = db.GetCollection<Feedback>(formName);

            return data;
        }

        public string ValidateFeedback(Feedback feedback)
        {
            if (string.IsNullOrEmpty(feedback.CustomerName) || string.IsNullOrWhiteSpace(feedback.CustomerName))
                return "Name cannot be empty";
            try
            {
                MailAddress m = new MailAddress(feedback.CustomerEmail);
            }
            catch (Exception)
            {
                return "Invalid email Address";
            }

            if (string.IsNullOrEmpty(feedback.CustomerMessage) || string.IsNullOrWhiteSpace(feedback.CustomerMessage))
                return "Message cannot be empty";

            if (feedback.CustomerMessage.Length < 10 || feedback.CustomerMessage.Length > 500)
                return "Message must be between 10 and 500 characters in length!";

            if (string.IsNullOrEmpty(feedback.DomainName) || string.IsNullOrWhiteSpace(feedback.DomainName))
                return "Domain name cannot be empty";

            if (string.IsNullOrEmpty(feedback.FormName) || string.IsNullOrWhiteSpace(feedback.FormName))
                return "Form name cannot be empty";

            return null;
        }
    }
}
