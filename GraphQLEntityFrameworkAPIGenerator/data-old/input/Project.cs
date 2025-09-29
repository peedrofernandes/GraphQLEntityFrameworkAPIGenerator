using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Project
{
    [Key]
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

    [StringLength(14)]
    [Unicode(false)]
    public string ModelName { get; set; } = null!;

    public Guid? AcuConfigurationId { get; set; }

    public Guid? MachineConfigurationId { get; set; }

    public Guid? SelectorConfigurationId { get; set; }

    public Guid? HmiConfigurationId { get; set; }

    [Unicode(false)]
    public string? Comment { get; set; }

    public byte ProductTypeId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ProjectCode { get; set; } = null!;

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GeneratorVersion { get; set; }

    [Unicode(false)]
    public string? SoftwareCodeNumber { get; set; }

    [Unicode(false)]
    public string? SoftwarePartNumber { get; set; }

    [Unicode(false)]
    public string? ChangeActivityNumber { get; set; }

    public short WindchillDescriptionObjectVersion { get; set; }

    public byte WindchillStatusId { get; set; }

    public string? AttributeTable { get; set; }

    public Guid? SettingFileExtensionsId { get; set; }

    [ForeignKey("AcuConfigurationId")]
    [InverseProperty("Projects")]
    public virtual Board? AcuConfiguration { get; set; }

    [InverseProperty("Project")]
    public virtual ICollection<CompiledResourceMetaDatum> CompiledResourceMetaData { get; set; } = new List<CompiledResourceMetaDatum>();

    [ForeignKey("HmiConfigurationId")]
    [InverseProperty("Projects")]
    public virtual Display? HmiConfiguration { get; set; }

    [ForeignKey("MachineConfigurationId")]
    [InverseProperty("Projects")]
    public virtual MachineConfiguration? MachineConfiguration { get; set; }

    [ForeignKey("ProductTypeId")]
    [InverseProperty("Projects")]
    public virtual ProductType ProductType { get; set; } = null!;

    [ForeignKey("SelectorConfigurationId")]
    [InverseProperty("Projects")]
    public virtual SelectorConfiguration? SelectorConfiguration { get; set; }

    [ForeignKey("SettingFileExtensionsId")]
    [InverseProperty("Projects")]
    public virtual SettingFileExtension? SettingFileExtensions { get; set; }

    [ForeignKey("TableTarget")]
    [InverseProperty("Projects")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
