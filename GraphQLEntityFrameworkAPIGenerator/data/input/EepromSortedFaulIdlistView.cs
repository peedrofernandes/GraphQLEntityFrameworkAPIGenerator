using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromSortedFaulIdlistView
{
    public byte FaultId { get; set; }

    public Guid ProjectId { get; set; }

    public byte Priority { get; set; }
}
