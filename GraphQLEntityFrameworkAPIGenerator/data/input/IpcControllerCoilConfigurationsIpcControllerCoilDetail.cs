using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("IpcControllerCoilConfigurationsId", "IpcControllerCoilDetailsId", "Index")]
[Table("IpcControllerCoilConfigurations_IpcControllerCoilDetails")]
public partial class IpcControllerCoilConfigurationsIpcControllerCoilDetail
{
    [Key]
    public Guid IpcControllerCoilConfigurationsId { get; set; }

    [Key]
    public Guid IpcControllerCoilDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("IpcControllerCoilConfigurationsId")]
    [InverseProperty("IpcControllerCoilConfigurationsIpcControllerCoilDetails")]
    public virtual IpcControllerCoilConfiguration IpcControllerCoilConfigurations { get; set; } = null!;

    [ForeignKey("IpcControllerCoilDetailsId")]
    [InverseProperty("IpcControllerCoilConfigurationsIpcControllerCoilDetails")]
    public virtual IpcControllerCoilDetail IpcControllerCoilDetails { get; set; } = null!;
}
