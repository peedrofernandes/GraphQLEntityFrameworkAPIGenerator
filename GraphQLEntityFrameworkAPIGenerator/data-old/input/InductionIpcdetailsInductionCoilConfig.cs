using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("InductionIpcid", "InductionCoilConfigId", "Index")]
[Table("InductionIPCDetails_InductionCoilConfig")]
public partial class InductionIpcdetailsInductionCoilConfig
{
    [Key]
    [Column("InductionIPCId")]
    public Guid InductionIpcid { get; set; }

    [Key]
    public Guid InductionCoilConfigId { get; set; }

    [Key]
    [Column("index")]
    public byte Index { get; set; }

    [ForeignKey("InductionCoilConfigId")]
    [InverseProperty("InductionIpcdetailsInductionCoilConfigs")]
    public virtual InductionCoilConfig InductionCoilConfig { get; set; } = null!;

    [ForeignKey("InductionIpcid")]
    [InverseProperty("InductionIpcdetailsInductionCoilConfigs")]
    public virtual InductionIpcdetail InductionIpc { get; set; } = null!;
}
