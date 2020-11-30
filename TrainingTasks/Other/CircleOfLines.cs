using System;

namespace TrainingTasks
{
    //Круг из линий. Без Sin и Cos

    /*
        Задача. С помощью горизонтальных и вертикальных 
        линий нарисовать круг в произвольных координатах 
        с определенным радиусом. 
        В решении не использовать функции синуса и косинуса.
     */

    class CircleOfLines
    {
        static void DrawLineVertical(ConsoleColor color, float x, float y1, float y2)
        {
            Console.ForegroundColor = color;

            for (int i = (int)y1; i <= (int)y2; i++)
            {
                Console.SetCursorPosition((int)x, i);
                Console.Write("#");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void DrawLineHorizontal(ConsoleColor color, float x, float y1, float y2)
        {
            Console.ForegroundColor = color;

            for (int i = (int)y1; i <= (int)y2; i++)
            {
                Console.SetCursorPosition(i, (int)x);
                Console.Write("#");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void DrawCircleOfLine(float x, float y, int radius)
        {
            /*
             for (int i = -radius; i < radius; i += 1)
            {
                float local_y = (float)Math.Sqrt(radius * radius - i * i);
                //вертикально
                //e.Graphics.DrawLine(Pens.Red, x + i, local_y + y, x + i, -local_y + y);           
                //горизонтально                
                // e.Graphics.DrawLine(Pens.Red, local_y + x, y + i, -local_y + x, y + i);
            }            
            */

            for (int i = -radius; i < radius; i += 1)
            {
                float local_y = (float)Math.Sqrt(radius * radius - i * i);
                //вертикально
                //local_y = (float)Math.Floor(local_y / 2.0f);
                DrawLineVertical(ConsoleColor.Red, x + i, -local_y + y, local_y + y);           
                //горизонтально
                DrawLineHorizontal(ConsoleColor.Red, y + i, -local_y + x, local_y + x);              
            }
        }


        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    int radius = 150;
        //    float x = 500, y = 100;
        //    for (int i = -radius; i < radius; i += 10)
        //    {
        //        float local_y = (float)Math.Sqrt(radius * radius - i * i);
        //        //вертикально
        //        e.Graphics.DrawLine(Pens.Red, x + i, local_y + y, x + i, -local_y + y);
        //        //горизонтально
        //        e.Graphics.DrawLine(Pens.Red, local_y + x, y + i, -local_y + x, y + i);
        //    }
        //}

    }
}
