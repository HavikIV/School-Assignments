#pragma once
#include "baseAddress.h"
#include <iostream>
#include <Windows.h>
#include <string.h>

//global variables
HWND bl2Window = FindWindow(0, _T("Borderlands 2 (32-bit, DX9)")); //finds the bl2 window
HANDLE hProcess;	//handle to the process
DWORD pid;	//holds the Process ID
DWORD baseAddress;	//holds the address for the module, in other words it's the baseAddress for the pointers
int offset1 = 0x01ed4798;	//first offset that is added to the baseAddress, value is the '"Borderlands2.exe" + 01ed4798' in Cheat Engine
// array of arrays, each inner array is a pointer, format: {value, memory location, offset1, offset2, ...}
//{money, eridium, seraph, torgue tokens, weapon decks, backpack size}
int stats[6][4] = { { 0, 0, 0x24, 0x2a0 }, { 0, 0, 0x24, 0x2b4 }, { 0, 0, 0x24, 0x2c8 }, { 0, 0, 0x24, 0x2f0 }, { 0, 0, 0x30, 0x1bc }, { 0, 0, 0x30, 0x1b8 } };
//array for the remaining stats pointers
//bank size, health, health switch, shield, shield switch
int stats2[5][5] = { { 0, 0, 0x30, 0x210, 0x40 }, { float (0.0), 0, 0x24, 0x3ac, 0x6c }, { 0, 0, 0x24, 0x3ac, 0x104 }, { 0, 0, 0x24, 0x3b8, 0x6c }, { 0, 0, 0x24, 0x3b8, 0x104 } };
//float stat pointers
//Health, Shield
float stats3[2][5] = { { 0, 0, 0x24, 0x3ac, 0x6c }, { 0, 0, 0x24, 0x3b8, 0x6c } };
//int pointerList2[1][6] = { { 0, 0x2c, 0xa4, 0xe70, 0x194, 0x138c } };

