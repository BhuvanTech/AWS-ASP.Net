using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    [DynamoDBTable("Students")]
    public class Student
    {
        [DynamoDBHashKey("Id")]
        public string? Id { get; set; }

        [DynamoDBProperty("FirstName")]
        public string? FirstName { get; set; }

        [DynamoDBProperty("LastName")]
        public string? LastName { get; set; }

        [DynamoDBProperty("Class")]
        public int Class { get; set; }

        [DynamoDBProperty("Country")]
        public string? Country { get; set; }
    }
}
