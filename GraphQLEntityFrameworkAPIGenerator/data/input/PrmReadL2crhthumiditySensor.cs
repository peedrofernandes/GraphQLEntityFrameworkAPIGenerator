using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadL2CRHTHumiditySensor")]
public partial class PrmReadL2crhthumiditySensor
{
    [Key]
    public Guid Id { get; set; }

    [Column("L2CChannel")]
    public byte L2cchannel { get; set; }

    [Column("L2CSPEED")]
    public byte L2cspeed { get; set; }

    [Column("RHTDeviceType")]
    public byte RhtdeviceType { get; set; }

    public byte NumReading { get; set; }

    [Column("I2CSlaveAddress")]
    public byte I2cslaveAddress { get; set; }
}
