using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorGfciV2")]
public partial class MonitorGfciV2
{
    [Key]
    [Column("MonitorGfciV2Id")]
    public Guid MonitorGfciV2id { get; set; }

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

    public byte Cav1NumberOfLoads { get; set; }

    public int Cav1DutyPeriod { get; set; }

    public int Cav1NumberOfCycles { get; set; }

    public byte Cav1LoadId1 { get; set; }

    public int Cav1LoadStartTime1 { get; set; }

    public int Cav1LoadStopTime1 { get; set; }

    public byte Cav1LoadId2 { get; set; }

    public int Cav1LoadStartTime2 { get; set; }

    public int Cav1LoadStopTime2 { get; set; }

    public byte Cav1LoadId3 { get; set; }

    public int Cav1LoadStartTime3 { get; set; }

    public int Cav1LoadStopTime3 { get; set; }

    public byte Cav1LoadId4 { get; set; }

    public int Cav1LoadStartTime4 { get; set; }

    public int Cav1LoadStopTime4 { get; set; }

    public byte Cav1LoadId5 { get; set; }

    public int Cav1LoadStartTime5 { get; set; }

    public int Cav1LoadStopTime5 { get; set; }

    public byte NumberOfCavities { get; set; }

    [InverseProperty("MonitorGfciV2")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
