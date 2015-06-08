;Manjinder Singh
;lab3 assignment, Problem 6 on page 138
;reverses the contents the array, using a loop, and also making use of LenghtOf, Type, and SizeOf opertors

.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.data
array word 1, 2, 3, 4, 5, 6, 7
count equ lengthof array / 2	; gets the number elements in the array, well half of the lenght of the array.
elementType equ type array		; gets the amount of bytes each elements consists of in the array
arraySize equ sizeof array		; gets the total amount of bytes in the array

.code
main proc
	mov ecx, count				; sets the counter for that's going to be used by the loop.
	mov esi, 0					; sets the index = 0 for the array
	mov ebx, arraySize			; sets ebx to the number of total bytes in the array
	sub ebx, elementType		; subtracts the number of bytes each element consists of, so that the register ebx is set to the offset of the last element of the array.

	Reverse:
        movzx eax, array[ebx]	; copys the element at the index [esi] as an unsigned 32-bit value to the eax register
        xchg ax, array[esi]		; exchanges the values of the ax register and the element at the index [esi]
        mov array[ebx], ax		; copys the contents of ax register into the array at the index [ebx]
        add esi, elementType	; increments the index for the array by elementType, which it gets with the TYPE opertor, in this case, it's 2
        sub ebx, elementType	; increments the index for the array by elementType, which it gets with the TYPE opertor, in this case, it's 2
        loop Reverse			; calls the loop, jumps to the label Reverse, and decrements the ecx register until it's equals 0

	invoke ExitProcess,0
main endp
end main