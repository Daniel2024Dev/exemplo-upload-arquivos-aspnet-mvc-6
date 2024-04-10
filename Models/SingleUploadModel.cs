using System.ComponentModel.DataAnnotations;

namespace Ex_data_base_com_imagem_e_arquivos.Models
{
    // Modelo para upload único de arquivo
    public class SingleUploadModel : ReponseModel
    {
        // Nome do arquivo
        [Required(ErrorMessage = "Please enter file name")]
        public string? FileName { get; set; }
        
        // Arquivo a ser enviado
        [Required(ErrorMessage = "Please select file")]
        public IFormFile File { get; set; }
    }
}
