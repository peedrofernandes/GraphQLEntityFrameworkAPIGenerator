using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class LoadAlias
{
    [Key]
    [Column("LoadAliasID")]
    public byte LoadAliasId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LoadAliasDsc { get; set; } = null!;
}
