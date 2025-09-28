using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadVirtualDigital")]
public partial class PrmReadVirtualDigital
{
    [Key]
    public Guid Id { get; set; }

    public byte InputIndex0 { get; set; }

    public byte InputIndex1 { get; set; }

    public byte InputIndex2 { get; set; }

    public byte InputIndex3 { get; set; }

    public byte ReadTypeId { get; set; }
}
