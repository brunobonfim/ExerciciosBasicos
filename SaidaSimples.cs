using System;

namespace ExerciciosConsole.Basicos
{
    public class SaidaSimples
    {
        public SaidaSimples()
        {
            FraseNaTela();
            Etiqueta();
            FrasesAssasinas();
            Mensagem();
            AoMestre();
            Quadrado();
            TabelaNotas();
            //Apresentacao();
            //LetraGrande();
            PalavraGrande();
            Emoticons();
            Pinheiro();
            Pinheiro2();
            Menu();
        }

        private static void FraseNaTela()
        {
            Console.WriteLine("\n 1.1.1 Frase na tela");
            Console.WriteLine("--------------------");
            Console.WriteLine("O primeiro programa a gente nunca esquece!");
        }

        private static void Menu()
        {
            Console.WriteLine("\n\n 1.1.14 Menu");
            Console.WriteLine("--------------------");

            Console.WriteLine("Cadastro de Clientes\n");
            Console.WriteLine("0 - Fim");
            Console.WriteLine("1 - Inclui");
            Console.WriteLine("2 - Altera");
            Console.WriteLine("3 - Exclui");
            Console.WriteLine("4 - Consulta");
            Console.Write("Opção: ");
        }

        private static void Pinheiro2()
        {
            Console.WriteLine("\n\n 1.1.13 Pinheiro");
            Console.WriteLine("--------------------");

            Console.WriteLine("       *");
            Console.WriteLine("      ***");
            Console.WriteLine("     *****");
            Console.WriteLine("    *******");
            Console.WriteLine("   *********");
            Console.WriteLine("  *********** ");
            Console.WriteLine(" ************* ");
            Console.WriteLine("*************** ");
            Console.WriteLine("      ***        ");
            Console.WriteLine("      ***        ");
            Console.WriteLine("    *******      ");
        }

        private static void Pinheiro()
        {
            Console.WriteLine("\n\n 1.1.14 Pinheiro 2");
            Console.WriteLine("--------------------");

            Console.WriteLine("       X");
            Console.WriteLine("      XXX");
            Console.WriteLine("     XXXXX");
            Console.WriteLine("    XXXXXXX");
            Console.WriteLine("   XXXXXXXXX");
            Console.WriteLine("  XXXXXXXXXXX ");
            Console.WriteLine(" XXXXXXXXXXXXX ");
            Console.WriteLine("XXXXXXXXXXXXXXX ");
            Console.WriteLine("      XXX");
            Console.WriteLine("      XXX");
            Console.WriteLine("     XXXXX");
        }

        private static void Emoticons()
        {
            Console.WriteLine("\n\n 1.1.11 Emoticons");
            Console.WriteLine("--------------------");

            Console.WriteLine(":-) \t Sorriso");
            Console.WriteLine(":-( \t Tristeza");
            Console.WriteLine(":-p \t Mostrando Língua");
            Console.WriteLine(":-o \t Espanto");
            Console.WriteLine("{:-) \t Cabelo Partido no meio");
            Console.WriteLine(":-{ \t Usa Bigode");
            Console.WriteLine(":-* \t Beijo");
        }

        private static void PalavraGrande()
        {
            Console.WriteLine("\n\n 1.1.10 Palavra Grande");
            Console.WriteLine("--------------------");

            Console.WriteLine("********  ********   *       ");
            Console.WriteLine("*         *      *   *       ");
            Console.WriteLine("*         *      *   *       ");
            Console.WriteLine("********  *      *   *       ");
            Console.WriteLine("       *  *      *   *       ");
            Console.WriteLine("       *  *      *   *       ");
            Console.WriteLine("********  ********   ********");
        }

        private static void LetraGrande()
        {
            Console.WriteLine("\n\n 1.1.9 Letra Grande");
            Console.WriteLine("--------------------");

            Console.WriteLine("Informe uma letra: ");
            var letra = Console.ReadLine();

            Console.WriteLine("\t" + letra);
            Console.WriteLine("\t" + letra);
            Console.WriteLine("\t" + letra);
            Console.WriteLine("\t" + letra + letra + letra + letra);
        }

        private static void Apresentacao()
        {
            Console.WriteLine("\n\n 1.1.8 Apresentação");
            Console.WriteLine("--------------------");

            Console.WriteLine("FOTOSSÍNTESE");
            Console.ReadKey();
            Console.WriteLine("A água e os sais minerais absorvidos pelas raízes sobem através dos vasos lenhosos do caule e chegam às folhas.");
            Console.ReadKey();
            Console.WriteLine("Nas folhas, existe uma substância verde, a clorofila, que absorve a energia luminosa do sol. Ao mesmo tempo, por meio dos estômatos presentes nas folhas, a planta absorve gás carbônico do ar.");
            Console.ReadKey();
            Console.WriteLine("Usando a energia solar, o gás carbônico e o hidrogênio contido na água retirada do solo, após complicadas reações químicas, a planta produz açúcares (glicose).");
        }

        private static void TabelaNotas()
        {
            Console.WriteLine("\n\n 1.1.7 Tabela de Notas");
            Console.WriteLine("--------------------");

            Console.WriteLine("ALUNO(A) \t NOTA");
            Console.WriteLine("======== \t =====");
            Console.WriteLine("ALINE \t\t 9.0 ");
            Console.WriteLine("MÁRIO \t\t 10.0 ");
            Console.WriteLine("SÉRGIO \t\t 4.5 ");
            Console.WriteLine("SHIRLEY \t 7.0 ");
        }

        private static void Quadrado()
        {
            Console.WriteLine("\n\n 1.1.6 Quadrado");
            Console.WriteLine("--------------------");
            Console.WriteLine("     XXXXX   ");
            Console.WriteLine("     X   X   ");
            Console.WriteLine("     X   X   ");
            Console.WriteLine("     X   X   ");
            Console.WriteLine("     XXXXX   ");
        }

        private static void AoMestre()
        {
            Console.WriteLine("\n\n 1.1.5 Ao Mestre");
            Console.WriteLine("--------------------");
            Console.WriteLine("Professor/Chefe,");
            Console.WriteLine("Espero que todos saibam tirar o maior proveito deste curso.");
            Console.WriteLine("PS: Eu gosto de Dojo.");
        }

        private static void Mensagem()
        {
            Console.WriteLine("\n\n 1.1.4 Mensagem");
            Console.WriteLine("--------------------");
            Console.WriteLine("Jesus, meu maior valor!");
        }

        private static void FrasesAssasinas()
        {
            Console.WriteLine("\n\n 1.1.3 Frases assassinas");
            Console.WriteLine("--------------------");
            Console.WriteLine("Isto não vai dar certo!");
            Console.WriteLine("Você nunca vai conseguir!");
            Console.WriteLine("Você vai se estrepar!");
            Console.WriteLine("Não vai dar em nada!");
            Console.WriteLine("Está tudo errado!");
        }

        private static void Etiqueta()
        {
            Console.WriteLine("\n\n 1.1.2 Etiqueta");
            Console.WriteLine("--------------------");
            Console.WriteLine("Nome: Cleiviane");
            Console.WriteLine("Endereço: Rua Nova Glória - Jd. Nova Esperança");
            Console.Write("CEP: 74.465-290  ");
            Console.WriteLine("Telefone: (62)9296-2337");
        }
    }
}
