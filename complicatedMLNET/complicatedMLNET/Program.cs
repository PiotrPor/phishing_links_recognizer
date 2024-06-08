// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;

namespace complicatedMLNET
{
    class OpisAdresu
    {
        [LoadColumn(1,13)]
        [VectorType(12)]
        public int[] cechy { get; set; }

        [LoadColumn(14)]
        [ColumnName("Result")] //nazwa kolumny w pliku, nie kodzie programu?
        public int Label { get; set; }
    }

    static class Program
    {
        static void Main(string[] args) 
        {
            String nazwa_pliku = "dataset.csv";
            //
            MLContext kontekst = new MLContext();
            IDataView dane = kontekst.Data.LoadFromTextFile<OpisAdresu>(path:nazwa_pliku, separatorChar:',', hasHeader:true);
            DataOperationsCatalog.TrainTestData zestawy_danych = kontekst.Data.TrainTestSplit(dane, 0.2); //80% to zestaw treningowy
            IDataView dane_treningowe = zestawy_danych.TrainSet;
            IDataView dane_testowe = zestawy_danych.TestSet;

            IEstimator<ITransformer> estymatorPrzygotowawczy = kontekst.Transforms.Concatenate(
                "having_IPhaving_IP_Address", "URLURL_Length", "Shortining_Service", "having_At_Symbol", "double_slash_redirecting", "Prefix_Suffix", 
                "having_Sub_Domain", "SSLfinal_State", "port", "HTTPS_token", "SFH", "Submitting_to_email", "Abnormal_URL");
            ITransformer transformer_przygotuj = estymatorPrzygotowawczy.Fit(dane_treningowe);
            IDataView stransformowane_treningowe = transformer_przygotuj.Transform(dane_treningowe);

            //aa

            var model_SDCA = kontekst.Regression.Trainers.Sdca();

            var wytrenowany = model_SDCA.Fit(stransformowane_treningowe);

            var parametry_wytrenowanego = wytrenowany.Model as LinearRegressionModelParameters; //?

            kontekst.Model.Save(wytrenowany, dane.Schema, "zapisany_model.zip");
        }
    }
}