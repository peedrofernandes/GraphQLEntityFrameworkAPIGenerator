using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIStmSetAudio")]
public partial class UistmSetAudio
{
    [Key]
    public Guid Id { get; set; }

    public byte? AudioLabel { get; set; }

    public bool OverrideMasterVolume { get; set; }

    public byte? Volume { get; set; }
}
