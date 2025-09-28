using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CompartmentType
{
    [Key]
    public byte CompartmentTypeId { get; set; }

    [StringLength(50)]
    public string CompartmentTypeDsc { get; set; } = null!;
}
