using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("I2CSpeedValues")]
public partial class I2cspeedValue
{
    [Key]
    [Column("I2CSpeedId")]
    public byte I2cspeedId { get; set; }

    [Column("I2CDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string I2cdescription { get; set; } = null!;
}
