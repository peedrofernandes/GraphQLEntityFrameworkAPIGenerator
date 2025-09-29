using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class DataModelDefinitionView
{
    public int? DataModelVersionTypeId { get; set; }

    [Unicode(false)]
    public string? DataModelVersionTypeDescription { get; set; }

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

    public int? DataModelVersion { get; set; }

    public int DataModelApi { get; set; }

    public int DataModelCategory { get; set; }

    public Guid DataModelDefinitionDetailId { get; set; }

    public int Index { get; set; }

    public int Expr1 { get; set; }

    public int? Expr2 { get; set; }

    [StringLength(100)]
    public string? DataModelNamespace { get; set; }

    [StringLength(100)]
    public string? Entity { get; set; }

    [StringLength(100)]
    public string? Instance { get; set; }

    [StringLength(100)]
    public string? AttributeName { get; set; }

    public string? AttributeDisplayName { get; set; }

    public byte? PayloadDataType { get; set; }

    public long? DataDefinition { get; set; }

    public bool? IsGlobal { get; set; }

    public bool? IsHardware { get; set; }

    public bool? IsPersistence { get; set; }

    public bool? IsTimeSeries { get; set; }

    public long? KeyValue { get; set; }

    public int? Sort { get; set; }

    public bool? IsGet { get; set; }

    public bool? IsSet { get; set; }

    public string? PayloadFromCloud { get; set; }

    public bool? OnRequest { get; set; }

    public bool? OnChange { get; set; }

    public long? OnFrequency { get; set; }

    public string? PayloadFromAppliance { get; set; }

    public string? DataModelDescription { get; set; }

    public bool? SetCmdEcho { get; set; }

    public bool? ApplianceState { get; set; }

    [MaxLength(1)]
    public byte[] KeyValueHex { get; set; } = null!;

    public int DataModelIndex { get; set; }

    public int DefaultValue { get; set; }
}
