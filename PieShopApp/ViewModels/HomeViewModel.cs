using System.Collections.Generic;
using PieShopApp.Models;

namespace PieShopApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}