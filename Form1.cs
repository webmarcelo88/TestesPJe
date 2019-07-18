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
        }

        private void Testar()
        {
            string idConsultante = "02482451558";
            string senhaConsultante = "Fis2047a";
            string numeroProcesso = "8000597-16.2019.8.05.0141";

            string dataReferencia = "";
            bool movimentos = false;
            bool incluirCabecalho = false;
            bool incluirDocumentos = false;
            PJeTRF3.tipoDocumento documento = null;

            string mensagem;
            PJeTRF3.tipoProcessoJudicial tipoProcesso;

            try
            {

                PJeTRF3.servicointercomunicacao222Client client = new PJeTRF3.servicointercomunicacao222Client();

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
    }
}
