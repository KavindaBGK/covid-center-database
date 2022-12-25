using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_center.Model_classes
{
    public class COVID_REPORT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public string Report_ID { get; set; }
        public int Patient_ID { get; set; }
        public int Doctor_ID { get; set; }
        public string Covid_Type { get; set; }
        public string Covid_Status { get; set; }
        public string Additional_Illness { get; set; }

        public DOCTOR DOCTORS { get; set; }

    }
}
