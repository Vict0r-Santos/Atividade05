using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string nome;
        string sobrenome;
        string cidade;
        string bairro;
        string estado;
        string endereço;
        int viagens_ant;
        int viagens_plan;
        int viagens_atual;
        string cupom;
        string email;
        
        
        Console.WriteLine ("Bem vindo a agencia de viagens Europe Airlines.\n");
        Console.WriteLine ("Informe seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine ("Agora informe seu sobrenome:");
        sobrenome = Console.ReadLine();
        Console.WriteLine ($"Bem vindo Sr(a).{nome} {sobrenome}, vamos continuar o seu cadastro...");
        Console.WriteLine ("Por favor informe a cidade onde mora:");
        cidade = Console.ReadLine();
        Console.WriteLine ("informe o estado onde se localiza:");
        estado = Console.ReadLine();
        Console.WriteLine ("informe o seu bairro:");
        bairro = Console.ReadLine();
        Console.WriteLine ("Informe seu endereço:");
        endereço = Console.ReadLine();
        Console.WriteLine ($"\nO Sr(a). {sobrenome} mora na cidade de {cidade} - {estado}, no endereço: {endereço}, localizado no bairro {bairro}.");
        Console.WriteLine ("Quantas viagens fez no ano passado?");
        viagens_ant = int.Parse(Console.ReadLine());
        Console.WriteLine ("Quantas viagens ja fez nesse ano?");
        viagens_atual = int.Parse(Console.ReadLine());
        Console.WriteLine ("Quantas viagens planeja fazer esse ano?");
        viagens_plan = int.Parse(Console.ReadLine());
        Console.WriteLine ($"Voce ja realizou um total de {viagens_atual + viagens_ant} viagens no total.");
        Console.WriteLine ($"Faltam {10 - (viagens_atual + viagens_ant)} viagens para voce completar 10.");
        Console.WriteLine ($"o intervalo de meses de suas vaigens e de: { 12/(viagens_atual + viagens_ant)} viagens.");
        Console.WriteLine ($"Digite seu cupom de desconto:");
        cupom = Console.ReadLine();
        
        if(cupom == "Conradito10") {
            
            Console.WriteLine ("Parabens, voce ganhou 10% e desconto.");
        }else{
            
            Console.WriteLine ("Esse cupom não existe.");
        }
        Console.WriteLine ("Gostaria de receber novidades no seu email?");
        email = Console.ReadLine();
        if(email == "sim") {
            Console.WriteLine ($"Obrigado {nome} por se registrar, voce recebera novos e-mails em breve.");
            
        }else {
            Console.WriteLine ("Ok, você não receberá e-mails de promoções");
            
        }
        Console.WriteLine ("Obrigado e volte sempre!");
        
        
        Console.ReadLine();
    }
}
