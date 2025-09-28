using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UISREventPrmEncoder")]
public partial class UisreventPrmEncoder
{
    [Key]
    public Guid Id { get; set; }

    [Column("SREncoderInputValue")]
    public byte SrencoderInputValue { get; set; }
}
