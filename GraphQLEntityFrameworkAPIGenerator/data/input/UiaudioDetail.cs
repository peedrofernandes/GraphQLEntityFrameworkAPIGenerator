using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIAudioDetails")]
public partial class UiaudioDetail
{
    [Key]
    [Column("UIAudioDetailsId")]
    public Guid UiaudioDetailsId { get; set; }

    public string Description { get; set; } = null!;

    [StringLength(100)]
    public string Name { get; set; } = null!;

    public byte DeviceType { get; set; }

    public byte DeviceIndex { get; set; }

    [Column("UIAudioDevicePrmId")]
    public Guid UiaudioDevicePrmId { get; set; }

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

    public short AudioFunction { get; set; }

    public byte Compartment { get; set; }

    public byte AudioIndex { get; set; }

    [InverseProperty("UiaudioDetails")]
    public virtual ICollection<UiaudioConfigurationsUiaudioDetail> UiaudioConfigurationsUiaudioDetails { get; set; } = new List<UiaudioConfigurationsUiaudioDetail>();
}
