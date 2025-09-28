using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadMultiInput")]
public partial class PrmReadMultiInput
{
    [Key]
    public Guid Id { get; set; }

    public byte ReadTypeId0 { get; set; }

    public Guid? ReadParametersId0 { get; set; }

    public byte ReadTypeId1 { get; set; }

    public Guid? ReadParametersId1 { get; set; }

    public byte? ReadTypeId2 { get; set; }

    public Guid? ReadParametersId2 { get; set; }

    public byte? ReadTypeId3 { get; set; }

    public Guid? ReadParametersId3 { get; set; }

    public byte NumOfPins { get; set; }

    [ForeignKey("ReadTypeId0")]
    [InverseProperty("PrmReadMultiInputReadTypeId0Navigations")]
    public virtual ReadType ReadTypeId0Navigation { get; set; } = null!;

    [ForeignKey("ReadTypeId1")]
    [InverseProperty("PrmReadMultiInputReadTypeId1Navigations")]
    public virtual ReadType ReadTypeId1Navigation { get; set; } = null!;

    [ForeignKey("ReadTypeId2")]
    [InverseProperty("PrmReadMultiInputReadTypeId2Navigations")]
    public virtual ReadType? ReadTypeId2Navigation { get; set; }

    [ForeignKey("ReadTypeId3")]
    [InverseProperty("PrmReadMultiInputReadTypeId3Navigations")]
    public virtual ReadType? ReadTypeId3Navigation { get; set; }
}
