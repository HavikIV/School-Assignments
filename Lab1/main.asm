;Manjinder Singh
;lab1 assignment
;BigEndian to littleEndian
;moves the contents of bigEndian array to the littleEndian array in reverse order

.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword

.data
bigEndian byte 12h, 34h, 56h, 78h
littleEndian dword ?

.code
main proc
	movzx eax, [bigEndian + 3]
	mov littleEndian, eax
	movzx eax, [bigEndian + 2]
	mov [littleEndian + 1], eax
	movzx eax, [bigEndian + 1]
	mov [littleEndian + 2], eax
	movzx eax, bigEndian
	mov [littleEndian + 3], eax
	mov eax, littleEndian

	invoke ExitProcess,0
main endp
end main