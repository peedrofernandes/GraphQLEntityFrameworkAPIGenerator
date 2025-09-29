using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIStmSetAnimation")]
public partial class UistmSetAnimation
{
    [Key]
    public Guid Id { get; set; }

    [Column("LEDPattern")]
    public int Ledpattern { get; set; }

    [Column("LEDGroup")]
    public short Ledgroup { get; set; }

    public byte AnimationParameterIndex { get; set; }

    public byte NumberOfRepeats { get; set; }

    public short PauseTime { get; set; }

    public bool FlagInfiniteRepeats { get; set; }

    public bool FlagOneShotAnimation { get; set; }

    public bool FlagInfinitePauseTime { get; set; }
}
