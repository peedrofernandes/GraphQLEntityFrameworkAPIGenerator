using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("AcuexpansionBoardConfigId", "BoardId", "Index")]
[Table("ACUExpansionBoardConfigurations_Boards")]
public partial class AcuexpansionBoardConfigurationsBoard
{
    [Key]
    [Column("ACUExpansionBoardConfigId")]
    public Guid AcuexpansionBoardConfigId { get; set; }

    [Key]
    public Guid BoardId { get; set; }

    [Key]
    public byte Index { get; set; }

    [Column("ACUExpansionBoardId")]
    public byte AcuexpansionBoardId { get; set; }

    [ForeignKey("AcuexpansionBoardConfigId")]
    [InverseProperty("AcuexpansionBoardConfigurationsBoards")]
    public virtual AcuexpansionBoardConfiguration AcuexpansionBoardConfig { get; set; } = null!;

    [ForeignKey("BoardId")]
    [InverseProperty("AcuexpansionBoardConfigurationsBoards")]
    public virtual Board Board { get; set; } = null!;
}
