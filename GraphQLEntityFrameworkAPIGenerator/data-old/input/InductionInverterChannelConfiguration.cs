using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("InductionInverterChannelConfiguration")]
public partial class InductionInverterChannelConfiguration
{
    [Key]
    public Guid InverterChannelId { get; set; }

    public Guid? CoilChannel0Id { get; set; }

    public Guid? CoilChannel1Id { get; set; }

    [ForeignKey("CoilChannel0Id")]
    [InverseProperty("InductionInverterChannelConfigurationCoilChannel0s")]
    public virtual InductionCoilChannel? CoilChannel0 { get; set; }

    [ForeignKey("CoilChannel1Id")]
    [InverseProperty("InductionInverterChannelConfigurationCoilChannel1s")]
    public virtual InductionCoilChannel? CoilChannel1 { get; set; }

    [InverseProperty("InverterChannel0")]
    public virtual ICollection<InductionZeroCrossConfiguration> InductionZeroCrossConfigurationInverterChannel0s { get; set; } = new List<InductionZeroCrossConfiguration>();

    [InverseProperty("InverterChannel1")]
    public virtual ICollection<InductionZeroCrossConfiguration> InductionZeroCrossConfigurationInverterChannel1s { get; set; } = new List<InductionZeroCrossConfiguration>();
}
