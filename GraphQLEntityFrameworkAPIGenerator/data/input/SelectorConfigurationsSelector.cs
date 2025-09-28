using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("SelectorConfigurationId", "SelectorId", "Index")]
[Table("SelectorConfigurations_Selectors")]
public partial class SelectorConfigurationsSelector
{
    [Key]
    public Guid SelectorConfigurationId { get; set; }

    [Key]
    public Guid SelectorId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("SelectorId")]
    [InverseProperty("SelectorConfigurationsSelectors")]
    public virtual Selector Selector { get; set; } = null!;

    [ForeignKey("SelectorConfigurationId")]
    [InverseProperty("SelectorConfigurationsSelectors")]
    public virtual SelectorConfiguration SelectorConfiguration { get; set; } = null!;
}
