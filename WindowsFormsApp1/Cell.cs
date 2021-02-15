using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    enum CellState
    {
        Empty,
        Growing,
        Green,
        Yellow,
        Red,
        Overgrow
    }
    class Cell
    {
        const int prGrowing = 2;
        const int prGreen = 6;
        const int prYellow = 8;
        const int prRed = 10;
        public CellState state 
        {
            get
            {
                if (progress == 0) return CellState.Empty;
                if (progress < prGrowing) return CellState.Growing;
                else if (progress < prGreen) return CellState.Green;
                else if (progress < prYellow) return CellState.Yellow;
                else if (progress < prRed) return CellState.Red;
                else return CellState.Overgrow;
            }

        }


        private int progress = 0;

        internal void StartGrow()
        {
            progress++;
        }

        internal void Cut()
        {
            progress = 0;
        }

        internal void Step()
        {
            if ((state != CellState.Overgrow) && (state != CellState.Empty))
                progress++;
        }
    }
}
