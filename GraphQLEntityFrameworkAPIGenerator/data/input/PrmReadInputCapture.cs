using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadInputCapture")]
public partial class PrmReadInputCapture
{
    [Key]
    public Guid Id { get; set; }

    public short FaultTimeout { get; set; }

    public short SamplingTime { get; set; }

    public int MinimumFrequency { get; set; }

    public int MaximumFrequency { get; set; }

    public byte MinimumDuty { get; set; }

    public byte MaximumDuty { get; set; }

    public int FilterFrequency { get; set; }

    public byte FilterDuty { get; set; }

    public byte BasePeriod { get; set; }
}
