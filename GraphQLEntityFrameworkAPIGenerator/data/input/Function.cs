using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Function
{
    [Key]
    public byte FunctionId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FunctionDsc { get; set; } = null!;

    public byte DataType { get; set; }
}
