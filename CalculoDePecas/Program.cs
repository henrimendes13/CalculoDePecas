
while (true)
{

    int codpeca, numpecas;
    double valoruni, valortotal;
    string[] vet;

    vet = Console.ReadLine().Split(' ');

    codpeca = int.Parse(vet[0]);
    
   numpecas = int.Parse(vet[1]);
    valoruni = double.Parse(vet[2]);
    valortotal = numpecas * valoruni;
    Console.WriteLine("VALOR A PAGAR: " + valortotal);
     

}
