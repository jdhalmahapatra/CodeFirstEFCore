using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using MyCookingMaster.BL.Models.Common;
using MyCookingMaster.BL.Models.Enums;

namespace MyCookingMaster.BL
{
    public record Recipe : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public RecipeDifficulty Difficulty { get; set; }
        public int Time { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
