using System;

namespace TempoEventoDIO
{
    class Program
    {
        /*
        Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.

        Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.

        Entrada
        Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.

        Saída
        Na saída, deve ser apresentada a duração do evento, no seguinte formato:

        W dia(s)
        X hora(s)
        Y minuto(s)
        Z segundo(s)

        Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.

        Exemplo de entrada: 
        
        Dia 5
        08 : 12 : 23
        Dia 9
        06 : 13 : 23   
        
        */
        static void Main(string[] args)
        {
            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;


            string[] dadosInicio = Console.ReadLine().Split(" ");
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split(":");
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);


            string[] dadosTermino = Console.ReadLine().Split(" ");
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split(":");
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[2]);

            int ano = DateTime.Now.Year;

            DateTime dataInicio = Convert.ToDateTime($"{ano}/04/{diaInicio} {horaMomentoInicio}:{minutoMomentoInicio}:{segundoMomentoInicio}");
            DateTime dataTermino = Convert.ToDateTime($"{ano}/04/{diaTermino} {horaMomentoTermino}:{minutoMomentoTermino}:{segundoMomentoTerminio}");

            int dias = ((dataTermino - dataInicio).Days);
            int horas = ((dataTermino - dataInicio).Hours);
            int minutos = ((dataTermino - dataInicio).Minutes);
            int segundos = ((dataTermino - dataInicio).Seconds);

            System.Console.WriteLine($"{dias} dia(s)");
            System.Console.WriteLine($"{horas} hora(s)");
            System.Console.WriteLine($"{minutos} minuto(s)");
            System.Console.WriteLine($"{segundos} segundo(s)");
        }
    }
}
