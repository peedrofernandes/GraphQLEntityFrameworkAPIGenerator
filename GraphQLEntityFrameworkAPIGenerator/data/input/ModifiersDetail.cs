using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class ModifiersDetail
{
    [Key]
    public Guid ModifiersDetailsId { get; set; }

    public byte NumItems { get; set; }

    public int VariableIndex { get; set; }

    public byte VariableOffset { get; set; }

    [MaxLength(1024)]
    public byte[] ModifierValues { get; set; } = null!;

    [MaxLength(1024)]
    public byte[] ModifiedValues { get; set; } = null!;

    public byte ModifierSearchMethodId { get; set; }

    public bool IsPercent { get; set; }

    public byte VariableGroupId { get; set; }

    public byte ProductTypeId { get; set; }

    [InverseProperty("ModifierDetails1Navigation")]
    public virtual ICollection<Modifier> ModifierModifierDetails1Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierDetails2Navigation")]
    public virtual ICollection<Modifier> ModifierModifierDetails2Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierDetails3Navigation")]
    public virtual ICollection<Modifier> ModifierModifierDetails3Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierDetails4Navigation")]
    public virtual ICollection<Modifier> ModifierModifierDetails4Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierDetails5Navigation")]
    public virtual ICollection<Modifier> ModifierModifierDetails5Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierDetails6Navigation")]
    public virtual ICollection<Modifier> ModifierModifierDetails6Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierDetails7Navigation")]
    public virtual ICollection<Modifier> ModifierModifierDetails7Navigations { get; set; } = new List<Modifier>();

    [InverseProperty("ModifierDetails8Navigation")]
    public virtual ICollection<Modifier> ModifierModifierDetails8Navigations { get; set; } = new List<Modifier>();

    [ForeignKey("ModifierSearchMethodId")]
    [InverseProperty("ModifiersDetails")]
    public virtual ModifierSearchMethod ModifierSearchMethod { get; set; } = null!;
}
