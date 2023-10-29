namespace PasswordGenerate
{
    internal class Program
    {
        static void Main()
        {
            Password classPass = new Password();

            while (true)
            {
                Console.WriteLine("Gerador de senhas");
                Console.Write("para gerar (S/s)im ou (N/n)ao: ");
                string? input = Console.ReadLine();

                if (input != "")
                {
                    if (input == "Sim" || input == "sim" || input == "S" || input == "s")
                    {
                        Console.WriteLine("Senha gerada!!!!!");
                        string passTemp = classPass.GeneratePassword();
                        
                        Console.WriteLine(passTemp);
                        Console.WriteLine("Deseja salvar a senha gerada: ");
                        string? outInput = Console.ReadLine();

                        if(outInput != "")
                        {
                            if (outInput == "Sim" || outInput == "sim" || outInput == "S" || outInput == "s")
                            {
                                Console.WriteLine("Senha salva");

                                if (!File.Exists(@"./pass.txt"))
                                {
                                    File.Create(@"./pass.txt");
                                }

                                string[] pass = File.ReadAllLines(@"./pass.txt");

                                List<string> output = new List<string>();

                                foreach (string item in pass)
                                {
                                    output.Add(item);
                                }

                                output.Add(passTemp);

                                File.WriteAllLinesAsync (@"./pass.txt", output).Wait();

                                Console.WriteLine(@"Arquivo salvo: " + AppDomain.CurrentDomain.BaseDirectory + @"pass.txt");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Senha não salva!");
                                continue;
                            }
                        }
                    }
                    if(input == "Nao" || input == "nao" || input == "N" || input == "n")
                    {
                        Console.WriteLine("Encerrando App");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Respoda apenas com: (S/s)im ou (N/n)ao");
                    }
                }
                else
                {
                    Console.WriteLine("Respoda apenas com: (S/s)im ou (N/n)ao");
                }
            }
        }
    }
}