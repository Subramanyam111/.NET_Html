using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter FullName : ");
            string fn = Console.ReadLine();

            Console.Write("enter age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            string qry= $"insert into ClinicPatient values('{fn}',{age})";
            //string qry = $"delete  ClinicPatient where PatientID=(select max(PatientID) from ClinicPatient)";
            //string qry = $"update  ClinicPatient set FullName='patient' where PatientID=(select max(PatientID) from ClinicPatient)";


            //string qry= $"select * from ClinicPatient";

            SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi");
            SqlCommand cmd = new SqlCommand(qry, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            //cmd.ExecuteReader();
            cn.Close();
        }
    }
}
//ClinicPatient
//DESKTOP-UPK6IVO
//subbu
//(PatientID,FullName, Age)