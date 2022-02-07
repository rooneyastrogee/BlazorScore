using System;
using System.Collections.Generic;

#nullable disable

namespace Scores.DataModels.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Score { get; set; }
    }
}
