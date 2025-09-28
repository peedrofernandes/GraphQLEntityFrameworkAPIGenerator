using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotWax")]
public partial class PrmPilotWax
{
    [Key]
    public Guid Id { get; set; }

    public short MaxFaultWaitTime { get; set; }

    public short MaxFaultWaitTimeClose { get; set; }

    public byte DoorLockFilterTime { get; set; }

    public byte DoorLockOnTime { get; set; }

    public byte DoorLockOffTime { get; set; }

    public bool IsDoorSensing { get; set; }
}
