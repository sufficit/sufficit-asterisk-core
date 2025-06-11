namespace Sufficit.Asterisk
{
    /// <summary>
    ///     Asterisk Version
    /// </summary>
    public enum AsteriskVersion
    {
        Unknown = 0,
        ASTERISK_1_0 = 10,
        ASTERISK_1_2 = 12,
        ASTERISK_1_4 = 14,
        ASTERISK_1_6 = 16,
        ASTERISK_1_8 = 18,
        ASTERISK_10 = 100,

        /// <summary>
        ///     Indicates a unknown version equals or before than 10 <br />
        ///     It is a key change for variables delimeters
        /// </summary>
        ASTERISK_Older = 101,

        ASTERISK_11 = 110,
        ASTERISK_12 = 120,
        ASTERISK_13 = 130,
        ASTERISK_14 = 140,
        ASTERISK_15 = 150,
        ASTERISK_16 = 160,
        ASTERISK_17 = 170,
        ASTERISK_18 = 180,
        ASTERISK_19 = 190,
        ASTERISK_20 = 200,
        ASTERISK_21 = 210,
        ASTERISK_22 = 220,

        /// <summary>
        ///     Indicates a unknown version newer than 22
        /// </summary>
        ASTERISK_Newer = 999
    }
}
