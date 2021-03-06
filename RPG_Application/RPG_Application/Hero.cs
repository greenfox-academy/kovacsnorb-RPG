﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Application
{
    class Hero : Character
    {
        public Hero(double posX, double posY)
        {
            this.positionX = posX;
            this.positionY = posY;
        }

        public double getPositionX()
        {
            return this.positionX;
        }

        public double getPositionY()
        {
            return this.positionY;
        }

        public double HeroMoveRight()
        {
            this.positionX = positionX + 50;

            if ((this.positionX >= 500) || (GetIsWall(positionX, positionY)))
            {
                this.positionX -= 50;
            }

            return this.positionX;
        }

        public double HeroMoveLeft()
        {
            this.positionX = positionX - 50;

            if ((this.positionX < 0) || (GetIsWall(positionX, positionY)))
            {
                this.positionX += 50;
            }

            return this.positionX;
        }

        public double HeroMoveUp()
        {
            this.positionY = positionY - 50;

            if ((this.positionY < 0) || (GetIsWall(positionX, positionY)))
            {
                this.positionY += 50;
            }

            return this.positionY;
        }

        public double HeroMoveDown()
        {
            this.positionY = positionY + 50;

            if ((this.positionY > 500) || (GetIsWall(positionX, positionY)))
            {
                this.positionY -= 50;
            }
            return this.positionY;
        }
    }
}
