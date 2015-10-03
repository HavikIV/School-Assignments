import sys, pygame
from random import *
#from PixelPerfect import *

#---------------ball subclass definition-----------------------------------
class MyBallClass(pygame.sprite.Sprite):
    def __init__(self, image_file, location, speed):
        pygame.sprite.Sprite.__init__(self)         #call Sprite initializer
        self.image = pygame.image.load(image_file)
        self.rect = self.image.get_rect()
        self.rect.left, self.rect.top = location
        self.speed = speed

    def move(self):
        self.rect = self.rect.move(self.speed)
        if self.rect.left < 0 or self.rect.right > width:
            self.speed [0] = -self.speed[0]

        if self.rect.top < 0 or self.rect.bottom > height:
            self.speed [1] = -self.speed[1]

def animate(group):
    screen.fill([255, 255, 255])
    for ball in group:
        ball.move()
    for ball in group:

        group.remove(ball)

##        if spritecollide_pp(ball, group, False):
##            ball.speed[0] = -ball.speed[0]
##            ball.speed[1] = -ball.speed[1]
        if pygame.sprite.spritecollide(ball, group, False):
            ball.speed[0] = -ball.speed[0]
            ball.speed[1] = -ball.speed[1]

        group.add(ball)

        screen.blit(ball.image, ball.rect)
    pygame.display.flip()
                
#---------------Main Program-----------------------------------------------

size = width, height = 640, 480
screen = pygame.display.set_mode(size)
screen.fill([255,255,255])
img_file = "beach_ball.png"
clock = pygame.time.Clock()
group = pygame.sprite.Group()
for row in range (0, 2):
    for column in range (0, 2):
        location = [column * 180 + 10, row * 180 +10]
        speed = [choice([-2,2]), choice([-2,2])]
        ball = MyBallClass(img_file, location, speed)
        group.add(ball)

while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            frame_rate = clock.get_fps()
            print "Frame rate = ", frame_rate
            sys.exit()
    animate(group)
    clock.tick(120)
