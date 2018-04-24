using System;

namespace Publisher.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime MidifiedDate { get; set; }
    }
}
