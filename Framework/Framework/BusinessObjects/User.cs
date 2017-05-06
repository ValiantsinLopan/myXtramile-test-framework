using System.Collections.Generic;
using System.Xml.Serialization;

namespace Framework.BusinessObjects
{
    public class User
    {
        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("password")]
        public string Password { get; set; }
        [XmlElement("companyName")]
        public string CompanyName { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("surname")]
        public string Surname { get; set; }
        [XmlElement("adress")]
        public string Adress { get; set; }
        [XmlElement("city")]
        public string City { get; set; }
        [XmlElement("country")]
        public string Country { get; set; }
        [XmlElement("zipcode")]
        public string ZipCode { get; set; }
        [XmlElement("deposit")]
        public decimal Deposit { get; set; }

        public User()
        {

        }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public User(string email, string password, string companyName, string name)
        {
            Email = email;
            Password = password;
            CompanyName = companyName;
            Name = name;
        }
        public User(string email, string password, string companyName, string name, string surname, string adress, string city, string country, string zipcode, decimal deposit)
        {
            Email = email;
            Password = password;
            CompanyName = companyName;
            Name = name;
            Surname = name;
            Adress = adress;
            City = city;
            Country = country;
            ZipCode = zipcode;
            Deposit = deposit;
        }
    }
}
