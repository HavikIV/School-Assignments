//header file for the TicTacToe class

class tictactoe
{
public:
	void printBoard() const;
		//function to out the board

	void makeMove(int, int, char);
		//Function to make a move

	bool vaildMove(int row, int column);
		//Function to check if the move is vaild
		//return true if it's a vaild move else return false

	bool deterWinner();
		//Function to determine the winner
		//return true if there is a winner else false

	void setCell(int, int, char);
		//Function to set the cells in the board

	char getCell(int, int);
		//function to get the cell

	tictactoe();
		//default constructor
		//sets cells to '*'

private:
	char board[3][3];

};
