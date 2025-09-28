using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("DefaultPinConfigurationId", "DefaultPinDetailId", "Index")]
[Table("DefaultPinConfigurations_DefaultPinDetails")]
public partial class DefaultPinConfigurationsDefaultPinDetail
{
    [Key]
    public Guid DefaultPinConfigurationId { get; set; }

    [Key]
    public Guid DefaultPinDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("DefaultPinConfigurationId")]
    [InverseProperty("DefaultPinConfigurationsDefaultPinDetails")]
    public virtual DefaultPinConfiguration DefaultPinConfiguration { get; set; } = null!;

    [ForeignKey("DefaultPinDetailId")]
    [InverseProperty("DefaultPinConfigurationsDefaultPinDetails")]
    public virtual DefaultPinDetail DefaultPinDetail { get; set; } = null!;
}
