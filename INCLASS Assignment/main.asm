;Manjinder Singh
;in-class looping lab
;10/28/2014

.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.data
	array dword 1h, 2h, 3h, 4h, 5h, 6h, 7h, 8h, 9h
	count equ lengthof array
	sum dword ?
.code
main proc
	mov ecx, count - 1
	mov esi, 0
	mov eax, 0
	swap:
		mov eax, array[esi + 4]
		sub eax , array[esi]
		add sum, eax
		add esi, 4
		loop swap

	invoke ExitProcess,0
main endp
end main