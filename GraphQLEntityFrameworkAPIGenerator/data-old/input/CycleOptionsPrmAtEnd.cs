using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmAtEnd")]
public partial class CycleOptionsPrmAtEnd
{
    [Key]
    public Guid AtEndOptionsId { get; set; }

    public byte AtEndDefault { get; set; }

    public bool TurnOffOptionPresent { get; set; }

    public bool HoldTempOptionPresent { get; set; }

    public bool KeepWarmOptionPresent { get; set; }
}
