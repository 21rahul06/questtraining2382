using System.Collections.Generic;
using System.Data.SqlClient;

public class DoctorRepository
{
    private string _connectionString;

    public DoctorRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void Add(Doctor doctor)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "INSERT INTO Doctor (Name, Specialization) VALUES (@Name, @Specialization)";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", doctor.Name);
                command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                command.ExecuteNonQuery();
            }
        }
    }

    public List<Doctor> GetAll()
    {
        var doctors = new List<Doctor>();
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "SELECT * FROM Doctor";
            using (var command = new SqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var doctor = new Doctor
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Specialization = (string)reader["Specialization"]
                    };
                    doctors.Add(doctor);
                }
            }
        }
        return doctors;
    }

    public void Update(Doctor doctor)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "UPDATE Doctor SET Name = @Name, Specialization = @Specialization WHERE Id = @Id";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", doctor.Id);
                command.Parameters.AddWithValue("@Name", doctor.Name);
                command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                command.ExecuteNonQuery();
            }
        }
    }

    public void Delete(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "DELETE FROM Doctor WHERE Id = @Id";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
