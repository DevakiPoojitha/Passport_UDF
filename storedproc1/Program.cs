using System.Data.SqlClient;


namespace storedproc1
{
     internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ConnectionStr = @"Data Source=INLPF1AVPDL;Initial Catalog=MyDb;trusted_connection=true";
                SqlConnection sqlconn = new SqlConnection(ConnectionStr);
                sqlconn.Open();
                int i = 0;

                while (i < 3)
                {
                    /*SqlCommand sqcmd = new SqlCommand("Pass_Pooj", sqlconn);
                    sqcmd.CommandType = System.Data.CommandType.StoredProcedure;
*/
                    Console.WriteLine("enter the passport number");
                    long passport_no = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("enter Candidate Name");
                    string cand_name = Console.ReadLine();
                    Console.WriteLine("Passport Expiry Date");
                    string Pass_Exp = Console.ReadLine();
                    Console.WriteLine("year Validity");
                    int yr_val = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("app channel");
                    string channel = Console.ReadLine();
                    SqlCommand sqcmd = new SqlCommand("Pass_Pooj", sqlconn);
                    sqcmd.CommandType = System.Data.CommandType.StoredProcedure;


                    sqcmd.Parameters.Add("@pass_num", System.Data.SqlDbType.BigInt).Value = passport_no;
                    sqcmd.Parameters.Add("@candid_name", System.Data.SqlDbType.VarChar).Value = cand_name;
                    sqcmd.Parameters.Add("@pass_expD", System.Data.SqlDbType.Date).Value = Pass_Exp;
                    sqcmd.Parameters.Add("@year_val", System.Data.SqlDbType.Int).Value = yr_val;
                    sqcmd.Parameters.Add("@app_ch", System.Data.SqlDbType.VarChar).Value = channel;

                    sqcmd.ExecuteNonQuery();
                    Console.WriteLine("Data Pushed Successfully!!");
                    i++;
                }
                    sqlconn.Close();
            }
            catch(SqlException sqle)
            {
                Console.WriteLine(sqle.Message);
                Console.WriteLine("sql prog");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exception catched");
            }
            Console.ReadKey();



        }
    }
}