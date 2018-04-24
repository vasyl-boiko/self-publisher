using System;

namespace Publisher.Models
{
    public class User
    {
        public int Id { get; set; }
        public int UserGroupId { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisterDate { get; set; }
        public string FacebookId { get; set; }
        public string LanguageCode { get; set; }
    }
}
