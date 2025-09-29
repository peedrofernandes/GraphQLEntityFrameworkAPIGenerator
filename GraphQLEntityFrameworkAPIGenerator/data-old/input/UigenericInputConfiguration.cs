using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIGenericInputConfigurations")]
public partial class UigenericInputConfiguration
{
    [Key]
    [Column("UIGenericInputConfigurationId")]
    public Guid UigenericInputConfigurationId { get; set; }

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

    [Column("UIInputEventMappingConfigurationId")]
    public Guid? UiinputEventMappingConfigurationId { get; set; }

    [InverseProperty("GenericInputConfiguration")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [ForeignKey("TableTarget")]
    [InverseProperty("UigenericInputConfigurations")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [InverseProperty("UigenericInputConfiguration")]
    public virtual ICollection<UigenericInputConfigurationsUigenericInputDetail> UigenericInputConfigurationsUigenericInputDetails { get; set; } = new List<UigenericInputConfigurationsUigenericInputDetail>();

    [ForeignKey("UiinputEventMappingConfigurationId")]
    [InverseProperty("UigenericInputConfigurations")]
    public virtual UiinputEventMappingConfiguration? UiinputEventMappingConfiguration { get; set; }
}
