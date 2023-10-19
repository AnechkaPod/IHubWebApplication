using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace IHubWebApplication.Model
{
    [Table("HgdrMutzar")]
    public class HgdrMutzarMetadata
    {
        [JsonIgnore]
        public virtual HgdrMutzarCategory? KodMutzarCategoryNavigation { get; set; }
        [JsonIgnore]
        public virtual HgdrSugMutzar KodSugMutzarNavigation { get; set; } = null!;

    }
}
