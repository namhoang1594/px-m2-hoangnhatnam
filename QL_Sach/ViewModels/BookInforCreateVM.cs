using Microsoft.AspNetCore.Mvc.Rendering;
using QL_Sach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL_Sach.ViewModels
{
    public class BookInforCreateVM
    {
        public BookInfor BookInfor { get; set; }
        public IEnumerable<SelectListItem> CategoriesSelectList { get; set; }
    }
}
