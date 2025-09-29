using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleOptionsStepDetail
{
    [Key]
    public Guid CycleOptionsStepDetailsId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public int UserPhaseNameId { get; set; }

    public short InstructionId { get; set; }

    public byte TableTypeId { get; set; }

    public byte? NumberOfLevels { get; set; }

    public float Time1 { get; set; }

    public float Coefficient1 { get; set; }

    public byte PowerLevelId1 { get; set; }

    public float Time2 { get; set; }

    public float Coefficient2 { get; set; }

    public byte PowerLevelId2 { get; set; }

    public float Time3 { get; set; }

    public float Coefficient3 { get; set; }

    public byte PowerLevelId3 { get; set; }

    public float Time4 { get; set; }

    public float Coefficient4 { get; set; }

    public byte PowerLevelId4 { get; set; }

    public float Time5 { get; set; }

    public float Coefficient5 { get; set; }

    public byte PowerLevelId5 { get; set; }

    public float Time6 { get; set; }

    public byte PowerLevelId6 { get; set; }

    public float Time7 { get; set; }

    public byte PowerLevelId7 { get; set; }

    public float Time8 { get; set; }

    public byte PowerLevelId8 { get; set; }

    [InverseProperty("CycleOptionsStepDetails")]
    public virtual ICollection<CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail> CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails { get; set; } = new List<CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail>();
}
