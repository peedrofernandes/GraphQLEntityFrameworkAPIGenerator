using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmFoodType")]
public partial class CycleOptionsPrmFoodType
{
    [Key]
    public Guid FoodTypeOptionsId { get; set; }

    public byte NumberOfOptions { get; set; }

    [MaxLength(50)]
    public byte[] Options { get; set; } = null!;

    public byte DefaultFoodType { get; set; }
}
