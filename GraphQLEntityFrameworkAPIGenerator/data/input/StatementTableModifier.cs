using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class StatementTableModifier
{
    [Key]
    public Guid Id { get; set; }

    public byte ModifiersNum { get; set; }

    [MaxLength(16)]
    public byte[] FunctionPos { get; set; } = null!;
}
