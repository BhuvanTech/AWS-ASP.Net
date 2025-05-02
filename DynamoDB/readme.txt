Packages needed for DynamoDB

Install-Package AWSSDK.Core
Install-Package AWSSDK.DynamoDBv2
Install-Package AWSSDK.Extensions.NETCore.Setup

appsettings.json
"AWS": {
    "Profile": "aws-admin",
    "Region": "ap-south-1"
  }

DBmodel

using Amazon.DynamoDBv2.DataModel;
namespace DynamoStudentManager.Models
{
    [DynamoDBTable("students")]
    public class Student
    {
        [DynamoDBHashKey("id")]
        public int? Id { get; set; }

        [DynamoDBProperty("first_name")]
        public string? FirstName { get; set; }

        [DynamoDBProperty("last_name")]
        public string? LastName { get; set; }

        [DynamoDBProperty("class")]
        public int Class { get; set; }

        [DynamoDBProperty("country")]
        public string? Country { get; set; }
    }
}


serviceRegistration

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var awsOptions = builder.Configuration.GetAWSOptions();
builder.Services.AddDefaultAWSOptions(awsOptions);
builder.Services.AddAWSService<IAmazonDynamoDB>();
builder.Services.AddScoped<IDynamoDBContext, DynamoDBContext>();

var app = builder.Build();

