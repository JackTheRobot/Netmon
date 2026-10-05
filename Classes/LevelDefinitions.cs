namespace Netmon.Classes
{
    public static class LevelDefinitions
    {
        // This class defines the experience thresholds for different levels.
        // Netmons start on level 0. GetLevelFromEXP is designed to return in this way.

        public static int[] ExperienceThresholds { get; } =
        {
            1000,
            2000,
            3000
        };

        public static int GetLevelFromEXP(int exp)
        {
            for (int i = 0;  i < ExperienceThresholds.Length; i++)
            {
                if (ExperienceThresholds[i] > exp) return i;
            }

            return 0;
        }
    }
}
