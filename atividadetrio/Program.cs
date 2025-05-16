using System;

namespace MenuExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1 - Calcula Aumento Salarial");
                Console.WriteLine("2 - Calcula Desconto Mercadoria");
                Console.WriteLine("3 - Aluguel de Carro");
                Console.WriteLine("4 - Cálculo de IMC");
                Console.WriteLine("5 - Gerador de Tabuada");
                Console.WriteLine("6 - Múltiplos de 3 entre 0 e 100");
                Console.WriteLine("7 - Fatoriais de 1 a 10");
                Console.WriteLine("8 - Cálculo de IRPF");
                Console.WriteLine("9 - Jogo de Adivinhação");
                Console.WriteLine("10 - Financiamento de Veículo");
                Console.WriteLine("11 - Planejamento de Aposentadoria");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                try
                {
                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            CalculaAumento.Executar();
                            break;
                        case 2:
                            Desconto.Executar();
                            break;
                        case 3:
                            AluguelCarro.Executar();
                            break;
                        case 4:
                            Imc.Executar();
                            break;
                        case 5:
                            Tabuada.Executar();
                            break;
                        case 6:
                            MultiplosDeTres.Executar();
                            break;
                        case 7:
                            Fatorial.Executar();
                            break;
                        case 8:
                            CalculoIRPF.Executar();
                            break;
                        case 9:
                            JogoAdivinhacao.Executar();
                            break;
                        case 10:
                            FinanciamentoVeiculo.Executar();
                            break;
                        case 11:
                            PlanejamentoAposentadoria.Executar();
                            break;
                        case 0:
                            Console.WriteLine("Encerrando o programa...");
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Por favor, digite um número válido.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    public class CalculaAumento
    {
        // Método estático que executa o cálculo
        public static void Executar()
        {
            try
            {
                // Solicita o salário atual ao usuário
                Console.Write("Digite o salário atual: ");
                double salario = double.Parse(Console.ReadLine());

                // Solicita o percentual de aumento
                Console.Write("Digite o percentual de aumento: ");
                double percentual = double.Parse(Console.ReadLine());

                // Calcula o valor do aumento
                double aumento = salario * percentual / 100;

                // Soma o aumento ao salário atual
                double novoSalario = salario + aumento;

                // Exibe o novo salário formatado com 2 casas decimais
                Console.WriteLine($"Novo salário: R$ {novoSalario:F2}");
            }
            catch (FormatException)
            {
                // Captura erro caso o usuário digite algo que não seja número
                Console.WriteLine("Erro: Entrada inválida.");
            }
        }
    }
}






public class Desconto
{

    public static void Executar()
    {
        try
        {
            // Solicita o valor ao usuário
            Console.Write("Digite o valor desejado: ");
            double salario = double.Parse(Console.ReadLine());

            // Solicita o percentual de desconto
            Console.Write("Digite o percentual de desconto: ");
            double percentual = double.Parse(Console.ReadLine());

            // Calcula o valor do desconto
            double desconto = salario * (percentual / 100);

            // faz o desconto
            double novoSalario = salario - desconto;

            // Exibe o novo valor com desconto
            Console.WriteLine($"Novo valor: R$ {novoSalario:F2}");
        }
        catch (FormatException)
        {
            // Captura erro caso o usuário digite algo que não seja número
            Console.WriteLine("Erro: Entrada inválida.");
        }
    }
}
    
