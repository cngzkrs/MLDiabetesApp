// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace MLDiabetesAppML.Model
{
    public class ModelInput
    {
        [ColumnName("Pregnancies"), LoadColumn(0)]
        public float Pregnancies { get; set; }


        [ColumnName("Glucose"), LoadColumn(1)]
        public float Glucose { get; set; }


        [ColumnName("BloodPressure"), LoadColumn(2)]
        public float BloodPressure { get; set; }


        [ColumnName("SkinThickness"), LoadColumn(3)]
        public float SkinThickness { get; set; }


        [ColumnName("Insulin"), LoadColumn(4)]
        public float Insulin { get; set; }


        [ColumnName("BMI"), LoadColumn(5)]
        public float BMI { get; set; }


        [ColumnName("DiabetesPedigreeFunction"), LoadColumn(6)]
        public float DiabetesPedigreeFunction { get; set; }


        [ColumnName("Age"), LoadColumn(7)]
        public float Age { get; set; }


        [ColumnName("Outcome"), LoadColumn(8)]
        public bool Outcome { get; set; }


    }
}
