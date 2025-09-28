using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadAccellerometerSTLISxDH")]
public partial class PrmReadAccellerometerStlisxDh
{
    [Key]
    [Column("PrmReadAccellerometerSTLISxDHId")]
    public Guid PrmReadAccellerometerStlisxDhid { get; set; }

    [Column("FIFO")]
    public byte Fifo { get; set; }

    [Column("RES")]
    public byte Res { get; set; }

    [Column("I2CPort")]
    public byte I2cport { get; set; }

    [Column("I2CSPD")]
    public byte I2cspd { get; set; }

    [Column("I2CAddress")]
    public byte I2caddress { get; set; }

    [Column("XA")]
    public byte Xa { get; set; }

    [Column("YA")]
    public byte Ya { get; set; }

    [Column("ZA")]
    public byte Za { get; set; }

    [Column("BDU")]
    public byte Bdu { get; set; }

    [Column("BE")]
    public byte Be { get; set; }

    [Column("TR")]
    public byte Tr { get; set; }

    public byte Scale { get; set; }

    public byte DataRate { get; set; }

    [Column("XAxisOptions")]
    public byte XaxisOptions { get; set; }

    [Column("YAxisOptions")]
    public byte YaxisOptions { get; set; }

    [Column("ZAxisOptions")]
    public byte ZaxisOptions { get; set; }

    [InverseProperty("AccellerometerParams")]
    public virtual ICollection<PrmReadAccellerometer> PrmReadAccellerometers { get; set; } = new List<PrmReadAccellerometer>();
}
