using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class ProjectsFullView
{
    public Guid ProjectId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string IndustrialCode { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? ProductType { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ProductCode { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ProductRevision { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string ModelName { get; set; } = null!;

    [Unicode(false)]
    public string? Comment { get; set; }

    public Guid? BoardId { get; set; }

    public Guid? DisplayId { get; set; }

    public Guid? SelectorConfigurationId { get; set; }

    public Guid? MachineConfigurationId { get; set; }

    public byte ProductTypeId { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(50)]
    public string? BoardCode { get; set; }

    [StringLength(50)]
    public string? BoardDescription { get; set; }

    [StringLength(50)]
    public string? DisplayCode { get; set; }

    [StringLength(50)]
    public string? DisplayDescription { get; set; }

    [StringLength(50)]
    public string? SelectorConfigurationDescription { get; set; }

    [StringLength(50)]
    public string? MachineConfigurationCode { get; set; }

    [StringLength(50)]
    public string? MachineConfigurationDescription { get; set; }

    [StringLength(50)]
    public string? SelectorConfigurationCode { get; set; }

    [Unicode(false)]
    public string? ChangeActivityNumber { get; set; }

    [Unicode(false)]
    public string? SoftwarePartNumber { get; set; }

    [Unicode(false)]
    public string? SoftwareCodeNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GeneratorVersion { get; set; }

    public short WindchillDescriptionObjectVersion { get; set; }

    public byte WindchillStatusId { get; set; }

    public long? StartPosition { get; set; }

    public int? Size { get; set; }

    public Guid? HmiConfigurationId { get; set; }

    public Guid? AcuConfigurationId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProductTypeDsc { get; set; }
}
