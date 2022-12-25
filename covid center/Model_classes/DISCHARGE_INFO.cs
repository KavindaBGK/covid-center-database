using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_center.Model_classes
{
    public class DISCHARGE_INFO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 0)]
        public int Patient_ID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime Discharge_Date { get; set; }
        public string Covid_Status { get; set; }
        
    }
}
