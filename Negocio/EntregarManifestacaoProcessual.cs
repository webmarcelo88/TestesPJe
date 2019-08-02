using System;

namespace ExemploPJe.Negocio
{

    public class EntregarManifestacaoProcessualComponent
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

        public EntregarManifestacaoProcessualParte Parte { get; set; }

        public EntregarManifestacaoProcessualEndereco Endereco { get; set; }

        public EntregarManifestacaoProcessualRepresentante Representante { get; set; }

        public EntregarManifestacaoProcessualAssunto Assunto { get; set; }

        public EntregarManifestacaoProcessualDocumento Documento { get; set; }
    }

    public class EntregarManifestacaoProcessualParte
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

    public class EntregarManifestacaoProcessualEndereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }

    public class EntregarManifestacaoProcessualRepresentante
    {
        public string Intimacao { get; set; }
        public string Nome { get; set; }
        public string Inscricao { get; set; }
        public string NumeroDocumentoPrincipal { get; set; }
        public string TipoRepresentante { get; set; }
    }

    public class EntregarManifestacaoProcessualAssunto
    {
        public string Principal { get; set; }
        public string CodigoNacional { get; set; }
        public string AssuntoLocal { get; set; }
        public string AssuntoLocalPai { get; set; }
        public string CodigoAssunto { get; set; }
        public string CodigoPaiNacional { get; set; }
        public string Descricao { get; set; }
    }

    public class EntregarManifestacaoProcessualDocumento
    {
        public string IdDocumento { get; set; }
        public string IdDocumentoVinculado { get; set; }
        public string TipoDocumento { get; set; }
        public string DataHora { get; set; }
        public string Descricao { get; set; }
        public string Hash { get; set; }
        public string NivelSigilo { get; set; }
        public string Conteudo { get; set; }
        public string Mimetype { get; set; }
    }

    public class EntregarManifestacaoProcessualAssinatura
    {
        public string Assinatura { get; set; }
        public string AlgoritmoHash { get; set; }
        public string CadeiaCertificado { get; set; }
        public string CodificacaoCertificado { get; set; }
        public string DataAssinatura { get; set; }
        public string SignatarioLogin { get; set; }
    }

    public interface IEntregarManifestacaoProcessual
    {
        string Executar(EntregarManifestacaoProcessualComponent pComponent);
    }

    public class EntregarManifestacaoProcessual : IEntregarManifestacaoProcessual
    {
        public string Executar(EntregarManifestacaoProcessualComponent pComponent)
        {
            string result = string.Empty;
            try
            {
                //PJeTRF3.servicointercomunicacao222Client client = new PJeTRF3.servicointercomunicacao222Client();
                //client.entregarManifestacaoProcessual(pComponent.IdManifestante,
                //                                      pComponent.SenhaManifestante,
                //                                      pComponent.ClasseProcessual,
                //                                      );
            }
            catch (Exception ex)
            {
                result = $"Não foi possível entregar a manifestação processual. {ex.Message}";
            }

            return result;
        }
    }
}
