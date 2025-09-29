using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("ApplianceConfigurationId", "AppConfigCompartmentDetailsId", "Index")]
[Table("ApplianceConfiguration_AppConfigCompartmentDetails")]
public partial class ApplianceConfigurationAppConfigCompartmentDetail
{
    [Key]
    [Column("ApplianceConfigurationID")]
    public Guid ApplianceConfigurationId { get; set; }

    [Key]
    [Column("AppConfigCompartmentDetailsID")]
    public Guid AppConfigCompartmentDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("AppConfigCompartmentDetailsId")]
    [InverseProperty("ApplianceConfigurationAppConfigCompartmentDetails")]
    public virtual AppConfigCompartmentDetail AppConfigCompartmentDetails { get; set; } = null!;

    [ForeignKey("ApplianceConfigurationId")]
    [InverseProperty("ApplianceConfigurationAppConfigCompartmentDetails")]
    public virtual ApplianceConfiguration ApplianceConfiguration { get; set; } = null!;
}
