using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UITimeToEndVisualizerDetails")]
public partial class UitimeToEndVisualizerDetail
{
    [Key]
    [Column("UITimeToEndVisualizerDetailId")]
    public Guid UitimeToEndVisualizerDetailId { get; set; }

    public int BumpUpValue { get; set; }

    public int BumpUpTime { get; set; }

    public float FreezeTimeRate { get; set; }

    public float SpeedUpRate { get; set; }

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

    public double LightFilterBeta { get; set; }

    public double HeavyFilterBeta { get; set; }

    [InverseProperty("UitimeToEndVisualizerDetail")]
    public virtual ICollection<UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail> UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails { get; set; } = new List<UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail>();
}
