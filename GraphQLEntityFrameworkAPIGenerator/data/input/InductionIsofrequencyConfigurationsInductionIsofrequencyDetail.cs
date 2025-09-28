using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("InductionIsofreqConfigId", "InductionIsofreqDetailsId", "Index")]
[Table("InductionIsofrequencyConfigurations_InductionIsofrequencyDetails")]
public partial class InductionIsofrequencyConfigurationsInductionIsofrequencyDetail
{
    [Key]
    public Guid InductionIsofreqConfigId { get; set; }

    [Key]
    public Guid InductionIsofreqDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("InductionIsofreqConfigId")]
    [InverseProperty("InductionIsofrequencyConfigurationsInductionIsofrequencyDetails")]
    public virtual InductionIsofrequencyConfiguration InductionIsofreqConfig { get; set; } = null!;

    [ForeignKey("InductionIsofreqDetailsId")]
    [InverseProperty("InductionIsofrequencyConfigurationsInductionIsofrequencyDetails")]
    public virtual InductionIsofrequencyDetail InductionIsofreqDetails { get; set; } = null!;
}
