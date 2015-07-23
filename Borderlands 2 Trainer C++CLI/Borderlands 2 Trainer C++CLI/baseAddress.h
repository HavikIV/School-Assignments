// Header for the functions to get base address of a module and to read memory address for pointers
#pragma once

#include "stdafx.h"
#include <Windows.h>
#include <TlHelp32.h>

using namespace std;

//function to get the base address
DWORD dwGetModuleBaseAddress(DWORD dwProcessIdentifier, TCHAR *lpszModuleName)
{
	HANDLE hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE, dwProcessIdentifier);
	DWORD dwModuleBaseAddress = 0;
	if (hSnapshot != INVALID_HANDLE_VALUE)
	{
		MODULEENTRY32 ModuleEntry32 = { 0 };
		ModuleEntry32.dwSize = sizeof(MODULEENTRY32);
		if (Module32First(hSnapshot, &ModuleEntry32))
		{
			do
			{
				if (_tcscmp(ModuleEntry32.szModule, lpszModuleName) == 0)
				{
					dwModuleBaseAddress = (DWORD)ModuleEntry32.modBaseAddr;
					break;
				}
			} while (Module32Next(hSnapshot, &ModuleEntry32));
		}
		CloseHandle(hSnapshot);
	}
	return dwModuleBaseAddress;
}

////function to read memory for array[][3], 1 offsets
//void readMemory(HANDLE hProcess, DWORD baseAddress, int offset, int pointerList[][3])
//{
//	//for loop to read the memory for each pointer given an arary of arrays.
//	for (int i = 0; i < sizeof(pointerList) - 1; i++)
//	{
//		ReadProcessMemory(hProcess, (LPCVOID)(baseAddress + offset), &pointerList[i][0], sizeof(pointerList[i][0]), NULL);
//		for (int j = 1; j < sizeof(pointerList[i]) - 1; j++)
//		{
//			ReadProcessMemory(hProcess, (LPCVOID)(pointerList[i][0] + pointerList[i][j]), &pointerList[i][0], sizeof(pointerList[i][0]), NULL);
//		}
//	}
//}

//function to read memory for array[][4], 2 offsets
void readMemory(HANDLE hProcess, DWORD baseAddress, int offset, int pointerList[][4], int rows)
{
	//for loop to read the memory for each pointer given an array of arrays.
	for (int i = 0; i < rows; i++)
	{
		ReadProcessMemory(hProcess, (LPCVOID)(baseAddress + offset), &pointerList[i][1], sizeof(pointerList[i][1]), NULL);
		for (int j = 2; j < 4; j++)
		{
			if (j == 3)
			{
				ReadProcessMemory(hProcess, (LPCVOID)(pointerList[i][1] + pointerList[i][j]), &pointerList[i][0], sizeof(pointerList[i][0]), NULL);
				pointerList[i][1] += pointerList[i][j];
			}
			else
			{
				ReadProcessMemory(hProcess, (LPCVOID)(pointerList[i][1] + pointerList[i][j]), &pointerList[i][1], sizeof(pointerList[i][1]), NULL);
			}
		}
	}
}

//function to read memory for array[][5], 3 offsets
void readMemory(HANDLE hProcess, DWORD baseAddress, int offset, int pointerList[][5], int rows)
{
	//for loop to read the memory for each pointer given an array of arrays.
	for (int i = 0; i < rows; i++)
	{
		ReadProcessMemory(hProcess, (LPCVOID)(baseAddress + offset), &pointerList[i][1], sizeof(pointerList[i][1]), NULL);
		for (int j = 2; j < 5; j++)
		{
			if (j == 4)
			{
				ReadProcessMemory(hProcess, (LPCVOID)(pointerList[i][1] + pointerList[i][j]), &pointerList[i][0], sizeof(pointerList[i][0]), NULL);
				pointerList[i][1] += pointerList[i][j];
			}
			else
			{
				ReadProcessMemory(hProcess, (LPCVOID)(pointerList[i][1] + pointerList[i][j]), &pointerList[i][1], sizeof(pointerList[i][1]), NULL);
			}
		}
	}
}

//function to read memory for array[][5], 3 offsets, float values
void readMemory(HANDLE hProcess, DWORD baseAddress, int offset, float pointerList[][5], int rows)
{
	float x;
	//for loop to read the memory for each pointer given an array of arrays.
	for (int i = 0; i < rows; i++)
	{
		ReadProcessMemory(hProcess, (LPCVOID)(baseAddress + offset), &pointerList[i][1], sizeof(pointerList[i][1]), NULL);
		for (int j = 2; j < 5; j++)
		{
			if (j == 4)
			{
				ReadProcessMemory(hProcess, (LPCVOID)(int(pointerList[i][1] + pointerList[i][j])), &pointerList[i][0], sizeof(pointerList[i][0]), NULL);
				pointerList[i][1] += pointerList[i][j];
			}
			else
			{
				ReadProcessMemory(hProcess, (LPCVOID)(int(pointerList[i][1] + pointerList[i][j])), &pointerList[i][1], sizeof(pointerList[i][1]), NULL);
			}
		}
	}
}

//function to read memory for array[][6], 4 offsets
void readMemory(HANDLE hProcess, DWORD baseAddress, int offset, int pointerList[][6], int rows)
{
	//for loop to read the memory for each pointer given an array of arrays.
	for (int i = 0; i < rows; i++)
	{
		ReadProcessMemory(hProcess, (LPCVOID)(baseAddress + offset), &pointerList[i][1], sizeof(pointerList[i][1]), NULL);
		for (int j = 2; j < 6; j++)
		{
			if (j == 5)
			{
				ReadProcessMemory(hProcess, (LPCVOID)(pointerList[i][1] + pointerList[i][j]), &pointerList[i][0], sizeof(pointerList[i][0]), NULL);
				pointerList[i][1] += pointerList[i][j];
			}
			else
			{
				ReadProcessMemory(hProcess, (LPCVOID)(pointerList[i][1] + pointerList[i][j]), &pointerList[i][1], sizeof(pointerList[i][1]), NULL);
			}
		}
	}
}

//function to read memory for array[][7], 5 offsets
void readMemory(HANDLE hProcess, DWORD baseAddress, int offset, int pointerList[][7], int rows)
{
	//for loop to read the memory for each pointer given an array of arrays.
	for (int i = 0; i < rows; i++)
	{
		ReadProcessMemory(hProcess, (LPCVOID)(baseAddress + offset), &pointerList[i][1], sizeof(pointerList[i][1]), NULL);
		for (int j = 2; j < 7; j++)
		{
			if (j == 6)
			{
				ReadProcessMemory(hProcess, (LPCVOID)(pointerList[i][1] + pointerList[i][j]), &pointerList[i][0], sizeof(pointerList[i][0]), NULL);
				pointerList[i][1] += pointerList[i][j];
			}
			else
			{
				ReadProcessMemory(hProcess, (LPCVOID)(pointerList[i][1] + pointerList[i][j]), &pointerList[i][1], sizeof(pointerList[i][1]), NULL);
			}
		}
	}
}