using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MinimumDcSupply")]
public partial class MinimumDcSupply
{
    [Key]
    public Guid MinimumDcSupplyId { get; set; }

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

    [Column("R1Resistance")]
    public long R1resistance { get; set; }

    [Column("R2Resistance")]
    public long R2resistance { get; set; }

    public float MinDcSupply { get; set; }

    [Column("ACLowerInputVoltage")]
    public short AclowerInputVoltage { get; set; }

    [Column("ACUpperInputVoltage")]
    public short AcupperInputVoltage { get; set; }

    [Column("ACVoltageDebounceMilliseconds")]
    public int AcvoltageDebounceMilliseconds { get; set; }

    [InverseProperty("MinimumDcSupply")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
