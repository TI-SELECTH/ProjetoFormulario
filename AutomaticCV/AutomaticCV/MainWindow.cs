using Timer = System.Windows.Forms.Timer;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;
using System.IO;
using RestSharp;
using RestSharp.Authenticators;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


//O sistema espera por 20 segundos para efetuar a busca no site, e para depois efetuar a conex�o com a API do Invenias e tentar colocar os novos dados

/*Documenta��es:
 * Forminator: https://wpmudev.com/docs/api-plugin-development/forminator-api-docs/
 * Invenias: https://bullhorn.github.io/invenias-api-docs/
 * Invenias: https://selecth.invenias.com/api
 */

namespace AutomaticCV
{

    public partial class MainWindow : Form
    {

        public string inveniasUrl = "https://selecth.invenias.com/";
        public string selectUrl = "https://selecth.com.br/";

        bool newSubmit = false;

        //Declara��o de vari�veis
        //Tempo de espera para atualizar a barra de carregamento
        int loading_timer = 200;

        public MainWindow()
        {
            InitializeComponent();
            call_loading_timer();
        }

        //Definindo e chamando  otimer
        public void call_loading_timer()
        {
            timer2 = new Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            //Atualiza a cada segundo
            timer2.Interval = loading_timer;
            timer2.Start();
        }

        //Gerenciamento de consumo da API do Invenias, analizando e inserindo os dados dos cadastrados
        //Eu preferi colocar os dados como est�ticos, mas � poss�vel colocar eles din�micos, s� tem que criar uma nova janela para logar, e armazenar os dados no cache do Windows
        public void inveniasAPIManager()
        {

            //Declara��od e vari�veis de consumo de API
            string thirdPartyApplicationUrl = (inveniasUrl + ""); //Vai precisar para criar uma ThirdPartyApplication para 2 dos dados abaixo.
            string authenticationUrl = (inveniasUrl + "identity/connect/token");
            string username = ""; //Email da Select com cargos de ADM para acessar os dados
            string password = ""; //Senha do Email
            string client_id = ""; //Perdi os dados das aplica��es que fiz do Invenias, s� precisa criar uma nova via ThirdPartyApplication
            string client_secret = ""; //Esse dado e o acima � atrav�s da aplica��o ThirdParty
            string grant_type = "password";
            string scope = "openid profile api email";

            string authorization = ""; //� a key que precisa ser gerada, vai ser pega ap�s a autoriza��o.
            //Passos: 1. Post de ThirdPartyApplication, 2. Post de Autoriza��o, 3. Consumo.

            //Declara��o de vari�veis de indentifica��o de campos no Invenias
            string envio = "";
            string nome = "";
            string email = "";
            string resultado = ""; //Cadastrado - Novo candidato cadastrado; Atualizado - J� havia candidato cadastrado, dados foram atualizados; Erro - Algo deu errado.

            /*var client = new RestClient(inveniasUrl + ""* parou de funcionar );
            var request = new RestRequest(Method.POST); Essa linha tamb�m come�ou a dar problema
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");*/

            //Essa parte deu problema por conta que algo mudou no get de dados do Forminator, o programa estava crashando
            //...


            //Inser��o dos campos de informa��o dos ultimos usu�rios cadastrados na janela desse programa
            if (newSubmit)
            {
                gridLastSubmits.Rows.Add(envio, nome, email, resultado);
            }
        }

        //Gerenciamento de consumo da API do Forminator, pegando dados dos cadastrados, vai ter que refazer, deu erro e o c�digo anterior parou de funcionar  (Ler documenta��o forminator)
        public void forminatorAPIManager()
        {

            //Declara��o de vari�veis de acesso do Forminator
            //...

            //Recolocar c�digo para acesso do Forminator no site da Select.
            //...

            inveniasAPIManager();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Para atualizar a barra de carregamento
            if (pb_proximaAtualizacao.Value < 100)
            {

                pb_proximaAtualizacao.Value += 10;

            }
            //Quando o timer vai resetar, ele efetua o carregamento de dados
            else
            {
                pb_proximaAtualizacao.Value = 0;
                forminatorAPIManager();
            }

        }

        private void lbl_proximaAtualizacao_Click(object sender, EventArgs e)
        {

        }
    }

}