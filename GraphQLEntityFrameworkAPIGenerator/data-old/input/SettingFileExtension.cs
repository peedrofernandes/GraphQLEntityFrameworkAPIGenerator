using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class SettingFileExtension
{
    [Key]
    public Guid SettingFileExtensionsId { get; set; }

    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public bool HighStatementsExt { get; set; }

    public bool LowStatementsExt { get; set; }

    public short OpCodeLowStatementExt { get; set; }

    public bool IsMaintainModifiersExtended { get; set; }

    [Column("IsTTEModifiersExtended")]
    public bool IsTtemodifiersExtended { get; set; }

    [Column("isHMIIOPointerExtended")]
    public bool IsHmiiopointerExtended { get; set; }

    [Column("IsHMIExpansion1IOPointerExtended")]
    public bool IsHmiexpansion1IopointerExtended { get; set; }

    [Column("IsHMIExpansion2IOPointerExtended")]
    public bool IsHmiexpansion2IopointerExtended { get; set; }

    [Column("IsHMIExpansion3IOPointerExtended")]
    public bool IsHmiexpansion3IopointerExtended { get; set; }

    [Column("IsHMIExpansion4IOPointerExtended")]
    public bool IsHmiexpansion4IopointerExtended { get; set; }

    [Column("IsHMIExpansion5IOPointerExtended")]
    public bool IsHmiexpansion5IopointerExtended { get; set; }

    [InverseProperty("SettingFileExtensions")]
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
