//Console.WriteLine("Informe sua idade");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade <= 59)
//{
//    Console.WriteLine("Você ainda não tem direito a tirar a carterinha de idoso");
//    int anosfaltantes = 60 - idade;
//    Console.WriteLine("Ainda falta " +  anosfaltantes + " para tirar a carteirinha de idoso");
//    int diasfaltantes = anosfaltantes * 365;
//    Console.WriteLine("Faltam " + diasfaltantes + " para tirar a carteirinha de idoso");
//}else
//{
//    Console.WriteLine("Você tem direito a tirar a carteirinha de idoso");
//}

string nomeJogador;

Console.WriteLine("Bem vindo ao campionato de Poker!");

Console.WriteLine("Qual o nome do jogador?");
nomeJogador = Console.ReadLine().ToString();

bool validacaojogador;

switch (nomeJogador)
{
    case "Gabriel":
    case "Geovanna":
    case "Gael":
    case "Luiz":
        Console.WriteLine("Jogador autorizado para o campionato de poker");
        validacaojogador = true;
        break;
    default:
        Console.WriteLine("Jogador não autorizado para o campionato de poker");
        validacaojogador = false;
        break;
}

if (validacaojogador)
{
    Console.WriteLine("Quantas vitórias você tem no torneio?");
    int vitorias = Convert.ToInt32(Console.ReadLine());
    int pontuacaoatual = Verificarpontuacao(vitorias);
    Console.WriteLine("Você possui " + pontuacaoatual.ToString() + "pontos no torneio");
    int pontuacaonova = BonificarParticipante(pontuacaoatual);
    Console.WriteLine("Parabéns, voc^ganhou mais um ponto de bonificação. Agora sua pontuação é " + pontuacaonova.ToString());
}


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

