using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_center.Model_classes
{
    public class DOCTOR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Doctor_ID { get; set; }
        [Required]
        public string D_FName { get; set; }
        [Required]
        public string D_LName { get; set; }
        public string Gender { get; set; }
        public string Specialization { get; set; }
        public string Ward_NO { get; set; }
        public string MBBS_NO { get; set; }

        public PATIENT PATIENT { get; set; }

    }
}
