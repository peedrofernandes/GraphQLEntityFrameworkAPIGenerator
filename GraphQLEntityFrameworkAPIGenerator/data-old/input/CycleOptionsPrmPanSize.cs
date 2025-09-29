using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmPanSize")]
public partial class CycleOptionsPrmPanSize
{
    [Key]
    public Guid PanSizeOptionsId { get; set; }

    public byte PanSizeDefault { get; set; }

    public bool Option8Present { get; set; }

    public bool Option9Present { get; set; }

    public bool Option10Present { get; set; }

    public bool Option8x8Present { get; set; }

    public bool Option9x9Present { get; set; }

    public bool Option9x13Present { get; set; }
}
