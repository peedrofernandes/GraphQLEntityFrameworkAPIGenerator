using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class DataModelType
{
    public byte DataModelTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DataModelTypeDescription { get; set; } = null!;
}
