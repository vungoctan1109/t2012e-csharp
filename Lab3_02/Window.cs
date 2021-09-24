﻿using System;

namespace Lab3_02
{
    public class Window
    {
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}", top, left);
        }
        
        protected int top;
        protected int left;
    }
}