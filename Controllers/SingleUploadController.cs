using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ex_data_base_com_imagem_e_arquivos.Models;

namespace Ex_data_base_com_imagem_e_arquivos.Controllers
{
    public class SingleUploadController : Controller
    {
        // Método para exibir a página de upload único
        public IActionResult SingleUpload()
        {
            // Cria uma instância do modelo SingleUploadModel
            SingleUploadModel model = new SingleUploadModel();
            return View(model); // Retorna a View com o modelo
        }

        // Método para lidar com o upload único de arquivo
        [HttpPost]
        public IActionResult SingleUpload(SingleUploadModel imagem)
        {
            if (ModelState.IsValid) // Verifica se o modelo é válido
            {
                imagem.IsResponse = true; // Define a flag IsResponse como verdadeira

                // Diretório onde as imagens serão salvas
                string CaminhoImagens = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/ImagesMain");

                // Gera um novo nome para o arquivo para evitar nomes duplicados
                string NovoNomeParaImagens = Guid.NewGuid().ToString();

                // Cria a pasta se ela não existir
                if (!Directory.Exists(CaminhoImagens))
                    Directory.CreateDirectory(CaminhoImagens);

                // Obtém a extensão do arquivo
                FileInfo fileInfo = new FileInfo(imagem.File.FileName);

                // Concatena o nome da imagem com o novo nome e a extensão do arquivo
                string NomeImagens = imagem.FileName + "_" + NovoNomeParaImagens + fileInfo.Extension;

                // Caminho completo para salvar a imagem
                string SalvarImagens = Path.Combine(CaminhoImagens, NomeImagens);

                // Copia o arquivo para o local de destino
                using (var stream = new FileStream(SalvarImagens, FileMode.Create))
                {
                    imagem.File.CopyTo(stream);
                }

                // Configurações para exibir a mensagem de sucesso na View
                imagem.IsSuccess = true;
                imagem.Message = "File upload successfully";
            }

            // Retorna a View "SingleUpload" com o modelo
            return View("SingleUpload", imagem);
        }
    }
}
