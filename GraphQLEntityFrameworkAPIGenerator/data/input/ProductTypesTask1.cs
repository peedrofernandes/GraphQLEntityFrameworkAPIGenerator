using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class ProductTypesTask1
{
    public byte ProductTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ProductTypeDsc { get; set; } = null!;

    public byte ProductTypeTaskId { get; set; }

    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Task { get; set; } = null!;
}
