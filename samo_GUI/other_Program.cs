// See https://aka.ms/new-console-template for more information

//using Rozpoznawanie_stron;
using System;

namespace Rozpoznawanie_stron
{
    //float[] opis_liczbami = new float[13] {1,1,1,1,1,-1,0,1,1,-1,-1,1,1};

    //MLModel1.ModelInput address_description = new MLModel1.ModelOutput();

    //Load model and predict output
    //var result = MLModel1.Predict(sampleData);
    //MLModel1.ModelOutput whole_output = MLModel1.Predict(sampleData);

    String URL_strony = "https://www.google.com";

    float[] opis = Pomocne_Funkcje.opisz_adres_liczbami(URL_strony);
    MLModel1.ModelInput testowy_input = Pomocne_Funkcje.tabelke_zmien_na_opis_dla_AI(opis);
    MLModel1.ModelOutput whole_output = MLModel1.Predict(testowy_input);
    //float given_label = whole_output.PredictedLabel;
    String wniosek = Pomocne_Funkcje.label_jako_wyraz(whole_output.PredictedLabel);

    Console.WriteLine("Conclusion: "+ wniosek +" page address");

// ...\source_zespolowe_WEEIA\rozpoznawanie_stron\rozpoznawanie_stron\MLModel1.consumption.cs
}

