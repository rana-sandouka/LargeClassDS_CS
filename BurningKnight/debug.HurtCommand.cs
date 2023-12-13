	public class HurtCommand : ConsoleCommand {
		public HurtCommand() {
			_Init();
		}

		protected void _Init() {
			{
				Name = "hurt";
				ShortName = "o";
			}
		}

		public override void Run(Console Console, string[] Args) {
			foreach (var player in Console.GameArea.Tagged[Tags.Player]) {
				player.GetComponent<HealthComponent>().ModifyHealth(-1, player);
			}
		}
	}