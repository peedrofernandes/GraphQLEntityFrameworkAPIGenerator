using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class VariableGroup
{
    [Key]
    public byte VariableGroupId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string VariableGroupDescription { get; set; } = null!;

    [ForeignKey("VariableGroupId")]
    [InverseProperty("VariableGroups")]
    public virtual ICollection<Variable> Variables { get; set; } = new List<Variable>();
}
