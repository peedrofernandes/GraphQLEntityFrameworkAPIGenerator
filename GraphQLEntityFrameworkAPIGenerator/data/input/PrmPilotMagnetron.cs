using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotMagnetron")]
public partial class PrmPilotMagnetron
{
    [Key]
    public Guid Id { get; set; }

    public byte StructureVersion { get; set; }

    public bool TurboEnable { get; set; }

    public bool AcMainsSamePhase { get; set; }

    public bool MwFbActiveHigh { get; set; }

    public byte TurboOnOffDelay { get; set; }

    public byte MainsPinIndex { get; set; }

    public byte MicrowaveFeedbackPinIndex { get; set; }

    public byte MicrowaveDoorInput { get; set; }
}
