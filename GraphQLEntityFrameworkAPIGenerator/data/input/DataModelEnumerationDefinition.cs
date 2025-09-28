using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class DataModelEnumerationDefinition
{
    public Guid DataModelDefinitionDetailId { get; set; }

    public byte EnumId { get; set; }

    public string EnumDescription { get; set; } = null!;
}
