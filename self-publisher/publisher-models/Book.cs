using System;
using System.Collections.Generic;

namespace Publisher.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public virtual ICollection<BookTag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
