	public class SpawnCommand : ConsoleCommand {
		public SpawnCommand() {
			Name = "spawn";
			ShortName = "s";
		}
		
		public override void Run(Console Console, string[] Args) {
			if (Args.Length != 1) {
				Console.Print("Usage: spawn [entity]");
				return;
			}

			var name = Args[0];
			var small = name.ToLower();

			foreach (var type in EntityEditor.Types) {
				if (type.Name.ToLower() == small) {
					try {
						var entity = (Entity) Activator.CreateInstance(type.Type);
						Console.GameArea.Add(entity);
						entity.BottomCenter = Console.GameArea.Tagged[Tags.Player][0].BottomCenter;
					} catch (Exception e) {
						Log.Error(e);
						Console.Print($"Failed to create entity {name}, consult @egordorichev");
					}
					
					return;
				}
			}
			
			Console.Print($"Unknown entity {name}");
		}
	}