;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
; Manjinder Singh
; CSCI 273-5299
; Fall 2014
; Assignment 5 - Page 187, #2
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.data
	start dword 1
	charsArray byte 'H', 'A', 'C', 'E', 'B', 'D', 'F', 'G'
	links dword 0, 4, 5, 6, 2, 3, 7, 0
.data?
	charsOutput byte 7 DUP(?) ;suppose have the following by the end of the program {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'}

.code
main proc
	

	invoke ExitProcess,0
main endp
end main