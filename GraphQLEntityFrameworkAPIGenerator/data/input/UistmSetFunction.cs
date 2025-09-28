using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIStmSetFunction")]
public partial class UistmSetFunction
{
    [Key]
    public Guid Id { get; set; }

    public byte FunctionLabel { get; set; }

    public byte DefaultIdx { get; set; }

    public bool DefaultFlag { get; set; }

    public byte MinIdx { get; set; }

    public bool MinFlag { get; set; }

    public byte MaxIdx { get; set; }

    public bool MaxFlag { get; set; }

    public byte CurrentIdx { get; set; }

    public bool CurrentFlag { get; set; }

    public bool Disable { get; set; }

    public bool DisableFlag { get; set; }

    public bool Freeze { get; set; }

    public bool FreezeFlag { get; set; }

    public bool AfterStart { get; set; }

    public bool AfterStartFlag { get; set; }

    public bool Confirm { get; set; }

    public bool ConfirmFlag { get; set; }

    public bool Inversion { get; set; }

    public bool InversionFlag { get; set; }
}
