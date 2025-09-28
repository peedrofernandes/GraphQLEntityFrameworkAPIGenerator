using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class FunctionLabel
{
    [Key]
    public byte FunctionLabelId { get; set; }

    [Column("FunctionLabel")]
    [StringLength(50)]
    [Unicode(false)]
    public string FunctionLabel1 { get; set; } = null!;

    [InverseProperty("FunctionLabelNavigation")]
    public virtual ICollection<UifunctionConfigurationsUifunctionDetail> UifunctionConfigurationsUifunctionDetails { get; set; } = new List<UifunctionConfigurationsUifunctionDetail>();
}
