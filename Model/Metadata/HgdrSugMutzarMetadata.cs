using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace IHubWebApplication.Model
{
    [Table("HgdrSugMutzar")]
    public class HgdrSugMutzarMetadata
    {
        [JsonIgnore]
        public virtual ICollection<HgdrMutzarCategory> HgdrMutzarCategories { get; set; } = new List<HgdrMutzarCategory>();
        [JsonIgnore]
        public virtual ICollection<HgdrMutzar> HgdrMutzars { get; set; } = new List<HgdrMutzar>();

    }
}
