using System;
using System.ComponentModel.DataAnnotations.Schema;
using MyCookingMaster.BL.Models.Common;

namespace MyCookingMaster.BL
{
    public record Ingredient : BaseEntity
    {
        public string Name { get; set; }

        public int Amount { get; set; }

        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}
