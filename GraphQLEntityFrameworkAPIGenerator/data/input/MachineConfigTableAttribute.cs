using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class MachineConfigTableAttribute
{
    [Key]
    public int Id { get; set; }

    public bool IsMandatory { get; set; }

    public bool AllowRepeat { get; set; }
}
