using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("LoadConfigurationId", "LoadDetailId", "Index")]
[Table("LoadConfigurations_LoadDetails")]
public partial class LoadConfigurationsLoadDetail
{
    [Key]
    public Guid LoadConfigurationId { get; set; }

    [Key]
    public Guid LoadDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("LoadConfigurationId")]
    [InverseProperty("LoadConfigurationsLoadDetails")]
    public virtual LoadConfiguration LoadConfiguration { get; set; } = null!;

    [ForeignKey("LoadDetailId")]
    [InverseProperty("LoadConfigurationsLoadDetails")]
    public virtual LoadDetail LoadDetail { get; set; } = null!;
}
