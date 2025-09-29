using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("InductionCoilPowerTableConfigId", "InductionCoilPowerTableDetailId", "Index")]
[Table("InductionCoilPowerTableConfigurations_InductionCoilPowerTableDetails")]
public partial class InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail
{
    [Key]
    public Guid InductionCoilPowerTableConfigId { get; set; }

    [Key]
    public Guid InductionCoilPowerTableDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("InductionCoilPowerTableConfigId")]
    [InverseProperty("InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails")]
    public virtual InductionCoilPowerTableConfiguration InductionCoilPowerTableConfig { get; set; } = null!;

    [ForeignKey("InductionCoilPowerTableDetailId")]
    [InverseProperty("InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails")]
    public virtual InductionCoilPowerTableDetail InductionCoilPowerTableDetail { get; set; } = null!;
}
