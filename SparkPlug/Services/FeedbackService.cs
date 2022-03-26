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
    /// <summary>
    /// Feedback service
    /// </summary>
    public class FeedbackService
    {
        private MongoClient _mongoClient;
        public FeedbackService(IDatabaseSettings settings)
        {
            _mongoClient = new MongoClient(settings.ConnectionString);
        }

        /// <summary>
        /// Insert data service
        /// </summary>
        /// <param name="feedback"></param>
        public void InsertData(Feedback feedback)
        {
            // Connect to the customer table.
            var _data = ConnectToCustomerTable(feedback.DomainName, feedback.FormName);
            _data.InsertOne(feedback);
        }

        /// <summary>
        /// Connect to the Database
        /// </summary>
        /// <param name="domainName"></param>
        /// <param name="formName"></param>
        /// <returns></returns>
        private IMongoCollection<Feedback> ConnectToCustomerTable(string domainName, string formName)
        {
            // Get database. The function retrieves the database or creates a new one if it does not exist.
            var db = _mongoClient.GetDatabase(domainName);

            // Get Feedback collection
            var data = db.GetCollection<Feedback>(formName);

            return data;
        }


        /// <summary>
        /// Validates the data sent to the API
        /// </summary>
        /// <param name="feedback"></param>
        /// <returns></returns>
        public string ValidateFeedback(Feedback feedback)
        {
            // Check if customer name is not empty
            if (string.IsNullOrEmpty(feedback.CustomerName) || string.IsNullOrWhiteSpace(feedback.CustomerName))
                return "Name cannot be empty";
            try
            {
                // Check if email is a valid email address
                MailAddress m = new MailAddress(feedback.CustomerEmail);
            }
            catch (Exception)
            {
                return "Invalid email Address";
            }

            // Check if customer message is not empty
            if (string.IsNullOrEmpty(feedback.CustomerMessage) || string.IsNullOrWhiteSpace(feedback.CustomerMessage))
                return "Message cannot be empty";

            // Checks if the length of the message is between 10 and 500
            if (feedback.CustomerMessage.Length < 10 || feedback.CustomerMessage.Length > 500)
                return "Message must be between 10 and 500 characters in length!";

            // Checks if the domain name is not empty
            if (string.IsNullOrEmpty(feedback.DomainName) || string.IsNullOrWhiteSpace(feedback.DomainName))
                return "Domain name cannot be empty";

            // Checks if the form name is not empty
            if (string.IsNullOrEmpty(feedback.FormName) || string.IsNullOrWhiteSpace(feedback.FormName))
                return "Form name cannot be empty";

            return null;
        }
    }
}
