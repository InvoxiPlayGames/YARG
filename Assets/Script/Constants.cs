using YARG.Data;

namespace YARG {
	public static class Constants {
		public static readonly YargVersion VERSION_TAG = YargVersion.Parse("v0.10.0");

		// General
		public const float HIT_MARGIN = 0.095f;
		// Guitar
		public const float STRUM_LENIENCY = 0.065f;
		public const bool ANCHORING = true;
		public const bool INFINITE_FRONTEND = false;
		public const bool ANCHOR_CHORD_HOPO = true;
		public const bool EASY_TAP_RECOVERY = true;
		// Guitar - Anti-ghosting
		public const int EXTRA_ALLOWED_GHOSTS = 0;
		public const bool ALLOW_DESC_GHOSTS = true;
		public const bool ALLOW_GHOST_IF_NO_NOTES = true; // seems to allow more ghosting than it should...
		public const float ALLOW_GHOST_IF_NO_NOTES_THRESHOLD = 1.5f;
	}
}