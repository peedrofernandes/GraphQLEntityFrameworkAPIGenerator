using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CodeBuilder
{
    [Key]
    public Guid CodeBuilderId { get; set; }

    [Unicode(false)]
    public string CodeBuilderFileName { get; set; } = null!;

    [InverseProperty("CodeBuilder")]
    public virtual ICollection<CodeBuildersCodeBuilderContainer> CodeBuildersCodeBuilderContainers { get; set; } = new List<CodeBuildersCodeBuilderContainer>();
}
