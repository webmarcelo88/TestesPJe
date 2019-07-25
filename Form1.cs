using ExemploPJe.PJeTRF3;
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
            try
            {
                string numeroProcesso = "8000597-16.2019.8.05.0141";
                buscarProcesso(numeroProcesso);
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
        }

        private static tipoProcessoJudicial buscarProcesso(string num)
        {
            tipoProcessoJudicial processo = new tipoProcessoJudicial();

            try
            {
                servicointercomunicacao222Client ws = new servicointercomunicacao222Client();
                
                consultarProcesso inValue = new consultarProcesso();
                inValue.numeroProcesso = num;

                string mensagem = "";
                tipoProcessoJudicial tipoProcesso = new tipoProcessoJudicial();
                consultarProcessoResponse retVal = new consultarProcessoResponse();
                mensagem = retVal.mensagem;
                tipoProcesso = retVal.processo;
                //string[] documento = inValue.documento;

                bool passa = ws.consultarProcesso("teste", "teste", inValue.numeroProcesso, "", true, true, true, null, out mensagem, out tipoProcesso);

                return processo;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu algum erro na integração com o ts. " + ex.Message);
            }
        }

    }
}
