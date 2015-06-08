//Basic OpenGL Program
//Example code from Chapter 0
//written in C in the book

#include <GL/glut.h>	//Windows: other includes for other systems
	//other includes as needed

//	typedef and global data section
	// as needed

//	function template section
void doMyInit(void);
void display(void);
void reshape(int, int);
void idle(void);
	///others as needed

// initialization function
void doMyinit(void)
{
	//set up basic OpenGL parameters and environment
	//set up projection transformation (orthogonal or perspective)
}

// reshape callback function
void reshape(int w, int h)
{
	//set up projection transformation with new window dimensions w and h
	//post redisplay
}

// display callback function
void display(void)
{
	//set up viewing transformation as in later chapters
	//define the geometry, transformations, appearance you need
	//post redisplay
}

// idle callback function
void idle(void)
{
	//update anything that changes between steps of the program
	//post display
}

// other graphics and application functions as needed

// main function - set up the system, turn it over to events
void main(int argc, char** argv)
{
	//initialize system through GLUT and your own initialization
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutInitWindowSize(500, 500);
	glutInitWindowPosition(50, 100);
	glutCreateWindow("A Sample Program");
	doMyInit();

	//define callback functions for events; this is pretty minimal
	glutDisplayFunc(display);
	glutReshapeFunc(reshape); 
	glutIdleFunc(idle);

	//go into main event loop
	glutMainLoop();
}