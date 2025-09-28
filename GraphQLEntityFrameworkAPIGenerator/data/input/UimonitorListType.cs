using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIMonitorListTypes")]
public partial class UimonitorListType
{
    [Key]
    [Column("UIMonitorTypeId")]
    public byte UimonitorTypeId { get; set; }

    [Column("UIMonitorTypeDsc")]
    [StringLength(50)]
    public string UimonitorTypeDsc { get; set; } = null!;
}
