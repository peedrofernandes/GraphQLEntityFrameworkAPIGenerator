using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIDefaultPinDetails")]
public partial class UidefaultPinDetail
{
    [Key]
    [Column("UIDefaultPinDetailId")]
    public Guid UidefaultPinDetailId { get; set; }

    public byte VirtualPinNumber { get; set; }

    public bool High { get; set; }

    public short GpioPinTypeId { get; set; }

    [ForeignKey("GpioPinTypeId")]
    [InverseProperty("UidefaultPinDetails")]
    public virtual DefaultGpioPinType GpioPinType { get; set; } = null!;

    [InverseProperty("UidefaultPinDetail")]
    public virtual ICollection<UidefaultPinConfigurationsUidefaultPinDetail> UidefaultPinConfigurationsUidefaultPinDetails { get; set; } = new List<UidefaultPinConfigurationsUidefaultPinDetail>();
}
