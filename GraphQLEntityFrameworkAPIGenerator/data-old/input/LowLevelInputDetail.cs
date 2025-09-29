using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class LowLevelInputDetail
{
    [Key]
    public Guid LowLevelInputDetailId { get; set; }

    public byte ReadTypeId { get; set; }

    public byte ReadTypePos { get; set; }

    public byte Delta { get; set; }

    public byte ChipSelect { get; set; }

    public byte NumReadings { get; set; }

    public bool IsAutomatic { get; set; }

    public bool IsMultiplexed { get; set; }

    [Column("IsACLine")]
    public bool IsAcline { get; set; }

    [Column("IsVReference")]
    public bool IsVreference { get; set; }

    public bool IsCompensated { get; set; }

    public bool IsInverted { get; set; }

    public bool IsPartialized { get; set; }

    public bool Rotation { get; set; }

    public bool PullUp { get; set; }

    public bool ChannelDischarge { get; set; }

    public byte? Pin1 { get; set; }

    public byte? Pin2 { get; set; }

    public byte? Pin3 { get; set; }

    public byte? Pin4 { get; set; }

    public Guid? ReadParametersId { get; set; }

    [InverseProperty("LowLevelInputDetail")]
    public virtual ICollection<LowLevelInputConfigurationsLowLevelInputDetail> LowLevelInputConfigurationsLowLevelInputDetails { get; set; } = new List<LowLevelInputConfigurationsLowLevelInputDetail>();

    [ForeignKey("ReadTypeId")]
    [InverseProperty("LowLevelInputDetails")]
    public virtual ReadType ReadType { get; set; } = null!;
}
