using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class SetVariableOperation
{
    [Key]
    public byte OperationId { get; set; }

    [StringLength(10)]
    public string Operation { get; set; } = null!;
}
