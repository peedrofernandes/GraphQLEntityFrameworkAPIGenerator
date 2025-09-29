using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleOptionsAssistedFormulaInput
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    [InverseProperty("InputId1Navigation")]
    public virtual ICollection<CycleOptionsAssistedFormula> CycleOptionsAssistedFormulaInputId1Navigations { get; set; } = new List<CycleOptionsAssistedFormula>();

    [InverseProperty("InputId2Navigation")]
    public virtual ICollection<CycleOptionsAssistedFormula> CycleOptionsAssistedFormulaInputId2Navigations { get; set; } = new List<CycleOptionsAssistedFormula>();

    [InverseProperty("InputId3Navigation")]
    public virtual ICollection<CycleOptionsAssistedFormula> CycleOptionsAssistedFormulaInputId3Navigations { get; set; } = new List<CycleOptionsAssistedFormula>();

    [InverseProperty("InputId4Navigation")]
    public virtual ICollection<CycleOptionsAssistedFormula> CycleOptionsAssistedFormulaInputId4Navigations { get; set; } = new List<CycleOptionsAssistedFormula>();
}
