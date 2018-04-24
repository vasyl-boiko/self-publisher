using System.Collections.Generic;

namespace Publisher.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public virtual ICollection<BookTag> Books { get; set; }
    }
}