namespace HelloWorldCGUI {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}		

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^  lblMoney;
	protected:

	protected:

	private: System::Windows::Forms::MenuStrip^  menuStrip1;
	private: System::Windows::Forms::ToolStripMenuItem^  helpToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  aboutToolStripMenuItem;

	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::TabControl^  tabControl1;
	private: System::Windows::Forms::TabPage^  tabPage1;
	private: System::Windows::Forms::TabPage^  tabPage2;
	private: System::Windows::Forms::TextBox^  tbMoney;
	private: System::Windows::Forms::Label^  lblEridium;
	private: System::Windows::Forms::Label^  lblBackpackSize;
	private: System::Windows::Forms::Label^  lblWeaponDecks;
	private: System::Windows::Forms::Label^  lblTorgueTokens;
	private: System::Windows::Forms::Label^  lblSeraph;
	private: System::Windows::Forms::TextBox^  tbBackpackSize;

	private: System::Windows::Forms::TextBox^  tbWeaponDecks;

	private: System::Windows::Forms::TextBox^  tbTorgueTokens;

	private: System::Windows::Forms::TextBox^  tbSeraph;

	private: System::Windows::Forms::TextBox^  tbEridium;
	private: System::Windows::Forms::TextBox^  tbBankSize;
	private: System::Windows::Forms::Label^  lblBankSize;
	private: System::Windows::Forms::Label^  lblShieldSwitch;
	private: System::Windows::Forms::Label^  lblShield;
	private: System::Windows::Forms::TextBox^  tbShieldSwitch;
	private: System::Windows::Forms::TextBox^  tbShield;
	private: System::Windows::Forms::TextBox^  tbHealthSwitch;
	private: System::Windows::Forms::TextBox^  tbHealth;
	private: System::Windows::Forms::Label^  lblHealthSwitch;
	private: System::Windows::Forms::Label^  lblHealth;
	private: System::Windows::Forms::Button^  btReload;








	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->lblMoney = (gcnew System::Windows::Forms::Label());
			this->menuStrip1 = (gcnew System::Windows::Forms::MenuStrip());
			this->helpToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->aboutToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->tabControl1 = (gcnew System::Windows::Forms::TabControl());
			this->tabPage1 = (gcnew System::Windows::Forms::TabPage());
			this->lblShieldSwitch = (gcnew System::Windows::Forms::Label());
			this->lblShield = (gcnew System::Windows::Forms::Label());
			this->tbShieldSwitch = (gcnew System::Windows::Forms::TextBox());
			this->tbShield = (gcnew System::Windows::Forms::TextBox());
			this->tbHealthSwitch = (gcnew System::Windows::Forms::TextBox());
			this->tbHealth = (gcnew System::Windows::Forms::TextBox());
			this->lblHealthSwitch = (gcnew System::Windows::Forms::Label());
			this->lblHealth = (gcnew System::Windows::Forms::Label());
			this->tbBankSize = (gcnew System::Windows::Forms::TextBox());
			this->lblBankSize = (gcnew System::Windows::Forms::Label());
			this->tbBackpackSize = (gcnew System::Windows::Forms::TextBox());
			this->tbWeaponDecks = (gcnew System::Windows::Forms::TextBox());
			this->tbTorgueTokens = (gcnew System::Windows::Forms::TextBox());
			this->tbSeraph = (gcnew System::Windows::Forms::TextBox());
			this->tbEridium = (gcnew System::Windows::Forms::TextBox());
			this->lblBackpackSize = (gcnew System::Windows::Forms::Label());
			this->lblWeaponDecks = (gcnew System::Windows::Forms::Label());
			this->lblTorgueTokens = (gcnew System::Windows::Forms::Label());
			this->lblSeraph = (gcnew System::Windows::Forms::Label());
			this->lblEridium = (gcnew System::Windows::Forms::Label());
			this->tbMoney = (gcnew System::Windows::Forms::TextBox());
			this->tabPage2 = (gcnew System::Windows::Forms::TabPage());
			this->btReload = (gcnew System::Windows::Forms::Button());
			this->menuStrip1->SuspendLayout();
			this->tabControl1->SuspendLayout();
			this->tabPage1->SuspendLayout();
			this->SuspendLayout();
			// 
			// lblMoney
			// 
			this->lblMoney->AutoSize = true;
			this->lblMoney->Location = System::Drawing::Point(17, 27);
			this->lblMoney->Name = L"lblMoney";
			this->lblMoney->Size = System::Drawing::Size(42, 13);
			this->lblMoney->TabIndex = 101;
			this->lblMoney->Text = L"Money:";
			// 
			// menuStrip1
			// 
			this->menuStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) { this->helpToolStripMenuItem });
			this->menuStrip1->Location = System::Drawing::Point(0, 0);
			this->menuStrip1->Name = L"menuStrip1";
			this->menuStrip1->Size = System::Drawing::Size(320, 24);
			this->menuStrip1->TabIndex = 2;
			this->menuStrip1->Text = L"menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			this->helpToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) { this->aboutToolStripMenuItem });
			this->helpToolStripMenuItem->Name = L"helpToolStripMenuItem";
			this->helpToolStripMenuItem->Size = System::Drawing::Size(44, 20);
			this->helpToolStripMenuItem->Text = L"Help";
			// 
			// aboutToolStripMenuItem
			// 
			this->aboutToolStripMenuItem->Name = L"aboutToolStripMenuItem";
			this->aboutToolStripMenuItem->Size = System::Drawing::Size(107, 22);
			this->aboutToolStripMenuItem->Text = L"About";
			this->aboutToolStripMenuItem->Click += gcnew System::EventHandler(this, &MyForm::aboutToolStripMenuItem_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(12, 369);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(0, 13);
			this->label3->TabIndex = 4;
			// 
			// tabControl1
			// 
			this->tabControl1->Controls->Add(this->tabPage1);
			this->tabControl1->Controls->Add(this->tabPage2);
			this->tabControl1->Location = System::Drawing::Point(0, 27);
			this->tabControl1->Name = L"tabControl1";
			this->tabControl1->SelectedIndex = 0;
			this->tabControl1->Size = System::Drawing::Size(320, 339);
			this->tabControl1->TabIndex = 5;
			// 
			// tabPage1
			// 
			this->tabPage1->Controls->Add(this->lblShieldSwitch);
			this->tabPage1->Controls->Add(this->lblShield);
			this->tabPage1->Controls->Add(this->tbShieldSwitch);
			this->tabPage1->Controls->Add(this->tbShield);
			this->tabPage1->Controls->Add(this->tbHealthSwitch);
			this->tabPage1->Controls->Add(this->tbHealth);
			this->tabPage1->Controls->Add(this->lblHealthSwitch);
			this->tabPage1->Controls->Add(this->lblHealth);
			this->tabPage1->Controls->Add(this->tbBankSize);
			this->tabPage1->Controls->Add(this->lblBankSize);
			this->tabPage1->Controls->Add(this->tbBackpackSize);
			this->tabPage1->Controls->Add(this->tbWeaponDecks);
			this->tabPage1->Controls->Add(this->tbTorgueTokens);
			this->tabPage1->Controls->Add(this->tbSeraph);
			this->tabPage1->Controls->Add(this->tbEridium);
			this->tabPage1->Controls->Add(this->lblBackpackSize);
			this->tabPage1->Controls->Add(this->lblWeaponDecks);
			this->tabPage1->Controls->Add(this->lblTorgueTokens);
			this->tabPage1->Controls->Add(this->lblSeraph);
			this->tabPage1->Controls->Add(this->lblEridium);
			this->tabPage1->Controls->Add(this->tbMoney);
			this->tabPage1->Controls->Add(this->lblMoney);
			this->tabPage1->Location = System::Drawing::Point(4, 22);
			this->tabPage1->Name = L"tabPage1";
			this->tabPage1->Padding = System::Windows::Forms::Padding(3);
			this->tabPage1->Size = System::Drawing::Size(312, 313);
			this->tabPage1->TabIndex = 0;
			this->tabPage1->Text = L"Stats";
			this->tabPage1->UseVisualStyleBackColor = true;
			// 
			// lblShieldSwitch
			// 
			this->lblShieldSwitch->AutoSize = true;
			this->lblShieldSwitch->Location = System::Drawing::Point(17, 287);
			this->lblShieldSwitch->Name = L"lblShieldSwitch";
			this->lblShieldSwitch->Size = System::Drawing::Size(74, 13);
			this->lblShieldSwitch->TabIndex = 111;
			this->lblShieldSwitch->Text = L"Shield Switch:";
			// 
			// lblShield
			// 
			this->lblShield->AutoSize = true;
			this->lblShield->Location = System::Drawing::Point(17, 261);
			this->lblShield->Name = L"lblShield";
			this->lblShield->Size = System::Drawing::Size(39, 13);
			this->lblShield->TabIndex = 110;
			this->lblShield->Text = L"Shield:";
			// 
			// tbShieldSwitch
			// 
			this->tbShieldSwitch->Location = System::Drawing::Point(229, 284);
			this->tbShieldSwitch->MaxLength = 9;
			this->tbShieldSwitch->Name = L"tbShieldSwitch";
			this->tbShieldSwitch->Size = System::Drawing::Size(61, 20);
			this->tbShieldSwitch->TabIndex = 11;
			this->tbShieldSwitch->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbShieldSwitch->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbShieldSwitch->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbShieldSwitch->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// tbShield
			// 
			this->tbShield->Location = System::Drawing::Point(229, 258);
			this->tbShield->MaxLength = 9;
			this->tbShield->Name = L"tbShield";
			this->tbShield->Size = System::Drawing::Size(61, 20);
			this->tbShield->TabIndex = 10;
			this->tbShield->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbShield->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbShield->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbShield->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// tbHealthSwitch
			// 
			this->tbHealthSwitch->Location = System::Drawing::Point(229, 232);
			this->tbHealthSwitch->MaxLength = 9;
			this->tbHealthSwitch->Name = L"tbHealthSwitch";
			this->tbHealthSwitch->Size = System::Drawing::Size(61, 20);
			this->tbHealthSwitch->TabIndex = 9;
			this->tbHealthSwitch->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbHealthSwitch->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbHealthSwitch->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbHealthSwitch->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// tbHealth
			// 
			this->tbHealth->Location = System::Drawing::Point(229, 206);
			this->tbHealth->MaxLength = 9;
			this->tbHealth->Name = L"tbHealth";
			this->tbHealth->Size = System::Drawing::Size(61, 20);
			this->tbHealth->TabIndex = 8;
			this->tbHealth->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbHealth->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbHealth->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbHealth->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// lblHealthSwitch
			// 
			this->lblHealthSwitch->AutoSize = true;
			this->lblHealthSwitch->Location = System::Drawing::Point(17, 235);
			this->lblHealthSwitch->Name = L"lblHealthSwitch";
			this->lblHealthSwitch->Size = System::Drawing::Size(76, 13);
			this->lblHealthSwitch->TabIndex = 109;
			this->lblHealthSwitch->Text = L"Health Switch:";
			// 
			// lblHealth
			// 
			this->lblHealth->AutoSize = true;
			this->lblHealth->Location = System::Drawing::Point(17, 209);
			this->lblHealth->Name = L"lblHealth";
			this->lblHealth->Size = System::Drawing::Size(41, 13);
			this->lblHealth->TabIndex = 108;
			this->lblHealth->Text = L"Health:";
			// 
			// tbBankSize
			// 
			this->tbBankSize->Location = System::Drawing::Point(229, 180);
			this->tbBankSize->MaxLength = 9;
			this->tbBankSize->Name = L"tbBankSize";
			this->tbBankSize->Size = System::Drawing::Size(61, 20);
			this->tbBankSize->TabIndex = 7;
			this->tbBankSize->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbBankSize->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbBankSize->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbBankSize->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// lblBankSize
			// 
			this->lblBankSize->AutoSize = true;
			this->lblBankSize->Location = System::Drawing::Point(17, 183);
			this->lblBankSize->Name = L"lblBankSize";
			this->lblBankSize->Size = System::Drawing::Size(58, 13);
			this->lblBankSize->TabIndex = 107;
			this->lblBankSize->Text = L"Bank Size:";
			// 
			// tbBackpackSize
			// 
			this->tbBackpackSize->Location = System::Drawing::Point(229, 154);
			this->tbBackpackSize->MaxLength = 9;
			this->tbBackpackSize->Name = L"tbBackpackSize";
			this->tbBackpackSize->Size = System::Drawing::Size(61, 20);
			this->tbBackpackSize->TabIndex = 6;
			this->tbBackpackSize->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbBackpackSize->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbBackpackSize->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbBackpackSize->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// tbWeaponDecks
			// 
			this->tbWeaponDecks->Location = System::Drawing::Point(229, 128);
			this->tbWeaponDecks->MaxLength = 9;
			this->tbWeaponDecks->Name = L"tbWeaponDecks";
			this->tbWeaponDecks->Size = System::Drawing::Size(61, 20);
			this->tbWeaponDecks->TabIndex = 5;
			this->tbWeaponDecks->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbWeaponDecks->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbWeaponDecks->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbWeaponDecks->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// tbTorgueTokens
			// 
			this->tbTorgueTokens->Location = System::Drawing::Point(229, 102);
			this->tbTorgueTokens->MaxLength = 9;
			this->tbTorgueTokens->Name = L"tbTorgueTokens";
			this->tbTorgueTokens->Size = System::Drawing::Size(61, 20);
			this->tbTorgueTokens->TabIndex = 4;
			this->tbTorgueTokens->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbTorgueTokens->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbTorgueTokens->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbTorgueTokens->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// tbSeraph
			// 
			this->tbSeraph->Location = System::Drawing::Point(229, 76);
			this->tbSeraph->MaxLength = 9;
			this->tbSeraph->Name = L"tbSeraph";
			this->tbSeraph->Size = System::Drawing::Size(61, 20);
			this->tbSeraph->TabIndex = 3;
			this->tbSeraph->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbSeraph->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbSeraph->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbSeraph->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// tbEridium
			// 
			this->tbEridium->Location = System::Drawing::Point(229, 50);
			this->tbEridium->MaxLength = 9;
			this->tbEridium->Name = L"tbEridium";
			this->tbEridium->Size = System::Drawing::Size(61, 20);
			this->tbEridium->TabIndex = 2;
			this->tbEridium->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbEridium->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbEridium->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbEridium->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// lblBackpackSize
			// 
			this->lblBackpackSize->AutoSize = true;
			this->lblBackpackSize->Location = System::Drawing::Point(17, 157);
			this->lblBackpackSize->Name = L"lblBackpackSize";
			this->lblBackpackSize->Size = System::Drawing::Size(82, 13);
			this->lblBackpackSize->TabIndex = 106;
			this->lblBackpackSize->Text = L"Backpack Size:";
			// 
			// lblWeaponDecks
			// 
			this->lblWeaponDecks->AutoSize = true;
			this->lblWeaponDecks->Location = System::Drawing::Point(17, 131);
			this->lblWeaponDecks->Name = L"lblWeaponDecks";
			this->lblWeaponDecks->Size = System::Drawing::Size(85, 13);
			this->lblWeaponDecks->TabIndex = 105;
			this->lblWeaponDecks->Text = L"Weapon Decks:";
			// 
			// lblTorgueTokens
			// 
			this->lblTorgueTokens->AutoSize = true;
			this->lblTorgueTokens->Location = System::Drawing::Point(17, 105);
			this->lblTorgueTokens->Name = L"lblTorgueTokens";
			this->lblTorgueTokens->Size = System::Drawing::Size(83, 13);
			this->lblTorgueTokens->TabIndex = 104;
			this->lblTorgueTokens->Text = L"Torgue Tokens:";
			// 
			// lblSeraph
			// 
			this->lblSeraph->AutoSize = true;
			this->lblSeraph->Location = System::Drawing::Point(17, 79);
			this->lblSeraph->Name = L"lblSeraph";
			this->lblSeraph->Size = System::Drawing::Size(44, 13);
			this->lblSeraph->TabIndex = 103;
			this->lblSeraph->Text = L"Seraph:";
			// 
			// lblEridium
			// 
			this->lblEridium->AutoSize = true;
			this->lblEridium->Location = System::Drawing::Point(17, 53);
			this->lblEridium->Name = L"lblEridium";
			this->lblEridium->Size = System::Drawing::Size(44, 13);
			this->lblEridium->TabIndex = 102;
			this->lblEridium->Text = L"Eridium:";
			// 
			// tbMoney
			// 
			this->tbMoney->Location = System::Drawing::Point(229, 24);
			this->tbMoney->MaxLength = 9;
			this->tbMoney->Name = L"tbMoney";
			this->tbMoney->Size = System::Drawing::Size(61, 20);
			this->tbMoney->TabIndex = 1;
			this->tbMoney->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->tbMoney->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::tbMoney_MouseClick);
			this->tbMoney->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::tbMoney_KeyDown);
			this->tbMoney->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::tbMoney_KeyPress);
			// 
			// tabPage2
			// 
			this->tabPage2->Location = System::Drawing::Point(4, 22);
			this->tabPage2->Name = L"tabPage2";
			this->tabPage2->Padding = System::Windows::Forms::Padding(3);
			this->tabPage2->Size = System::Drawing::Size(312, 313);
			this->tabPage2->TabIndex = 1;
			this->tabPage2->Text = L"tabPage2";
			this->tabPage2->UseVisualStyleBackColor = true;
			// 
			// btReload
			// 
			this->btReload->Location = System::Drawing::Point(233, 368);
			this->btReload->Name = L"btReload";
			this->btReload->Size = System::Drawing::Size(61, 23);
			this->btReload->TabIndex = 6;
			this->btReload->Text = L"Reload";
			this->btReload->UseVisualStyleBackColor = true;
			this->btReload->Click += gcnew System::EventHandler(this, &MyForm::btReload_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(320, 391);
			this->Controls->Add(this->btReload);
			this->Controls->Add(this->tabControl1);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->menuStrip1);
			this->MainMenuStrip = this->menuStrip1;
			this->Name = L"MyForm";
			this->Text = L"Borderlands 2";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->menuStrip1->ResumeLayout(false);
			this->menuStrip1->PerformLayout();
			this->tabControl1->ResumeLayout(false);
			this->tabPage1->ResumeLayout(false);
			this->tabPage1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	
	private: System::Void aboutToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e)
	{
		MessageBox::Show("This is a simple program to test out making a GUI with the .NEt environment like in visual basic.");
	}
