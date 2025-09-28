using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotVent")]
public partial class PrmPilotVent
{
    [Key]
    public Guid Id { get; set; }

    public byte StructureVersion { get; set; }

    public byte OnPositionDetectionMethod { get; set; }

    [Column("OffPositionFeedbackGIIndex")]
    public byte OffPositionFeedbackGiindex { get; set; }

    [Column("OnPositionFeedbackGIIndex")]
    public byte OnPositionFeedbackGiindex { get; set; }

    public int OffToOnPositionTime { get; set; }

    [Column("OffToOnPositionZCNumber")]
    public int OffToOnPositionZcnumber { get; set; }

    public short OffPositionDetectionTimeout { get; set; }

    public short OnPositionDetectionTimeout { get; set; }

    public byte OffPositionDetectionMethod { get; set; }

    public int OnToOffPositionTimeOrZcNumber { get; set; }
}
