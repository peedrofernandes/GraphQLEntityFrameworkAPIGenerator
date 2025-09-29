using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DataModelDefinitionConfiguration
{
    [Key]
    public Guid DataModelDefinitionConfigurationId { get; set; }

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

    public int DataModelVersion { get; set; }

    public int DataModelApi { get; set; }

    public int DataModelCategory { get; set; }

    [InverseProperty("DataModelDefinitionConfiguration")]
    public virtual ICollection<DataModelDefinitionConfigurationsDataModelDefinitionDetail> DataModelDefinitionConfigurationsDataModelDefinitionDetails { get; set; } = new List<DataModelDefinitionConfigurationsDataModelDefinitionDetail>();
}
