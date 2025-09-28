using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UICypressTouchParameters")]
public partial class UicypressTouchParameter
{
    [Key]
    [Column("UICypressTouchId")]
    public Guid UicypressTouchId { get; set; }

    [StringLength(100)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public byte NumDevices { get; set; }

    public bool CapsenseMethod { get; set; }

    [Column("DeviceI2CPort0")]
    public byte DeviceI2cport0 { get; set; }

    [Column("DeviceI2CAddress0")]
    public byte DeviceI2caddress0 { get; set; }

    public byte DeviceNumKeys0 { get; set; }

    [Column("DeviceI2CPort1")]
    public byte? DeviceI2cport1 { get; set; }

    [Column("DeviceI2CAddress1")]
    public byte? DeviceI2caddress1 { get; set; }

    public byte? DeviceNumKeys1 { get; set; }

    public byte NumSensors { get; set; }

    [MaxLength(48)]
    public byte[] Sensors { get; set; } = null!;

    [Column("LLIs")]
    [MaxLength(48)]
    public byte[] Llis { get; set; } = null!;

    [MaxLength(48)]
    public byte[] Positions { get; set; } = null!;

    [Column("LPMDevice")]
    public byte Lpmdevice { get; set; }

    [Column("LPMSensorBitmap")]
    [MaxLength(3)]
    public byte[] LpmsensorBitmap { get; set; } = null!;

    public byte StuckKeyTimeout { get; set; }

    [Column("I2CSpeed")]
    public byte I2cspeed { get; set; }

    public byte DeviceNumSliders0 { get; set; }

    public byte DeviceNumSliders1 { get; set; }

    [MaxLength(4)]
    public byte[] PositionsTouchSliders1 { get; set; } = null!;

    [MaxLength(4)]
    public byte[] PositionsTouchSliders2 { get; set; } = null!;

    [MaxLength(4)]
    public byte[] SensorsTouchSliders1 { get; set; } = null!;

    [MaxLength(4)]
    public byte[] SensorsTouchSliders2 { get; set; } = null!;

    [MaxLength(24)]
    public byte[] SensorsDataTouchSliders1 { get; set; } = null!;

    [MaxLength(24)]
    public byte[] SensorsDataTouchSliders2 { get; set; } = null!;

    [InverseProperty("UicypressTouch")]
    public virtual ICollection<UitouchDevice> UitouchDevices { get; set; } = new List<UitouchDevice>();
}
