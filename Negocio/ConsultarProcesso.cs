using System;

namespace ExemploPJe.Negocio
{

    public class FiltroConsultarProcesso
    {
        public string IdConsultante { get; set; }
        public string SenhaConsultante { get; set; }
        public string NumeroProcesso { get; set; }
        public string DataReferencia { get; set; }
        public bool Movimentos { get; set; }
        public bool IncluirCabecalho { get; set; }
        public bool IncluirDocumentos { get; set; }
        public string[] Documento { get; set; }
    }

    public interface IConsultarProcesso
    {
        string Executar(FiltroConsultarProcesso pFiltro);
    }

    public class ConsultarProcesso : IConsultarProcesso
    {

        public string Executar(FiltroConsultarProcesso pFiltro)
        {
            string result = string.Empty;

            string mensagem;
            PJeTRF3.tipoProcessoJudicial tipoProcesso = null;
            string[] tipoDocumento = null;

            try
            {
                PJeTRF3.servicointercomunicacao222Client client = new PJeTRF3.servicointercomunicacao222Client();
                client.consultarProcesso(pFiltro.IdConsultante, 
                                         pFiltro.SenhaConsultante, 
                                         pFiltro.NumeroProcesso, 
                                         pFiltro.DataReferencia, 
                                         pFiltro.Movimentos, 
                                         pFiltro.IncluirCabecalho, 
                                         pFiltro.IncluirDocumentos, 
                                         tipoDocumento, 
                                         out mensagem, 
                                         out tipoProcesso);
            }
            catch (Exception ex)
            {
                result = $"Não foi possível consultar o processo. {ex.Message}";
            }

            return result;
        }

    }
}
