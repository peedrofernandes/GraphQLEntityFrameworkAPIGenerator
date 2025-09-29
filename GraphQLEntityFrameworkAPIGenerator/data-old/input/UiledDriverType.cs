using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UILedDriverTypes")]
public partial class UiledDriverType
{
    [Key]
    public byte LedTypeId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string LedTypeDescription { get; set; } = null!;

    [InverseProperty("LedType")]
    public virtual ICollection<UiledDriverParameter> UiledDriverParameters { get; set; } = new List<UiledDriverParameter>();
}
