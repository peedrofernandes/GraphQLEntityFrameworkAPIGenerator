using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorSteamDrain")]
public partial class MonitorSteamDrain
{
    [Key]
    public Guid MonitorSteamDrainId { get; set; }

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

    public bool DrainToQcTank { get; set; }

    public bool DrainToRemoveableDrawer { get; set; }

    public bool DrainToExternal { get; set; }

    public bool DrainToPlumbedOutlet { get; set; }

    public bool AutoDrainPresent { get; set; }

    public bool BoilerTempSensorPresent { get; set; }

    public int RecommendDrainTime { get; set; }

    public short RequireDrainTime { get; set; }

    public short MinTimeBeforeDrain { get; set; }

    public byte MaxDrainTemp { get; set; }

    public short DrainPumpExtraTime { get; set; }

    public short BoilerTempDebounceTime { get; set; }

    [InverseProperty("MonitorSteamDrain")]
    public virtual ICollection<MonitorSteam> MonitorSteams { get; set; } = new List<MonitorSteam>();
}
