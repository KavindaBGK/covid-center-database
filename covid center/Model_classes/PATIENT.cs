using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_center.Model_classes
{
    public class PATIENT
    {
        public PATIENT()
        {
            this.NURSES = new HashSet<NURSE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Patient_ID { get; set; }
        [Required]
        public string P_FName { get; set; }
        [Required]
        public string P_LName { get; set; }
        public int Age { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public virtual ICollection<NURSE> NURSES { get; set; }
        public WARD WARDS { get; set; }
        public virtual VACCINE VACCINES { get; set; }
        public virtual ICU ICUS { get; set; }
        public virtual DISCHARGE_INFO DISCHARGE_INFO { get; set; }

    }
}
