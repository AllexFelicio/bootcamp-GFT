using static System.Console;

public class Program
{
    static void Demo6(){
         int[] numeros = new int[]{0,2,4,6,8};

        WriteLine("Digite um numero:");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros,numero);

        WriteLine($"O Numero digitado está na posição {idxEncontrado}");
    }
    static void Demo5(){
        int[] pares = new int[]{0,2,4,6,8};

     MudarParaImpar(pares);

     WriteLine($"Os impares {string.Join(",",pares)}");
    }
    static void Demo4(){
        string nome ="Alex";

       nome = TrocarNome(nome, "felicio");

       WriteLine($"O novo nome é: {nome}");
 
    }
    static void Demo3(){
       StructPessoa p1 = new StructPessoa{
           Documento = "1234",
           Idade = 22,
           Nome = "Alex" 
       };

        var p2 = p1;

        p1 = TrocaNomeStruct(p1,"Felicio");

        WriteLine($@"
        Nome do p1: {p1.Nome}
        Nome do p2: {p2.Nome}");  
    }
    static void Demo2(){
        Pessoa p1 = new Pessoa();

       p1.Nome ="Alex";
       p1.Idade=22;
       p1.Documento="123456";

       WriteLine($"Nome antigo: {p1.Nome}");

       Pessoa p2 = p1.Clone();
       

       TrocarNome(p1,"Felicio");

       WriteLine($@"
       O nome de p1 é: {p1.Nome}
       O nome de p2 é: {p2.Nome}");
    }
    static void Demo1(){
         int a = 2;
        a = Adicionar20(a);
        WriteLine($"O valor da variável a é {a}");
    }
    static int Adicionar20(int a)
    {
        return a +20;
    } 

    static void TrocarNome(Pessoa p1, string nomeNovo){
        p1.Nome= nomeNovo;
    }
  
    static StructPessoa TrocaNomeStruct(StructPessoa p1, string nomeNovo){
        p1.Nome = nomeNovo;
        return p1;
    }

    static string TrocarNome(string nome,string nomeNovo){


        nome = nomeNovo;

        return nome;

    }
    static void MudarParaImpar(int[] pares){

        for(int i =0; i<pares.Length;i++)
        {
            pares[i] = pares[i]+1;
        }
    }
    
    static int EncontrarNumero(int[] numeros, int numero){

        for(int i = 0;i<numeros.Length;i++){
            
            if(numeros[i] == numero){

                return i;
            }
        }
        return -1;
    }
    
    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa){

        foreach (var item in pessoas)
        {
            if (item.Nome == pessoa.Nome)
            {
                return true;
            }
            
        }
        return false;
    }
    public static void Main()
    {
       
        List<Pessoa> pessoas = new List<Pessoa>(){

            new Pessoa(){Nome="Alex"},
            new Pessoa(){Nome="Louise"},
            new Pessoa(){Nome="Felicio"},
            new Pessoa(){Nome="Enzo"},
            new Pessoa(){Nome="Lauren"},
        };

        WriteLine("Digite a pessoa que gostaria de localizar:");
        var nome= ReadLine();
        var pessoa = new Pessoa(){Nome=nome};

        var encontrado = EncontrarPessoa(pessoas,pessoa);

        if(encontrado == true){
            WriteLine($"{pessoa.Nome} localizado na lista!");
        }else{
            WriteLine("Pessoa não localizada");
        }


    }
}