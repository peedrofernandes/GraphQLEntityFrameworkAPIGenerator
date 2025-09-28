using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CodeBuilderContainer
{
    [Key]
    public Guid CodeBuilderContainerId { get; set; }

    [Unicode(false)]
    public string? TabName { get; set; }

    [InverseProperty("CodeBuilderContainer")]
    public virtual ICollection<CodeBuilderContainersElement> CodeBuilderContainersElements { get; set; } = new List<CodeBuilderContainersElement>();

    [InverseProperty("CodeBuilderContainer")]
    public virtual ICollection<CodeBuildersCodeBuilderContainer> CodeBuildersCodeBuilderContainers { get; set; } = new List<CodeBuildersCodeBuilderContainer>();
}
