using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class InductionCoilPowerTableDetail
{
    [Key]
    public Guid InductionCoilPowerTableDetailId { get; set; }

    public int Wattage { get; set; }

    public int Timeout { get; set; }

    public byte ReturnLevel { get; set; }

    [InverseProperty("InductionCoilPowerTableDetail")]
    public virtual ICollection<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail> InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails { get; set; } = new List<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail>();
}
