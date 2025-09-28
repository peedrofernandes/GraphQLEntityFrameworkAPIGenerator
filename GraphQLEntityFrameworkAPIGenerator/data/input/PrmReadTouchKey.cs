using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadTouchKey")]
public partial class PrmReadTouchKey
{
    [Key]
    public Guid Id { get; set; }

    public byte TouchControllerIndex { get; set; }

    public byte TouchKeyIndex { get; set; }
}
