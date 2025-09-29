using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class FeedbackParameter
{
    [Key]
    public Guid FeedbackParametersId { get; set; }

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

    public byte FeedbacksNumber { get; set; }

    public byte StatesNumber { get; set; }

    public byte ItemsNumber { get; set; }

    public byte ReadTypeId1 { get; set; }

    public byte ReadTypePos1 { get; set; }

    public byte ReadTypeId2 { get; set; }

    public byte ReadTypePos2 { get; set; }

    [MaxLength(16)]
    public byte[] Off1 { get; set; } = null!;

    [MaxLength(16)]
    public byte[] On1 { get; set; } = null!;

    [MaxLength(16)]
    public byte[] Trn1 { get; set; } = null!;

    [MaxLength(16)]
    public byte[] Alt1 { get; set; } = null!;

    [MaxLength(16)]
    public byte[] Off2 { get; set; } = null!;

    [MaxLength(16)]
    public byte[] On2 { get; set; } = null!;

    [MaxLength(16)]
    public byte[] Trn2 { get; set; } = null!;

    [MaxLength(16)]
    public byte[] Alt2 { get; set; } = null!;

    [Column("FBValues")]
    [MaxLength(32)]
    public byte[] Fbvalues { get; set; } = null!;

    [InverseProperty("FeedbackParameters")]
    public virtual ICollection<LoadDetail> LoadDetails { get; set; } = new List<LoadDetail>();
}
