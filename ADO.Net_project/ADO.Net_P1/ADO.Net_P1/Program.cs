using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ADO.Net_P1
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
}*/
//ClinicPatient
//DESKTOP-UPK6IVO
//subbu
//(PatientID,FullName, Age)


//update 
/*namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter docter id:");
            int did = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter docter name:");
            string dname = Console.ReadLine();

            Console.Write("enter exp:");
            int exp = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter dept:");
            string dept = Console.ReadLine();

            Console.Write("enter qul:");
            string qul = Console.ReadLine();

            string qry = $"update docter set did={did},dname='{dname}',exp={exp},dept='{dept}',qul='{qul}' where did={did} ";
            SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi");
            SqlCommand cmd = new SqlCommand(qry, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}*/


//delete
/*namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter docter id:");
            int did = Convert.ToInt32(Console.ReadLine());
           
            string qry = $"delete docter where did={did}";
            SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi");
            SqlCommand cmd = new SqlCommand(qry, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}*/



//Cstudent table
//Scourse table 
/*namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("enter stydent name:");
            string Sname = Console.ReadLine();

            Console.Write("enter stydent cell:");
            string Cell = Console.ReadLine();

            Console.Write("enter stydent Course:");
            string Cname = Console.ReadLine();


            string qry = $"insert into Cstudent (Sname,cell,Cid)values('{Sname}','{Cell}',(select Cid from Scourse where Cname='{Cname}'))"; 

            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi"))
            {
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            
        }
    }
}*/

//patient
//pid,fname,lname,age,bg
namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter patient id:");
            int pid = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter patient fname:");
            string fname = Console.ReadLine();

            Console.Write("enter patient lname:");
            string lname = Console.ReadLine();

            Console.Write("enter patient age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter patient bg:");
            string bg = Console.ReadLine();


            string qry = $"insert into patient values({pid},'{fname}','{lname}',{age},'{bg}')";

            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi"))
            {
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }

        }
    }
}