using System;
using System.Collections.Generic;
using MyCookingMaster.BL.Models.Common;

namespace MyCookingMaster.BL
{
    public record User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}
