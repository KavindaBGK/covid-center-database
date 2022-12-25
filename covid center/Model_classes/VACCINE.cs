using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_center.Model_classes
{
    public class VACCINE
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public string Vaccine_ID { get; set; }
        [Key, Column(Order = 1)]
        public int Patient_ID { get; set; }
        public string V_Type { get; set; }
        [Key, Column(Order = 2)]
        public int Dose { get; set; }
        public DateTime Vaccinated_Date { get; set; }

        [Required]
        public virtual PATIENT PATIENT { get; set; }
    }
}
