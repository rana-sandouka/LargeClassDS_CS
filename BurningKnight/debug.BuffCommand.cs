	public class BuffCommand : ConsoleCommand {
		public BuffCommand() {
			ShortName = "bf";
			Name = "buff";
		}

		public override void Run(Console Console, string[] Args) {
			if (Args.Length > 0 && Args.Length < 2) {
				var id = Args[0];

				if (!id.Contains(":")) {
					id = $"{Mods.BurningKnight}:{id}";
				}

				var player = LocalPlayer.Locate(Console.GameArea);
				player.GetComponent<BuffsComponent>().Add(id).TimeLeft = 128;
			}
		}
	}