using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_center.Model_classes
{
    public class NURSE
    {
        public NURSE() {
            this.PATIENTS = new HashSet<PATIENT>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Nurse_ID { get; set; }
        [Required]
        public string N_FName { get; set; }
        [Required]
        public string N_LName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string Ward_NO { get; set; }

        public virtual ICollection<PATIENT> PATIENTS { get; set; }

    }
}
