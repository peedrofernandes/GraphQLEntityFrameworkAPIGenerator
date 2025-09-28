using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UISREventPrmAnalog")]
public partial class UisreventPrmAnalog
{
    [Key]
    public Guid Id { get; set; }

    [Column("SRAnalogInputMinimum")]
    public int SranalogInputMinimum { get; set; }

    [Column("SRAnalogInputMaximum")]
    public int SranalogInputMaximum { get; set; }
}
