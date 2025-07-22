#https://neetcode.io/problems/valid-sudoku?list=neetcode150
class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        # This approach uses sets. But it would be the same complexity as if it used
        # HashTables. Instead of doing set() for _ you could just do {} for _ that
        # the same result would be achieved. The only difference is that you would
        # need to use rows[i][key] = somevalue
        # Set uses some implementations from hashtable, which allows it to perform some operations in O(1)
        rows = [set() for _ in range(9)]       # 9 sets for 9 rows
        cols = [set() for _ in range(9)]       # 9 sets for 9 columns
        boxes = [set() for _ in range(9)]      # 9 sets for 9 boxes

        for i in range(9):
            for j in range(9):
                cell = board[i][j]

                if board[i][j] != ".":
                    box_index = (i // 3) * 3 + (j // 3)
                    if (cell in rows[i] or
                        cell in cols[j] or 
                        cell in boxes[box_index]
                        ): 
                        return False

                    rows[i].add(cell)
                    cols[j].add(cell)
                    boxes[box_index].add(cell)
                
        return True