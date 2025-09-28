using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DataModelCategoryType
{
    [Key]
    public byte DataModelCategoryTypeId { get; set; }

    [StringLength(50)]
    public string DataModelCategoryTypeDescription { get; set; } = null!;
}
