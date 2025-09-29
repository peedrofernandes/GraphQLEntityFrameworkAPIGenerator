using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("CodeBuilderContainerId", "ElementId", "Index")]
[Table("CodeBuilderContainers_Elements")]
public partial class CodeBuilderContainersElement
{
    [Key]
    public Guid CodeBuilderContainerId { get; set; }

    [Key]
    public Guid ElementId { get; set; }

    [Key]
    public int Index { get; set; }

    public int StartPosition { get; set; }

    public int EndPosition { get; set; }

    [ForeignKey("CodeBuilderContainerId")]
    [InverseProperty("CodeBuilderContainersElements")]
    public virtual CodeBuilderContainer CodeBuilderContainer { get; set; } = null!;
}
