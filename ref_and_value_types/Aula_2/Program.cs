using static System.Console;

class Aula_2{

    static void Demo2(){
        var nomes = new string[]{"Alex","Louise","Enzo","Felicio"};
         WriteLine($@"A lista de nomes atuais é: 
        {string.Join(", \n",nomes)}
        ");
        WriteLine("Nome que deseja alterar: ");
        var nome = ReadLine();
        WriteLine("Digite o nome novo: ");
        var nomeNovo = ReadLine();

        AlterarNome(nomes,nome, nomeNovo);

        WriteLine($@"A nova lista de nomes é: 
        {string.Join(", \n",nomes)}
        ");
    }
    static void Demo1(){
         int a= 5;
        Adicionar20(ref a);
        WriteLine($"o valor de a é: {a}");

    }

    static void Adicionar20(ref int a){

        a= a+20;
    }

    static void AlterarNome(string[] nomes,string nome,string nomeNovo){

        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }
    }

    static int LocalizaNome(String[] nomes, string nome){

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                  return i;
                }

            }
            return -1;
    }
 static void Main(){

        var nomes = new string[]{"Alex","Louise","Enzo","Felicio"};
         WriteLine($@"A lista de nomes atuais é: 
        {string.Join(", \n",nomes)}
        ");
        WriteLine("Nome que deseja alterar: ");
        var nome = ReadLine();
        WriteLine("Digite o nome novo: ");
        var nomeNovo = ReadLine();

        var indice = LocalizaNome(nomes,nome);

        if (indice>0){

            nomes[indice] = nomeNovo;

            WriteLine($@"A nova lista de nomes é: 
        {string.Join(", \n",nomes)}
        ");
        }



        //AlterarNome(nomes,nome, nomeNovo);


    }
}