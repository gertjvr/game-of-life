using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    public static class Game
    {
        private static readonly (int y, int x)[] Neighbours =
        {
            (-1, -1), (0, -1), (1, -1),
            (-1,  0),          (1,  0),
            (-1,  1), (0,  1), (1,  1)
        };

        public static List<(int y, int x)> Generate((int y, int x) min, (int y, int x) max, double percentage)
        {
            var dice = new Random();

            var cells = new List<(int y, int x)>();

            for (var y = min.y; y < max.y; y++)
            for (var x = min.x; x < max.x; x++)
                if (dice.NextDouble() <= percentage) cells.Add((y, x));

            return cells;
        }

        public static List<(int y, int x)> Next(this List<(int y, int x)> cells)
        {
            var next = new List<(int y, int x)>();

            for (var y = cells.Min(c => c.y) - 1; y <= cells.Max(c => c.y) + 1; y++)
            for (var x = cells.Min(c => c.x) - 1; x <= cells.Max(c => c.x) + 1; x++)
            {
                var neighboursCount = Neighbours
                    .Select(c => cells.Contains((c.y + y, c.x + x)) ? 1 : 0)
                    .Sum();

                var alive = cells.Contains((y, x));

                // 1. Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
                // 2. Any live cell with more than three live neighbours dies, as if by overcrowding.

                // 3. Any live cell with two or three live neighbours lives on to the next generation.
                if (alive && (neighboursCount == 2 || neighboursCount == 3)) next.Add((y, x));

                // 4. Any dead cell with exactly three live neighbours becomes a live cell.
                if (!alive && neighboursCount == 3) next.Add((y, x));
            }

            return next;
        }

        public static object Window(this List<(int y, int x)> cells, (int y, int x) min, (int y, int x) max)
        {
            var table = "<table>";

            table += "<thead>";
            table += "<tr>";
            table += "<th></th>";

            for (var y = min.y; y < max.y; y++)
                table += $"<th>{y}</th>";

            table += "</tr>";
            table += "</thead>";
            table += "<tbody>";
            for (var y = min.y; y < max.y; y++)
            {
                table += "<tr>";
                table += $"<td>{y}</td>";

                for (var x = min.x; x < max.x; x++)
                {
                    var value = cells.Contains((y, x)) ? 'x' : 'o';
                    table += $"<td>{value}</td>";
                }

                table += "</tr>";
            }

            table += "</tbody>";
            table += "</table>";

            return table;
        }
    }
}
