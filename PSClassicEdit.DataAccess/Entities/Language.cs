using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSClassicEdit.DataAccess.Entities
{
    //Unused by the UI, but needed on creation
    [Table("LANGUAGE_SPECIFIC")]
    public class Language
    {
        [Column("DEFAULT_VALUE")]
        public string DefaultValue { get; set; }

        [Column("LANGUAGE_ID")]
        public string LanguageId { get; set; }

        [Column("VALUE")]
        public string Value { get; set; }
    }
}
