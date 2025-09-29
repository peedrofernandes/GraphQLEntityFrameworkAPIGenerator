using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class InputToInputGroupView
{
    public byte InputId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string InputDsc { get; set; } = null!;

    public byte InputGroupId { get; set; }

    [StringLength(50)]
    public string InputGroupDesc { get; set; } = null!;
}
