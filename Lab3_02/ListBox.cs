using System;

namespace Lab3_02
{
    public class ListBox: Window
    {
        private string listBoxContents;
        public ListBox(int top, int left, string contents): base(top, left)
        {
            listBoxContents = contents;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the list box: {0}", listBoxContents);
        }
    }
}