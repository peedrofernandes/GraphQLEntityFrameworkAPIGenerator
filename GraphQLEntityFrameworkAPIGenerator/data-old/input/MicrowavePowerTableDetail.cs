using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class MicrowavePowerTableDetail
{
    [Key]
    public Guid MicrowavePowerTableDetailsId { get; set; }

    public byte PowerLabel { get; set; }

    [Column("SMPSDuty")]
    public float Smpsduty { get; set; }

    public float OnTime { get; set; }

    [InverseProperty("MicrowavePowerTableDetails")]
    public virtual ICollection<MicrowavePowerTableConfigurationsMicrowavePowerTableDetail> MicrowavePowerTableConfigurationsMicrowavePowerTableDetails { get; set; } = new List<MicrowavePowerTableConfigurationsMicrowavePowerTableDetail>();
}
