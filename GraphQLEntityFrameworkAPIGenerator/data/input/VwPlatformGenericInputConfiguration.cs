using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class VwPlatformGenericInputConfiguration
{
    public Guid GenericInputConfigurationId { get; set; }

    public byte Index { get; set; }

    public Guid GenericInputDetailId { get; set; }

    public byte InputId { get; set; }

    public byte ReadTypeId { get; set; }

    public byte ReadTypePos { get; set; }

    public Guid? ParametersId { get; set; }
}
