using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace PieShop.ViewModels
{
    public class PieViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public Pie Pie { get; set; }
        public IEnumerable<Pie> Pies { get; set; }
    }
}
