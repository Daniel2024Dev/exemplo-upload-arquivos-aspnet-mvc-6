namespace Ex_data_base_com_imagem_e_arquivos.Models
{
    // Classe que representa o modelo de erro para exibição em views
    public class ErrorViewModel
    {
        // Propriedade que armazena o identificador da requisição
        public string? RequestId { get; set; }

        // Método que indica se o identificador da requisição deve ser mostrado
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
