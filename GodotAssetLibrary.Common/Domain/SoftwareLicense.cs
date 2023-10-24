using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GodotAssetLibrary.Common.Domain
{
    [Table("as_licenses")]
    public class SoftwareLicense
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Tag { get; set; }
    }
}
