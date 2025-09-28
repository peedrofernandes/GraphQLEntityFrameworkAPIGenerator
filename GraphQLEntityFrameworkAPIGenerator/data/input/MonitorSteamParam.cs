using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class MonitorSteamParam
{
    [Key]
    public Guid MonitorSteamParamsId { get; set; }

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

    public bool ExtraTankPresent { get; set; }

    public bool ColdTankPresent { get; set; }

    public bool RemovableDrawerPresent { get; set; }

    public bool QuickCouplingTankPresent { get; set; }

    public short FillPumpMaxTime { get; set; }

    public short DrainPumpMaxTime { get; set; }

    public bool FillPlumbingPresent { get; set; }

    public short FillExtraTime { get; set; }

    public short LowLevelTime { get; set; }

    public int RecommendNewFilterVolume { get; set; }

    public int RequireNewFilterVolume { get; set; }

    public float ColdTankToWarmTankFlowRate { get; set; }

    public float DrainPumpFlowRate { get; set; }

    public float QuickCouplingFlowRate { get; set; }

    public float PlumbingPumpFlowRate { get; set; }

    public float SteamGeneratorFlowRate { get; set; }

    public bool TipsPresent { get; set; }

    public short RefillTimeThreshold { get; set; }

    public byte AllowDynamicFlowCalibration { get; set; }

    public bool SteamSystemType { get; set; }

    [InverseProperty("MonitorSteamParams")]
    public virtual ICollection<MonitorSteam> MonitorSteams { get; set; } = new List<MonitorSteam>();
}
