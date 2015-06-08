;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
; Manjinder Singh
; CSCI 273-5299
; Fall 2014
; Assignment 6 - Page 238, #2
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.data
testArray sdword 50, 1564, -45, -9, 2, -245
testArray2 sdword 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50
j byte 0										;lower limit
k byte 6										;upper limit
sum dword 0										;sum variable, going to use this to prevent the sum being lost the popad instruction as I don't know a way to pop all
												;registers except eax. I know I can push all of the individual registers myself (push register) and then pop them individually (pop register)
												;in the right order, but this seems to be easier and faster way.

.code
main proc
	mov edi, offset testArray					;points to the testArray
	mov eax, type testArray						;size of elements, used to increment the offset
	movzx ebx, j								;passing the lower limit
	movzx edx, k								;passing the upper limit
	;mov eax, 0									;empties out the eax register

	call arraySumming

	mov edi, offset testArray2					;points to the testArrary2
	mov eax, type testArray2					;size of elements, used to increment the offset
	mov k, 5
	movzx ebx, j								;passing the lower limit
	movzx edx, k								;passing the upper limit

	call arraySumming

	invoke ExitProcess,0
main endp

arraySumming proc								;procedure to sum up the elements of an array within the range of j to k, and returns the sum in eax register.
	pushad										;pushes everything onto the stack to preserve the registers
	mov ecx, edx
	sub ecx, ebx								;sets the ecx register to (k - j), used for the loop counter
	imul ebx, eax								;multiplies the ebx value by 4, gonna be used to adjust the edi offset to the first element in the range j to k
	add edi, ebx								;sets the offset to the location of j
	mov ebx, eax								;moves the size of each elements from eax to ebx, we don't need the value anymore
	mov eax, 0									;empties out the eax register for the summation process
	L1:
		add eax, dword ptr [edi]				;adds the element at the offset of [edi] into eax
		add edi, ebx							;increments the offset by 4 as the array is double word
		loop L1									;loops to the beginning of the loop until ecx equals 0
	mov sum, eax								;moves the sum into the sum variable
	popad										;returns to the previous state, before procedure call
	mov eax, sum								;moves the sum back into the eax register
	ret
arraySumming endp
end main