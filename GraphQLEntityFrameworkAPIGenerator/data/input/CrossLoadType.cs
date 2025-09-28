using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CrossLoadType
{
    [Key]
    public byte CrossLoadTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CrossLoadTypeDsc { get; set; } = null!;

    [InverseProperty("CrossLoadType")]
    public virtual ICollection<CrossLoadDetail> CrossLoadDetails { get; set; } = new List<CrossLoadDetail>();
}
