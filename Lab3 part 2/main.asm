;Manjinder Singh
;lab4 assignment, Problem 5 on page 138
;loop to find the first 7 numbers of the Fibonacci Numbers


.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.data
fibarray dword 1, 1 ;probably should have made it into an unitialized array of 7 elements and later added the first two elements in the main code before the loop.
					;Didn't need to make an dword array either, a byte array would have worked also.

.code
main proc
	mov ecx, 5		; sets the counter for the loop to be 5 as we already know the first numbers of the sequence, so we only need 5 more
	mov eax, 0		; clears out the eax register
	mov ebx, 0		; clears out the ebx register
	mov esi, 0		; sets the index to 0

	fib:
		mov eax, fibarray[esi]		; copys the element form the fibarray array to the eax register
		add esi, 4					; increments the index by 4, as the array elements are double word (4 bytes), to get the next element
		mov ebx, fibarray[esi]		; copys another element to the ebx register
		add eax, ebx				; adds the contents of the eax and the ebx registers together and places the sum into the eax register
		add esi, 4					; increments the index by 4 to store the sum into the next location in the array
		mov fibarray[esi], eax		; copys the sum from the eax register to the fibarray
		sub esi, 4					; decrements the index in prepration for the next run the loop, need to get the second to last element first
		loop fib

	invoke ExitProcess,0
main endp
end main