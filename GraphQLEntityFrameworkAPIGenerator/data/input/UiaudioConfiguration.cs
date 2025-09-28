using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIAudioConfigurations")]
public partial class UiaudioConfiguration
{
    [Key]
    [Column("UIAudioConfigurationsId")]
    public Guid UiaudioConfigurationsId { get; set; }

    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [InverseProperty("UiaudioConfiguration")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [InverseProperty("UiaudioConfigurations")]
    public virtual ICollection<UiaudioConfigurationsUiaudioDetail> UiaudioConfigurationsUiaudioDetails { get; set; } = new List<UiaudioConfigurationsUiaudioDetail>();
}
