using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIStmSetObject")]
public partial class UistmSetObject
{
    [Key]
    public Guid Id { get; set; }

    public byte ProductTypeId { get; set; }

    public byte Type { get; set; }

    public int Idx { get; set; }

    public int Data { get; set; }

    public int VariableIndex { get; set; }

    public byte VariableOffset { get; set; }

    public byte? LedIndex { get; set; }

    public byte? GroupIndex { get; set; }

    public byte Intensity { get; set; }

    public byte VariableGroups { get; set; }

    [Required]
    public bool? VisualValueFlag { get; set; }

    public bool BitfieldIndexFlag { get; set; }
}
