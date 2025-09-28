using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmTouchSlider")]
public partial class PrmTouchSlider
{
    [Key]
    public Guid Id { get; set; }

    public byte TouchControllerIndex { get; set; }

    public byte TouchSliderIndex { get; set; }
}
