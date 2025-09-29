using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadAccellerometer")]
public partial class PrmReadAccellerometer
{
    [Key]
    public Guid Id { get; set; }

    public byte Device { get; set; }

    public Guid? AccellerometerParamsId { get; set; }

    [ForeignKey("AccellerometerParamsId")]
    [InverseProperty("PrmReadAccellerometers")]
    public virtual PrmReadAccellerometerStlisxDh? AccellerometerParams { get; set; }
}
