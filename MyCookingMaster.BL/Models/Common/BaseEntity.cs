using System;
using System.ComponentModel.DataAnnotations;

namespace MyCookingMaster.BL.Models.Common
{
    public record BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
