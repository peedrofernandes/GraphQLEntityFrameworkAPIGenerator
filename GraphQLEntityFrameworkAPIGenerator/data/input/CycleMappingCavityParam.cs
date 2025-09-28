using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleMappingCavityParam
{
    [Key]
    public Guid CycleMappingCavityParamsId { get; set; }

    public int ProbeRemovalTimeout { get; set; }

    [InverseProperty("CycleMappingCavityParamsId1Navigation")]
    public virtual ICollection<CycleMappingAcuTarget> CycleMappingAcuTargetCycleMappingCavityParamsId1Navigations { get; set; } = new List<CycleMappingAcuTarget>();

    [InverseProperty("CycleMappingCavityParamsId2Navigation")]
    public virtual ICollection<CycleMappingAcuTarget> CycleMappingAcuTargetCycleMappingCavityParamsId2Navigations { get; set; } = new List<CycleMappingAcuTarget>();

    [InverseProperty("CycleMappingCavityParamsId3Navigation")]
    public virtual ICollection<CycleMappingAcuTarget> CycleMappingAcuTargetCycleMappingCavityParamsId3Navigations { get; set; } = new List<CycleMappingAcuTarget>();

    [InverseProperty("CycleMappingCavityParamsId4Navigation")]
    public virtual ICollection<CycleMappingAcuTarget> CycleMappingAcuTargetCycleMappingCavityParamsId4Navigations { get; set; } = new List<CycleMappingAcuTarget>();
}
