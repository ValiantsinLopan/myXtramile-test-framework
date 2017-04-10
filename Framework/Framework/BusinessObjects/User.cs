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

        public User()
        {

        }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
