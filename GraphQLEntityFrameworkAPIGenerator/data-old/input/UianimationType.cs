using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIAnimationTypes")]
public partial class UianimationType
{
    [Key]
    public byte AnimationTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AnimationTypeDesc { get; set; } = null!;
}
