using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("CodeBuilderId", "CodeBuilderContainerId", "Index")]
[Table("CodeBuilders_CodeBuilderContainers")]
public partial class CodeBuildersCodeBuilderContainer
{
    [Key]
    public Guid CodeBuilderId { get; set; }

    [Key]
    public Guid CodeBuilderContainerId { get; set; }

    [Key]
    public int Index { get; set; }

    [ForeignKey("CodeBuilderId")]
    [InverseProperty("CodeBuildersCodeBuilderContainers")]
    public virtual CodeBuilder CodeBuilder { get; set; } = null!;

    [ForeignKey("CodeBuilderContainerId")]
    [InverseProperty("CodeBuildersCodeBuilderContainers")]
    public virtual CodeBuilderContainer CodeBuilderContainer { get; set; } = null!;
}
