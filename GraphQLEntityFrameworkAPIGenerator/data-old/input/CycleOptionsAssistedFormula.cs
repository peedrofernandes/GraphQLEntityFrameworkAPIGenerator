using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsAssistedFormula")]
public partial class CycleOptionsAssistedFormula
{
    [Key]
    public Guid AssistedFormulaParamsId { get; set; }

    public byte NumberOfInputs { get; set; }

    public float Constant { get; set; }

    public float Temperature { get; set; }

    public byte InputId1 { get; set; }

    public float Coefficient1 { get; set; }

    public byte InputId2 { get; set; }

    public float Coefficient2 { get; set; }

    public byte InputId3 { get; set; }

    public float Coefficient3 { get; set; }

    public byte InputId4 { get; set; }

    public float Coefficient4 { get; set; }

    [ForeignKey("InputId1")]
    [InverseProperty("CycleOptionsAssistedFormulaInputId1Navigations")]
    public virtual CycleOptionsAssistedFormulaInput InputId1Navigation { get; set; } = null!;

    [ForeignKey("InputId2")]
    [InverseProperty("CycleOptionsAssistedFormulaInputId2Navigations")]
    public virtual CycleOptionsAssistedFormulaInput InputId2Navigation { get; set; } = null!;

    [ForeignKey("InputId3")]
    [InverseProperty("CycleOptionsAssistedFormulaInputId3Navigations")]
    public virtual CycleOptionsAssistedFormulaInput InputId3Navigation { get; set; } = null!;

    [ForeignKey("InputId4")]
    [InverseProperty("CycleOptionsAssistedFormulaInputId4Navigations")]
    public virtual CycleOptionsAssistedFormulaInput InputId4Navigation { get; set; } = null!;
}
