using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DefaultPinDetail
{
    [Key]
    public Guid DefaultPinDetailId { get; set; }

    public byte VirtualPinNumber { get; set; }

    public bool High { get; set; }

    public short GpioPinTypeId { get; set; }

    [InverseProperty("DefaultPinDetail")]
    public virtual ICollection<DefaultPinConfigurationsDefaultPinDetail> DefaultPinConfigurationsDefaultPinDetails { get; set; } = new List<DefaultPinConfigurationsDefaultPinDetail>();

    [ForeignKey("GpioPinTypeId")]
    [InverseProperty("DefaultPinDetails")]
    public virtual DefaultGpioPinType GpioPinType { get; set; } = null!;
}
