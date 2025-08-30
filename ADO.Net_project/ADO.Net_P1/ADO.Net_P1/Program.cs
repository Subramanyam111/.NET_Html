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
//join
/*
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
                        int Quantity = Convert.ToInt32(dr["Quantity"]);
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
*/

/*namespace ADO.Net_P1
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


            SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi");
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_update_patient_details", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@pid", System.Data.SqlDbType.Int);
            p1.Value = pid;
            SqlParameter p2 = new SqlParameter("@fname", System.Data.SqlDbType.VarChar, 20);
            p2.Value = fname;

            SqlParameter p3 = new SqlParameter("@lname", System.Data.SqlDbType.VarChar, 20);
            p3.Value = lname;

            SqlParameter p4 = new SqlParameter("@age", System.Data.SqlDbType.Int);
            p4.Value = age;

            SqlParameter p5 = new SqlParameter("@bg", System.Data.SqlDbType.VarChar, 20);
            p5.Value = bg;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.ExecuteNonQuery();
            cn.Close();
                    Console.ReadLine();
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

            

            SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi");
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_delete_patient_details", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@pid", System.Data.SqlDbType.Int);
            p1.Value = pid;
           
            cmd.Parameters.Add(p1);
            
            cmd.ExecuteNonQuery();
            cn.Close();
            Console.ReadLine();
        }
    }

}

 */

//sp_delete_docter_details
/*namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter docter id:");
            int did = Convert.ToInt32(Console.ReadLine());



            SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi");
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_delete_docter_details", cn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@did", System.Data.SqlDbType.Int);

            p1.Value = did;

            cmd.Parameters.Add(p1);

            cmd.ExecuteNonQuery();

            cn.Close();
            Console.ReadLine();
        }
    }

}*/
//searching docter details 
namespace ADO.Net_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking input from the user to search docter details using diocter id
            Console.Write("enter docter id:");
            int did = Convert.ToInt32(Console.ReadLine());

            SqlConnection cn = new SqlConnection("data source=DESKTOP-UPK6IVO; initial catalog=subbu; integrated security=sspi");
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_search_docter_details", cn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@did", System.Data.SqlDbType.Int);

            p1.Value = did;

            cmd.Parameters.Add(p1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //to instalise the values 
                did = Convert.ToInt32(dr["did"]);
                string dname = Convert.ToString(dr["dname"]);
                int exp = Convert.ToInt32(dr["exp"]);
                string dept = Convert.ToString(dr["dept"]);
                string qul = Convert.ToString(dr["qul"]);

                //to display the records
                Console.Write(did + " ");
                Console.Write(dname + " ");
                Console.Write(exp + " "); ;
                Console.Write(dept + " ");
                Console.Write(qul + " ");

            }
                cn.Close();
            Console.ReadLine();
        }
    }

}


