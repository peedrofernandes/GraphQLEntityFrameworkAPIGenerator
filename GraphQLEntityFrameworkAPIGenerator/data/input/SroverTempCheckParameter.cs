using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("SROverTempCheckParameters")]
public partial class SroverTempCheckParameter
{
    [Key]
    public Guid Id { get; set; }

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

    public byte? Version { get; set; }

    [Column("TIAI")]
    public byte Tiai { get; set; }

    [Column("RTD1DisableLatchThreshold")]
    public short Rtd1disableLatchThreshold { get; set; }

    [Column("RTD1DisableLoadsNormalThreshold")]
    public short Rtd1disableLoadsNormalThreshold { get; set; }

    [Column("RTD1DisableLoadsCleanThreshold")]
    public short Rtd1disableLoadsCleanThreshold { get; set; }

    [Column("RTD2DisableLatchThreshold")]
    public short Rtd2disableLatchThreshold { get; set; }

    [Column("RTD2DisableLoadsNormalThreshold")]
    public short Rtd2disableLoadsNormalThreshold { get; set; }

    [Column("RTD2DisableLoadsCleanThreshold")]
    public short Rtd2disableLoadsCleanThreshold { get; set; }

    [Column("RTD1ShortedSensorThreshold")]
    public short Rtd1shortedSensorThreshold { get; set; }

    [Column("RTD1OpenedSensorThreshold")]
    public short Rtd1openedSensorThreshold { get; set; }

    [Column("RTD2ShortedSensorThreshold")]
    public short Rtd2shortedSensorThreshold { get; set; }

    [Column("RTD2OpenedSensorThreshold")]
    public short Rtd2openedSensorThreshold { get; set; }

    [InverseProperty("SroverTempCheck")]
    public virtual ICollection<SrsafetyRelevantParameter> SrsafetyRelevantParameters { get; set; } = new List<SrsafetyRelevantParameter>();
}