private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) 
{
	if (!bl2Window)
	{
		label3->Text = "Borderlands 2 Window not found.";
	}
	else
	{
		GetWindowThreadProcessId(bl2Window, &pid);
		hProcess = OpenProcess(PROCESS_ALL_ACCESS, FALSE, pid);

		if (!hProcess)
		{
			label3->Text = "Can't open the process";
		}
		else
		{
			baseAddress = dwGetModuleBaseAddress(pid, _T("Borderlands2.exe"));
			readMemory(hProcess, baseAddress, offset1, stats, 6);
			readMemory(hProcess, baseAddress, offset1, stats2, 5);
			//readMemory(hProcess, baseAddress, offset1, stats3, 2);

			if (!ReadProcessMemory(hProcess, (void*)stats[0][1], &stats[0][0], sizeof(stats[0][0]), NULL))
			{
				label3->Text = "Failed to read memory.";
			}
			else
			{
				//loads the memory values into the text boxes
				//tbMoney->Text = "" + stats[0][0];
				//tbEridium->Text = "" + stats[1][0];
				//tbSeraph->Text = "" + stats[2][0];
				//tbTorgueTokens->Text = "" + stats[3][0];
				//tbWeaponDecks->Text = "" + stats[4][0];
				//tbBackpackSize->Text = "" + stats[5][0];
				//tbBankSize->Text = "" + stats2[0][0];
				//float health = 0;
				//ReadProcessMemory(hProcess, (void*)stats2[1][1], &health, sizeof(health), NULL);
				//tbHealth->Text = "" + health;
				////tbHealth->Text = "" + stats3[0][0];
				//tbHealthSwitch->Text = "" + stats2[2][0];
				//float shield;
				//ReadProcessMemory(hProcess, (void*)stats2[3][1], &shield, sizeof(shield), NULL);
				//tbShield->Text = "" + shield;
				//tbShieldSwitch->Text = "" + stats2[4][0];
				loadMemory();
			}
		}
	}
}
private: System::Void tbMoney_KeyDown(System::Object^  sender, System::Windows::Forms::KeyEventArgs^  e)
{
	//updates the value in game once it receives the enter key press down event
	if (e->KeyCode == Keys::Enter)
	{
		String^ tbName = safe_cast<TextBox^>(sender)->Name;
		int i = 0;	//variable to store the value from the event sending text box
		int j = 0;	//variable used to get the right memory address
		float k = 0.0;	//variable used to store float value in from the event sending text

		//determines where the event call came from
		for each (Control^ con in tabPage1->Controls)
		{
			if (con->Name == tbName)
			{
				if (con->Name == "tbHealth" || con->Name == "tbShield")
				{
					k = float::Parse(safe_cast<TextBox ^>(sender)->Text);
					j = safe_cast<TextBox ^>(sender)->TabIndex;
					break;
				}
				else
				{
					i = int::Parse(safe_cast<TextBox ^>(sender)->Text);
					j = safe_cast<TextBox ^>(sender)->TabIndex;
					break;
				}
			}
		}

		//if (tbName == "tbMoney")
		//{
		//	i = int::Parse(safe_cast<TextBox^>(sender)->Text);
		//	//i = int::Parse(tbMoney->Text); // string to int
		//	j = 0;
		//}
		//else if (tbName == "tbEridium")
		//{
		//	i = int::Parse(tbEridium->Text); // string to int
		//	j = 1;
		//}
		//else if (tbName == "tbSeraph")
		//{
		//	i = int::Parse(tbSeraph->Text); // string to int
		//	j = 2;
		//}
		//else if (tbName == "tbTorgueTokens")
		//{
		//	i = int::Parse(tbTorgueTokens->Text); // string to int
		//	j = 3;
		//}
		//else if (tbName == "tbWeaponDecks")
		//{
		//	i = int::Parse(tbWeaponDecks->Text); // string to int
		//	j = 4;
		//}
		//else if (tbName == "tbBackpackSize")
		//{
		//	i = int::Parse(tbBackpackSize->Text); // string to int
		//	j = 5;
		//}
		//else if (tbName == "tbBankSize")
		//{
		//	i = int::Parse(tbBankSize->Text); // string to int
		//	j = 6;
		//}
		//else if (tbName == "tbHealth")
		//{
		//	k = float::Parse(tbHealth->Text); // string to int
		//	j = 7;
		//}
		//else if (tbName == "tbHealthSwitch")
		//{
		//	i = int::Parse(tbHealthSwitch->Text); // string to int
		//	j = 8;
		//}
		//else if (tbName == "tbShield")
		//{
		//	i = int::Parse(tbShield->Text); // string to int
		//	j = 9;
		//}
		//else if (tbName == "tbShieldSwitch")
		//{
		//	i = int::Parse(tbShieldSwitch->Text); // string to int
		//	j = 10;
		//}

		if (i > 0)
		{
			WriteProcessMemory(hProcess, (void*)stats[j - 1][1], (void*)&i, (DWORD)sizeof(i), NULL);	//write to memory
			ReadProcessMemory(hProcess, (void*)stats[j - 1][1], &stats[j - 1][0], sizeof(stats[j - 1][0]), NULL); //rereads memory to update the label
		}
		else
		{
			if (j == 8 || j == 10)
			{
				WriteProcessMemory(hProcess, (void*)stats2[j - 7][1], (void*)&k, (DWORD)sizeof(k), NULL);	//write to memory, writes as a float
			}
			else
			{
				WriteProcessMemory(hProcess, (void*)stats2[j - 7][1], (void*)&i, (DWORD)sizeof(i), NULL);	//write to memory
			}
			ReadProcessMemory(hProcess, (void*)stats2[j - 7][1], &stats2[j - 7][0], sizeof(stats2[j - 7][0]), NULL); //rereads memory to update the label
		}
		
		//Reload the text boxes
		loadMemory();
		//if (tbName == "tbMoney")
		//{
		//	tbMoney->Text = "" + stats[j][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
		//else if (tbName == "tbEridium")
		//{
		//	tbEridium->Text = "" + stats[j][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
		//else if (tbName == "tbSeraph")
		//{
		//	tbSeraph->Text = "" + stats[j][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
		//else if (tbName == "tbTorgueTokens")
		//{
		//	tbTorgueTokens->Text = "" + stats[j][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
		//else if (tbName == "tbWeaponDecks")
		//{
		//	tbWeaponDecks->Text = "" + stats[j][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
		//else if (tbName == "tbBackpackSize")
		//{
		//	tbBackpackSize->Text = "" + stats[j][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
		//else if (tbName == "tbBankSize")
		//{
		//	tbBankSize->Text = "" + stats2[j-6][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
		//else if (tbName == "tbHealth")
		//{
		//	tbHealth->Text = "" + stats2[j-6][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
		//else if (tbName == "tbHealthSwitch")
		//{
		//	tbHealthSwitch->Text = "" + stats2[j-6][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
		//else if (tbName == "tbShield")
		//{
		//	tbShield->Text = "" + stats2[j-6][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
		//else if (tbName == "tbShieldSwitch")
		//{
		//	tbShieldSwitch->Text = "" + stats2[j-6][0]; //updates the text box to current value
		//	Focus(); //text box loses focus
		//}
	}
}
private: System::Void tbMoney_KeyPress(System::Object^  sender, System::Windows::Forms::KeyPressEventArgs^  e)
{
	//Only accepts numbers
	if (!Char::IsDigit(e->KeyChar) && e->KeyChar != 0x08){
		e->Handled = true;
	}
	else
	{
		e->Handled = false;
	}
}
private: System::Void tbMoney_MouseClick(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e)
{
	//selects all of the text when the text box is clicked
	String^ tbName = safe_cast<TextBox^>(sender)->Name;
	if (tbName == "tbMoney")
	{
		tbMoney->SelectionStart = 0;
		tbMoney->SelectionLength = tbMoney->TextLength;
	}
	else if (tbName == "tbEridium")
	{
		tbEridium->SelectionStart = 0;
		tbEridium->SelectionLength = tbEridium->TextLength;
	}
	else if (tbName == "tbSeraph")
	{
		tbSeraph->SelectionStart = 0;
		tbSeraph->SelectionLength = tbSeraph->TextLength;
	}
	else if (tbName == "tbTorgueTokens")
	{
		tbTorgueTokens->SelectionStart = 0;
		tbTorgueTokens->SelectionLength = tbTorgueTokens->TextLength;
	}
	else if (tbName == "tbWeaponDecks")
	{
		tbWeaponDecks->SelectionStart = 0;
		tbWeaponDecks->SelectionLength = tbWeaponDecks->TextLength;
	}
	else if (tbName == "tbBackpackSize")
	{
		tbBackpackSize->SelectionStart = 0;
		tbBackpackSize->SelectionLength = tbBackpackSize->TextLength;
	}
	else if (tbName == "tbBankSize")
	{
		tbBankSize->SelectionStart = 0;
		tbBankSize->SelectionLength = tbBankSize->TextLength;
	}
	else if (tbName == "tbHealth")
	{
		tbHealth->SelectionStart = 0;
		tbHealth->SelectionLength = tbHealth->TextLength;
	}
	else if (tbName == "tbHealthSwitch")
	{
		tbHealthSwitch->SelectionStart = 0;
		tbHealthSwitch->SelectionLength = tbHealthSwitch->TextLength;
	}
	else if (tbName == "tbShield")
	{
		tbShield->SelectionStart = 0;
		tbShield->SelectionLength = tbShield->TextLength;
	}
	else if (tbName == "tbShieldSwitch")
	{
		tbShieldSwitch->SelectionStart = 0;
		tbShieldSwitch->SelectionLength = tbShieldSwitch->TextLength;
	}
}

private: System::Void loadMemory()
{
	tbMoney->Text = "" + stats[0][0];
	tbEridium->Text = "" + stats[1][0];
	tbSeraph->Text = "" + stats[2][0];
	tbTorgueTokens->Text = "" + stats[3][0];
	tbWeaponDecks->Text = "" + stats[4][0];
	tbBackpackSize->Text = "" + stats[5][0];
	tbBankSize->Text = "" + stats2[0][0];
	float health = 0;
	ReadProcessMemory(hProcess, (void*)stats2[1][1], &health, sizeof(health), NULL);
	tbHealth->Text = "" + health;
	//tbHealth->Text = "" + stats3[0][0];
	tbHealthSwitch->Text = "" + stats2[2][0];
	float shield;
	ReadProcessMemory(hProcess, (void*)stats2[3][1], &shield, sizeof(shield), NULL);
	tbShield->Text = "" + shield;
	tbShieldSwitch->Text = "" + stats2[4][0];
}
private: System::Void btReload_Click(System::Object^  sender, System::EventArgs^  e)
{
	loadMemory();
}
};
}
