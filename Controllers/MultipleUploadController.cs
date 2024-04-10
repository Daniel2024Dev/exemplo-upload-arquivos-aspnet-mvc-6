using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ex_data_base_com_imagem_e_arquivos.Models;

namespace Ex_data_base_com_imagem_e_arquivos.Controllers
{
    public class MultipleUploadController : Controller
    {
        // Método para exibir a página de upload múltiplo
        public IActionResult MultipleUpload()
        {
            // Criação de uma instância do modelo MultipleUploadModel
            MultipleUploadModel model = new MultipleUploadModel();
            return View(model); // Retorna a View com o modelo
        }

        // Método para lidar com o upload múltiplo de arquivos
        [HttpPost]
        public IActionResult MultipleUpload(MultipleUploadModel model)
        {
            if (ModelState.IsValid) // Verifica se o modelo é válido
            {
                model.IsResponse = true; // Define a flag IsResponse como verdadeira

                if (model.Files.Count > 0) // Verifica se há arquivos para fazer upload
                {
                    // Loop através de cada arquivo na lista de arquivos
                    foreach (var file in model.Files)
                    {
                        // Diretório onde os arquivos serão salvos
                        string CaminhoImagens = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/ImagesMain");

                        // Cria a pasta se ela não existir
                        if (!Directory.Exists(CaminhoImagens))
                            Directory.CreateDirectory(CaminhoImagens);

                        // Gera um novo nome para o arquivo para evitar nomes duplicados
                        string NovoNomeParaImagens = Guid.NewGuid().ToString() + "_" + file.FileName;

                        // Caminho completo para salvar o arquivo
                        string SalvarImagens = Path.Combine(CaminhoImagens, NovoNomeParaImagens);

                        // Copia o arquivo para o local de destino
                        using (var stream = new FileStream(SalvarImagens, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }

                    // Configurações para exibir a mensagem de sucesso na View
                    model.IsSuccess = true;
                    model.Message = "Files upload successfully";
                }
                else
                {
                    // Configurações para exibir a mensagem de erro na View
                    model.IsSuccess = false;
                    model.Message = "Please select files";
                }
            }

            // Retorna a View "MultipleUpload" com o modelo
            return View("MultipleUpload", model);
        }
    }
}
