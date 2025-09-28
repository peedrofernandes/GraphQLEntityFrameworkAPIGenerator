using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("CooktopOrgConfigurationId", "InductionIpcid", "Index")]
[Table("InductionCooktopOrgConfigurations_InductionIPCDetails")]
public partial class InductionCooktopOrgConfigurationsInductionIpcdetail
{
    [Key]
    public Guid CooktopOrgConfigurationId { get; set; }

    [Key]
    [Column("InductionIPCId")]
    public Guid InductionIpcid { get; set; }

    [Key]
    public byte Index { get; set; }

    [Column("ACUExpansionBoardId")]
    public byte AcuexpansionBoardId { get; set; }

    [ForeignKey("CooktopOrgConfigurationId")]
    [InverseProperty("InductionCooktopOrgConfigurationsInductionIpcdetails")]
    public virtual InductionCooktopOrgConfiguration CooktopOrgConfiguration { get; set; } = null!;

    [ForeignKey("InductionIpcid")]
    [InverseProperty("InductionCooktopOrgConfigurationsInductionIpcdetails")]
    public virtual InductionIpcdetail InductionIpc { get; set; } = null!;
}
