using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UitimeToEndVisualizerId", "UitimeToEndVisualizerDetailId", "Index")]
[Table("UITimeToEndVisualizerConfigurations_UITimeToEndVisualizerDetails")]
public partial class UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail
{
    [Key]
    [Column("UITimeToEndVisualizerId")]
    public Guid UitimeToEndVisualizerId { get; set; }

    [Key]
    [Column("UITimeToEndVisualizerDetailId")]
    public Guid UitimeToEndVisualizerDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UitimeToEndVisualizerId")]
    [InverseProperty("UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails")]
    public virtual UitimeToEndVisualizerConfiguration UitimeToEndVisualizer { get; set; } = null!;

    [ForeignKey("UitimeToEndVisualizerDetailId")]
    [InverseProperty("UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetails")]
    public virtual UitimeToEndVisualizerDetail UitimeToEndVisualizerDetail { get; set; } = null!;
}
