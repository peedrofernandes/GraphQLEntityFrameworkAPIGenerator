using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Brand
{
    [Key]
    public byte BrandId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BrandDsc { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[]? BrandImageOn { get; set; }

    [Column(TypeName = "image")]
    public byte[]? BrandImageOff { get; set; }

    [InverseProperty("Brand")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();
}
