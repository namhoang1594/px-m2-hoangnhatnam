using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL_Sach.Models
{
    public class BookInfor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ShortContent { get; set; }
        public int PublishYear { get; set; }
        public int Amount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
