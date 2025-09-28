using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("FaultConfigurationsId", "FaultDetailsId", "Index")]
[Table("FaultConfigurations_FaultDetails")]
public partial class FaultConfigurationsFaultDetail
{
    [Key]
    public Guid FaultConfigurationsId { get; set; }

    [Key]
    public Guid FaultDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    public byte Priority { get; set; }

    [ForeignKey("FaultConfigurationsId")]
    [InverseProperty("FaultConfigurationsFaultDetails")]
    public virtual FaultConfiguration FaultConfigurations { get; set; } = null!;

    [ForeignKey("FaultDetailsId")]
    [InverseProperty("FaultConfigurationsFaultDetails")]
    public virtual FaultDetail FaultDetails { get; set; } = null!;
}
