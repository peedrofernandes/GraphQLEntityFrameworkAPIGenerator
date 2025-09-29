using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmUIAudioExpansion")]
public partial class PrmUiaudioExpansion
{
    [Key]
    public Guid Id { get; set; }

    public byte SoundIndex { get; set; }
}
