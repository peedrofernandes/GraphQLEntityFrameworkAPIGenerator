using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmActivateTask")]
public partial class StmActivateTask
{
    [Key]
    public Guid Id { get; set; }

    public int TaskCode { get; set; }

    public byte TaskParamsPosition { get; set; }

    public Guid? TaskParamsId { get; set; }
}
