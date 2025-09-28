using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIInputEventMappingConfigurations")]
public partial class UiinputEventMappingConfiguration
{
    [Key]
    [Column("UIInputEventMappingConfigurationId")]
    public Guid UiinputEventMappingConfigurationId { get; set; }

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

    public byte Version { get; set; }

    [InverseProperty("UiinputEventMappingConfiguration")]
    public virtual ICollection<UigenericInputConfiguration> UigenericInputConfigurations { get; set; } = new List<UigenericInputConfiguration>();

    [InverseProperty("UiinputEventMappingConfiguration")]
    public virtual ICollection<UiinputEventMappingConfigurationsUiinputEventMappingDetail> UiinputEventMappingConfigurationsUiinputEventMappingDetails { get; set; } = new List<UiinputEventMappingConfigurationsUiinputEventMappingDetail>();
}
