using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UILowPowerTime")]
public partial class UilowPowerTime
{
    [Key]
    [Column("UILowPowerTimeId")]
    public Guid UilowPowerTimeId { get; set; }

    public int LowPowerTime { get; set; }

    [StringLength(50)]
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

    public bool DisableLowPowerTime { get; set; }

    [Required]
    public bool? DisableEndToOffTransitionTime { get; set; }

    [Required]
    public bool? DisableProgrammingToOffTransitionTime { get; set; }

    [Required]
    public bool? DisableCommunicationErrorDetection { get; set; }

    public int EndToOffTransitionTime { get; set; }

    public int ProgrammingToOffTransitionTime { get; set; }

    public int CommunicationErrorDetectionTime { get; set; }

    public int PasueToOffTransitionTime { get; set; }

    public bool DisablePasueToOffTransitionTime { get; set; }

    [InverseProperty("UilowPowerTime")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();
}
