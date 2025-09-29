using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class ModifierType
{
    [Key]
    public byte ModifierTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifierTypeDescription { get; set; } = null!;

    [InverseProperty("ModifierType1Navigation")]
    public virtual ICollection<Modifier> ModifierModifierType1Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierType2Navigation")]
    public virtual ICollection<Modifier> ModifierModifierType2Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierType3Navigation")]
    public virtual ICollection<Modifier> ModifierModifierType3Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierType4Navigation")]
    public virtual ICollection<Modifier> ModifierModifierType4Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierType51")]
    public virtual ICollection<Modifier> ModifierModifierType51s { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierType61")]
    public virtual ICollection<Modifier> ModifierModifierType61s { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierType7Navigation")]
    public virtual ICollection<Modifier> ModifierModifierType7Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierType8Navigation")]
    public virtual ICollection<Modifier> ModifierModifierType8Navigations { get; set; } = new List<Modifier>();
}
