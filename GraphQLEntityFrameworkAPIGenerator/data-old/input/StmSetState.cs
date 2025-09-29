using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmSetState")]
public partial class StmSetState
{
    [Key]
    public Guid Id { get; set; }

    public byte EndCompletion { get; set; }
}
