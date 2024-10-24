using System.Collections.Generic;
using System.Data.SqlClient;

public class PatientRepository
{
    private string _connectionString;

    public PatientRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void Add(Patient patient)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "INSERT INTO Patient (Name, Age, Gender, MedicalCondition) VALUES (@Name, @Age, @Gender, @MedicalCondition)";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("@Gender", patient.Gender);
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
                command.ExecuteNonQuery();
            }
        }
    }

    public List<Patient> GetAll()
    {
        var patients = new List<Patient>();
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "SELECT * FROM Patient";
            using (var command = new SqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var patient = new Patient
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Age = (int)reader["Age"],
                        Gender = (string)reader["Gender"],
                        MedicalCondition = (string)reader["MedicalCondition"]
                    };
                    patients.Add(patient);
                }
            }
        }
        return patients;
    }

    public void Update(Patient patient)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "UPDATE Patient SET Name = @Name, Age = @Age, Gender = @Gender, MedicalCondition = @MedicalCondition WHERE Id = @Id";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", patient.Id);
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("@Gender", patient.Gender);
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
                command.ExecuteNonQuery();
            }
        }
    }

    public void Delete(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var query = "DELETE FROM Patient WHERE Id = @Id";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
