using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploPJe.Negocio
{

    public class FiltroEntregarManifestacaoProcessual
    {
        public string IdManifestante { get; set; }
        public string SenhaManifestante { get; set; }

        public string ClasseProcessual { get; set; }
        public string CodigoLocalidade { get; set; }
        public string Competencia { get; set; }
        public string ProcessoVinculado { get; set; }
        public string ModalidadeVinculacaoProcesso { get; set; }
        public string Prioridade { get; set; }
        public string ValorCausa { get; set; }
        public string AssistenciaJudiciaria { get; set; }
        public string NivelSigilo { get; set; }
        public string DataAjuizamento { get; set; }
        public string OutroParametro { get; set; }

        public string Polo { get; set; }

        public FiltroEntregarManifestacaoProcessualParte Parte { get; set; }

        /*
        
         * 
         * ----endereço
         * cep
         * logradouro
         * numero
         * complemento
         * bairro
         * cidade
         * estado
         * pais
         * 
         * ----representante
         * intimacao
         * nome
         * inscricao
         * numeroDocumentoPrincipal
         * tipoRepresentante
         * 
         * ----asunto
         * principal
         * codigoNacional
         * assuntoLocal	
         * assuntoLocalPai
         * codigoAssunto
         * codigoPaiNacional
         * descricao
         * 
         * ----documento
         * idDocumento
         * idDocumentoVinculado
         * tipoDocumento
         * dataHora
         * descricao
         * hash
         * nivelSigilo
         * tipoDocumento
         * conteudo
         * mimetype
         * 
         * ----assinatura
         * assinatura
         * algoritmoHash
         * cadeiaCertificado
         * codificacaoCertificado
         * dataAssinatura
         * signatarioLogin
         * 
         * 
         */
    }

    public class FiltroEntregarManifestacaoProcessualParte
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string NomeGenitor { get; set; }
        public string NomeGenitora { get; set; }
        public string DataNascimento { get; set; }
        public string DataObito { get; set; }
        public string NumeroDocumentoPrincipal { get; set; }
        public string TipoPessoa { get; set; }
        public string PessoaVinculada { get; set; }
        public string CidadeNatural { get; set; }
        public string EstadoNatural { get; set; }
        public string Nacionalidade { get; set; }
        public string CodigoDocumento { get; set; }
        public string EmissorDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Nome2 { get; set; }
        public string OutroNome { get; set; }
    }

    public class FiltroEntregarManifestacaoProcessualEndereco
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string NomeGenitor { get; set; }
        public string NomeGenitora { get; set; }
        public string DataNascimento { get; set; }
        public string DataObito { get; set; }
        public string NumeroDocumentoPrincipal { get; set; }
        public string TipoPessoa { get; set; }
        public string PessoaVinculada { get; set; }
        public string CidadeNatural { get; set; }
        public string EstadoNatural { get; set; }
        public string Nacionalidade { get; set; }
        public string CodigoDocumento { get; set; }
        public string EmissorDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Nome2 { get; set; }
        public string OutroNome { get; set; }
    }

    public interface IEntregarManifestacaoProcessual
    {
        string Executar(FiltroEntregarManifestacaoProcessual pFiltro);
    }

    public class EntregarManifestacaoProcessual : IEntregarManifestacaoProcessual
    {
        public string Executar(FiltroEntregarManifestacaoProcessual pFiltro)
        {
            string result = string.Empty;
            try
            {
                //PJeTRF3.servicointercomunicacao222Client client = new PJeTRF3.servicointercomunicacao222Client();
                //client.consultarProcesso(pFiltro.IdConsultante, pFiltro.SenhaConsultante, pFiltro.NumeroProcesso, pFiltro.DataReferencia, pFiltro.Movimentos, pFiltro.IncluirCabecalho, pFiltro.IncluirDocumentos, pFiltro.Documento, out mensagem, out tipoProcesso);
            }
            catch (Exception ex)
            {
                result = $"Não foi possível entregar a manifestação processual. {ex.Message}";
            }

            return result;
        }
    }
}
