	[ContentProcessor(DisplayName = "Audio Processor")]
	public class AudioProcessor : ContentProcessor<AudioFile, AudioFile> {
		public override AudioFile Process(AudioFile input, ContentProcessorContext context) {
			return input;
		}
	}