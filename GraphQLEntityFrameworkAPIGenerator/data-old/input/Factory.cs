using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Factory
{
    [Key]
    public byte FactoryId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FactoryDsc { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string FactoryCode { get; set; } = null!;
}
