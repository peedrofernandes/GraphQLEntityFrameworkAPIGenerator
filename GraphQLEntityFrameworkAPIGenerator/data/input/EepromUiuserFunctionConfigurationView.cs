using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromUiuserFunctionConfigurationView
{
    public Guid ProjectId { get; set; }

    public Guid SelectorConfigurationId { get; set; }

    [Column("UIFunctionConfigurationId")]
    public Guid UifunctionConfigurationId { get; set; }

    public byte Index { get; set; }

    [Column("UIFunctionDetailId")]
    public Guid UifunctionDetailId { get; set; }

    [Column("UIRegulationTableId")]
    public Guid? UiregulationTableId { get; set; }

    [Column("GIReadTypeId")]
    public byte? GireadTypeId { get; set; }

    [Column("GIReadTypePosition")]
    public byte? GireadTypePosition { get; set; }

    public byte? FunctionLabel { get; set; }

    public bool Compulsory { get; set; }

    public bool Monitored { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte FunctionId { get; set; }

    public byte TargetId { get; set; }

    public bool ToMainBoard { get; set; }

    public byte FunctionFlags { get; set; }

    public int RegulationFlags { get; set; }

    public byte? SlaveInputTypeId { get; set; }

    public byte? SlaveInputTypePosition { get; set; }

    public bool IgnoreVisualRegulationTable { get; set; }

    public byte FactoryRestoreIndex { get; set; }

    public byte? RegulationNum { get; set; }
}
