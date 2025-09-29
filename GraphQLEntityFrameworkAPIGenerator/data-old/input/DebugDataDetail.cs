using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DebugDataDetail
{
    [Key]
    public Guid DebugDataDetailsId { get; set; }

    public byte DataType { get; set; }

    public int DataValue { get; set; }

    [InverseProperty("DebugDataDetails")]
    public virtual ICollection<DebugDisplacementConfigurationsDebugDataDetail> DebugDisplacementConfigurationsDebugDataDetails { get; set; } = new List<DebugDisplacementConfigurationsDebugDataDetail>();
}
