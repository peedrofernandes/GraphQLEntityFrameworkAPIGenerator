using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadI2CPressureSensor")]
public partial class PrmReadI2cpressureSensor
{
    [Key]
    public Guid Id { get; set; }

    public bool DeviceModeType { get; set; }

    public byte InvertedAlpha { get; set; }

    public byte InitialStabilizationTime { get; set; }

    public byte CommunicationFaultDebounce { get; set; }

    public byte CommunicationFaultRetries { get; set; }
}
