using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DataModelVersionType
{
    [Key]
    public byte DataModelVersionTypeId { get; set; }

    [StringLength(50)]
    public string DataModelVersionTypeDescription { get; set; } = null!;

    public int DataModelApi { get; set; }
}
