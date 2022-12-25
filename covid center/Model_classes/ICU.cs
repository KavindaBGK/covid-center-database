using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_center.Model_classes
{
    public class ICU
    {
        [Key,Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public string ICU_NO { get; set; }
        [Key, Column(Order = 1)]
        public int Patient_ID { get; set; }
        [Key, Column(Order = 2)]
        public DateTime Enter_Date { get; set; }
        public int Capacity { get; set; }
        [Required]
        public virtual PATIENT PATIENT { get; set; }
    }
}
