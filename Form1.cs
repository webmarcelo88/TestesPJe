using ExemploPJe.PJe;
using System;
using System.Windows.Forms;

namespace ExemploPJe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Testar();
            //Testar_PJE_TJMT();
        }

        private void Testar()
        {
            string idConsultante = "75293730215";
            string senhaConsultante = "admin123";
            string numeroProcesso = "1002111-71.2018.8.11.0051";

            string dataReferencia = "";
            bool movimentos = false;
            bool incluirCabecalho = false;
            bool incluirDocumentos = false;
            tipoDocumento documento = null;

            string mensagem;
            tipoProcessoJudicial tipoProcesso;

            try
            {

                servicointercomunicacao222Client client = new servicointercomunicacao222Client();
                var result = client.consultarProcesso(idConsultante,
                                                      senhaConsultante,
                                                      numeroProcesso,
                                                      dataReferencia,
                                                      movimentos,
                                                      incluirCabecalho,
                                                      incluirDocumentos,
                                                      documento,
                                                      out mensagem,
                                                      out tipoProcesso);

                //string auxMensagem = ((result) ? "Consulta de processo executada com sucesso. " : "Erro ao executar consulta de processo");
                //MessageBox.Show($"{auxMensagem}{Environment.NewLine}{mensagem}{Environment.NewLine}Processo: {tipoProcesso.dadosBasicos.numero}");

            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
        }

        private void Testar_PJE_TJMT()
        {
            string idConsultante = "";
            string senhaConsultante = "";
            string numeroProcesso = "1002111-71.2018.8.11.0051";

            string dataReferencia = "";
            bool movimentos = false;
            bool incluirCabecalho = false;
            bool incluirDocumentos = false;
            string[] documento = null;

            string mensagem;
            PJeTMT.tipoProcessoJudicial tipoProcesso;

            try
            {

                PJeTMT.servicointercomunicacao222Client client = new PJeTMT.servicointercomunicacao222Client();
                var result = client.consultarProcesso(idConsultante,
                                                      senhaConsultante,
                                                      numeroProcesso,
                                                      dataReferencia,
                                                      movimentos,
                                                      incluirCabecalho,
                                                      incluirDocumentos,
                                                      documento,
                                                      out mensagem,
                                                      out tipoProcesso);

            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
        }
    }
}
