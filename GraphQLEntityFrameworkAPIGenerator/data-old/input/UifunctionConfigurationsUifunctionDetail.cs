using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UifunctionConfigurationId", "UifunctionDetailId", "Index")]
[Table("UIFunctionConfigurations_UIFunctionDetails")]
public partial class UifunctionConfigurationsUifunctionDetail
{
    [Key]
    [Column("UIFunctionConfigurationId")]
    public Guid UifunctionConfigurationId { get; set; }

    [Key]
    [Column("UIFunctionDetailId")]
    public Guid UifunctionDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [Column("GIReadTypeId")]
    public byte? GireadTypeId { get; set; }

    [Column("GIReadTypePosition")]
    public byte? GireadTypePosition { get; set; }

    [Column("UIRegulationTableId")]
    public Guid? UiregulationTableId { get; set; }

    public byte? FunctionLabel { get; set; }

    public bool Compulsory { get; set; }

    public bool Monitored { get; set; }

    [ForeignKey("FunctionLabel")]
    [InverseProperty("UifunctionConfigurationsUifunctionDetails")]
    public virtual FunctionLabel? FunctionLabelNavigation { get; set; }

    [ForeignKey("UifunctionConfigurationId")]
    [InverseProperty("UifunctionConfigurationsUifunctionDetails")]
    public virtual UifunctionConfiguration UifunctionConfiguration { get; set; } = null!;

    [ForeignKey("UifunctionDetailId")]
    [InverseProperty("UifunctionConfigurationsUifunctionDetails")]
    public virtual UifunctionDetail UifunctionDetail { get; set; } = null!;

    [ForeignKey("UiregulationTableId")]
    [InverseProperty("UifunctionConfigurationsUifunctionDetails")]
    public virtual UiregulationTable? UiregulationTable { get; set; }
}
