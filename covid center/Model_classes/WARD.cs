using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_center.Model_classes
{
    public class WARD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Ward_NO { get; set; }
        public int Capacity { get; set; }
        public int NO_of_Patients { get; set; }
        public int Ward_phone { get; set; }
        
    }
}
