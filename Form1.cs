using ExemploPJe.PJeTRF3;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

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
            buscarProcesso();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            entregarProcesso();
        }

        private void entregarProcesso()
        {
            try
            {
                string[] tipoDocumento = new string[] { };

                string mensagem, protocoloRecebimento, dataOperacao;
                byte[] recibo;
                tipoParametro[] tipoParametro;

                servicointercomunicacao222Client ws = new servicointercomunicacao222Client();

                ws.entregarManifestacaoProcessual(txtUsuario.Text,
                                                  txtSenha.Text,
                                                  txtProcesso.Text,
                                                  new tipoCabecalhoProcesso(),
                                                  tipoDocumento,
                                                  string.Empty,
                                                  null,
                                                  out mensagem,
                                                  out protocoloRecebimento,
                                                  out dataOperacao,
                                                  out recibo,
                                                  out tipoParametro);
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
        }

        private void buscarProcesso()
        {
            tipoProcessoJudicial processo = new tipoProcessoJudicial();

            try
            {
                servicointercomunicacao222Client ws = new servicointercomunicacao222Client();
                
                consultarProcesso inValue = new consultarProcesso();

                string mensagem;
                tipoProcessoJudicial tipoProcesso;

                ws.consultarProcesso(txtUsuario.Text,
                                    txtSenha.Text,
                                    txtProcesso.Text,
                                    string.Empty, 
                                    true, 
                                    true, 
                                    true, 
                                    null, 
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
