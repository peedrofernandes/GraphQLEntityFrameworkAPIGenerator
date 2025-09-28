using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("DataModelDefinitionConfigurationId", "DataModelDefinitionDetailId", "Index")]
[Table("DataModelDefinitionConfigurations_DataModelDefinitionDetails")]
public partial class DataModelDefinitionConfigurationsDataModelDefinitionDetail
{
    [Key]
    public Guid DataModelDefinitionConfigurationId { get; set; }

    [Key]
    public Guid DataModelDefinitionDetailId { get; set; }

    [Key]
    public int Index { get; set; }

    [ForeignKey("DataModelDefinitionConfigurationId")]
    [InverseProperty("DataModelDefinitionConfigurationsDataModelDefinitionDetails")]
    public virtual DataModelDefinitionConfiguration DataModelDefinitionConfiguration { get; set; } = null!;

    [ForeignKey("DataModelDefinitionDetailId")]
    [InverseProperty("DataModelDefinitionConfigurationsDataModelDefinitionDetails")]
    public virtual DataModelDefinitionDetail DataModelDefinitionDetail { get; set; } = null!;
}
