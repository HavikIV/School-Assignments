;Manjinder Singh
;lab2 assignment

.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.data
dVal dword 12345678h
dVal2 dword ?

.code
main proc
	;problem 5
	mov al, 1	
	add al, 3	;PE = 0

	;problem 6
	mov eax, 5
	sub eax, 6	;eax = FFFFFFFFh, PL = 1

	;problem 7
	mov al, -1
	add al, 130	; as the val was already negative, when adding 130 it becomes 129, which is outrange so the OV doesn't change.

	;problem 10
	mov ax, 3
	mov word ptr dVal+2, ax
	mov eax, dVal	; eax = 35678h

	;problem 11
	mov dVal2, 12345678h
	mov ax, word ptr dVal2+2
	add ax, 3
	mov word ptr dVal2, ax
	mov eax, dVal2	; eax = 12341237h


	invoke ExitProcess,0
main endp
end main