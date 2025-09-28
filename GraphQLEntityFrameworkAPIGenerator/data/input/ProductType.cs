using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class ProductType
{
    [Key]
    public byte ProductTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ProductTypeDsc { get; set; } = null!;

    [InverseProperty("ProductType")]
    public virtual ICollection<ProductTypesHighStatement> ProductTypesHighStatements { get; set; } = new List<ProductTypesHighStatement>();

    [InverseProperty("ProductType")]
    public virtual ICollection<ProductTypesTask> ProductTypesTasks { get; set; } = new List<ProductTypesTask>();

    [InverseProperty("ProductType")]
    public virtual ICollection<ProductTypesVariable> ProductTypesVariables { get; set; } = new List<ProductTypesVariable>();

    [InverseProperty("ProductType")]
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    [InverseProperty("ProductType")]
    public virtual ICollection<StatusVariable> StatusVariables { get; set; } = new List<StatusVariable>();

    [InverseProperty("ProductType")]
    public virtual ICollection<StmSetVariable> StmSetVariables { get; set; } = new List<StmSetVariable>();

    [ForeignKey("ProductTypeId")]
    [InverseProperty("ProductTypes")]
    public virtual ICollection<VisualBoardType> VisualBoardTypes { get; set; } = new List<VisualBoardType>();
}
