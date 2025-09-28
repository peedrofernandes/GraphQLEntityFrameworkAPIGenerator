using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class ModifierOperator
{
    [Key]
    public byte ModifierOperatorId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifierOperatorDescription { get; set; } = null!;

    [InverseProperty("ModifierOperator1Navigation")]
    public virtual ICollection<Modifier> ModifierModifierOperator1Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierOperator2Navigation")]
    public virtual ICollection<Modifier> ModifierModifierOperator2Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierOperator3Navigation")]
    public virtual ICollection<Modifier> ModifierModifierOperator3Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierOperator4Navigation")]
    public virtual ICollection<Modifier> ModifierModifierOperator4Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierOperator7Navigation")]
    public virtual ICollection<Modifier> ModifierModifierOperator7Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierOperator8Navigation")]
    public virtual ICollection<Modifier> ModifierModifierOperator8Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierType5Navigation")]
    public virtual ICollection<Modifier> ModifierModifierType5Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierType6Navigation")]
    public virtual ICollection<Modifier> ModifierModifierType6Navigations { get; set; } = new List<Modifier>();
}
