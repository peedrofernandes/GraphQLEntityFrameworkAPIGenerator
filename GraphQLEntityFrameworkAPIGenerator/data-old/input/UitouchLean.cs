using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UITouchLean")]
public partial class UitouchLean
{
    [Key]
    [Column("UITouchLeanId")]
    public Guid UitouchLeanId { get; set; }

    [StringLength(100)]
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

    public byte NumberOfZones { get; set; }

    public bool EnableTouchLeanFeature { get; set; }

    public int TimeToComeOutFromLeanModeZone0 { get; set; }

    public int TimeDuringLeanModeZone0 { get; set; }

    public byte LockKeysNumberZone0 { get; set; }

    public long SensorSelectionBufferZone0 { get; set; }

    public int TimeToComeOutFromLeanModeZone1 { get; set; }

    public int TimeDuringLeanModeZone1 { get; set; }

    public byte LockKeysNumberZone1 { get; set; }

    public long SensorSelectionBufferZone1 { get; set; }

    public int TimeToComeOutFromLeanModeZone2 { get; set; }

    public int TimeDuringLeanModeZone2 { get; set; }

    public byte LockKeysNumberZone2 { get; set; }

    public long SensorSelectionBufferZone2 { get; set; }

    public int TimeToComeOutFromLeanModeZone3 { get; set; }

    public int TimeDuringLeanModeZone3 { get; set; }

    public byte LockKeysNumberZone3 { get; set; }

    public long SensorSelectionBufferZone3 { get; set; }

    public byte MaxZoneSensorBufferSize { get; set; }

    [InverseProperty("UitouchLean")]
    public virtual ICollection<UitouchDevice> UitouchDevices { get; set; } = new List<UitouchDevice>();
}
