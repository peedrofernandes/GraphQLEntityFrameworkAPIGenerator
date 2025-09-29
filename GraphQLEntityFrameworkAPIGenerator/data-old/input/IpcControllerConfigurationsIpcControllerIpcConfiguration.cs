using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("IpcControllerConfigurationsId", "IpcControllerIpcConfigurationsId", "Index")]
[Table("IpcControllerConfigurations_IpcControllerIpcConfigurations")]
public partial class IpcControllerConfigurationsIpcControllerIpcConfiguration
{
    [Key]
    public Guid IpcControllerConfigurationsId { get; set; }

    [Key]
    public Guid IpcControllerIpcConfigurationsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [Column("ACUExpansionBoardId")]
    public byte AcuexpansionBoardId { get; set; }

    [ForeignKey("IpcControllerConfigurationsId")]
    [InverseProperty("IpcControllerConfigurationsIpcControllerIpcConfigurations")]
    public virtual IpcControllerConfiguration IpcControllerConfigurations { get; set; } = null!;

    [ForeignKey("IpcControllerIpcConfigurationsId")]
    [InverseProperty("IpcControllerConfigurationsIpcControllerIpcConfigurations")]
    public virtual IpcControllerIpcConfiguration IpcControllerIpcConfigurations { get; set; } = null!;
}
