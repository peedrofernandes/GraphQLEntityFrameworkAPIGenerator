using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class InductionCoilPowerTableConfiguration
{
    [Key]
    public Guid InductionCoilPowerTableConfigId { get; set; }

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

    public byte BoosterLevel { get; set; }

    [InverseProperty("CoilPowerTable")]
    public virtual ICollection<InductionCoilChannel> InductionCoilChannels { get; set; } = new List<InductionCoilChannel>();

    [InverseProperty("InductionCoilPowerTableConfig")]
    public virtual ICollection<InductionCoilConfig> InductionCoilConfigs { get; set; } = new List<InductionCoilConfig>();

    [InverseProperty("InductionCoilPowerTableConfig")]
    public virtual ICollection<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail> InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails { get; set; } = new List<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail>();
}
