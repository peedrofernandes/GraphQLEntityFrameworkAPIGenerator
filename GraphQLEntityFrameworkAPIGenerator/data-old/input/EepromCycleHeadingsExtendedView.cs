using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromCycleHeadingsExtendedView
{
    public Guid ProjectId { get; set; }

    public Guid SelectorConfigurationId { get; set; }

    public Guid SelectorId { get; set; }

    [StringLength(50)]
    public string SelectorDescription { get; set; } = null!;

    public int? Target { get; set; }

    public byte CyclePosition { get; set; }

    public byte? EnteringCycle { get; set; }

    public Guid? SelectorConditionId { get; set; }

    public Guid CycleId { get; set; }

    [StringLength(50)]
    public string CycleDescription { get; set; } = null!;

    public byte AfterFaultRestore { get; set; }

    public byte BackupRestore { get; set; }

    public bool Pause { get; set; }

    public int CycleName { get; set; }

    public byte CycleHeading { get; set; }

    public byte CycleSubHeading { get; set; }

    public byte CycleGroup { get; set; }
}
