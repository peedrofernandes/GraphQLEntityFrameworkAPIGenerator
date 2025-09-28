using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("AppConfigCoolingFanCompartment")]
public partial class AppConfigCoolingFanCompartment
{
    [Key]
    public Guid Id { get; set; }

    public byte NumberOfCoolingFans { get; set; }

    public short Fan1LoadId { get; set; }

    [Column("Fan1SpeedGI")]
    public short Fan1SpeedGi { get; set; }

    public short Fan2LoadId { get; set; }

    [Column("Fan2SpeedGI")]
    public short Fan2SpeedGi { get; set; }

    [InverseProperty("OvenCoolingFanComp")]
    public virtual ICollection<AppConfigCompartmentDetail> AppConfigCompartmentDetails { get; set; } = new List<AppConfigCompartmentDetail>();
}
