using Terraria.ModLoader;

namespace EverCraze
{
	class EverCraze : Mod
	{
		public EverCraze()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
