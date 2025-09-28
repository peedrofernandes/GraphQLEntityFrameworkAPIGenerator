using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PilotMultiSequenceConfig")]
public partial class PilotMultiSequenceConfig
{
    [Key]
    public Guid ConfigId { get; set; }

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

    [Column("Number_Of_Sequence")]
    public byte NumberOfSequence { get; set; }

    [InverseProperty("Config")]
    public virtual ICollection<PilotMultiSequenceConfigDetail> PilotMultiSequenceConfigDetails { get; set; } = new List<PilotMultiSequenceConfigDetail>();

    [InverseProperty("SequencesConfigurationNavigation")]
    public virtual ICollection<PrmPilotMultiSequence> PrmPilotMultiSequences { get; set; } = new List<PrmPilotMultiSequence>();
}
