using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL_Sach.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookInfor> BookInfors { get; set; }
    }
}
