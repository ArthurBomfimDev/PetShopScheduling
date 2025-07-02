using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Base;

public abstract class BaseEntry<TEntry>
    where TEntry : BaseEntry<TEntry>
{
    [Key]
    [Column("id")]
    public long Id { get; set; }
}