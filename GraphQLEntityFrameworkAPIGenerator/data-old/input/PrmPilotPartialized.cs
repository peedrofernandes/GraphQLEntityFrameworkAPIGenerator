using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotPartialized")]
public partial class PrmPilotPartialized
{
    [Key]
    public Guid Id { get; set; }

    public byte? Start1 { get; set; }

    public byte? Stop1 { get; set; }

    public byte? Start2 { get; set; }

    public byte? Stop2 { get; set; }

    public byte? Start3 { get; set; }

    public byte? Stop3 { get; set; }

    public byte? Start4 { get; set; }

    public byte? Stop4 { get; set; }

    public byte? NumSpeeds { get; set; }

    public byte PulseWidthPercentage { get; set; }

    public byte MinDeactivationPercentage { get; set; }

    public byte ActivationEdge { get; set; }

    public byte MinPulseWidthPercentage { get; set; }
}
