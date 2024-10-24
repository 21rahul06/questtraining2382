using System;
using System.Collections.Generic;

namespace PatientDoctorManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=PatientDoctorDB;Integrated Security=True;";
            var patientRepo = new PatientRepository(connectionString);
            var doctorRepo = new DoctorRepository(connectionString);

            while (true)
            {
                Console.WriteLine("\nSelect an operation:");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. List Patients");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");
                Console.WriteLine("5. Add Doctor");
                Console.WriteLine("6. List Doctors");
                Console.WriteLine("7. Update Doctor");
                Console.WriteLine("8. Delete Doctor");
                Console.WriteLine("9. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    
                    var patient = new Patient();
                    Console.Write("Enter Patient Name: ");
                    patient.Name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    patient.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Gender: ");
                    patient.Gender = Console.ReadLine();
                    Console.Write("Enter Medical Condition: ");
                    patient.MedicalCondition = Console.ReadLine();
                    patientRepo.Add(patient);
                    Console.WriteLine("Patient added successfully.");
                }
                else if (choice == "2")
                {
                    
                    List<Patient> patients = patientRepo.GetAll();
                    Console.WriteLine("Patients:");
                    foreach (var p in patients)
                    {
                        Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Age: {p.Age}, Gender: {p.Gender}, Medical Condition: {p.MedicalCondition}");
                    }
                }
                else if (choice == "3")
                {
                    
                    Console.Write("Enter Patient Id to update: ");
                    int id = int.Parse(Console.ReadLine());
                    var patient = new Patient { Id = id };
                    Console.Write("Enter New Patient Name: ");
                    patient.Name = Console.ReadLine();
                    Console.Write("Enter New Age: ");
                    patient.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Gender: ");
                    patient.Gender = Console.ReadLine();
                    Console.Write("Enter New Medical Condition: ");
                    patient.MedicalCondition = Console.ReadLine();
                    patientRepo.Update(patient);
                    Console.WriteLine("Patient updated successfully.");
                }
                else if (choice == "4")
                {
                    
                    Console.Write("Enter Patient Id to delete: ");
                    int id = int.Parse(Console.ReadLine());
                    patientRepo.Delete(id);
                    Console.WriteLine("Patient deleted successfully.");
                }
                else if (choice == "5")
                {
                    
                    var doctor = new Doctor();
                    Console.Write("Enter Doctor Name: ");
                    doctor.Name = Console.ReadLine();
                    Console.Write("Enter Specialization: ");
                    doctor.Specialization = Console.ReadLine();
                    doctorRepo.Add(doctor);
                    Console.WriteLine("Doctor added successfully.");
                }
                else if (choice == "6")
                {
                    
                    List<Doctor> doctors = doctorRepo.GetAll();
                    Console.WriteLine("Doctors:");
                    foreach (var d in doctors)
                    {
                        Console.WriteLine($"Id: {d.Id}, Name: {d.Name}, Specialization: {d.Specialization}");
                    }
                }
                else if (choice == "7")
                {
                    
                    Console.Write("Enter Doctor Id to update: ");
                    int id = int.Parse(Console.ReadLine());
                    var doctor = new Doctor { Id = id };
                    Console.Write("Enter New Doctor Name: ");
                    doctor.Name = Console.ReadLine();
                    Console.Write("Enter New Specialization: ");
                    doctor.Specialization = Console.ReadLine();
                    doctorRepo.Update(doctor);
                    Console.WriteLine("Doctor updated successfully.");
                }
                else if (choice == "8")
                {
                    
                    Console.Write("Enter Doctor Id to delete: ");
                    int id = int.Parse(Console.ReadLine());
                    doctorRepo.Delete(id);
                    Console.WriteLine("Doctor deleted successfully.");
                }
                else if (choice == "9")
                {
                    
                    Console.WriteLine("Exiting the program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}
