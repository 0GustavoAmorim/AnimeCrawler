using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;


namespace AnimeCrawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            var wc = new WebClient();

            string urlBase = wc.DownloadString("https://ww4.gogoanime2.org/watch/boruto-naruto-next-generations/");


            var htmlDocument = new HtmlAgilityPack.HtmlDocument();

            htmlDocument.LoadHtml(urlBase);

            dataGridView1.Rows.Clear();



            var episodiosNode = htmlDocument.DocumentNode.SelectSingleNode("//ul[@id='episode_related']");

            if (episodiosNode != null)
            {
                int qtdEpisodios = episodiosNode.SelectNodes("./li").Count;

                for (int i = 1; i <= qtdEpisodios; i++)
                {

                    var novoHtml = htmlDocument.LoadHtml(urlBase + i.ToString());


                    var iframeNode = htmlDocument.DocumentNode.SelectSingleNode("//iframe[@id='playerframe']");

                    string iframeHtml = iframeNode.OuterHtml;

                    dataGridView1.Rows.Add($"Episódio: {i}", iframeHtml);

                }
            }
            else
            {
                Console.WriteLine("A lista de episódios não foi encontrada com o ID especificado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


//< iframe allowfullscreen = "true"id = "playerframe" src = "https://goone.pro/streaming.php?id=MjEyODg5&amp;title=Kamierabi+Episode+1&amp;typesub=SUB" style = "width: 100%;" ></ iframe >




//var iframeNode = htmlDocument.DocumentNode.SelectSingleNode("//iframe[@id='playerframe']");

//if (iframeNode != null)
//{
//    string iframeHtml = iframeNode.OuterHtml;

//    dataGridView1.Rows.Add("Video Player", "", iframeHtml, "");
//}



// pega a quantidade geral de epísódios

//var episodiosNode = htmlDocument.DocumentNode.SelectSingleNode("//ul[@id='episode_related']");

//if (episodiosNode != null)
//{
//    int qtdEpisodios = episodiosNode.SelectNodes("./li").Count;

//    dataGridView1.Rows.Add("Quantidade de Episódios", qtdEpisodios.ToString(), "", "");
//}
//else