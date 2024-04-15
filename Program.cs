using System;
using Microsoft.CognitiveServices.Speech;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var config = SpeechConfig.FromSubscription("YOUR_SUBSCRIPTION_KEY", "YOUR_REGION");
        using var synthesizer = new SpeechSynthesizer(config);
        
        Console.WriteLine("Digite o texto para conversão:");
        var text = Console.ReadLine();

        using var result = await synthesizer.SpeakTextAsync(text);
        if (result.Reason == ResultReason.SynthesizingAudioCompleted)
        {
            Console.WriteLine($"Conversão para áudio concluída. Reproduzindo o áudio...");
            var audioStream = AudioDataStream.FromResult(result);
            audioStream.SaveToWaveFile("output.wav");
            
        }
        else if (result.Reason == ResultReason.Canceled)
        {
            var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
            Console.WriteLine($"Erro na conversão: {cancellation.Reason}");
        }
    }
}
