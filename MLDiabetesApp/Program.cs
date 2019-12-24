using MLDiabetesAppML.Model;
using System;

namespace MLDiabetesApp
{
    class Program
    {
        static void Main(string[] args)
        { 

            var input = new ModelInput();
            input.Pregnancies = 6;
            input.Glucose = 50;
            input.BloodPressure = 70;
            input.SkinThickness = 25;

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"[0: Not Diabet, 1: Diabet] - The prediction result: {result.Prediction}");
        }
    }
}
