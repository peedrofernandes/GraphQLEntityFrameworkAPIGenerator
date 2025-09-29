using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("SRExpansionDetails")]
public partial class SrexpansionDetail
{
    [Key]
    [Column("SRExpansionDetailsId")]
    public Guid SrexpansionDetailsId { get; set; }

    public bool DuplicateOverTempCheckParams { get; set; }

    public bool DuplicatePlausibilityCheckParams { get; set; }

    public bool DuplicatePcbCheckParams { get; set; }

    public bool DuplicatePinShortCheckParams { get; set; }

    [InverseProperty("SrexpansionDetails")]
    public virtual ICollection<SrexpansionConfigurationsSrexpansionDetail> SrexpansionConfigurationsSrexpansionDetails { get; set; } = new List<SrexpansionConfigurationsSrexpansionDetail>();
}
