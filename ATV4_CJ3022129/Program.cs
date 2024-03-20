
int opc;
int dia;
Console.WriteLine("<<MENU>>");
Console.WriteLine("Digite para qual questão você deseja ir");
Console.WriteLine("1 - Exercício 1");
Console.WriteLine("2 - Exercício 2");
Console.WriteLine("3 - Exercício 3");
Console.WriteLine("4 - Exercício 4");
Console.WriteLine("5 - Exercício 5");
Console.WriteLine("6 - Exercício 6");
opc = int.Parse(Console.ReadLine());

switch (opc)
{


    case 1:
        Console.WriteLine("Digite um número de 1 a 7 equivalente a um dia da semana \n");
        dia = int.Parse(Console.ReadLine());
        switch (dia)
        {
            case 1:
                Console.WriteLine("\nDomingo, 17 de abril de 2024");
                break;


            case 2:
                Console.WriteLine("\nSegunda-Feira, 18 de março de 2024");
                break;
            case 3:
                Console.WriteLine("\nTerça-Feira, 19 de março de 2024");
                break;
            case 4:
                Console.WriteLine("\nQuarta-Feira, 20 de março de 2024");
                break;
            case 5:
                Console.WriteLine("\nQuinta-Feira, 21 de abril de 2024");
                break;
            case 6:
                Console.WriteLine("\nSexta-Feira, 22 de abril de 2024");
                break;
            case 7:
                Console.WriteLine("\nSábado, 23 de abril de 2024");
                break;
        }
        break;
        float valor;
        float compra;
        float opca;
    case 2:
        Console.WriteLine("Qual o valor da sua compra?");
        compra = float.Parse(Console.ReadLine());
        Console.WriteLine("Qual o método de pagamento?");
        Console.WriteLine("1 - Dinheiro, até 15% de desconto à vista");
        Console.WriteLine("2 - Pix, até 10% de desconto à vista");
        Console.WriteLine("3 - Débito, até 5% de acréscimo");
        Console.WriteLine("4 - Crédito, até 10% de acréscimo");
        opca = float.Parse(Console.ReadLine());
        switch (opca)
        {
            case 1:
                valor = (compra - (((compra / 100) * 15)));
                Console.WriteLine("\nCom o desconto, a sua compra ficou {0}", valor);
                break;
            case 2:
                valor = (compra - (((compra / 100) * 10)));
                Console.WriteLine("\nCom o desconto, a sua compra ficou {0}", valor);
                break;
            case 3:
                valor = (compra + (((compra / 100) * 5)));
                Console.WriteLine("\nCom o acréscimo, a sua compra ficou {0}", valor);
                break;
            case 4:
                valor = (compra + (((compra / 100) * 10)));
                Console.WriteLine("\nCom o acréscimo, a sua compra ficou {0}", valor);
                break;

        }
        break;
    case 3:
        int mes, ano;
        Console.WriteLine("Primeiramente, digite 1 para ano bissexto ou 2 para um ano normal");
        ano = int.Parse(Console.ReadLine());
        if (ano == 1)
        {
            Console.WriteLine("\nDigite algum número de 1 a 12 corresponde aos meses do ano");
            mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    Console.WriteLine("\nJaneiro, contém 31 dias.");
                    break;
                case 2:
                    Console.WriteLine("\nFevereiro, costuma ter 28 dias, mas nesse caso, contém 29 dias");
                    break;
                case 3:
                    Console.WriteLine("\nMarço, contém 31 dias");
                    break;
                case 4:
                    Console.WriteLine("\nAbril, contém 30 dias");
                    break;
                case 5:
                    Console.WriteLine("\nMaio, contém 31 dias");
                    break;
                case 6:
                    Console.WriteLine("\nJunho, contém 30 dias");
                    break;
                case 7:
                    Console.WriteLine("\nJulho, contém 31 dias");
                    break;
                case 8:
                    Console.WriteLine("\nAgosto, contém 31 dias");
                    break;
                case 9:
                    Console.WriteLine("\nSetembro, contém 30 dias");
                    break;
                case 10:
                    Console.WriteLine("\nOutubro, contém 31 dias");
                    break;
                case 11:
                    Console.WriteLine("\nNovembro, contém 30 dias");
                    break;
                case 12:
                    Console.WriteLine("\nDezembro, contém 31 dias");
                    break;
            }
            if (ano == 2)
            {
                switch (ano)
                {
                    case 1:
                        Console.WriteLine("\nJaneiro, contém 31 dias.");
                        break;
                    case 2:
                        Console.WriteLine("\nFevereiro, costuma ter 28 dias");
                        break;
                    case 3:
                        Console.WriteLine("\nMarço, contém 31 dias");
                        break;
                    case 4:
                        Console.WriteLine("\nAbril, contém 30 dias");
                        break;
                    case 5:
                        Console.WriteLine("\nMaio, contém 31 dias");
                        break;
                    case 6:
                        Console.WriteLine("\nJunho, contém 30 dias");
                        break;
                    case 7:
                        Console.WriteLine("\nJulho, contém 31 dias");
                        break;
                    case 8:
                        Console.WriteLine("\nAgosto, contém 31 dias");
                        break;
                    case 9:
                        Console.WriteLine("\nSetembro, contém 30 dias");
                        break;
                    case 10:
                        Console.WriteLine("\nOutubro, contém 31 dias");
                        break;
                    case 11:
                        Console.WriteLine("\nNovembro, contém 30 dias");
                        break;
                    case 12:
                        Console.WriteLine("\nDezembro, contém 31 dias");
                        break;
                }
            }
            break;
        }
        break;



    case 4:
        int num = 5;
        float n, n1, n2;
        int op;
        Console.WriteLine(">>CALCULADORA<<");
        Console.WriteLine("Digite dois números abaixo");
        n = float.Parse(Console.ReadLine());
        n1 = float.Parse(Console.ReadLine());


        Console.WriteLine("Digite qual operação você deseja realizar com esses números: ");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Multiplicação");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Subtração ");
        Console.WriteLine("5 - Potenciação");
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
            case 5:
                n2 = (float)Math.Pow(n, n1);
                Console.WriteLine("A potenciação dos seus números ficou {0}", n2);
                break;
            default:
                Console.WriteLine("Opção inválida, tente novamente");
                break;


        }
        Console.WriteLine("Digite 0 para realizar ou qualquer outro número para finalizar");
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
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("5 - Potenciação");
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
                case 5:
                    n2 = (float)Math.Pow(n, n1);
                    Console.WriteLine("A potenciação dos seus números ficou {0}", n2);
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente");
                    break;
            }
            break;
        }
        break;


    case 5:


        float salario;
        float desconto;
        float sal;
        int opcao;
        float saw;


        Console.WriteLine(">>Bem vindo ao nosso sistema, hoje vamos efetuar um aumento aos nossos colaboladores<<");
        Console.WriteLine("Primeiramente, qual o seu cargo?");
        Console.WriteLine("1 - Código 101, Professor");
        Console.WriteLine("2 - Código 102, Secretário");
        Console.WriteLine("3 - Código 103, Publicitário");
        Console.WriteLine("4 - Código 204, Jornalista");
        Console.WriteLine("5 - Código 206, Mecânico");
        Console.WriteLine("6 - Código 301, Estagiário");
        Console.WriteLine("7 - Código 302, Técnico em TI");
        Console.WriteLine("8 - Outro");
        opcao = int.Parse(Console.ReadLine());
        Console.WriteLine("\nCerto, agora digite o seu sálario atual");
        salario = float.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                desconto = (salario / 100) * 7.5f;
                sal = salario - desconto;
                saw = salario + (salario / 100) * 7.5f;
                Console.WriteLine("Seu sálario antigo era de {0}, com o novo aumenta de 7,5%, seu salário agora é de {1}, com uma diferença de {2}", salario, saw, desconto);
                break;
            case 2:
                desconto = (salario / 100) * 9.7f;
                sal = salario - desconto;
                saw = salario + (salario / 100) * 9.7f;
                Console.WriteLine("Seu sálario antigo era de {0}, com o novo aumenta de 9,7 seu salário agora é de {1}, com uma diferença de {2}", salario, saw, desconto);
                break;
            case 3:
                desconto = (salario / 100) * 11.7f;
                sal = salario - desconto;
                saw = salario + (salario / 100) * 11.7f;
                Console.WriteLine("Seu sálario antigo era de {0}, com o novo aumenta de 11,7%, seu salário agora é de {1}, com uma diferença de {2}", salario, saw, desconto);
                break;
            case 4:
                desconto = (salario / 100) * 8.9f;
                sal = salario - desconto;
                saw = salario + (salario / 100) * 8.9f;
                Console.WriteLine("Seu sálario antigo era de {0}, com o novo aumenta de 8,9%, seu salário agora é de {1}, com uma diferença de {2}", salario, saw, desconto);
                break;
            case 5:
                desconto = (salario / 100) * 13.24f;
                sal = salario - desconto;
                saw = salario + (salario / 100) * 13.24f;
                Console.WriteLine("Seu sálario antigo era de {0}, com o novo aumenta de 13,24%, seu salário agora é de {1}, com uma diferença de {2}", salario, saw, desconto);
                break;
            case 6:
                desconto = (salario / 100) * 10.4f;
                sal = salario - desconto;
                saw = salario + (salario / 100) * 10.4f;
                Console.WriteLine("Seu sálario antigo era de {0}, com o novo aumenta de 10,4%, seu salário agora é de {1}, com uma diferença de {2}", salario, saw, desconto);
                break;
            case 7:
                desconto = (salario / 100) * 14.6f;
                sal = salario - desconto;
                saw = salario + (salario / 100) * 14.6f;
                Console.WriteLine("Seu sálario antigo era de {0}, com o novo aumenta de 14,6 seu salário agora é de {1}, com uma diferença de {2}", salario, saw, desconto);
                break;
            case 8:
                desconto = (salario / 100) * 43.5f ;
                sal = salario - desconto;
                saw = salario + (salario / 100) * 43.5f;
                Console.WriteLine("Seu sálario antigo era de {0}, com o novo aumenta de 43.5, seu salário agora é de {1}, com uma diferença de {2}", salario, saw, desconto);
                break;

        } break;
