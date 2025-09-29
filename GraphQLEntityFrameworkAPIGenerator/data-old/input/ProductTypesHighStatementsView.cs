using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class ProductTypesHighStatementsView
{
    public byte ProductTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ProductTypeDsc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public byte Priority { get; set; }

    public byte OpCode { get; set; }

    public bool F0 { get; set; }

    public bool F1 { get; set; }

    public int HighStatementId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Statement { get; set; } = null!;
}
