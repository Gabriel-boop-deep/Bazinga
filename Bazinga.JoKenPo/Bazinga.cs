/*
a tesoura corta o papel;
o papel embrulha a pedra;
a pedra esmaga o lagarto;
o lagarto envenena Spock;
Spock destrói a tesoura;
a tesoura decapita o lagarto;
o lagarto come o papel;
o papel contesta Spock;
Spock vaporiza a pedra;
a pedra quebra a tesoura.
Conhecendo os personagens
*/
using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2,papel,tesoura,pedra,Spock,lagarto ;
            for (int i = 1; i <=qtdTeste ; i++) //insira a variavel correta
            {
                Console.WriteLine("Informe duas opções entre espaço [Ex: papel tesoura]");
                string[] valores = Console.ReadLine().Split(" ");
                v1 = valores[0];
                v2 = valores[1];
                papel="papel";
                tesoura="tesoura";
                pedra="pedra";
                lagarto="lagarto";
                Spock="Spock";
               
                if((  v1==tesoura && v2==papel   ) || (v1==papel && v2==pedra  ) //complete a solução
                    || (  v1==pedra && v2==lagarto  ) || (  v1==lagarto && v2==Spock  )
                    || (   v1==Spock && v2==tesoura) || ( v1==tesoura && v2==lagarto  )
                    || (  v1==lagarto && v2==papel  ) || ( v1==papel && v2==Spock   )
                    || ( v1==Spock && v2==pedra   ) || ( v1==pedra && v2==tesoura ))
                    Console.WriteLine("Caso #{0}: Bazinga!", i) ;             
                else if (  v1==v2  )   //complete a solucao
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }

    }

}
