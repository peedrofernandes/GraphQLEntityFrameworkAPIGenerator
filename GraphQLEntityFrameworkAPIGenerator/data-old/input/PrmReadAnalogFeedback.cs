using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadAnalogFeedback")]
public partial class PrmReadAnalogFeedback
{
    [Key]
    public Guid Id { get; set; }

    public byte WaitTime { get; set; }

    public byte SamplingDelay { get; set; }

    [MaxLength(64)]
    public byte[] FeedbackValues { get; set; } = null!;

    [MaxLength(64)]
    public byte[] Thresholds { get; set; } = null!;
}
