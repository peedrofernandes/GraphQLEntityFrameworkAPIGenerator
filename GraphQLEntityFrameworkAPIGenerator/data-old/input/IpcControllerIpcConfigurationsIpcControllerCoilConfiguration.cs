using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("IpcControllerIpcConfigurationsId", "IpcControllerCoilConfigurationsId", "Index")]
[Table("IpcControllerIpcConfigurations_IpcControllerCoilConfigurations")]
public partial class IpcControllerIpcConfigurationsIpcControllerCoilConfiguration
{
    [Key]
    public Guid IpcControllerIpcConfigurationsId { get; set; }

    [Key]
    public Guid IpcControllerCoilConfigurationsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("IpcControllerCoilConfigurationsId")]
    [InverseProperty("IpcControllerIpcConfigurationsIpcControllerCoilConfigurations")]
    public virtual IpcControllerCoilConfiguration IpcControllerCoilConfigurations { get; set; } = null!;

    [ForeignKey("IpcControllerIpcConfigurationsId")]
    [InverseProperty("IpcControllerIpcConfigurationsIpcControllerCoilConfigurations")]
    public virtual IpcControllerIpcConfiguration IpcControllerIpcConfigurations { get; set; } = null!;
}
