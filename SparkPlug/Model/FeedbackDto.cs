using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Model
{
    public class FeedbackDto
    {
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerMessage { get; set; }

        public string _formDomainName { get; set; }

        public string _formName { get; set; }
    }
}
