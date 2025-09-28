using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class TemperatureNodeName
{
    [Key]
    public byte TemperatureNodeNamesCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TemperatureNodeNamesDescription { get; set; } = null!;
}
