using Timer = System.Windows.Forms.Timer;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;
using System.IO;
using RestSharp;
using RestSharp.Authenticators;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


//O sistema espera por 20 segundos para efetuar a busca no site, e para depois efetuar a conexão com a API do Invenias e tentar colocar os novos dados

/*Documentações:
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

        //Declaração de variáveis
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
        //Eu preferi colocar os dados como estáticos, mas é possível colocar eles dinâmicos, só tem que criar uma nova janela para logar, e armazenar os dados no cache do Windows
        public void inveniasAPIManager()
        {

            //Declaraçãod e variáveis de consumo de API
            string thirdPartyApplicationUrl = (inveniasUrl + ""); //Vai precisar para criar uma ThirdPartyApplication para 2 dos dados abaixo.
            string authenticationUrl = (inveniasUrl + "identity/connect/token");
            string username = ""; //Email da Select com cargos de ADM para acessar os dados
            string password = ""; //Senha do Email
            string client_id = ""; //Perdi os dados das aplicações que fiz do Invenias, só precisa criar uma nova via ThirdPartyApplication
            string client_secret = ""; //Esse dado e o acima é através da aplicação ThirdParty
            string grant_type = "password";
            string scope = "openid profile api email";

            string authorization = ""; //É a key que precisa ser gerada, vai ser pega após a autorização.
            //Passos: 1. Post de ThirdPartyApplication, 2. Post de Autorização, 3. Consumo.

            //Declaração de variáveis de indentificação de campos no Invenias
            string envio = "";
            string nome = "";
            string email = "";
            string resultado = ""; //Cadastrado - Novo candidato cadastrado; Atualizado - Já havia candidato cadastrado, dados foram atualizados; Erro - Algo deu errado.

            /*var client = new RestClient(inveniasUrl + ""* parou de funcionar );
            var request = new RestRequest(Method.POST); Essa linha também começou a dar problema
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");*/

            //Essa parte deu problema por conta que algo mudou no get de dados do Forminator, o programa estava crashando
            //...


            //Inserção dos campos de informação dos ultimos usuários cadastrados na janela desse programa
            if (newSubmit)
            {
                gridLastSubmits.Rows.Add(envio, nome, email, resultado);
            }
        }

        //Gerenciamento de consumo da API do Forminator, pegando dados dos cadastrados, vai ter que refazer, deu erro e o código anterior parou de funcionar  (Ler documentação forminator)
        public void forminatorAPIManager()
        {

            //Declaração de variáveis de acesso do Forminator
            //...

            //Recolocar código para acesso do Forminator no site da Select.
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