;Manjinder Singh
;lab3 assignment, Problem 4 on page 138
;moves the contents of warray array to the dwarray array

.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.data
warray word 1, 2, 3, 4, 5, 6, 7, 8
dwarray dword ?
count equ lengthof warray ; gets the length of the array warray

.code
main proc
	mov ecx, count	; sets the counter for that's going to be used by the loop.
	mov esi, 0		; sets the index = 0 for the array warray
	mov ebx, 0		; sets the index = 0 for the array dwarray

	copy:
		movzx eax, warray[esi]	; copys the element at the index [esi] as an unsigned 32-bit value to the eax register
		mov dwarray[ebx], eax	; copys the contents of the eax register to the dwarray at the index [ebx]
		add esi, 2				; increments the index for the warray by 2, as warray is an array of word elements (2 bytes)
		add ebx, 4				; increments the index for the dwarray by 4, as dwarray is an array of double word elements (4 bytes)
		loop copy				; calls the loop, jumps to the label copy, and decrements the ecx register until it's equals 0

	invoke ExitProcess,0
main endp
end main