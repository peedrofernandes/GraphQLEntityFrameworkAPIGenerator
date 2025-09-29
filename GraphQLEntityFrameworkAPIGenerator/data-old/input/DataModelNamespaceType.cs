using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DataModelNamespaceType
{
    [Key]
    public byte DataModelNamespaceTypeId { get; set; }

    [StringLength(50)]
    public string DataModelNamespaceTypeDescription { get; set; } = null!;
}
