using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("ProductTypeId", "VariableOffset", "TrackId")]
public partial class VariableBaseTrack
{
    [Key]
    public byte ProductTypeId { get; set; }

    public int VariableId { get; set; }

    [Key]
    public byte VariableOffset { get; set; }

    public byte VariableType { get; set; }

    [StringLength(50)]
    public string TrackName { get; set; } = null!;

    [Key]
    public int TrackId { get; set; }

    public byte TrackType { get; set; }

    [StringLength(80)]
    public string? TrackHelpLabel { get; set; }

    public bool IsWritable { get; set; }

    [StringLength(15)]
    public string? TrackMeasUnit { get; set; }

    public long TrackColor { get; set; }

    public byte TrackWidth { get; set; }

    public byte TrackStyle { get; set; }

    public bool TrackAutoscale { get; set; }

    public bool TrackEnabled { get; set; }

    public byte TrackDecs { get; set; }

    public byte TrackMeanDecs { get; set; }

    public byte TrackDevDecs { get; set; }

    public bool TrackMultMetSciNotation { get; set; }

    public byte TrackSaveDecs { get; set; }

    public bool TrackAcqFileSciNotation { get; set; }

    [Column("TrackVMin")]
    public float TrackVmin { get; set; }

    [Column("TrackVMax")]
    public float TrackVmax { get; set; }

    public int TrackTime { get; set; }

    public byte TrackDependances { get; set; }

    [StringLength(50)]
    public string DisplayName { get; set; } = null!;

    [StringLength(3)]
    public string Tag { get; set; } = null!;

    public int TrackMultiplier { get; set; }

    [StringLength(500)]
    public string TrackFormula { get; set; } = null!;
}
