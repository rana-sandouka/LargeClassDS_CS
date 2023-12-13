	public class GodModeCommand : ConsoleCommand {
		public GodModeCommand() {
			_Init();
		}

		protected void _Init() {
			{
				Name = "gm";
				ShortName = "g";
			}
		}

		public override void Run(Console Console, string[] Args) {
			var all = Console.GameArea.Tagged[Tags.Player];
			
			foreach (var player in all) {
				var health = player.GetComponent<HealthComponent>();
				health.Unhittable = !health.Unhittable;
				
				TextParticle.Add(player, "God Mode", 1, true, !health.Unhittable);
				Console.Print(health.Unhittable ? "God mode is on" : "God mode is off");
			}			
		}
	}