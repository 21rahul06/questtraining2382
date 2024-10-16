using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8hospitalmanagement
{
    internal class Program
    {
        static List<Dictionary<string, string>> patients = new List<Dictionary<string, string>>();
        // Function to add a new patient
        static void AddPatient()
        {
            var patient = new Dictionary<string, string>();

            Console.WriteLine("Enter patient name: ");
            patient.Add("name", Console.ReadLine());

            Console.WriteLine("Enter the patient age: ");
            patient.Add("age", Console.ReadLine());

            Console.WriteLine("Enter the symptom: ");
            patient.Add("symptom", Console.ReadLine());

            // Generate a unique ID for the patient
            var id = Guid.NewGuid().ToString();
            patient.Add("id", id);

            // Add the patient to the list
            patients.Add(patient);
            Console.WriteLine($"Patient added succesfully with id :{id}");
        }

        // Function to search a patient by their unique ID
        static void SearchPatient()
        {
            Console.WriteLine("Enter the patient ID to search: ");
            string id = Console.ReadLine();

            // Loop through each item in list
            foreach (var patient in patients)
            {
                if (patient["id"] == id)
                {
                    Console.WriteLine("Patient Found:");
                    Console.WriteLine($"ID: {patient["id"]}");
                    Console.WriteLine($"Name: {patient["name"]}");
                    Console.WriteLine($"Age: {patient["age"]}");
                    Console.WriteLine($"Symptom: {patient["symptom"]}\n");
                    break;
                }
            }
        }
        // Function to search patients by a given symptom (case-sensitive)
        static void SearchPatientsBySymptom()
        {
            Console.WriteLine("Enter the symptom to search for: ");
            string symptom = Console.ReadLine();

            foreach (var patient in patients)
            {
                //  if symptom found return details 
                if (patient["symptom"] == symptom)
                {
                    Console.WriteLine("Patient Found:");
                    Console.WriteLine($"ID: {patient["id"]}");
                    Console.WriteLine($"Name: {patient["name"]}");
                    Console.WriteLine($"Age: {patient["age"]}");
                    Console.WriteLine($"Symptom: {patient["symptom"]}\n");
                    break;

                }
            }
        }

            static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Search Patient by id");
                Console.WriteLine("3. Search patient by Symptom");
                Console.WriteLine("Enter your choice: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        SearchPatient();
                        break;
                    case"3":
                        SearchPatientsBySymptom();
                        break;

                    default:
                        Console.WriteLine("Invalid option! Try again.\n");
                        break;
                }
            }
        }
    }
}
