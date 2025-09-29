using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmUIAudioBuzzer")]
public partial class PrmUiaudioBuzzer
{
    [Key]
    public Guid Id { get; set; }

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

    public byte ChimeIndex { get; set; }

    public byte NumRepeats { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<UiaudioBuzzerUiaudioBuzzerDetail> UiaudioBuzzerUiaudioBuzzerDetails { get; set; } = new List<UiaudioBuzzerUiaudioBuzzerDetail>();
}
