using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class InductionCoilChannel
{
    [Key]
    public Guid CoilChannelId { get; set; }

    public byte CoilType { get; set; }

    public Guid? CoilPowerTableId { get; set; }

    [Column("CoilNtcGIID")]
    public byte? CoilNtcGiid { get; set; }

    [Column("AssistedCookingNtcGIID")]
    public byte? AssistedCookingNtcGiid { get; set; }

    public int? ResonanceCapacity { get; set; }

    public bool ResonantCapacitorPresent { get; set; }

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

    [ForeignKey("CoilPowerTableId")]
    [InverseProperty("InductionCoilChannels")]
    public virtual InductionCoilPowerTableConfiguration? CoilPowerTable { get; set; }

    [ForeignKey("CoilType")]
    [InverseProperty("InductionCoilChannels")]
    public virtual InductionCoilType CoilTypeNavigation { get; set; } = null!;

    [InverseProperty("CoilChannel0")]
    public virtual ICollection<InductionInverterChannelConfiguration> InductionInverterChannelConfigurationCoilChannel0s { get; set; } = new List<InductionInverterChannelConfiguration>();

    [InverseProperty("CoilChannel1")]
    public virtual ICollection<InductionInverterChannelConfiguration> InductionInverterChannelConfigurationCoilChannel1s { get; set; } = new List<InductionInverterChannelConfiguration>();
}
