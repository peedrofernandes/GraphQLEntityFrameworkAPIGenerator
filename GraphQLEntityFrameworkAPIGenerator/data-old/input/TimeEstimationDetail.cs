using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class TimeEstimationDetail
{
    [Key]
    public Guid TimeEstimationDetailId { get; set; }

    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiersLabel { get; set; } = null!;

    public Guid? ModifiersId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [ForeignKey("ModifiersId")]
    [InverseProperty("TimeEstimationDetails")]
    public virtual Modifier? Modifiers { get; set; }

    [InverseProperty("TimeEstimationDetail")]
    public virtual ICollection<TimeEstimationConfigurationsTimeEstimationDetail> TimeEstimationConfigurationsTimeEstimationDetails { get; set; } = new List<TimeEstimationConfigurationsTimeEstimationDetail>();
}
