	public class HealCommand : ConsoleCommand {
		public HealCommand() {
			_Init();
		}

		protected void _Init() {
			{
				Name = "heal";
				ShortName = "h";
			}
		}

		public override void Run(Console Console, string[] Args) {
			foreach (var player in Console.GameArea.Tagged[Tags.Player]) {
				var component = player.GetComponent<HealthComponent>();
				component.SetHealth(component.MaxHealth, null);
			}		
		}
	}