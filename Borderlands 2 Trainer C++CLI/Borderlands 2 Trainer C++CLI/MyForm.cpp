#include "MyForm.h"
#include "baseAddress.h"
#include <Windows.h>
#include <Windows.Applicationmodel.Activation.h>

using namespace System;
using namespace System::Windows::Forms;

//This is used to run GUIs for programs, in other it's the Windows Main function
int CALLBACK WinMain(_In_  HINSTANCE hInstance, _In_  HINSTANCE hPrevInstance, _In_  LPSTR lpCmdLine, _In_  int nCmdShow) //the parameters are defined in Windows.h
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	HelloWorldCGUI::MyForm form;
	Application::Run(%form);
	return 0;
	
}

//int main() is used to run in console not ideal for running a program with it's own User Interface
//int main()
//{
//	//hiding the console window
//	//ShowWindow(GetConsoleWindow(), SW_HIDE);
//	FreeConsole(); //this is the not recommended way to hide the console but I don;t how of another method.
//	//displaying the form I made
//	Application::EnableVisualStyles();
//	Application::SetCompatibleTextRenderingDefault(false);
//	HelloWorldCGUI::MyForm form;
//	Application::Run(%form);
//	return 0;
//}