﻿namespace Trajectories
{
#if DEBUG
    public class TrajectoriesDebug : PartModule
	{
		[KSPField(isPersistant = false, guiActive = true)]
		public float Drag;

		[KSPField(isPersistant = false, guiActive = true)]
		public float Lift;
	}
	#endif
}