float sala, imposto;
float sal_liq;
int imp;
case 6:

Console.WriteLine("Informe o seu sálario para calcular o imposto de renda");
Console.WriteLine("1 - Até 1.903,98");
Console.WriteLine("2 - Entre 1.903,98 e 2.826,66");
Console.WriteLine("3 - Entre 2.826,66 e 3.751,06");
Console.WriteLine("4 - Entre R$ 3.751,06 e R$ 4.664,68");
Console.WriteLine("5 - Acima de R$ 4.664,68");
imp = int.Parse(Console.ReadLine());

switch (imp){
case 1:
Console.WriteLine("Isento de imposto de renda");
break;

case 2:
Console.WriteLine ("Digite o valor exato do seu sálario bruto");
sala = float.Parse(Console.ReadLine());
imposto= (sala/100f) * 7.5f;
sal_liq= sala-imposto;
Console.WriteLine("O imposto dado é de {0} R$, e seu sálario líquido vai ficar {1} R$", imposto, sal_liq);
break;
case 3:
Console.WriteLine ("Digite o valor exato do seu sálario bruto");
sala = float.Parse(Console.ReadLine());
imposto= (sala/100f) * 15f;
sal_liq= sala-imposto;
Console.WriteLine("O imposto dado é de {0} R$, e seu sálario líquido vai ficar {1} R$", imposto, sal_liq);
break;
case 4:
Console.WriteLine ("Digite o valor exato do seu sálario bruto");
sala = float.Parse(Console.ReadLine());
imposto= (sala/100f) * 22.5f;
sal_liq= sala-imposto;
Console.WriteLine("O imposto dado é de {0} R$, e seu sálario líquido vai ficar {1} R$", imposto, sal_liq);
break;
case 5:
Console.WriteLine ("Digite o valor exato do seu sálario bruto");
sala = float.Parse(Console.ReadLine());
imposto= (sala/100f) * 27.5f;
sal_liq= sala-imposto;
Console.WriteLine("O imposto dado é de {0} R$, e seu sálario líquido vai ficar {1} R$", imposto, sal_liq);
break;
} break;
}
}
}
