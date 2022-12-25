using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_center.Model_classes
{
    public class CONTACT_LIST
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 0)]
        public int Patient_ID { get; set; }
        [Required]
        [Key, Column(Order = 1)]
        public string C_FName { get; set; }
        [Required]
        public string C_LName { get; set; }
        public string Residence { get; set; }
        public string Contact_Type { get; set; }
        public string Relation { get; set; }
        public DateTime Contact_Date { get; set; }

        public PATIENT PATIENT { get; set; }
    }
}
