using covid_center.Model_classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_center.Db_context
{
    public class Covid_context:DbContext
    {
        public DbSet<PATIENT> PATIENTS { get; set; }
        public DbSet<DOCTOR> DOCTORS { get; set; }
        public DbSet<NURSE> NURSES { get; set; }
        public DbSet<WARD> WARDS { get; set; }
        public DbSet<VACCINE> VACCINES { get; set; }
        public DbSet<ICU> ICUS { get; set; }
        public DbSet<COVID_REPORT> COVID_REPORTS { get; set; }
        public DbSet<CONTACT_LIST> CONTACT_LISTS { get; set; }
        public DbSet<DISCHARGE_INFO> DISCHARGE_INFOS { get; set; }

    }
}
