using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Board
{
    [Key]
    public Guid BoardId { get; set; }

    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(50)]
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

    public Guid? LoadConfigurationId { get; set; }

    public Guid? LowLevelInputConfigurationId { get; set; }

    public Guid? GenericInputConfigurationId { get; set; }

    public Guid? CrossLoadConfigurationId { get; set; }

    [Column("ACUExpansionBoardConfigurationId")]
    public Guid? AcuexpansionBoardConfigurationId { get; set; }

    public byte NodeAddress { get; set; }

    public long StartPosition { get; set; }

    public int Size { get; set; }

    public Guid? DefaultPinConfigurationId { get; set; }

    public byte ReadableFlash { get; set; }

    [ForeignKey("AcuexpansionBoardConfigurationId")]
    [InverseProperty("Boards")]
    public virtual AcuexpansionBoardConfiguration? AcuexpansionBoardConfiguration { get; set; }

    [InverseProperty("Board")]
    public virtual ICollection<AcuexpansionBoardConfigurationsBoard> AcuexpansionBoardConfigurationsBoards { get; set; } = new List<AcuexpansionBoardConfigurationsBoard>();

    [ForeignKey("CrossLoadConfigurationId")]
    [InverseProperty("Boards")]
    public virtual CrossLoadConfiguration? CrossLoadConfiguration { get; set; }

    [ForeignKey("DefaultPinConfigurationId")]
    [InverseProperty("Boards")]
    public virtual DefaultPinConfiguration? DefaultPinConfiguration { get; set; }

    [ForeignKey("GenericInputConfigurationId")]
    [InverseProperty("Boards")]
    public virtual GenericInputConfiguration? GenericInputConfiguration { get; set; }

    [ForeignKey("LoadConfigurationId")]
    [InverseProperty("Boards")]
    public virtual LoadConfiguration? LoadConfiguration { get; set; }

    [ForeignKey("LowLevelInputConfigurationId")]
    [InverseProperty("Boards")]
    public virtual LowLevelInputConfiguration? LowLevelInputConfiguration { get; set; }

    [InverseProperty("AcuConfiguration")]
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    [ForeignKey("TableTarget")]
    [InverseProperty("Boards")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
