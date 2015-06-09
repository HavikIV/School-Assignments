;Manjinder Singh
;in-class looping lab
;10/28/2014

.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.data
	array byte 1h, 2h, 3h, 4h, 5h, 6h, 7h, 8h, 9h, 10h
	count equ lengthof array / 2
	count2 byte 10
.code
main proc
	mov ecx, count - 1
	mov esi, 0

	swap:
		mov al, array[esi]
		xchg al , array[esi + 1]
		mov array[esi] , al
		add esi, 2
		loop swap

	invoke ExitProcess,0
main endp
end main