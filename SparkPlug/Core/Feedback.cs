using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Core
{
    public class Feedback
    {
        /// <summary>
        /// Mongo db auto generated Id
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        /// <summary>
        /// Customer Name
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Customer Email Address
        /// </summary>
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Customer message
        /// </summary>
        public string CustomerMessage { get; set; }

        /// <summary>
        /// Domain name of website
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Form
        /// </summary>
        public string FormName { get; set; }
    }
}
