using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UITouchDevices")]
public partial class UitouchDevice
{
    [Key]
    [Column("UITouchDevicesId")]
    public Guid UitouchDevicesId { get; set; }

    [Column("UICypressTouchId")]
    public Guid? UicypressTouchId { get; set; }

    [Column("UITouchLeanId")]
    public Guid? UitouchLeanId { get; set; }

    [InverseProperty("UitouchDevices")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    [ForeignKey("UicypressTouchId")]
    [InverseProperty("UitouchDevices")]
    public virtual UicypressTouchParameter? UicypressTouch { get; set; }

    [ForeignKey("UitouchLeanId")]
    [InverseProperty("UitouchDevices")]
    public virtual UitouchLean? UitouchLean { get; set; }
}
