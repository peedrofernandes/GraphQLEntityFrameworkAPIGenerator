using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class LoadToLoadGroupView
{
    public byte LoadId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LoadDsc { get; set; } = null!;

    public byte LoadGroupId { get; set; }

    [StringLength(50)]
    public string LoadGroupDsc { get; set; } = null!;
}
