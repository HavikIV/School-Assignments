import pygame, sys
pygame.init()
screen = pygame.display.set_mode([640,480])
background = pygame.Surface(screen.get_size())
background.fill([255, 255, 255])
clock = pygame.time.Clock()

class Ball(pygame.sprite.Sprite):
    def __init__(self, image_file, speed, location):
        pygame.sprite.Sprite.__init__(self) #call Sprite initializer
        self.image = pygame.image.load(image_file)
        self.rect = self.image.get_rect()
        self.rect.left, self.rect.top = location
        self.speed = speed

    def move(self):
        self.rect = self.rect.move(self.speed)
        if self.rect.top <= screen.get_rect().top:
            self.speed[1] = -self.speed[1]
        elif self.rect.bottom >= screen.get_rect().bottom:
            self.speed[1] = -(self.speed[1] - 2) + .01
        #newpos = self.rect.move(self.speed)
        #self.rect = newpos

my_ball = Ball('beach_ball.png', [0,10], [20,20])
#pygame.time.set_timer(pygame.USEREVENT, 1000)
#direction = 1

while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            sys.exit()
##        elif event.type == pygame.USEREVENT:
##            my_ball.rect.centery = my_ball.rect.centery + (30*direction)
##            if my_ball.rect.top <= 0 or \
##            my_ball.rect.bottom >= screen.get_rect().bottom:
##                direction = -direction

    clock.tick(60)
    screen.blit(background, (0,0))
    my_ball.move()
    screen.blit(my_ball.image, my_ball.rect)
    pygame.display.flip()
