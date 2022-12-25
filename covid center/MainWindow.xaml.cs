using covid_center.Db_context;
using covid_center.Model_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace covid_center
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (Covid_context context = new Covid_context())
            {

                PATIENT patient_1 = new PATIENT()
                {

                    Patient_ID = 001,
                    P_FName = "Keshara",
                    P_LName = "Kavinda",
                    Age = 25,
                    District = "Colombo",
                    City = "Kiribathgoda",
                    Street = "Kandy road",

                    ICUS = new ICU()
                    {
                        ICU_NO = "ICU_01",
                        Patient_ID = 001,
                        Enter_Date = DateTime.Parse("2022/08/22"),
                        Capacity = 10,
                    },

                    VACCINES = new VACCINE()
                    {
                        Vaccine_ID = "p_01",
                        Patient_ID = 001,
                        V_Type = "pfizer",
                        Dose = 2,
                        Vaccinated_Date = DateTime.Parse("2022/03/15")
                    }
                
                };
               context.PATIENTS.Add(patient_1);
                 
            
                DOCTOR doctor1 = new DOCTOR() {
                Doctor_ID=001,
                D_FName="Saman",
                D_LName="Kumara",
                Gender="M",
                Specialization= "cardiovascular",
                Ward_NO="02",
                MBBS_NO="CARD0012"
                };

                COVID_REPORT cocid_report1 = new COVID_REPORT() {
                Report_ID ="REP_1",
                Patient_ID = 001,
                Doctor_ID = 001,
                Covid_Type = "Delta",
                Covid_Status = "Normal",
                Additional_Illness="NO",
                };
                doctor1.PATIENT = patient_1;
                cocid_report1.DOCTORS = doctor1;
                context.DOCTORS.Add(doctor1); 
                context.COVID_REPORTS.Add(cocid_report1);

                NURSE nurse1 = new NURSE()
                {
                    Nurse_ID = 001,
                    N_FName = "Suneetha",
                    N_LName = "Withana",
                    Gender = "F",
                    Designation = "Sister",
                    Ward_NO = "05",
                    Age = 50,
                };
                patient_1.NURSES.Add(nurse1);
                context.NURSES.Add(nurse1);

                WARD ward1 = new WARD() {
                    Ward_NO = 001,
                    Capacity = 20,
                    NO_of_Patients = 15,
                    Ward_phone=22568923
                };

                patient_1.WARDS=ward1;
                context.WARDS.Add(ward1);

                CONTACT_LIST contact1 = new CONTACT_LIST() {
                    Patient_ID = 001, 
                    C_FName = "Naveen",
                    C_LName = "Denuwan",
                    Residence = "Colombo",
                    Contact_Type = "First",
                    Relation = "Brother",
                    Contact_Date = DateTime.Parse("2022/08/10"),
                };
                contact1.PATIENT=patient_1;
                context.CONTACT_LISTS.Add(contact1);

                DISCHARGE_INFO discharg1 = new DISCHARGE_INFO() {
                    Patient_ID = 001,
                    Discharge_Date = DateTime.Parse("2022/08/25"),
                    Covid_Status="Good",

                };

                patient_1.DISCHARGE_INFO = discharg1;
                context.DISCHARGE_INFOS.Add(discharg1);
                context.SaveChanges();
            }
        }
    }
}
