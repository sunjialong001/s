using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// SQL
using System.Data;
using System.Data.SqlClient;

/// Debug
using System.Diagnostics;

namespace WebApplication4.KMS
{
    public class KKHSystem
    {
        // Attribute ( components )
        public List<KKHMitarbeiter> MitarbeiterList;
        public List<KKHPatienten> PatientenList;
        public List<KKHRoom> RoomList;

        // Default Constructor
        public KKHSystem()
        {
            this.MitarbeiterList = new List<KKHMitarbeiter>();
            this.PatientenList = new List<KKHPatienten>();
            this.RoomList = new List<KKHRoom>();

            //ConnectionExample1();
            ProgrammingExample1();
        }

        public enum XXX
        {
            X1,
            X2,
            X3
        }

        public void ProgrammingExample1()
        {
            //int i = 1;
            //int j = 1;

            // if-then-else
            //if ( true )
            //{
            //    // then
            //} else {
            //    // else
            //}

            //// switch
            //switch (i)
            //{
            //    default:
            //        break;
            //}

            // while-loop
            //while (i <= 10)
            //{
            //    // To-do
            //    Debug.WriteLine(String.Format("i = {0}", i));

            //    i = i + 1;
            //}

            // for-loop
            // i++    <=>          i = i + 1;
            //List<int> lst = new List<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    lst.Add(100 + i);
            //}

            /* Method 1 */
            //foreach (var item in lst)
            //{
            //    Debug.WriteLine("List has {0}", item);
            //}

            ///* Method 2 */
            //for (int i = 0; i < lst.Count; i++)
            //{
            //    var j = lst[i];
            //    Debug.WriteLine("List[{0}] has {1}", i, j);
            //}

            // try-catch-throw
            int l = 1;
            try
            {
                if (l != 8)
                    throw new Exception("length is not correct");

                // TO DO
                int j = 0;
                int k = 1;

                //if (m not exist)
                //    throw new Exception("cannot find in db");
            }
            catch (Exception ex)
            {
                ///
                Debug.WriteLine(ex.Message);
            }

            //Debug.WriteLine(String.Format("i = {0}", i));
        }

        public void ConnectionExample1()
        {
            SqlConnection connection = null;

            try
            {
                // Connection Setting
                String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db01.mdf;Integrated Security=True";

                // Connection object
                connection = new SqlConnection(connectionString);

                // Command object
                SqlCommand cmd = new SqlCommand("SELECT * FROM Mitarbeiter", connection);

                connection.Open();

                // If open succeeded
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    String MitarbeiterNumber = Convert.ToString(reader["MitarbeiterNumber"]);
                    String Name = Convert.ToString(reader["Name"]);
                    String Address = Convert.ToString(reader["Address"]);

                    // TO-DO

                    Debug.WriteLine(String.Format("{0} , {1} , {2}, {3}", Id, MitarbeiterNumber, Name, Address));
                }
            }
            catch (Exception ex)
            {
                // If anything failed
                String msg = ex.Message;

                Debug.WriteLine(String.Format("[Exception] {0}", msg));
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
