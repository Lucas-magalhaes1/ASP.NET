# ASP.NET

- **Nome do Framework:** ASP.NET
- **Ano de Lançamento:** 2002
- **Desenvolvedor:** Microsoft
- **Linguagem de Programação:** Principalmente C#
- **Quando é recomendado utilizar o framework:** O ASP.NET é recomendado para o desenvolvimento de uma ampla gama de aplicativos web, desde pequenos sites até grandes aplicações empresariais. É especialmente útil quando se trabalha em um ambiente Microsoft ou .NET.

## Principais Características:
1. **Desenvolvimento Rápido:** O ASP.NET oferece diversas ferramentas e componentes para acelerar o desenvolvimento web, como controles de servidor, bibliotecas de código e integração com o Visual Studio.
2. **Segurança Integrada:** Possui recursos de segurança integrados, como autenticação e autorização, prevenção contra ataques CSRF e XSS, e suporte para criptografia.
3. **Escalabilidade:** Pode ser dimensionado facilmente para atender às demandas crescentes de tráfego e carga de trabalho, com suporte para balanceamento de carga, cache e escalabilidade horizontal.

- **Vídeos Recomendado:** [ASP.NET](https://www.youtube.com/watch?v=J_YTQEmMaGU&list=PLHlHvK2lnJncl6eGo9Qt66qIumaq6oP58&pp=iAQB)
- **Site Oficial:** [ASP.NET](https://dotnet.microsoft.com/apps/aspnet)


- ## Experimento: Converter Texto em Áudio

- 1. **Configuração do Ambiente:**
   - Certifique-se de ter uma chave de assinatura válida para os Serviços Cognitivos da Microsoft.
   - Para obter uma chave de assinatura:
     1. Crie uma conta da Microsoft, se você ainda não tiver uma.
     2. Acesse o portal do Azure em [https://portal.azure.com/](https://portal.azure.com/).
     3. Crie um recurso de Serviços Cognitivos.
     4. Obtenha a chave de assinatura do recurso criado.
     5. Anote a chave de assinatura e a região do recurso.

2. **Baixar o Código Fonte:**
   - Baixe o código fonte do arquivo `TextToSpeechController.cs`.

3. **Configurando a Chave de Assinatura:**
   - Abra o arquivo `TextToSpeechController.cs`.
   - Substitua `"YOUR_SUBSCRIPTION_KEY"` pela sua chave de assinatura obtida no portal do Azure.
   - Substitua `"YOUR_REGION"` pela região onde sua assinatura está registrada.

4. **Executando o Código:**
   - Execute o projeto ASP.NET na IDE.
   - Após o lançamento do aplicativo, pode enviar solicitações HTTP POST para o endpoint do controlador de API `TextToSpeech` para converter texto em áudio.
   - O áudio resultante será retornado como uma resposta HTTP no formato WAV.
