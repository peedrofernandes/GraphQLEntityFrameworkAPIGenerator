using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DefaultGpioPinType
{
    [Key]
    public short Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public bool IsOutput { get; set; }

    [InverseProperty("GpioPinType")]
    public virtual ICollection<DefaultPinDetail> DefaultPinDetails { get; set; } = new List<DefaultPinDetail>();

    [InverseProperty("GpioPinType")]
    public virtual ICollection<UidefaultPinDetail> UidefaultPinDetails { get; set; } = new List<UidefaultPinDetail>();
}
