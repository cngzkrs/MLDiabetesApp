// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.IO;
using System.Linq;
using Microsoft.ML;
using MLDiabetesAppML.Model;

namespace MLDiabetesAppML.ConsoleApp
{
    class Program
    {
        //Dataset to use for predictions 
        private const string DATA_FILEPATH = @"C:\Users\BIM2842\source\repos\MLDiabetesApp\MLDiabetesApp\diabetes.csv";

        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = CreateSingleDataSample(DATA_FILEPATH);

            // Make a single prediction on the sample data and print results
            ModelOutput predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Outcome with predicted Outcome from sample data...\n\n");
            Console.WriteLine($"Pregnancies: {sampleData.Pregnancies}");
            Console.WriteLine($"Glucose: {sampleData.Glucose}");
            Console.WriteLine($"BloodPressure: {sampleData.BloodPressure}");
            Console.WriteLine($"SkinThickness: {sampleData.SkinThickness}");
            Console.WriteLine($"Insulin: {sampleData.Insulin}");
            Console.WriteLine($"BMI: {sampleData.BMI}");
            Console.WriteLine($"DiabetesPedigreeFunction: {sampleData.DiabetesPedigreeFunction}");
            Console.WriteLine($"Age: {sampleData.Age}");
            Console.WriteLine($"\n\nActual Outcome: {sampleData.Outcome} \nPredicted Outcome: {predictionResult.Prediction}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }

        // Change this code to create your own sample data
        #region CreateSingleDataSample
        // Method to load single row of dataset to try a single prediction
        private static ModelInput CreateSingleDataSample(string dataFilePath)
        {
            // Create MLContext
            MLContext mlContext = new MLContext();

            // Load dataset
            IDataView dataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                                            path: dataFilePath,
                                            hasHeader: true,
                                            separatorChar: ',',
                                            allowQuoting: true,
                                            allowSparse: false);

            // Use first line of dataset as model input
            // You can replace this with new test data (hardcoded or from end-user application)
            ModelInput sampleForPrediction = mlContext.Data.CreateEnumerable<ModelInput>(dataView, false)
                                                                        .First();
            return sampleForPrediction;
        }
        #endregion
    }
}
