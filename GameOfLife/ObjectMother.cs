using System.Collections.Generic;

namespace GameOfLife
{
    public static class ObjectMother
    {
        public static List<(int y, int x)> Block => new List<(int y, int x)>
        {
            (1, 1),
            (1, 2),
            (2, 1),
            (2, 2)
        };

        public static List<(int y, int x)> Beehive => new List<(int y, int x)>
        {
            (1, 2),
            (1, 3),
            (2, 1),
            (2, 4),
            (3, 2),
            (3, 3)
        };

        public static List<(int y, int x)> Loaf => new List<(int y, int x)>
        {
            (1, 2),
            (1, 3),
            (2, 1),
            (2, 4),
            (3, 2),
            (3, 4),
            (4, 3)
        };
        public static List<(int y, int x)> Boat => new List<(int y, int x)>
        {
            (1, 1),
            (1, 2),
            (2, 1),
            (2, 3),
            (3, 2),
        };

        public static List<(int y, int x)> Tub => new List<(int y, int x)>
        {
            (1, 2),
            (2, 1),
            (2, 3),
            (3, 2)
        };

        public static List<(int y, int x)>[] Blinker => new [] {
            new List<(int y, int x)>
            {
                (2, 1),
                (2, 2),
                (2, 3)
            },
            new List<(int y, int x)>
            {
                (1, 2),
                (2, 2),
                (3, 2)
            }
        };

        public static List<(int y, int x)>[] Toad => new [] {
            new List<(int y, int x)>
            {
                (2, 2),
                (2, 3),
                (2, 4),
                (3, 3),
                (3, 4),
                (3, 5)
            },
            new List<(int y, int x)>
            {
                (1, 3),
                (2, 2),
                (2, 5),
                (3, 2),
                (3, 5),
                (4, 4)
            }
        };


        public static List<(int y, int x)>[] Beacon => new [] {
            new List<(int y, int x)>
            {
                (1, 1),
                (1, 2),
                (2, 1),
                (2, 2),
                (3, 3),
                (3, 4),
                (4, 3),
                (4, 4)
            },
            new List<(int y, int x)>
            {
                (1, 1),
                (1, 2),
                (2, 1),
                (3, 4),
                (4, 3),
                (4, 4)
            }
        };

        public static List<(int y, int x)> Glider => new List<(int y, int x)>
        {
            (1, 2),
            (2, 3),
            (3, 1),
            (3, 2),
            (3, 3)
        };
    }
}