class AluguelCarro //classe do programa 
{
    public static void Executar() //inicia o programa 
    {
        Console.WriteLine("Cálculo de aluguel de carro!!"); //exibe o texto 

        try //tratamento de erro pro catch
        {
            // constantes (valores fixos que não mudam!)
            const double diaria = 95.00;
            const double precoKm = 0.35;

            // dias de aluguel
            Console.Write("Digite o total de dias alugados: ");
            int diasAluguel = int.Parse(Console.ReadLine()); //pede o número de dias e converte pra inteiro 

            // pede a quilometragem inicial e final
            Console.Write("Digite a quilometragem inicial (km): ");
            double kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem final (km): ");
            double kmFinal = double.Parse(Console.ReadLine());

            // calculo da km >total< percorrida (distância percorrida é igual a km final - a inicial)
            double kmTotal = kmFinal - kmInicial;

            // calcula o valor total do aluguel (o total de dias vezes valor da diária, total de km vezes o preço)
            double valorTotal = (diasAluguel * diaria) + (kmTotal * precoKm);

            // Exibe os resultados
            Console.WriteLine("\nResultado:");
            Console.WriteLine($"Dias alugados: {diasAluguel}!");
            Console.WriteLine($"Km percorridos: {kmTotal} km");
            Console.WriteLine($"Custo por dias: R$ {diasAluguel * diaria}");
            Console.WriteLine($"Custo por km: R$ {kmTotal * precoKm}");
            Console.WriteLine($"Total a pagar: R$ {valorTotal}");
        }
        catch (FormatException) //erro caso o usuário escreva texto invés de número 
        {
            Console.WriteLine("Erro: Digite apenas números válidos.");
        }
        catch (Exception ex) //qualquer outro erro
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
        }
    }
}
public class Imc { 
public static void Executar()
{
    Console.Clear();
    Console.WriteLine("CÁLCULO DE IMC (ÍNDICE DE MASSA CORPORAL)");

    try
    {
        Console.Write("Digite seu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Digite seu gênero (M/F): ");
        char genero = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        double imc = peso / (altura * altura);
        string classificacao = ClassificarIMC(imc, genero);

        Console.WriteLine("\nRESULTADO:");
        Console.WriteLine($"Seu IMC é: {imc:F1}");
        Console.WriteLine($"Classificação: {classificacao}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Por favor, digite valores numéricos válidos.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
    }
}

public static string ClassificarIMC(double imc, char genero)
{
    if (genero == 'M')
    {
        if (imc < 20) return "Abaixo do peso";
        else if (imc < 24.9) return "Peso normal";
        else if (imc < 29.9) return "Acima do peso";
        else if (imc < 39.9) return "Obeso";
        else return "Obesidade mórbida";
    }
    else if (genero == 'F')
    {
        if (imc < 19) return "Abaixo do peso";
        else if (imc < 23.9) return "Peso normal";
        else if (imc < 28.9) return "Acima do peso";
        else if (imc < 38.9) return "Obeso";
        else return "Obesidade mórbida";
    }
    else
    {
        return "Gênero não reconhecido";
    }
}
    }
    public class Tabuada
{
    // Método estático que executa a geração da tabuada
    public static void Executar()
    {
        try
        {
            // Solicita ao usuário o número para gerar a tabuada
            Console.Write("Digite um número para ver a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            // Loop de 1 até 10 para exibir a tabuada do número
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        catch (FormatException)
        {
            // Captura erro se a entrada não for um número inteiro
            Console.WriteLine("Erro: Entrada inválida.");
            return;
        }
    }
}

class MultiplosDeTres //classe do programa 
{
    public static void Executar() //inicia 
    {
        Console.WriteLine("Múltiplos de 3 entre 0 e 100!!");

        Console.WriteLine("Números múltiplos de 3: ");
        for (int i = 0; i <= 100; i++) //loop que inicia i com 0 e dura enquanto i for menor que 100 e adiciona 1 a cada passagem
        {
            if (i % 3 == 0) //verifica se é múltiplo de 3
            {
                Console.Write(i + " ");
            }
        }
    }
}

class Fatorial
{
    public static void Executar()
    {
        Console.WriteLine("\nCalculando os fatoriais de 1 a 10:");

        for (int i = 1; i <= 10; i++)
        {
            int fatorial = CalcularFatorial(i);
            Console.WriteLine($"{i}! = {fatorial}");
        }
    }

    private static int CalcularFatorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        int resultado = 1;
        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
class CalculoIRPF
{
    public static void Executar()
    {
        Console.WriteLine("\nCalculadora de Imposto de Renda");

        try
        {
            Console.Write("Informe seu salário mensal: R$ ");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 0)
            {
                Console.WriteLine("Salário não pode ser negativo.");
                return;
            }

            double imposto = CalcularImposto(salario);
            Console.WriteLine($"Imposto devido: R$ {imposto:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Digite um número.");
        }
    }

    private static double CalcularImposto(double salario)
    {
        if (salario <= 1903.98)
            return 0;
        else if (salario <= 2826.65)
            return (salario - 1903.98) * 0.075;
        else if (salario <= 3751.05)
            return (salario - 2826.65) * 0.15 + 69.20;
        else if (salario <= 4664.68)
            return (salario - 3751.05) * 0.225 + 207.86;
        else
            return (salario - 4664.68) * 0.275 + 413.43;
    }
}
class JogoAdivinhacao //classe do programa 
{
    public static void Executar() //inicia
    {
        Console.WriteLine("Jogo de adivinhação!!!");
        Random random = new Random(); //random gera número aleatório
        int numeroSecreto = random.Next(0, 100); //random.next gera entre os intervalos de 0 e 100
        int tentativas = 0; //contador de tentativas (cria uma variável chamada tentativa e inicia com 0 pra armazenar quantas tentativas foram usadas)
        bool acertou = false; //bool (booleana) é comando pra verdadeiro e falso (o while continua enquanto o acertou for false)

        Console.WriteLine("Tente adivinhar o número entre 0 e 100!");

        while (tentativas < 10 && !acertou) //delimita o while a 10 tentativas
        {
            try //controle de erros que leva ao catch
            {
                Console.Write($"Tentativa {tentativas + 1}/10: "); //a cada tentativa ele adiciona 1
                int palpite = int.Parse(Console.ReadLine());

                if (palpite < 0 || palpite > 100) //valida o intervalo permitido
                {
                    Console.WriteLine("Digite um número entre 0 e 100!");
                    continue; //volta o início do loop se for inválido 
                }

                if (palpite == numeroSecreto)
                {
                    acertou = true;
                    Console.WriteLine($"Meus parabéns!!! Você acertou em {tentativas + 1} tentativas!"); //compara com o número certo
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é MAIOR!");
                }
                else
                {
                    Console.WriteLine("O número secreto é MENOR!"); //esse bloco informa se é maior ou menor
                }

                tentativas++; //incrementa o contador 
            }
            catch (FormatException) //se o usuário não digitar número 
            {
                Console.WriteLine("ERRO!! Digite um número válido!");
            }
        }

        if (!acertou) //revela o número se as tentativas acabarem sem acerto 
        {
            Console.WriteLine($"Fim das tentativas! O número era {numeroSecreto}.");
        }
    }
}

class FinanciamentoVeiculo
{
    public static void Executar()
    {
        Console.WriteLine("Cálculo de financiamento de veículo!");

        try //erro leva pro catch
        {

            const double taxaAdministrativa = 1200.00; //valor da taxa

            Console.Write("Digite o valor do veículo (R$): ");
            double valorVeiculo = double.Parse(Console.ReadLine());


            Console.Write("Digite o total de parcelas: ");
            int totalParcelas = int.Parse(Console.ReadLine());

            
            Console.Write("Digite a taxa de juros mensal (%): ");
            double taxaJurosMensal = double.Parse(Console.ReadLine()) / 100; // converte % para decimal (5% vira 0,05)
            double valorFinanciado = valorVeiculo + taxaAdministrativa; //calcula o valor total financiamento 

            // cálculo da parcela (fórmula Price)
            double parcela = (valorFinanciado * taxaJurosMensal * Math.Pow(1 + taxaJurosMensal, totalParcelas))
                           / (Math.Pow(1 + taxaJurosMensal, totalParcelas) - 1); //math.pow calcula potência prós juros compostos; divide o valor financiado em parcelas incluindo os juros

            // cálcula o valor total a ser pago
            double valorTotalPago = parcela * totalParcelas;

            // Exibe os resultados
            Console.WriteLine("\nResultado!");
            Console.WriteLine($"Valor do veículo: R$ {valorVeiculo}");
            Console.WriteLine($"Taxa administrativa: R$ {taxaAdministrativa}");
            Console.WriteLine($"Valor financiado: R$ {valorFinanciado}");
            Console.WriteLine($"Número de parcelas: {totalParcelas}");
            Console.WriteLine($"Taxa de juros mensal: {taxaJurosMensal * 100}%");
            Console.WriteLine($"Valor da parcela: R$ {parcela}");
            Console.WriteLine($"TOTAL: R$ {valorTotalPago}");
            Console.WriteLine($"Custo do financiamento: R$ {valorTotalPago - valorVeiculo}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Digite apenas números válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
        }
    }
}

class PlanejamentoAposentadoria
{
    public static void Executar()
    {
        Console.WriteLine("\nAposentadoria");

       
        
            Console.Clear();
            Console.WriteLine("PLANEJAMENTO DE APOSENTADORIA");

            try
            {
                Console.Write("Digite sua idade atual: ");
                int idadeAtual = int.Parse(Console.ReadLine());

                Console.Write("Com quantos anos pretende se aposentar: ");
                int idadeAposentadoria = int.Parse(Console.ReadLine());

                Console.Write("Valor que pretende guardar mensalmente (R$): ");
                double aporteMensal = double.Parse(Console.ReadLine());

                Console.Write("Taxa de rendimento mensal da aplicação (%): ");
                double taxaRendimento = double.Parse(Console.ReadLine()) / 100;

                int anosContribuicao = idadeAposentadoria - idadeAtual;
                int mesesContribuicao = anosContribuicao * 12;

                // Cálculo do montante acumulado
                double montante = 0;
                for (int i = 0; i < mesesContribuicao; i++)
                {
                    montante = (montante + aporteMensal) * (1 + taxaRendimento);
                }

                // Cálculo da renda mensal após aposentadoria (considerando mesma taxa)
                double rendaMensal = montante * taxaRendimento;

                Console.WriteLine("\nRESULTADO:");
                Console.WriteLine($"Período de contribuição: {anosContribuicao} anos ({mesesContribuicao} meses)");
                Console.WriteLine($"Montante acumulado: R$ {montante:F2}");
                Console.WriteLine($"Renda mensal estimada (com mesma taxa): R$ {rendaMensal:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Por favor, digite valores numéricos válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
        
    }
}



