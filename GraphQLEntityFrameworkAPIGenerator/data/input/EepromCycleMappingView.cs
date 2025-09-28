using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromCycleMappingView
{
    public Guid ProjectId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    [Unicode(false)]
    public string? DataModelVersionTypeDescription { get; set; }

    public byte ExportOptionId { get; set; }

    public byte Compartment0 { get; set; }

    [StringLength(50)]
    public string CompartmentName { get; set; } = null!;

    public int? CycleNameId { get; set; }

    public long? KeyValue0 { get; set; }

    public long? ConnectivityCycleKey0 { get; set; }

    public string? KeyName0 { get; set; }

    public int? ConnectivityCycleEnumeration0 { get; set; }

    public string? EnumDescription { get; set; }

    public byte CycleMapIndex { get; set; }

    public Guid CycleOptionsConfigurationsId { get; set; }

    public bool IsConnected { get; set; }

    public byte CyclePosition { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CycleName { get; set; } = null!;

    [StringLength(100)]
    public string? HmiCycleName { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string IndustrialCode { get; set; } = null!;

    [Unicode(false)]
    public string? SoftwarePartNumber { get; set; }

    public float Version { get; set; }

    public byte? HexEncoding { get; set; }

    [StringLength(100)]
    public string? FileId { get; set; }

    public int Revision { get; set; }

    public Guid? CycleMappingFileInfoId { get; set; }

    public Guid CycleMappingId { get; set; }

    public Guid? UriTreeId { get; set; }
}
