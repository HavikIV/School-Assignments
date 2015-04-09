//	Example - Temperature change in a thin rectangular body with fixed hot and cold spots

//	Declarations and initialization of variables and system
#include <GL/glut.h>	// for windows; can change for other systems, this also includes gl.h and glu.h
#include <stdlib.h>
#include <stdio.h>
#include <math.h>
#define ROWS 10			// body is ROWSxCOLS (unit less) squares
#define COLS 30

#define AMBIENT 25.0;	// ambient temperature, degrees Celsius
#define HOT 50.0		// hot temperature of heat source cell
#define COLD 0.0		// cold temperature of cold-sink cell
#define NHOTS 4			// number of hot cells
#define NCOLDS 5		// number of cold cells

GLfloat angle = 0.0;
GLfloat temps[ROWS][COLS], back[ROWS + 2][COLS + 2];
GLfloat theta = 0.0, vp = 30.0;

// set locations of fixed hot and cold spots on the bar
int hotspots[NHOTS][2] =
{ { ROWS / 2, 0 }, { ROWS / 2 - 1, 0 }, { ROWS / 2 - 2, 0 }, { 0, 3 * COLS / 4 } };
int coldspots[NCOLDS][2] =
{ { ROWS - 1, COLS / 3 }, { ROWS - 1, 1 + COLS / 3 }, { ROWS - 1, 2 + COLS / 3 },
{ ROWS - 1, 3 + COLS / 3 }, { ROWS - 1, 4 + COLS / 3 } };
int myWin;

// prototypes of the functions so don't have to worry about the order that they are defined in
void myinit(void);
void cube(void);
void display(void);
void reshape(int w, int h);
void setColor(float t);
void animate(void);
void iterationStep(void);

void myinit(void)
{
	int i, j;

	glEnable(GL_DEPTH_TEST);
	glClearColor(0.6, 0.6, 0.6, 1.0);

	// set up initial temperatures in cells
	for (i = 0; i < ROWS; i++)
	{
		for (j = 0; j < COLS; j++)
		{
			temps[i][j] = AMBIENT;
		}
	}
	for (i = 0; i<NHOTS; i++) {
		temps[hotspots[i][0]][hotspots[i][1]] = HOT;
	}
	for (i = 0; i<NCOLDS; i++) {
		temps[coldspots[i][0]][coldspots[i][1]] = COLD;
	}
}

// create a unit cube in first octant in model coordinates
void cube(void)
{
	typedef GLfloat point[3];

	point v[8] = {
		{ 0.0, 0.0, 0.0 }, { 0.0, 0.0, 1.0 },
		{ 0.0, 1.0, 0.0 }, { 0.0, 1.0, 1.0 },
		{ 1.0, 0.0, 0.0 }, { 1.0, 0.0, 1.0 },
		{ 1.0, 1.0, 0.0 }, { 1.0, 1.0, 1.0 } };

	glBegin(GL_QUAD_STRIP);
	glVertex3fv(v[4]);
	glVertex3fv(v[5]);
	glVertex3fv(v[0]);
	glVertex3fv(v[1]);
	glVertex3fv(v[2]);
	glVertex3fv(v[3]);
	glVertex3fv(v[6]);
	glVertex3fv(v[7]);
	glEnd();

	glBegin(GL_QUAD_STRIP);
	glVertex3fv(v[1]);
	glVertex3fv(v[3]);
	glVertex3fv(v[5]);
	glVertex3fv(v[7]);
	glVertex3fv(v[4]);
	glVertex3fv(v[6]);
	glVertex3fv(v[0]);
	glVertex3fv(v[2]);
	glEnd();
}

void display(void)
{
#define SCALE 10.0
	int i, j;

	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	// This short section defines the viewing transformation
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
	//				eye point		center of view		up
	gluLookAt(vp, vp / 2., vp / 4., 0.0, 0.0, 0.0, 0.0, 0.0, 1.0);

	// set up a rotation for the entire scene
	glPushMatrix();
	glRotatef(angle, 0., 0., 1.);

	// Draw the bars
	for (i = 0; i < ROWS; i++)
	{
		for (j = 0; j < COLS; j++)
		{
			setColor(temps[i][j]);
			// Here is the modeling transformation for each item in the display

			glPushMatrix();
			glTranslatef((float)i - (float)ROWS / 2.0,
				(float)j - (float)COLS / 2.0, 0.0);
			// 0.1 cold, 4.0 hot
			glScalef(1.0, 1.0, 0.1 + 3.9*temps[i][j] / HOT);
			cube();
			glPopMatrix();
		}
	}

	// Wrap up the scene by popping the rotation and swapping buffers
	glPopMatrix();
	glutSwapBuffers();
}

void reshape(int w, int h)
{
	// This defines the projection transformation

	glViewport(0, 0, (GLsizei)w, (GLsizei)h);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluPerspective(60.0, (float)w / (float)h, 1.0, 300.0);
	glutPostRedisplay();
}

void setColor(float t)
{
	// Color is based on HOT=red (1,0,0) and COLD=blue (0,0,1)
	// with the assumption that CODL <= t <= HOT at all times
	float r, g, b;
	r = (t - COLD) / (HOT - COLD);
	g = 0.0;
	b = 1.0 - r;

	glColor3f(r, g, b);
}

void animate(void)
{
	// This function is  called whenever the system is idle; it calls
	// iterationStep() to change the data so the next image is changed
	iterationStep();
	glutPostRedisplay();
}

void iterationStep(void)
{
	int i, j, m, n;

	float filter[3][3] = { { 0., 0.125, 0. },
	{ 0.125, 0.5, 0.125 },
	{ 0., 0.125, 0. } };
	// increment temperatures throughout the material
	for (i = 0; i < ROWS; i++) // backup temps up to recreate it
	{
		for (j = 0; j < COLS; j++)
		{
			back[i + 1][j + 1] = temps[i][j]; // leave boundaries on back
		}
	}

	// fill boundaries with adjacent values from original temps[][]
	for (i = 1; i<ROWS + 2; i++) {
		back[i][0] = back[i][1];
		back[i][COLS + 1] = back[i][COLS];
	}
	for (j = 0; j<COLS + 2; j++) {
		back[0][j] = back[1][j];
		back[ROWS + 1][j] = back[ROWS][j];
	}
	for (i = 0; i<ROWS; i++) // diffusion based on back values
		for (j = 0; j<COLS; j++) {
			temps[i][j] = 0.0;
			for (m = -1; m <= 1; m++)
				for (n = -1; n <= 1; n++)
					temps[i][j] += back[i + 1 + m][j + 1 + n] * filter[m + 1][n + 1];
		}
	for (i = 0; i<NHOTS; i++) {
		temps[hotspots[i][0]][hotspots[i][1]] = HOT;
	}
	for (i = 0; i<NCOLDS; i++) {
		temps[coldspots[i][0]][coldspots[i][1]] = COLD;
	}
	// update the angle for the rotation
	angle += 1.0;
}

int main(int argc, char** argv)
{
	// Initialize the GLUT system and define the window
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB | GLUT_DEPTH);
	glutInitWindowSize(500, 500);
	glutInitWindowPosition(50, 50);
	myWin = glutCreateWindow("Temperature in bar");
	myinit();

	// define the event callbacks and enter main event loop
	glutDisplayFunc(display);
	glutReshapeFunc(reshape);
	glutIdleFunc(animate);
	glutMainLoop(); /* enter event loop*/
}