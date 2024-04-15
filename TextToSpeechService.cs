public static class TextToSpeechService
    {
        private const string SubscriptionKey = "YOUR_SUBSCRIPTION_KEY";
        private const string Region = "YOUR_REGION";

        public static async Task<MemoryStream> ConvertTextToSpeechAsync(string text)
        {
            var config = SpeechConfig.FromSubscription(SubscriptionKey, Region);
            using var synthesizer = new SpeechSynthesizer(config);

            using var result = await synthesizer.SpeakTextAsync(text);
            if (result.Reason == ResultReason.SynthesizingAudioCompleted)
            {
                var audioStream = AudioDataStream.FromResult(result);
                var memoryStream = new MemoryStream();
                await audioStream.CopyToAsync(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);
                return memoryStream;
            }
            else if (result.Reason == ResultReason.Canceled)
            {
                var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
                throw new Exception($"Erro na conversão: {cancellation.Reason}");
            }

            throw new Exception("Erro desconhecido na conversão de texto para áudio.");
        }
    }
}
