using System;

namespace Lab4Task3
{
    // [Flags] дозволяє комбінувати значення через бітові маски.
    // Значення мають бути степенями двійки: 1, 2, 4, 8
    [Flags]
    public enum AccessLevels
    {
        None = 0,
        Office = 1,
        ServerRoom = 2,
        Vault = 4,
        Lab = 8
    }
}