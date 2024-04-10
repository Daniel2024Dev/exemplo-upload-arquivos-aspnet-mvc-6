namespace Ex_data_base_com_imagem_e_arquivos.Models
{
    // Classe base para modelos de resposta
    public class ReponseModel
    {
        // Mensagem a ser exibida na resposta
        public string? Message { get; set; }
        
        // Indica se a operação foi bem-sucedida
        public bool IsSuccess { get; set; }
        
        // Indica se houve alguma resposta
        public bool IsResponse { get; set; }
    }
}
