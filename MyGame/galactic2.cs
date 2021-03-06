﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//Брижак Андрей Домашнее задание к уроку 3 Продвинутый курс C#

namespace MyGame
{
    class galactic2 : BaseObject  //Создадим класс galactic2, который будет наследовать BaseObject.

    {
        public galactic2(Point pos, Point dir, Size size) : base(pos, dir, size)  //создать конструктор, который будет
                                                                            //передавать параметры базовому объекту, чтобы создать его.
        {

        }

        public override void Draw()  //переопределите метод Draw
        {
            Image newImage = Image.FromFile("galactic2.jpg");
            Game.Buffer.Graphics.DrawImage(newImage, Pos.X, Pos.Y, Size.Width, Size.Height);
            //Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X, Pos.Y, Pos.X + Size.Width, Pos.Y + Size.Height);
            //Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X + Size.Width, Pos.Y, Pos.X, Pos.Y + Size.Height);
        }

        public override void Update()   //Теперь переопределите метод Update.
        {
            Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;
            Size.Width = Size.Width + 1;  // изменяем масштаб объектов
            Size.Height = Size.Height +1;

            if (Pos.X > Game.Width)
            {
                Pos.X = Game.Width / 2;
                Size.Width = 1;
                Size.Height = 1;
            }
            if (Pos.Y > Game.Height)
            {
                Pos.Y = Game.Height / 2;
                Size.Width = 1;
                Size.Height = 1;
            }
            if (Pos.X < 0)
            {
                Pos.X = Game.Width / 2;   // возвращаются в центр
                Size.Width = 1;
                Size.Height = 1;
            }
            if (Pos.Y < 0)
            {
                Pos.Y = Game.Height / 2;
                Size.Width = 1;
                Size.Height = 1;
            }
        }
    }
}
