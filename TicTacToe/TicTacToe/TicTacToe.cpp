// TicTacToe.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include "tictactoe.h"

using namespace std;


int main()
{
	tictactoe game;
	game.printBoard();

	game.makeMove(1,1,'X');
	game.printBoard();

	game.makeMove(0,0,'O');
	game.printBoard();

	game.makeMove(1,2,'X');
	game.printBoard();

	game.makeMove(0,1,'O');
	game.printBoard();

	game.makeMove(0,2,'X');
	game.printBoard();

	game.makeMove(2,2,'O');
	game.printBoard();

	game.makeMove(1,0,'X');
	game.printBoard();

	if (game.deterWinner())
		cout << "WE HAVE A WINNER!" << endl;
	else
		cout << "No Winner" << endl;


	return 0;
}

