# exemplo-upload-arquivos-aspnet-mvc-6

Os dois trechos de código fornecem exemplos de como lidar com o upload de arquivos em um aplicativo web ASP.NET MVC.

O MultipleUpload, responsável por lidar com o upload de múltiplos arquivos para o servidor. Ele possui dois métodos principais: MultipleUpload, que exibe a página de upload múltiplo, e MultipleUpload, que processa o formulário submetido com os arquivos para upload. O código dentro do método MultipleUpload verifica se há arquivos para upload, cria um diretório para armazená-los, gera nomes únicos para cada arquivo e os salva no servidor. Em seguida, ele configura mensagens de sucesso ou erro, dependendo do resultado do processo, e retorna a mesma página de upload múltiplo com o modelo atualizado.

O SingleUpload, que lida com o upload de um único arquivo para o servidor. Ele também possui dois métodos principais: SingleUpload, que exibe a página de upload único, e SingleUpload, que processa o formulário submetido com o arquivo para upload. Assim como no primeiro trecho, o código verifica se o modelo é válido, cria um diretório para armazenar o arquivo, gera um nome único para o arquivo e o salva no servidor. Em seguida, ele configura uma mensagem de sucesso ou erro e retorna a mesma página de upload único com o modelo atualizado.

Ambos utilizam a mesma lógica para lidar com o processo de upload de arquivos, diferindo apenas na quantidade de arquivos que podem ser enviados de uma só vez. Esses exemplos ilustram como implementar funcionalidades de upload de arquivos em um aplicativo ASP.NET MVC, utilizando os recursos fornecidos pelo framework.
