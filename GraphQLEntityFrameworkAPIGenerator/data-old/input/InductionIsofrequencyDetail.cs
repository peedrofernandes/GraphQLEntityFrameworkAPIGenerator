using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class InductionIsofrequencyDetail
{
    [Key]
    public Guid InductionIsofreqDetailsId { get; set; }

    public byte NumberOfCoils { get; set; }

    public byte? AdjacentCoil0 { get; set; }

    public byte? AdjacentCoil1 { get; set; }

    public byte? AdjacentCoil2 { get; set; }

    public byte? AdjacentCoil3 { get; set; }

    public byte? AdjacentCoil4 { get; set; }

    public byte? AdjacentCoil5 { get; set; }

    [InverseProperty("InductionIsofreqDetails")]
    public virtual ICollection<InductionIsofrequencyConfigurationsInductionIsofrequencyDetail> InductionIsofrequencyConfigurationsInductionIsofrequencyDetails { get; set; } = new List<InductionIsofrequencyConfigurationsInductionIsofrequencyDetail>();
}
