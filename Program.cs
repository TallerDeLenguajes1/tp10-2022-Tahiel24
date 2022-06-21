using System.Net;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

string url=$"https://age-of-empires-2-api.herokuapp.com/api/v1/civilizations";
var request=(HttpWebRequest)WebRequest.Create(url);
request.Method="GET";
request.ContentType="application/json";
request.Accept = "application/json";
Root ListaCivilizaciones;
try
{
    WebResponse response = request.GetResponse();
    Stream strReader = response.GetResponseStream();
    if (strReader == null) return;
    StreamReader objReader = new StreamReader(strReader);
    string responseBody = objReader.ReadToEnd();
    ListaCivilizaciones=JsonSerializer.Deserialize<Root>(responseBody);
    foreach(var i in ListaCivilizaciones.Civilizations){
        Console.WriteLine(i.Id);
        Console.WriteLine(i.Name);
    }
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Mostrando las caracteristicas de alguna civilzacion al azar: ");
    Random r=new Random();
    int indice=r.Next(0,33);
    Console.WriteLine("ID: "+ListaCivilizaciones.Civilizations[indice].Id);
    Console.WriteLine("Nombre: "+ListaCivilizaciones.Civilizations[indice].Name);
    Console.WriteLine("Expansion: "+ListaCivilizaciones.Civilizations[indice].Expansion);
}
catch(WebException error)
{
    Console.WriteLine("Se ha producido un error al intentar comunicarse con la API");
}
