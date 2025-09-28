using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DataModelSubType
{
    [Key]
    public byte DataModelSubTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DataModelSubTypeDescription { get; set; } = null!;
}
