using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UiaudioConfigurationsId", "UiaudioDetailsId", "Index")]
[Table("UIAudioConfigurations_UIAudioDetails")]
public partial class UiaudioConfigurationsUiaudioDetail
{
    [Key]
    [Column("UIAudioConfigurationsId")]
    public Guid UiaudioConfigurationsId { get; set; }

    [Key]
    [Column("UIAudioDetailsId")]
    public Guid UiaudioDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UiaudioConfigurationsId")]
    [InverseProperty("UiaudioConfigurationsUiaudioDetails")]
    public virtual UiaudioConfiguration UiaudioConfigurations { get; set; } = null!;

    [ForeignKey("UiaudioDetailsId")]
    [InverseProperty("UiaudioConfigurationsUiaudioDetails")]
    public virtual UiaudioDetail UiaudioDetails { get; set; } = null!;
}
