using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _00014809;

namespace _00014809.DAL
{
   
    public partial class SwipeManager : DbManager
    {
        //new swipe logic

        public void Create(Swipe c)
        {
            var connection = Connection;
            try
            {
                var sql = $@"INSERT INTO sp_swipe
           (sp_emp_id_14809
           ,sp_date_14809
           ,sp_in_14809
           ,sp_out_14809
           )
     VALUES
           ({c.EmployeeID}
           ,{c.SwipeDate.Ticks}
           ,{c.SwipeIn.Ticks}
           ,{c.SwipeOut.Ticks})";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }





        //show all swipes function

        public List<Swipe> GetAll()
        {
            var connection = Connection;
            var result = new List<Swipe>();
            try
            {
                var sql = @"
SELECT sp_id_14809
            ,sp_emp_id_14809
            ,sp_date_14809
            ,sp_in_14809
            ,sp_out_14809
FROM sp_swipe";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Swipe
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        EmployeeID = Convert.ToInt32(reader.GetValue(1)),
                        SwipeDate = new DateTime(Convert.ToInt64(reader.GetValue(2))),
                        SwipeIn = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        SwipeOut = new DateTime(Convert.ToInt64(reader.GetValue(4)))
                    };
                    result.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }

            return result;
        }
    }
}
