;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
; Manjinder Singh
; CSCI 273-5299
; Fall 2014
; Assignment 6 - Page 238, #1
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.data
upperLimit byte 100					;upper limit for the random number
lowerLimit byte 1					;lower limit for the random number

.data?
fillArray dword 10 dup(?)

.code
main proc
	mov edi, offset fillArray		;points to the fillArray
	mov ecx, lengthof fillArray		;number of elements for fillArray, used as the loop counter
	mov bl, upperLimit				;the upper limit
	movzx si, lowerLimit			;the lower limit
	L1:
		call randGen				;calls the randGen procedure
		movzx eax, al				;shouldn't need this step if the random number is properly generated.
		mov dword ptr [edi], eax	;moves the random number in eax to the fillArray
		add edi, 4 
		loop L1
	invoke ExitProcess,0
main endp

randGen proc
	mov ah, 0h						;moves 0 to the ah register

	mov ax, dx						;moves whatever happens to be in the dx register to the ax register
	xor dx, dx						;does the XOR bitwise comparison on the dx register
	movzx bx, bl					;unsigned extends the bl register into the bx register, can avoid this step by originally doing so before calling the procedure
	div bx							;divides the ax register by the  bx register, stores the quotient into ax and the remainder into dx

	mov ax, dx						;copies the dx register into the ax register
	div  bx							;divides the ax register by the  bx register once again, stores the quotient into ax and the remainder into dx

	mov eax, edx					;copies the edx register into the eax register
	add  eax, esi					;adds the esi, the lower limit, to eax
RET
randGen endp
end main