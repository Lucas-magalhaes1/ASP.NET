using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CognitiveServices.Speech;

namespace TextToSpeech
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextToSpeechController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string text)
        {
            var config = SpeechConfig.FromSubscription("YOUR_SUBSCRIPTION_KEY", "YOUR_REGION");
            using var synthesizer = new SpeechSynthesizer(config);

            using var result = await synthesizer.SpeakTextAsync(text);
            if (result.Reason == ResultReason.SynthesizingAudioCompleted)
            {
                var audioStream = AudioDataStream.FromResult(result);
                return File(audioStream, "audio/wav", "output.wav");
            }
            else if (result.Reason == ResultReason.Canceled)
            {
                var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
                return BadRequest($"Erro na conversão: {cancellation.Reason}");
            }

            return BadRequest("Erro desconhecido na conversão de texto para áudio.");
        }
    }
}
