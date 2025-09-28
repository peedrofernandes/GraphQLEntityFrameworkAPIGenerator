using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class ProjectsLastRevisionView
{
    [StringLength(11)]
    [Unicode(false)]
    public string? IndustrialCode { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ProductType { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ProductCode { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? LastProductRevision { get; set; }

    public byte Status { get; set; }
}
