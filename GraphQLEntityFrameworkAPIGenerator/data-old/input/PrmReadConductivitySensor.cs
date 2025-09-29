using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadConductivitySensor")]
public partial class PrmReadConductivitySensor
{
    [Key]
    public Guid Id { get; set; }

    public byte FaultTimeout { get; set; }

    [Column("SignalTMax")]
    public short SignalTmax { get; set; }

    [Column("SignalTMin")]
    public short SignalTmin { get; set; }

    public byte Period { get; set; }

    public byte Filter { get; set; }

    public byte OutputUnitMeasure { get; set; }
}
