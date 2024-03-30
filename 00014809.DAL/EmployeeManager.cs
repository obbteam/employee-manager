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
    public partial class EmployeeManager : DbManager
    {
        //code was taken from intranet lectures by Vasiliy kuznesov

        public void Create(Employee a)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
INSERT INTO em_employee
           (em_name_14809
           ,em_is_active_14809
           ,em_start_date_14809
           ,em_discharge_date_14809
           )
     VALUES
           ('{a.Name}'
           ,{Convert.ToInt32(a.IsActive)}
           ,{a.StartDate.Ticks}
           ,{a.DischargeDate.Ticks}
           )";

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


        public void Update(Employee a)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
UPDATE em_employee 
   SET em_name_14809 = '{a.Name}'
      ,em_start_date_14809 = {a.StartDate.Ticks}
      ,em_discharge_date_14809 = {a.DischargeDate.Ticks}
      ,em_is_active_14809 = {Convert.ToInt32(a.IsActive)}
WHERE em_id_14809 = {a.Id}";
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
                {
                    connection.Close();
                }

            }
        }


        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM em_employee WHERE em_id_14809 = {id}";
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
                {
                    connection.Close();
                }
            }
        }


        public List<Employee> GetAll()
        {

            var connection = Connection;

            var result = new List<Employee>();
            try
            {
                var sql = @"
                        SELECT em_id_14809
                              , em_name_14809
                              , em_is_active_14809
                              , em_start_date_14809
                              , em_discharge_date_14809
                        FROM em_employee";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Employee
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = reader.GetValue(1).ToString(),
                        IsActive = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(2))),
                        StartDate = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        DischargeDate = new DateTime(Convert.ToInt64(reader.GetValue(4))),
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

