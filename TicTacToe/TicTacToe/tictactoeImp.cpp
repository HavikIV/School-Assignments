//Implenmentation file for tictactoe class

#include "stdafx.h"
#include "tictactoe.h"
#include <iostream>

using namespace std;

void tictactoe::printBoard() const
{
	cout << "Current TicTacToe Board" << endl;
	for (int row = 0; row < 3; row++)
	{
		for (int column = 0; column < 3; column++)
		{
			cout << board[row][column] << " ";
		}
		cout << endl;
	}
}

void tictactoe::makeMove(int row, int column, char player)
{
	tictactoe::setCell(row, column, player);
}

bool tictactoe::vaildMove(int row, int column)
{
	if (board[row][column] == '*')
		return true;
	else
		return false;

}

bool tictactoe::deterWinner()
{
	//rows
	if (board[0][0] == board[0][1] && board[0][0] == board[0][2])
		return true;
	else if (board[1][0] == board[1][1] && board[1][0] == board[1][2])
		return true;
	else if (board[2][0] == board[2][1] && board[2][0] == board[2][2])
		return true;

	//columns
	if (board[0][0] == board[1][0] && board[0][0] == board[2][0])
		return true;
	else if (board[1][0] == board[1][1] && board[1][0] == board[1][2])
		return true;
	else if (board[2][0] == board[2][1] && board[2][0] == board[2][2])
		return true;

	//diagonals
	if (board[0][0] == board[1][1] && board[0][0] == board[2][2])
		return true;
	else if (board[0][2] == board[1][1] && board[0][1] == board[2][0])
		return true;
	else
		//no winner
		return false;

}

void tictactoe::setCell(int row, int column, char player)
{
	bool check = tictactoe::vaildMove(row, column);
	if (check)
		board[row][column] = player;
	else
		board[row][column] = player;
}

char tictactoe::getCell(int row, int column)
{
	return board[row][column];
}

tictactoe::tictactoe()
{
	for (int row = 0; row < 3; row++)
	{
		for (int column = 0; column < 3; column++)
		{
			board[row][column] = '*';
		}
	}
}