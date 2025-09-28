using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class LoadsControlActivateOption
{
    public byte Id { get; set; }

    [Unicode(false)]
    public string Description { get; set; } = null!;
}
