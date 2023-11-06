using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.ArrayAndHashing;

public class ValidSudoku : Problem, ISolution
{
    public string Title => "Valid Sudoku";

    private bool IsValidSudoku(char[][] board)
    {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<(int, int), HashSet<char>>();

        for (var r = 0; r < 9; r++)
        {
            rows[r] = new HashSet<char>();

            for (var c = 0; c < 9; c++)
            {
                if (!cols.ContainsKey(c))
                {
                    cols[c] = new HashSet<char>();
                }

                if (!squares.ContainsKey((r / 3, c / 3)))
                {
                    squares[(r / 3, c / 3)] = new HashSet<char>();
                }

                if (board[r][c] == '.')
                {
                    continue;
                }

                // check if its exists in row, col, and squares
                if (rows[r].Contains(board[r][c]) || cols[c].Contains(board[r][c]) || squares[(r / 3, c / 3)].Contains(board[r][c]))
                {
                    return false;
                }
                rows[r].Add(board[r][c]);
                cols[c].Add(board[r][c]);
                squares[(r / 3, c / 3)].Add(board[r][c]);
            }
        }

        return true;
    }

    public string Answer()
    {
        char[][] grid = new char[][]
        {
            new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };
        return $"Is Valid sudoku: {(IsValidSudoku(grid) ? "YES" : "NO")}";
    }
}
