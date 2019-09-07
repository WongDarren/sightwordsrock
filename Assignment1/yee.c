//	Justin Yee
//	1000269334
//	CS 472 002 Fall 2019

#include <sys/syscall.h> 								//header for making system calls

void _start(){											// Using _start avoids calling (main), avoid C runtime library
	syscall(SYS_write, 1, "Hello, world!\n", 14);		// Direct system call instead of printf()
	syscall(SYS_exit,0); 	 							//Sets proper return value without using return 0, proper closure
}
