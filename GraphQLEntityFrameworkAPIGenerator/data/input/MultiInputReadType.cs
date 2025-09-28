using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class MultiInputReadType
{
    [Key]
    public byte ReadTypeId { get; set; }

    [ForeignKey("ReadTypeId")]
    [InverseProperty("MultiInputReadType")]
    public virtual ReadType ReadType { get; set; } = null!;
}
