; This will print "Hello, World!" to your terminal.

; The following commands will make an object file and then compile it into an executable.
; $ nasm -f elf32 -o hello.o hello.asm
; $ ld -m elf_i386 -o hello hello.o

global _start  ; Define _start label.

section .text:  ; This section contains program instructions.
    _start:  ; The start label.
        mov eax, 0x4         ; 0x4 is the write syscall.
        mov ebx, 1           ; Use stdout as file descriptor.
        mov ecx, msg         ; Use msg as buffer.
        mov edx, msg_length  ; Use msg_length as buffer length.

        int 0x80  ; Run the syscall.

        mov eax, 0x1  ; 0x1 is the exit syscall.
        mov ebx, 0x0  ; 0x0 will return an exit code of 0.
        int 0x80  ; Run the exit syscall.

section .data:  ; This section contains variable definitions.
    ; Create a new variable `msg` with the value `Hello, World!` with a newline at the end.
    msg: db "Hello, World!", 0xA  ; 0xA is a newline character.
    msg_length equ $-msg  ; Set the variable `msg_length` to have the length of `msg`.
