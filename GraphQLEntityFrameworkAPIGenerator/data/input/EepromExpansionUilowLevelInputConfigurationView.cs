using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromExpansionUilowLevelInputConfigurationView
{
    public Guid ProjectId { get; set; }

    public Guid DisplayId { get; set; }

    public Guid LowLevelInputConfigurationId { get; set; }

    public byte Board { get; set; }

    public byte Index { get; set; }

    public Guid LowLevelInputDetailId { get; set; }

    public byte ReadTypeId { get; set; }

    public byte ReadTypePos { get; set; }

    public bool IsMultiplexed { get; set; }

    public byte ChipSelect { get; set; }

    public bool IsAutomatic { get; set; }

    public byte NumReadings { get; set; }

    [Column("IsACLine")]
    public bool IsAcline { get; set; }

    [Column("IsVReference")]
    public bool IsVreference { get; set; }

    public bool IsCompensated { get; set; }

    public bool IsInverted { get; set; }

    public bool IsPartialized { get; set; }

    public byte? Pin1 { get; set; }

    public byte? Pin2 { get; set; }

    public byte? Pin3 { get; set; }

    public byte? Pin4 { get; set; }

    public byte Delta { get; set; }

    public bool Rotation { get; set; }

    public bool PullUp { get; set; }

    public bool ChannelDischarge { get; set; }

    public Guid? ReadParametersId { get; set; }

    public bool? IsSafetyRelevant { get; set; }
}
