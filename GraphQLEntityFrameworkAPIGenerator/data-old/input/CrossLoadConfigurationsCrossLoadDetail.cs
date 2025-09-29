using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("CrossLoadConfigurationId", "CrossLoadDetailId", "Index")]
[Table("CrossLoadConfigurations_CrossLoadDetails")]
public partial class CrossLoadConfigurationsCrossLoadDetail
{
    [Key]
    public Guid CrossLoadConfigurationId { get; set; }

    [Key]
    public Guid CrossLoadDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("CrossLoadConfigurationId")]
    [InverseProperty("CrossLoadConfigurationsCrossLoadDetails")]
    public virtual CrossLoadConfiguration CrossLoadConfiguration { get; set; } = null!;

    [ForeignKey("CrossLoadDetailId")]
    [InverseProperty("CrossLoadConfigurationsCrossLoadDetails")]
    public virtual CrossLoadDetail CrossLoadDetail { get; set; } = null!;
}
