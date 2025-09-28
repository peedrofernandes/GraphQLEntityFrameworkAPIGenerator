using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Variable
{
    [Key]
    public int VariableId { get; set; }

    [Column("Variable")]
    [StringLength(50)]
    [Unicode(false)]
    public string Variable1 { get; set; } = null!;

    public byte DataType { get; set; }

    public bool IsBitmap { get; set; }

    public bool IsWritable { get; set; }

    public byte? Offset { get; set; }

    [InverseProperty("Variable")]
    public virtual ICollection<Flag> Flags { get; set; } = new List<Flag>();

    [InverseProperty("Variable")]
    public virtual ICollection<ProductTypesVariable> ProductTypesVariables { get; set; } = new List<ProductTypesVariable>();

    [ForeignKey("VariableId")]
    [InverseProperty("Variables")]
    public virtual ICollection<VariableGroup> VariableGroups { get; set; } = new List<VariableGroup>();
}
