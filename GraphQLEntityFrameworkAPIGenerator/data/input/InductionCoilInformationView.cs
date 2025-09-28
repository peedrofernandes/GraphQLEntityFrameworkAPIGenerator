using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class InductionCoilInformationView
{
    public Guid MachineConfigurationId { get; set; }

    [Column("IPC")]
    public int? Ipc { get; set; }

    public int ZeroCrossChannel { get; set; }

    public int Inverter { get; set; }

    public int Channel { get; set; }

    [StringLength(50)]
    public string CoilDescription { get; set; } = null!;

    [StringLength(50)]
    public string CoilPowerTableDesc { get; set; } = null!;

    public Guid InductionCoilPowerTableConfigId { get; set; }
}
