using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("SRFanSpeedCheckParameters")]
public partial class SrfanSpeedCheckParameter
{
    [Key]
    public Guid SrFanSpeedCheckParamsId { get; set; }

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

    public byte Version { get; set; }

    public byte NumberOfCoolingFans { get; set; }

    public short MinFanSpeed1 { get; set; }

    public short MaxFanSpeed1 { get; set; }

    public int DebounceMsForFan1 { get; set; }

    public short FanLoad1 { get; set; }

    [Column("FanGI1")]
    public short FanGi1 { get; set; }

    public short MinFanSpeed2 { get; set; }

    public short MaxFanSpeed2 { get; set; }

    public int DebounceMsForFan2 { get; set; }

    public short FanLoad2 { get; set; }

    [Column("FanGI2")]
    public short FanGi2 { get; set; }

    [InverseProperty("SrFanSpeedCheckParams")]
    public virtual ICollection<SrsafetyRelevantParameter> SrsafetyRelevantParameters { get; set; } = new List<SrsafetyRelevantParameter>();
}
