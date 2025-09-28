using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleMapping")]
public partial class CycleMapping
{
    [Key]
    public Guid CycleMappingId { get; set; }

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

    public byte ExportOptionId { get; set; }

    public bool IsConnected { get; set; }

    public int? DataModelVersion { get; set; }

    public float Version { get; set; }

    public Guid? CycleMappingFileInfoId { get; set; }

    public Guid? CycleMappingAcuTargetId { get; set; }

    [ForeignKey("CycleMappingAcuTargetId")]
    [InverseProperty("CycleMappings")]
    public virtual CycleMappingAcuTarget? CycleMappingAcuTarget { get; set; }

    [InverseProperty("CycleMapping")]
    public virtual ICollection<CycleMappingCycleOptionsConfiguration> CycleMappingCycleOptionsConfigurations { get; set; } = new List<CycleMappingCycleOptionsConfiguration>();

    [ForeignKey("CycleMappingFileInfoId")]
    [InverseProperty("CycleMappings")]
    public virtual CycleMappingFileInfo? CycleMappingFileInfo { get; set; }

    [ForeignKey("ExportOptionId")]
    [InverseProperty("CycleMappings")]
    public virtual CycleMappingExportOption ExportOption { get; set; } = null!;

    [InverseProperty("CycleMapping")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
