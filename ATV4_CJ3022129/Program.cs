using System.ComponentModel.Design;

int num = 4;
float n, n1, n2;
int op;
Console.WriteLine(">>CALCULADORA<<");
Console.WriteLine("Digite dois números abaixo");
n = float.Parse (Console.ReadLine ());
n1 = float.Parse (Console.ReadLine ()); 


Console.WriteLine("Digite qual operação você deseja realizar com esses números: ");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Multiplicação");
Console.WriteLine("3 - Divisão");
Console.WriteLine("4 - Subtração ");
num = int.Parse (Console.ReadLine ());


switch (num)
{
    case 1:
        n2 = n + n1;
        Console.WriteLine("A soma dos seus números ficou {0}", n2);
        break;

    case 2:
        n2 = n * n1;
        Console.WriteLine("A multiplicação dos seus números ficou {0}", n2);
        break;

    case 3:
        n2 = n / n1;
        Console.WriteLine("A divisão dos seus números ficou {0}", n2);
        break;
    case 4:
        n2 = n - n1;
        Console.WriteLine("A subtração dos seus números ficou {0}", n2);
        break;

    default:
        Console.WriteLine("Opção inválida, tente novamente");
        break;


} Console.WriteLine("Digite 0 para realizar ou qualquer outro número para finalizar");
op = int.Parse(Console.ReadLine());
while (op == 0)
{
    Console.WriteLine("Digite dois números abaixo");
    n = float.Parse(Console.ReadLine());
    n1 = float.Parse(Console.ReadLine());


    Console.WriteLine("Digite qual operação você deseja realizar com esses números: ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Multiplicação");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Subtração ");
    num = int.Parse(Console.ReadLine());


    switch (num)
    {
        case 1:
            n2 = n + n1;
            Console.WriteLine("A soma dos seus números ficou {0}", n2);
            break;

        case 2:
            n2 = n * n1;
            Console.WriteLine("A multiplicação dos seus números ficou {0}", n2);
            break;

        case 3:
            n2 = n / n1;
            Console.WriteLine("A divisão dos seus números ficou {0}", n2);
            break;
        case 4:
            n2 = n - n1;
            Console.WriteLine("A subtração dos seus números ficou {0}", n2);
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente");
            break;
    }
    break;
}
    