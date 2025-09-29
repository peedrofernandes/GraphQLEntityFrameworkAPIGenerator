using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmSetVariable")]
public partial class StmSetVariable
{
    [Key]
    public Guid Id { get; set; }

    public byte ProductTypeId { get; set; }

    public byte? Operation { get; set; }

    public int VariableIndex { get; set; }

    public byte VariableOffset { get; set; }

    public short? Operand { get; set; }

    public bool? IsSet { get; set; }

    public byte? BitPosition { get; set; }

    public byte? Operation1 { get; set; }

    public int? VariableIndex1 { get; set; }

    public byte? VariableOffset1 { get; set; }

    public short? Operand1 { get; set; }

    public bool? IsSet1 { get; set; }

    public byte? BitPosition1 { get; set; }

    public byte? Operation2 { get; set; }

    public int? VariableIndex2 { get; set; }

    public byte? VariableOffset2 { get; set; }

    public short? Operand2 { get; set; }

    public bool? IsSet2 { get; set; }

    public byte? BitPosition2 { get; set; }

    public byte? Operation3 { get; set; }

    public int? VariableIndex3 { get; set; }

    public byte? VariableOffset3 { get; set; }

    public short? Operand3 { get; set; }

    public bool? IsSet3 { get; set; }

    public byte? BitPosition3 { get; set; }

    public byte? Operation4 { get; set; }

    public int? VariableIndex4 { get; set; }

    public byte? VariableOffset4 { get; set; }

    public short? Operand4 { get; set; }

    public bool? IsSet4 { get; set; }

    public byte? BitPosition4 { get; set; }

    public byte? Operation5 { get; set; }

    public int? VariableIndex5 { get; set; }

    public byte? VariableOffset5 { get; set; }

    public short? Operand5 { get; set; }

    public bool? IsSet5 { get; set; }

    public byte? BitPosition5 { get; set; }

    public byte? Operation6 { get; set; }

    public int? VariableIndex6 { get; set; }

    public byte? VariableOffset6 { get; set; }

    public short? Operand6 { get; set; }

    public bool? IsSet6 { get; set; }

    public byte? BitPosition6 { get; set; }

    public byte? Operation7 { get; set; }

    public int? VariableIndex7 { get; set; }

    public byte? VariableOffset7 { get; set; }

    public short? Operand7 { get; set; }

    public bool? IsSet7 { get; set; }

    public byte? BitPosition7 { get; set; }

    public byte? Operation8 { get; set; }

    public int? VariableIndex8 { get; set; }

    public byte? VariableOffset8 { get; set; }

    public short? Operand8 { get; set; }

    public bool? IsSet8 { get; set; }

    public byte? BitPosition8 { get; set; }

    public byte? Operation9 { get; set; }

    public int? VariableIndex9 { get; set; }

    public byte? VariableOffset9 { get; set; }

    public short? Operand9 { get; set; }

    public bool? IsSet9 { get; set; }

    public byte? BitPosition9 { get; set; }

    public byte VariableGroups { get; set; }

    public byte? VariableGroups1 { get; set; }

    public byte? VariableGroups2 { get; set; }

    public byte? VariableGroups3 { get; set; }

    public byte? VariableGroups4 { get; set; }

    public byte? VariableGroups5 { get; set; }

    public byte? VariableGroups6 { get; set; }

    public byte? VariableGroups7 { get; set; }

    public byte? VariableGroups8 { get; set; }

    public byte? VariableGroups9 { get; set; }

    public Guid? Modifier { get; set; }

    public Guid? Modifier1 { get; set; }

    public Guid? Modifier2 { get; set; }

    public Guid? Modifier3 { get; set; }

    public Guid? Modifier4 { get; set; }

    public Guid? Modifier5 { get; set; }

    public Guid? Modifier6 { get; set; }

    public Guid? Modifier7 { get; set; }

    public Guid? Modifier8 { get; set; }

    public Guid? Modifier9 { get; set; }

    [ForeignKey("Modifier1")]
    [InverseProperty("StmSetVariableModifier1Navigations")]
    public virtual Modifier? Modifier1Navigation { get; set; }

    [ForeignKey("Modifier2")]
    [InverseProperty("StmSetVariableModifier2Navigations")]
    public virtual Modifier? Modifier2Navigation { get; set; }

    [ForeignKey("Modifier3")]
    [InverseProperty("StmSetVariableModifier3Navigations")]
    public virtual Modifier? Modifier3Navigation { get; set; }

    [ForeignKey("Modifier4")]
    [InverseProperty("StmSetVariableModifier4Navigations")]
    public virtual Modifier? Modifier4Navigation { get; set; }

    [ForeignKey("Modifier5")]
    [InverseProperty("StmSetVariableModifier5Navigations")]
    public virtual Modifier? Modifier5Navigation { get; set; }

    [ForeignKey("Modifier6")]
    [InverseProperty("StmSetVariableModifier6Navigations")]
    public virtual Modifier? Modifier6Navigation { get; set; }

    [ForeignKey("Modifier7")]
    [InverseProperty("StmSetVariableModifier7Navigations")]
    public virtual Modifier? Modifier7Navigation { get; set; }

    [ForeignKey("Modifier8")]
    [InverseProperty("StmSetVariableModifier8Navigations")]
    public virtual Modifier? Modifier8Navigation { get; set; }

    [ForeignKey("Modifier9")]
    [InverseProperty("StmSetVariableModifier9Navigations")]
    public virtual Modifier? Modifier9Navigation { get; set; }

    [ForeignKey("Modifier")]
    [InverseProperty("StmSetVariableModifierNavigations")]
    public virtual Modifier? ModifierNavigation { get; set; }

    [ForeignKey("ProductTypeId")]
    [InverseProperty("StmSetVariables")]
    public virtual ProductType ProductType { get; set; } = null!;
}
