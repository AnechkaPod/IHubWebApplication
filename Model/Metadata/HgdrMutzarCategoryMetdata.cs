using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace IHubWebApplication.Model
{
    [Table("HgdrMutzarCategory")]
    public class HgdrMutzarCategoryMetdata
    {
        [JsonIgnore]
        public virtual ICollection<HgdrMutzar> HgdrMutzars { get; set; } = new List<HgdrMutzar>();

    }
}
