	public static class CheatWindow {
		public static bool AutoGodMode = BK.Version.Dev;
		public static bool InfiniteActive;
		public static bool NoSleep;
		
		public static void Render() {
			if (!WindowManager.Cheats) {
				return;
			}

			if (!ImGui.Begin("Cheats", ImGuiWindowFlags.AlwaysAutoResize)) {
				ImGui.End();
				return;
			}

			var player = LocalPlayer.Locate(Engine.Instance.State.Area);

			if (player != null) {
				ImGui.Checkbox("God Mode", ref player.GetComponent<HealthComponent>().Unhittable);
			}
			

			if (ImGui.Checkbox("Auto god mode", ref AutoGodMode) && player != null) {
				player.GetComponent<HealthComponent>().Unhittable = AutoGodMode;
			}
			
			ImGui.Separator();

			if (ImGui.Checkbox("Infinite active charge", ref InfiniteActive) && player != null && InfiniteActive) {
				player.GetComponent<InventoryComponent>().Pickup(Items.CreateAndAdd("bk:battery", player.Area));
			}
			
			ImGui.Checkbox("No Sleep", ref NoSleep);
			
			ImGui.End();
		}
	}