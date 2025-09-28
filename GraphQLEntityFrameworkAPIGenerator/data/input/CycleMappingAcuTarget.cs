using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleMappingAcuTarget
{
    [Key]
    public Guid CycleMappingAcuTargetId { get; set; }

    [MaxLength(50)]
    public byte[] CycleMappingCompartmentArray { get; set; } = null!;

    [Column("ACUTargetArray")]
    [MaxLength(50)]
    public byte[] AcutargetArray { get; set; } = null!;

    public int NumberOfComparments { get; set; }

    public Guid? CycleMappingCavityParamsId1 { get; set; }

    public Guid? CycleMappingCavityParamsId2 { get; set; }

    public Guid? CycleMappingCavityParamsId3 { get; set; }

    public Guid? CycleMappingCavityParamsId4 { get; set; }

    [ForeignKey("CycleMappingCavityParamsId1")]
    [InverseProperty("CycleMappingAcuTargetCycleMappingCavityParamsId1Navigations")]
    public virtual CycleMappingCavityParam? CycleMappingCavityParamsId1Navigation { get; set; }

    [ForeignKey("CycleMappingCavityParamsId2")]
    [InverseProperty("CycleMappingAcuTargetCycleMappingCavityParamsId2Navigations")]
    public virtual CycleMappingCavityParam? CycleMappingCavityParamsId2Navigation { get; set; }

    [ForeignKey("CycleMappingCavityParamsId3")]
    [InverseProperty("CycleMappingAcuTargetCycleMappingCavityParamsId3Navigations")]
    public virtual CycleMappingCavityParam? CycleMappingCavityParamsId3Navigation { get; set; }

    [ForeignKey("CycleMappingCavityParamsId4")]
    [InverseProperty("CycleMappingAcuTargetCycleMappingCavityParamsId4Navigations")]
    public virtual CycleMappingCavityParam? CycleMappingCavityParamsId4Navigation { get; set; }

    [InverseProperty("CycleMappingAcuTarget")]
    public virtual ICollection<CycleMapping> CycleMappings { get; set; } = new List<CycleMapping>();
}
