using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CompiledResourceMetaDatum
{
    [Key]
    public Guid Id { get; set; }

    public int? ProgramingOffset { get; set; }

    public int? Length { get; set; }

    [Column("CRC")]
    public int? Crc { get; set; }

    public byte[] DecryptionKey { get; set; } = null!;

    [StringLength(350)]
    [Unicode(false)]
    public string EncryptedFileStoragePath { get; set; } = null!;

    public Guid ProjectId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("CompiledResourceMetaData")]
    public virtual Project Project { get; set; } = null!;
}
