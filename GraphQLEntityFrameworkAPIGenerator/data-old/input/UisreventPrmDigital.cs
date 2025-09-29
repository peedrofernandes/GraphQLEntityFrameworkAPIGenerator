using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UISREventPrmDigital")]
public partial class UisreventPrmDigital
{
    [Key]
    public Guid Id { get; set; }

    [Column("SRDigitalInputValue")]
    public byte SrdigitalInputValue { get; set; }
}
