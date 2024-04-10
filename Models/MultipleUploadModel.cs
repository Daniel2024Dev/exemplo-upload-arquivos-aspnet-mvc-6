using System.ComponentModel.DataAnnotations;// Importa o namespace para usar as anotações de validação

namespace Ex_data_base_com_imagem_e_arquivos.Models;// Namespace do modelo

public class MultipleUploadModel : ReponseModel// Declaração da classe MultipleUploadModel, que herda de ReponseModel
{
   // Anotação de validação: campo Files é obrigatório e exibe a mensagem de erro se estiver vazio
   [Required(ErrorMessage = "Please select files")]
    public List<IFormFile> Files { get; set; }// Propriedade Files do tipo List<IFormFile> para armazenar os arquivos
}
