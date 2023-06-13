string nomeJogador;

Console.WriteLine("Bem vindo ao campionato de Poker!");

ExemploDoWhile();

//Console.WriteLine("Qual o nome do jogador?");
//nomeJogador = Console.ReadLine().ToString();

//bool validacaojogador;

//switch (nomeJogador)
//{
//    case "Gabriel":
//    case "Geovanna":
//    case "Gael":
//    case "Luiz":
//        Console.WriteLine("Jogador autorizado para o campionato de poker");
//        validacaojogador = true;
//        break;
//    default:
//        Console.WriteLine("Jogador não autorizado para o campionato de poker");
//        validacaojogador = false;
//        break;
//}

//if (validacaojogador)
//{
//    Console.WriteLine("Quantas vitórias você tem no torneio?");
//    int vitorias = Convert.ToInt32(Console.ReadLine());
//    int pontuacaoatual = Verificarpontuacao(vitorias);
//    Console.WriteLine("Você possui " + pontuacaoatual.ToString() + "pontos no torneio");
//    int pontuacaonova = BonificarParticipante(pontuacaoatual);
//    Console.WriteLine("Parabéns, voc^ganhou mais um ponto de bonificação. Agora sua pontuação é " + pontuacaonova.ToString());
//}


// metodo de verificacao da pontuacao do jogador
int Verificarpontuacao (int vitorias)
{
    const int fatorvitoria = 3;

    int pontuacao = fatorvitoria * vitorias;

    return pontuacao;
}

// metodo verificacao de bonus de participacao
int BonificarParticipante (int pontuacaoatual)
{
    int pontuacaonova = pontuacaoatual;
    pontuacaoatual++;

    return pontuacaoatual;
}

void ExemploForeach()
{
    string[] jogadores = { "Gabriel", "Geovanna", "Gael", "Luiz" };

    foreach(string jogador in jogadores)
    {
        Console.WriteLine("Bem vindo as quartas de finais " + jogador);
    }
}

void ExemploWhile()
{
    Console.WriteLine("Qual a sua pontuação atual?");
    int pontuacaojogador = Convert.ToInt32(Console.ReadLine());

    if (pontuacaojogador < 27)
    {
        while (pontuacaojogador < 27)
        {
            Console.WriteLine("Jogando!");
            Console.WriteLine("Você ganhou? (S/N)");
            string ganhou = Console.ReadLine();
            if(ganhou == "S")
            {
                pontuacaojogador = pontuacaojogador + 3;
            }
            else
            {
                Console.WriteLine("Você infelizmente esta fora do toneio");
                break;
            }
        }
        Console.WriteLine("Você está nas quartas");
    }
    else
    {
        Console.WriteLine("Você esta nas quartas de final");
    }

}

void ExemploDoWhile()
{
    string mensagem = "";
    try
    {
        Console.WriteLine("Qual a sua pontuação atual?");
        int pontuacaojogador = Convert.ToInt32(Console.ReadLine());

        if (pontuacaojogador < 27)
        {
            do
            {
                Console.WriteLine("Jogando!");
                Console.WriteLine("Você ganhou? (S/N)");
                string ganhou = Console.ReadLine();
                if (ganhou == "S")
                {
                    pontuacaojogador = pontuacaojogador + 3;
                }
                else
                {
                    mensagem = "Você infelizmente esta fora do toneio";
                    break;
                }
            }
            while (pontuacaojogador < 27);

            mensagem = "Você está nas quartas";
        }
        else
        {
            mensagem = "Você esta nas quartas de final";
        }
    }
    catch (Exception ex)
    {
        mensagem = "Aconteceu o seguinte erro: " + ex.Message;
    }
    finally
    {
        Console.WriteLine(mensagem);
    }


}

