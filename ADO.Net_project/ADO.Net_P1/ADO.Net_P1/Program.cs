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
/*
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
}*/


/*
 namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter patient id:");
            int pid = Convert.ToInt32(Console.ReadLine());
          
            string qry = $"delete from patient where pid={pid}";
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

 */


/*
 namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string qry = $"select * from docter";
            Console.Write("did | ");
            Console.Write("dname | ");
            Console.Write("exp | "); ;
            Console.Write("dept | ");
            Console.Write("qul | ");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi"))
            {
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int did = Convert.ToInt32(dr["did"]);
                        string dname =Convert.ToString(dr["dname"]);
                        int exp = Convert.ToInt32(dr["exp"]);
                        string dept = Convert.ToString(dr["dept"]);
                        string qul = Convert.ToString(dr["qul"]);

                        Console.Write(did+" | ");
                        Console.Write(dname+" | ");
                        Console.Write(exp+" | "); ;
                        Console.Write(dept+" | ");
                        Console.Write(qul+" | ");
                        Console.WriteLine();
                    }

                    cn.Close();
                    Console.ReadLine();
                }
            }

        }
    }
}
*/

/*namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter docter id to search:");
            int id = Convert.ToInt32(Console.ReadLine());
            string qry = $"select * from docter where did={id}";
            
            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi"))
            {
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int did = Convert.ToInt32(dr["did"]);
                        string dname = Convert.ToString(dr["dname"]);
                        int exp = Convert.ToInt32(dr["exp"]);
                        string dept = Convert.ToString(dr["dept"]);
                        string qul = Convert.ToString(dr["qul"]);

                        Console.Write(did +" ");
                        Console.Write(dname +" ");
                        Console.Write(exp+" " ); ;
                        Console.Write(dept+" ");
                        Console.Write(qul+" ");
                        Console.WriteLine();
                    }

                    cn.Close();
                    Console.ReadLine();
                }
            }

        }
    }
}*/

/*
 namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string qry = $"select * from patient order by age asc";

            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi"))
            {
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int pid = Convert.ToInt32(dr["pid"]);
                        string fname = Convert.ToString(dr["fname"]);
                        string lname = Convert.ToString(dr["lname"]);
                        int age = Convert.ToInt32(dr["age"]);
                        string bg = Convert.ToString(dr["bg"]);

                        Console.Write(pid + " ");
                        Console.Write(fname + " ");
                        Console.Write(lname + " "); ;
                        Console.Write(age + " ");
                        Console.Write(bg + " ");
                        Console.WriteLine();
                    }

                    cn.Close();
                    Console.ReadLine();
                }
            }

        }
    }
}

*/

/*
 namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {

            string qry = $"select * from patient where bg like 'b%'";

            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi"))
            {
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int pid = Convert.ToInt32(dr["pid"]);
                        string fname = Convert.ToString(dr["fname"]);
                        string lname = Convert.ToString(dr["lname"]);
                        int age = Convert.ToInt32(dr["age"]);
                        string bg = Convert.ToString(dr["bg"]);

                        Console.Write(pid + " ");
                        Console.Write(fname + " ");
                        Console.Write(lname + " "); ;
                        Console.Write(age + " ");
                        Console.Write(bg + " ");
                        Console.WriteLine();
                    }

                    cn.Close();
                    Console.ReadLine();
                }
            }

        }
    }
}
     */

namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter product id:");
            int id = Convert.ToInt32(Console.ReadLine());

            string qry = $"select p.pid,p.pname,p.Quantity,p.Price,m.ManufacturerName from Product p join Manufacturer m on p.ManufacturerID=m.ManufacturerID where pid={id}";

            using (SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi"))
            {
                using (SqlCommand cmd = new SqlCommand(qry, cn))
                {
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int pid = Convert.ToInt32(dr["pid"]);
                        string pname = Convert.ToString(dr["pname"]);
                        string Quantity = Convert.ToString(dr["Quantity"]);
                        int Price = Convert.ToInt32(dr["Price"]);
                        string ManufacturerName = Convert.ToString(dr["ManufacturerName"]);

                        Console.Write(pid + " ");
                        Console.Write(pname+ " ");
                        Console.Write(Quantity + " "); ;
                        Console.Write(Price + " ");
                        Console.Write(ManufacturerName + " ");
                        Console.WriteLine();
                    }

                    cn.Close();
                    Console.ReadLine();
                }
            }

        }
    }
}
