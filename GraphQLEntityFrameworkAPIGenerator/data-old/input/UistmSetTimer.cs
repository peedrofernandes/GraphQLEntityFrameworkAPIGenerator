using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIStmSetTimer")]
public partial class UistmSetTimer
{
    [Key]
    public Guid Id { get; set; }

    public int VariableIndex { get; set; }

    public double Value { get; set; }

    public byte VariableOffset { get; set; }

    public byte VariableGroup { get; set; }

    public byte ProductType { get; set; }
}
