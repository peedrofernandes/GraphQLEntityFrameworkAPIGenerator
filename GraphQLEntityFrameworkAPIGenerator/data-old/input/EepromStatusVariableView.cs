using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromStatusVariableView
{
    public Guid ProjectId { get; set; }

    public Guid DisplayId { get; set; }

    public Guid StatusVariableId { get; set; }

    public byte[] StatusVariables { get; set; } = null!;

    public byte[] StatusVariableGroups { get; set; } = null!;

    public byte ProductTypeId { get; set; }
}
