using System;
using System.IO;

namespace ExercicioDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Cursos\CSharp\ExercicioDictionary\ExercicioDictionary\Files\input.txt";
            Dictionary<string, int> votos = new Dictionary<string, int>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int voto = int.Parse(line[1]);

                        if(votos.ContainsKey(name)){
                            votos[name] += voto;
                        }
                        else{
                            votos[name] = voto;
                        }
                    }
                }
                foreach (KeyValuePair<string, int> v in votos)
                {
                    Console.WriteLine($"{v.Key}: {v.Value}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ocorreu uma falha ao tentar utilizar o arquivo");
                Console.WriteLine(ex.Message);
            }
        }

    }
}