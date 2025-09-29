using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromTimeEstimationDetailsView
{
    [StringLength(50)]
    [Unicode(false)]
    public string ModifiersLabel { get; set; } = null!;

    public Guid? ModifiersId { get; set; }

    public Guid ProjectId { get; set; }
}
